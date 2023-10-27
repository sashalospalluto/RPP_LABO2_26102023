using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Fabrica
    {
        private int capacidad;
        private List<Vehiculo> vehiculos;

        public List<Vehiculo> Vehiculos 
        { 
            get
            {
                return this.vehiculos;
            }
        }

        private Fabrica()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        public Fabrica (int capacidad) :this()
        {
            this.capacidad = capacidad;
        }

        public static Fabrica operator - (Fabrica fabrica, Vehiculo vehiculo)
        {
            foreach (Vehiculo item in fabrica.vehiculos)
            {
                if(item == vehiculo)
                {
                    fabrica.vehiculos.Remove(vehiculo);
                    break;
                }
            }
            return fabrica;
        }

        public static Fabrica operator + (Fabrica fabrica, Vehiculo vehiculo)
        {
           
            if(fabrica.capacidad > fabrica.vehiculos.Count)
            {
                fabrica.vehiculos.Add(vehiculo);
            }

            return fabrica;
        }
    }
}
