using Ejercicio4.Models;

namespace Ejercicio4
{
    public partial class fPrincipal : Form
    {
        Servicio s = new Servicio();

        public fPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            fDatos fDatos = new fDatos();
            while (fDatos.ShowDialog() == DialogResult.OK || s.VerCantidadVehiculos() > 15)
            {
                double auxk = Convert.ToDouble(fDatos.tbKilometros.Text);
                string patente = fDatos.tbPatente.Text;
                s.CargarVehiculo(auxk, patente);
               
                listBoxPatentes.Items.Add(patente);

                fDatos.tbPatente.Clear();
                fDatos.tbKilometros.Clear();
            }
        }

        private void btnRegistrarViaje_Click(object sender, EventArgs e)
        {
            fDatos fDatos = new fDatos();
            while (fDatos.ShowDialog() == DialogResult.OK)
            {
                double auxk = Convert.ToDouble(fDatos.tbKilometros.Text);
                string patente = fDatos.tbPatente.Text;
                s.CargarViaje(auxk, patente);
                fDatos.tbPatente.Clear();
                fDatos.tbKilometros.Clear();
            }
            labelCantViajes.Text = Convert.ToString(s.VerCantidadViajes());
        }

        private void btnResumenFinal_Click(object sender, EventArgs e)
        {
            fResumen fresumen = new fResumen();
            listBoxPatentes.Items.Clear();
            s.Ordenar();
            for (int i = 0; i < s.VerCantidadVehiculos(); i++)
            {
                fresumen.listBoxPatentes.Items.Add(s.VerVehiculo(i));
            }
            fresumen.listBoxPatentes.Items.Add(s.CalcularProm());
            fresumen.ShowDialog();
        }
    }
}
