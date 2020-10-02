using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aspiradora
{
    public partial class Form2 : Form
    {
        int zona;
        int movimientos;
        bool[] sucios = { false, false };
        public Form2()
        {
            InitializeComponent();
            zona = 0;
            movimientos = 1;
            sucios[0] = false;
            sucios[1] = false;
        }

        public int Zona { get => zona; set => zona = value; }
        public int Movimientos { get => movimientos; set => movimientos = value; }
        public bool[] Sucios { get => sucios; set => sucios = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioCarga.Checked) zona = 0;
            else if (radioA.Checked) zona = 1;
            else zona = 2;
            if (chA.Checked) sucios[0] = true;
            if (chB.Checked) sucios[1] = true;
            movimientos = (int)numMov.Value;
            this.Close();
        }

        private void numMov_Click(object sender, EventArgs e)
        {
            if (numMov.Value > 2)
            {
                radioA.Enabled = true;
                radioB.Enabled = true;
            }
            else
            {
                radioA.Enabled = false;
                radioB.Enabled = false;
            }
        }
    }
}
