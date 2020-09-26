using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aspiradora
{
    public class Entorno
    {

        private bool[] localizacion = new bool[3];
        private int timeGlobal;


        public Entorno()
        {

            Random rand = new Random();
            timeGlobal = 0;
            if (rand.Next(2) == 1) // Limpio
                localizacion[1] = true;
            else //Sucio
                localizacion[1] = false;
            
            if (rand.Next(2) == 1)
                localizacion[2] = true;
            else
                localizacion[2] = false;

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
