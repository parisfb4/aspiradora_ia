using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aspiradora
{
    public partial class Form1 : Form
    {
        #region Bateria
        private int bateria = 1;
        #endregion

        Vacuum aspirar;
        Entorno entorno;
        Random rnd;
        int aleatorio;

        public Form1()
        {
            InitializeComponent();
            entorno = new Entorno();
            aspirar = new Vacuum(this, entorno);
            rnd = new Random();
            aleatorio =  rnd.Next(13,15);
        }

        //Bateria
        private void Batery()
        {
            //timerBatery.Enabled = true;
            do
            {
                Thread.Sleep(1000);
                if (bateria >= 1 && bateria < 10)
                {
                    bateria++;
                    if (bateria == 2)
                    {
                        Bateria1.Visible = false;
                        Bateria2.Visible = true;
                    }
                    else if (bateria == 3)
                    {
                        Bateria2.Visible = false;
                        Bateria3.Visible = true;
                    }
                    else if (bateria == 4)
                    {
                        Bateria3.Visible = false;
                        Bateria4.Visible = true;
                    }
                    else if (bateria == 5)
                    {
                        Bateria4.Visible = false;
                        Bateria5.Visible = true;
                    }
                    else if (bateria == 6)
                    {
                        Bateria5.Visible = false;
                        Bateria6.Visible = true;
                    }
                    else if (bateria == 7)
                    {
                        Bateria6.Visible = false;
                        Bateria7.Visible = true;
                    }
                    else if (bateria == 8)
                    {
                        Bateria7.Visible = false;
                        Bateria8.Visible = true;
                    }
                    else if (bateria == 9)
                    {
                        Bateria8.Visible = false;
                        Bateria9.Visible = true;
                    }
                    else if (bateria == 10)
                    {
                        Bateria9.Visible = false;
                        Bateria10.Visible = true;
                        //timerGlobal.Enabled = false;
                        //MessageBox.Show("Bateria Cargada", "Advertencia");
                    }
                }
                batteries.Refresh();
            } while (bateria >= 1 && bateria < 10);
            
        }

        //Boton Comenzar
        private void button1_Click(object sender, EventArgs e)
        {
            
            aspirar.cargar();

            MessageBox.Show("Finalizado", "Estatus");
        }

        //Actualizar Bateria
        public int ActualizarBateria(int valor, int accion)
        {
            if(accion == 0)//
            {
                Batery();
            }
            if(valor > 0 && valor < 10 && accion == 1)
            {
                Thread.Sleep(1000);
                bateria = valor;
                ImagenBateria();
                batteries.Refresh();
            }
            return bateria;
        }

        //Posicion Actual
        public void PosicionActual(int valor)
        {
            Posicion.Clear();

            //0 Cargando
            if(valor == 0)
            {
                //Esta cargando
                Posicion.Text = "Cargando";
            }
            //1 Sector A
            else if(valor == 1)
            {
                //Esta en A
                Posicion.Text = "Sector A";
            }
            //2 Sector B
            else if(valor == 2)
            {
                //Esta en B
                Posicion.Text = "Sector B";
            }
            Posicion.Refresh();
        }

        //Actualziar Imagenes Sector A y Sector B
        public void ImagenesSectores()
        {
            //Estado y la posicion
            if (entorno.estaLimpioEspacio(1))
            {
                //Si el espacio en A esta limpio
                EstatusA.Text = "Limpio";
            }
            else
            {
                //Si el espacio en A esta sucio
                EstatusA.Text = "Sucio";
            }

            if (entorno.estaLimpioEspacio(2))
            {
                //Si el espacio en B esta limpio
                EstatusB.Text = "Limpio";
            }
            else
            {
                //Si el espacio en B esta sucio
                EstatusB.Text = "Sucio";
            }
            information.Refresh();
        }

        //Actualziar Imagen de Bateria
        private void ImagenBateria()
        {
            if (bateria == 2)
            {
                Bateria1.Visible = false;
                Bateria3.Visible = false;
                Bateria4.Visible = false;
                Bateria5.Visible = false;
                Bateria6.Visible = false;
                Bateria7.Visible = false;
                Bateria8.Visible = false;
                Bateria9.Visible = false;
                Bateria10.Visible = false;

                Bateria2.Visible = true;
            }
            else if (bateria == 3)
            {
                Bateria2.Visible = false;
                Bateria1.Visible = false;
                Bateria4.Visible = false;
                Bateria5.Visible = false;
                Bateria6.Visible = false;
                Bateria7.Visible = false;
                Bateria8.Visible = false;
                Bateria9.Visible = false;
                Bateria10.Visible = false;

                Bateria3.Visible = true;
            }
            else if (bateria == 4)
            {
                Bateria1.Visible = false;
                Bateria2.Visible = false;
                Bateria3.Visible = false;
                Bateria5.Visible = false;
                Bateria6.Visible = false;
                Bateria7.Visible = false;
                Bateria8.Visible = false;
                Bateria9.Visible = false;
                Bateria10.Visible = false;

                Bateria4.Visible = true;
            }
            else if (bateria == 5)
            {
                Bateria1.Visible = false;
                Bateria2.Visible = false;
                Bateria3.Visible = false;
                Bateria4.Visible = false;
                Bateria6.Visible = false;
                Bateria7.Visible = false;
                Bateria8.Visible = false;
                Bateria9.Visible = false;
                Bateria10.Visible = false;

                Bateria5.Visible = true;
            }
            else if (bateria == 6)
            {
                Bateria1.Visible = false;
                Bateria2.Visible = false;
                Bateria3.Visible = false;
                Bateria4.Visible = false;
                Bateria5.Visible = false;
                Bateria7.Visible = false;
                Bateria8.Visible = false;
                Bateria9.Visible = false;
                Bateria10.Visible = false;

                Bateria6.Visible = true;
            }
            else if (bateria == 7)
            {
                Bateria1.Visible = false;
                Bateria2.Visible = false;
                Bateria3.Visible = false;
                Bateria4.Visible = false;
                Bateria5.Visible = false;
                Bateria6.Visible = false;
                Bateria8.Visible = false;
                Bateria9.Visible = false;
                Bateria10.Visible = false;

                Bateria7.Visible = true;
            }
            else if (bateria == 8)
            {
                Bateria1.Visible = false;
                Bateria2.Visible = false;
                Bateria3.Visible = false;
                Bateria4.Visible = false;
                Bateria5.Visible = false;
                Bateria6.Visible = false;
                Bateria7.Visible = false;
                Bateria9.Visible = false;
                Bateria10.Visible = false;

                Bateria8.Visible = true;
            }
            else if (bateria == 9)
            {
                Bateria1.Visible = false;
                Bateria2.Visible = false;
                Bateria3.Visible = false;
                Bateria4.Visible = false;
                Bateria5.Visible = false;
                Bateria6.Visible = false;
                Bateria7.Visible = false;
                Bateria8.Visible = false;
                Bateria10.Visible = false;

                Bateria9.Visible = true;
            }
            else if (bateria == 10)
            {
                Bateria1.Visible = false;
                Bateria2.Visible = false;
                Bateria3.Visible = false;
                Bateria4.Visible = false;
                Bateria5.Visible = false;
                Bateria6.Visible = false;
                Bateria7.Visible = false;
                Bateria8.Visible = false;
                Bateria9.Visible = false;

                Bateria10.Visible = true;
            }
        }

        //Control del programa
        private void Control()
        {

        }
    }
}
