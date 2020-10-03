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


        public Entorno()
        {

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
