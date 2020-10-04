using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aspiradora
{
    public class Vacuum
    {
        //private Point posicionExacta { get; set; } // (x,y)
        private int movimientos; // 
        private int[] registro; //PosicionAnterior - EstadoAnterior 
        //int band_limpio;

        #region sensores
        private int ubicacionEntorno; // si es estado de carga, a o b
        private bool espacioEncontrado; // 1 Limpio o  0 sucio 
        int vidaMax = 200;
        int contador;
        int opcion;
        bool bandera1 = false;
        Random rnd;

        Main control;
        Entorno entorno;

        public bool estaLimpio()
        {
            return entorno.estaLimpioEspacio(ubicacionEntorno);
        }
        #endregion

        #region Actuadores
        private int estado { get; set; }            // limpiando, cargar, standby
        public int UbicacionEntorno { get => ubicacionEntorno; set => ubicacionEntorno = value; }
        public bool EspacioEncontrado { get => espacioEncontrado; set => espacioEncontrado = value; }
        public int Movimientos { get => movimientos; set => movimientos = value; }

        public void limpiar()
        {
            //Actualizar bateria
            movimientos--;
            control.Movimientos_realizados++;
            control.Limpiezas_realizadas++;
            control.ActualizarBateria(movimientos, 1);

            //Actualizar datos            
            entorno.limpiarEspacio(ubicacionEntorno);

            //Actualziar Imagenes
            control.ImagenesSectores();
            Thread.Sleep(1000);


            //Moverse
            escogerMoverse();
        }
        public void cargar()
        {
            MessageBox.Show("Entro a Cargar");
            //Verificar movimientos
            ubicacionEntorno = 0; //En modo de carga

            //Control de posicion
            //control.PosicionActual(ubicacionEntorno);
            control.PosicionActual(0);

            if(movimientos < 10)
            {
                movimientos = control.ActualizarBateria(movimientos, 0);
                //movimientos = 10;
            }
            if (vidaMax < 1)
            {
                Console.WriteLine("Esta cosa ya se murió, Compra una nueva");
                return;
            }

            //Funcion Stand By
            if(movimientos == 10 && entorno.estaLimpioEspacio(1) && entorno.estaLimpioEspacio(2))
            {
                //Si la bateria esta cargada
                //Si el espacio en A esta limpio
                //Si el espacio en B esta limpio
                standby();
            }

            escogerMoverse();

            //Esta parte es la final del programa
        }
        public void escogerMoverse()
        {            //Verificar locacion
            if (!entorno.estaLimpioEspacio(ubicacionEntorno))
            {
                //band_limpio = 1;
                limpiar();
            }
            System.Windows.Forms.Application.DoEvents();
            if (!control.Encendido) return;
            //Moverse a la posición donde no estuvo            
            if (ubicacionEntorno == 0) //centro de carga
            {
                Random rnd = new Random();
                moverse(rnd.Next(1, 3));

                #region carga con registro
                /*if (registro[0] == 0)
                {
                    registro[0] = 0;
                    registro[1] = band_limpio;
                    moverse(rnd.Next(1,3));
                    //Random para ir a o a b
                }
                if(registro[0] == 1)  //viene de a
                {
                    registro[0] = 0;
                    registro[1] = band_limpio;
                    moverse(2);
                }
                else if(registro[0] == 2)
                {
                    registro[0] = 0;
                    registro[1] = band_limpio;
                    moverse(1);
                } */
                #endregion

            }
            else if (ubicacionEntorno == 1)
            {
                Random rnd = new Random();
                moverse(2);
                #region a con registro 
                /* if (registro[0] == 0)  //viene de carga
                {
                    registro[0] = 1;
                    registro[1] = band_limpio;
                    moverse(2);
                }
                else if (registro[0] == 2)// Viene de b
                {
                    registro[0] = 2;
                    registro[1] = band_limpio;
                    movimientos--;
                    control.ActualizarBateria(movimientos, 1);
                    cargar();
                }
                */
                #endregion
            }
            else if (ubicacionEntorno == 2)
            {
                moverse(1);
                #region b con registro
                /* if (registro[0] == 0)  //viene de carga
               {
                   registro[0] = 2;
                   registro[1] = band_limpio;
                   moverse(1);
               }
               else if (registro[0] == 1)// Viene de a
               {
                   registro[0] = 2;
                   registro[1] = band_limpio;
                   movimientos--;
                   control.ActualizarBateria(movimientos, 1);
                   cargar();
               }
                */
                #endregion
            }



        }

        public void standby()
        {
            //No tengo nada que hacer
            MessageBox.Show("Estoy esperando a que se ensucie", "Estatus");

            //Timer artificial
            do
            {
                contador++;
                Thread.Sleep(1000);

            } while (contador < rnd.Next(2, 5));

            bandera1 = false;

            while (bandera1 == false)
            {
                //Cambiar estados de limpieza para A
                opcion = rnd.Next(1, 3);
                if (entorno.estaLimpioEspacio(opcion))
                {
                    entorno.Localizacion[opcion] = false;
                    bandera1 = true;
                }
            }
            control.ImagenesSectores();
        }
        public void moverse(int posicion)
        {

            movimientos--;
            vidaMax--;
            control.Movimientos_realizados++;
            //Cambiar la imagen de la bateria
            control.ActualizarBateria(movimientos, 1);
            //Posision actual de la aspiradora
            control.PosicionActual(posicion);

            if (movimientos < 2)
            {
                cargar();
            }

            //Animación de movimiento cambiar de localización            
            ubicacionEntorno = posicion;


            //Verificar locacion
            if (!entorno.estaLimpioEspacio(ubicacionEntorno))
            {
                //band_limpio = 1;
                limpiar();
            }
            else
            {
                //band_limpio = 0;
                escogerMoverse();
            }

        }
        #endregion

        public Vacuum(object form1, object entorno1)
        {
            control = (Main)form1;
            entorno = (Entorno)entorno1;
            estado = 0; //
            registro = new int[2]; //Movimiento 
            registro[0] = 0;
            registro[1] = 0;
            contador = 0;
            rnd = new Random();
            opcion = 0;
        }
    }
}
