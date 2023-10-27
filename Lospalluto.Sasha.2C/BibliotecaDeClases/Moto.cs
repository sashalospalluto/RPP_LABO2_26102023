using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Moto : Vehiculo
    {
        protected override string Tipo
        {
            get
            {
                return "Moto";
            }
        }

        public Moto(EPropulsion propulsion) : base(propulsion)
        {

        }
    }
}
