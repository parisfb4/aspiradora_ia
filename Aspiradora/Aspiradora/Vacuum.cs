using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
        Form1 control;

        public bool estaLimpio()
        {
            return Entorno.estaLimpioEspacio(ubicacionEntorno);
        }
        #endregion

        #region Actuadores
        private int estado { get; set; }            // limpiando, cargar, standby


        public void limpiar()
        {
            //Verificar registro 

            //Actualizar datos            
            Entorno.limpiarEspacio(ubicacionEntorno);

            //Actualziar Imagenes
            control.ImagenesSectores();

            //Moverse
            escogerMoverse();
        }
        public void cargar()
        {
            //Verificar movimientos
            ubicacionEntorno = 0; //En modo de carga

            //Control de posicion
            control.PosicionActual(ubicacionEntorno);
            control.PosicionActual(0);

            if(movimientos < 10)
            {
                //Timer 0 = Cargar
                if (movimientos == 5)
                {
                    return;
                }

                movimientos = control.ActualizarBateria(movimientos, 0);
                //movimientos = 10;
            }
            if (vidaMax < 1)
            {
                Console.WriteLine("Esta cosa ya se murió, Compra una nueva");
                return;
            }

            Thread.Sleep(5000);

            escogerMoverse();

            //Esta parte es la final del programa
        }
        public void escogerMoverse()
        {
            //Moverse a la posición donde no estuvo            
            if(ubicacionEntorno == 0) //centro de carga
            {
                if(registro[0] == 0)
                {
                    registro[0] = 0;
                    registro[1] = band_limpio;
                    moverse(1);
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
            if (!Entorno.estaLimpioEspacio(ubicacionEntorno))
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

        public Vacuum(object form1)
        {
            movimientos = 10;
            ubicacionEntorno = 0; //Estado de carga
            estado = 0; //
            Random rnd = new Random();
            registro = new int[2]; //Movimiento 
            registro[0] = 0;
            registro[1] = 0;
            control = (Form1)form1;
        }
    }
}
