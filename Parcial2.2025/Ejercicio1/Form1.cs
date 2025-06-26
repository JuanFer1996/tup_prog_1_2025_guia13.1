namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] patentes = new string[15];
        double[] kilometraje = new double[15];
        int cantidad = 0;
        int viajes = 0;

        public int Buscar(string patente)
        {
            for (int i = 0; i < cantidad; i++)
            {
                if (patente == patentes[i])
                {
                    return i;
                }
            }
            return -1;
        }

        public void Ordenar()
        {
            for (int i = 0; i < cantidad - 1; i++)
            {
                for (int j = i + 1; j < cantidad; j++)
                {
                    if (kilometraje[i] > kilometraje[j])
                    {
                        double auxk = kilometraje[i];
                        string auxp = patentes[i];

                        kilometraje[i] = kilometraje[j];
                        patentes[i] = patentes[j];

                        patentes[j] = auxp;
                        kilometraje[j] = auxk;
                    }
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnRegistrarViaje_Click(object sender, EventArgs e)
        {
            fdatos fDatos = new fdatos();
            int idx;
            if (fDatos.ShowDialog() != DialogResult.Cancel)
            {
                idx = Buscar(fDatos.tbPatente.Text);
                double aux = Convert.ToDouble(fDatos.tbKilometros.Text);
                kilometraje[idx] += aux;
                viajes++;
                labelCantViajes.Text = Convert.ToString(viajes);
            }
        }
    }
}
