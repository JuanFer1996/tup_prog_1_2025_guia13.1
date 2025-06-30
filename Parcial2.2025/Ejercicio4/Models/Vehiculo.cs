using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.Models
{
    internal class Vehiculo
    {
        String patente = "";
        Double kilometraje;




        public void CrearVehiculo(String p, Double k)
        {
            patente = p;
            kilometraje = k;

        }

        public String VerPatentes()
        {
            return patente;
        }

        public void CargarViaje(double k)
        {
            kilometraje += k;
        }

        public double VerKilometraje()
        { return kilometraje; }

    }
}
