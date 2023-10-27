using System.Runtime.CompilerServices;
using System.Text;

namespace BibliotecaDeClases
{
    public enum EPropulsion
    {
        Combustion,
        Hibrida,
        Electrica
    }
    public abstract class Vehiculo
    {

        protected bool esAWD;
        protected Guid numeroDeChasis;
        protected EPropulsion propulsion;

        public EPropulsion Propulsion
        {
            get
            {
                return this.propulsion;
            }
        }

        protected abstract string Tipo { get; }

        protected Vehiculo(EPropulsion propulsion) : this(propulsion, false)
        {

        }

        protected Vehiculo(EPropulsion propulsion, bool esAWD)
        {
            this.esAWD = esAWD;
            numeroDeChasis = Guid.NewGuid();
        }

        protected string GetInfo()
        {
            string info = string.Format("\n{0} con propulsion a {1}, {2} es AWD, numero de chasis {3}", this.Tipo, this.propulsion, this.esAWD ? "SI" : "NO", this.numeroDeChasis);
            return info;
        }

        public override string ToString()
        {
            return this.GetInfo();
        }
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return v1.numeroDeChasis == v2.numeroDeChasis && v1.GetType() == v2.GetType();
        }

        public static bool operator != (Vehiculo v1 , Vehiculo v2)
        {
            return !(v1 == v2);
        }


    }
}