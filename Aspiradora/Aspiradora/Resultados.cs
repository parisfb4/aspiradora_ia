using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;

namespace Aspiradora
{
    public partial class Resultados : Form
    {
        #region Variables
        private double media_global; //Media de todo el rendimiento de la aspiradora (rendimientos / no. configuraciones) * 100
        #endregion

        public Resultados()
        {
            InitializeComponent();
        }

        private void ActualizarTabla()
        {
            //Leer Archivo
            var reader = new StreamReader(File.OpenRead(@"C:\Users\omara\OneDrive - Universidad de Guadalajara\Desktop\2020-B\INTELIGENCIA ARTIFICIAL\Practica02\Codigo\aspiradora_ia\Aspiradora\Aspiradora\hola.csv"));
            reader.ReadLine(); // Leer la primera linea (Encabezado)

            while (!reader.EndOfStream)
            {
                var linea = reader.ReadLine();
                var valores = linea.Split(',');

                //Crear Lista
                ListViewItem lista = new ListViewItem(valores[0]);
                lista.SubItems.Add(valores[1]);
                lista.SubItems.Add(valores[2]);
                lista.SubItems.Add(valores[3]);
                lista.SubItems.Add(valores[4]);
                lista.SubItems.Add(valores[5]);
                listResult.Items.Add(lista);
            }
            Media.Value = Convert.ToDecimal(media_global);
        }

        public void datos(double valor)
        {
            media_global = valor;
        }

        private void informe_Click(object sender, EventArgs e)
        {
            ActualizarTabla();
        }
    }
}
