using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aspiradora
{
    public class Entorno
    {

        private static bool[] localizacion = new bool[3];

        public Entorno()
        {
            Random rand = new Random();            
            if (rand.Next(2) == 1) // Limpio
                localizacion[1] = true;
            else //Sucio
                localizacion[1] = false;
            
            if (rand.Next(2) == 1)
                localizacion[2] = true;
            else
                localizacion[2] = false;

        }
        public static bool estaLimpioEspacio(int indice)
        {            
            return localizacion[indice];
        }
        public static void limpiarEspacio(int indice)
        {
            localizacion[indice] = true;
        }
    }
}
