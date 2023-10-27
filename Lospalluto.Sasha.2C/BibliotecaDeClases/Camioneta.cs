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

        public Camioneta(EPropulsion propulsion, bool cabinaSimple) : base(propulsion, true)
        {
            this.cabinaSimple = cabinaSimple;
        }

        protected new string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.ToString()} con cambina ");
            if(cabinaSimple)
            {
                sb.Append("Simple");
            }
            else
            {
                sb.Append("Doble");
            }
            return sb.ToString();
        }
    }
}
