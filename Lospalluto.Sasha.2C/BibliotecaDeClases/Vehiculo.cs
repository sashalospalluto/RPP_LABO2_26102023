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

        protected Vehiculo(EPropulsion propulsion)
        {
            esAWD = false;
            this.propulsion = propulsion;
            numeroDeChasis = new Guid();
        }

        protected Vehiculo(EPropulsion propulsion, bool esAWD) :this(propulsion)
        {
            this.esAWD = esAWD;
        }

        protected virtual string GetInfo()
        {
            string info = string.Format("\n{0} con propulsion a {1}, {2} es AWD, numero de chasis {3}", this.GetType().Name, this.propulsion, this.esAWD ? "SI" : "NO", this.numeroDeChasis);

            return info;
        }

        public override string ToString()
        {
            return this.GetInfo();
        }
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return v1.esAWD == v2.esAWD && v1.Tipo == v2.Tipo;
        }

        public static bool operator != (Vehiculo v1 , Vehiculo v2)
        {
            return !(v1 == v2);
        }


    }
}