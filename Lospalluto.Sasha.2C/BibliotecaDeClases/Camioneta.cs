using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Camioneta : Vehiculo
    {
        private bool cabinaSimple;

        protected override string Tipo 
        {
            get
            {
                return "Camioneta";
            }
        }

        public Camioneta(EPropulsion propulsion, bool cabinaSimple) :base(propulsion, true)
        {
            this.cabinaSimple = cabinaSimple;
        }

        protected override string GetInfo()
        {
            string info = string.Format("{0} con cambina {1}", base.ToString(), this.cabinaSimple ? "Simple" : "Doble");
            return info;
        }
    }
}
