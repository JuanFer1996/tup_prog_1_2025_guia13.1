using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.Models
{
    internal class Servicio
    {
        Vehiculo[] vehiculos = new Vehiculo[15];
        int cant;
        public void CargarVehiculo(double k, string p)
        {
            if (cant < 15)
            {
                vehiculos[cant].CrearVehiculo(p,k);
            }
            cant++;
        }

        public void Ordenar()
        {
            for (int i = 0; i < cant-1; i++)
            {
                for (int j = i + 1; j < cant; j++) 
                {
                    intercambio(i,j);
                }
            }
        }

        void intercambio(int i, int j)
        {

        }
    }

}
