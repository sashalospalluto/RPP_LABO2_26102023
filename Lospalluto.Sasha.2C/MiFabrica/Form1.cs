using BibliotecaDeClases;

namespace MiFabrica
{
    public partial class FabricaDeVehiculos : Form
    {
        Fabrica fabrica;
        public FabricaDeVehiculos()
        {
            InitializeComponent();
            this.InicializarFabrica();
            this.Refrescar();
        }

        private void btnFabricar_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculo = this.CrearVehiculo();
            fabrica = fabrica + vehiculo;
            this.Refrescar();
        }

        private void FabricaDeVehiculos_Load(object sender, EventArgs e)
        {

        }

        private void btnElimimar_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculoSeleccionado = (Vehiculo)lstVehiculos.SelectedItem;
            fabrica = fabrica - vehiculoSeleccionado;
        }

        private Vehiculo CrearVehiculo()
        {
            switch (this.cmbTipo.SelectedItem.ToString())
            {
                case "Automovil":
                    Automovil a = new Automovil();
                    return a;
                case "Camioneta":
                    Camioneta c = new Camioneta(EPropulsion.Hibrida, false);
                    return c;
                default:
                    Moto m = new Moto(EPropulsion.Electrica);
                    return m;
            }

        }

        private void InicializarFabrica()
        {
            fabrica = new Fabrica(3);
            //Camioneta c1 = new Camioneta(EPropulsion.Electrica, true);
            //fabrica = fabrica + c1;
        }

        private void Refrescar()
        {
            this.lstVehiculos.DataSource = null;
            this.lstVehiculos.DataSource = fabrica.Vehiculos;
        }

    }
}