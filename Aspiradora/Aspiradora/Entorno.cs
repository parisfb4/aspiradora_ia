using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aspiradora
{
    public class Entorno
    {

        private bool[] localizacion = {false, false, false};
        private int timeGlobal;
        Form2 datos;


        public Entorno(object data)
        {
            datos = (Form2)data;
            localizacion[1] = !datos.Sucios[0];
            localizacion[2] = !datos.Sucios[1];

        }

        public int TimeGlobal { get => timeGlobal; set => timeGlobal = value; }
        public bool[] Localizacion { get => localizacion; set => localizacion = value; }

        public bool estaLimpioEspacio(int indice)
        {            
            return localizacion[indice];
        }
        public void limpiarEspacio(int indice)
        {
            localizacion[indice] = true;
        }
    }
}
