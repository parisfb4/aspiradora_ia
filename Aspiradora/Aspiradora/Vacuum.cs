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
        private Point posicionExacta { get; set; } // (x,y)
        private int movimientos { get; set; } // 
        private int[] registro; //PosicionAnterior - EstadoAnterior 
        int band_limpio;

        #region sensores
        private int ubicacionEntorno { get; set; } // si es estado de carga, a o b
        private bool espacioEncontrado { get; set; } // 1 Limpio o  0 sucio 
        int vidaMax = 200;
        int contador;
        int opcion;
        bool bandera1 = false;
        Random rnd;

        Form1 control;
        Form2 datos;
        Entorno entorno;

        public bool estaLimpio()
        {
            return entorno.estaLimpioEspacio(ubicacionEntorno);
        }
        #endregion

        #region Actuadores
        private int estado { get; set; }            // limpiando, cargar, standby


        public void limpiar()
        {
            //Actualizar bateria
            movimientos--;
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
        {
            System.Windows.Forms.Application.DoEvents();
            if (!control.Encendido) return;
            //Moverse a la posición donde no estuvo            
            if(ubicacionEntorno == 0) //centro de carga
            {
                Random rnd = new Random();
                if (registro[0] == 0)
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
                }

            }
            else if (ubicacionEntorno == 1)
            {
                if (registro[0] == 0)  //viene de carga
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
            }
            else if (ubicacionEntorno == 2)
            {
                if (registro[0] == 0)  //viene de carga
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
            }
            //Si esta en a
            //Si registro estuvo en b                
            //Si a estaba limpio
            //Sino
            //Si registro estuvo en carga
            //Si esta en b
            //Si registro estuvo en a
            //Si registro estuvo en b

            //Si está en carga
            //Si registro estuvo en a
            //Si registro estuvo en b
         
            
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
                band_limpio = 1;
                limpiar();
            }
            else
            {
                band_limpio = 0;
                escogerMoverse();
            }

        }
        #endregion

        public Vacuum(object form1, object entorno1, object data)
        {
            control = (Form1)form1;
            entorno = (Entorno)entorno1;
            datos = (Form2)data;
            movimientos = datos.Movimientos;
            ubicacionEntorno = datos.Zona; //Estado en donde ingreso el usuario
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
