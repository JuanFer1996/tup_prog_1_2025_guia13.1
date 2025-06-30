using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.Models
{
    internal class Servicio
    {
        private Vehiculo[] vehiculos = new Vehiculo[15];
        private int cantVehiculos=0;
        private int cantViajes=0;



        public void CargarVehiculo(double k, string p)
        {
            if (cantVehiculos < vehiculos.Length)
            {
                
                Vehiculo v = new Vehiculo();
                v.CrearVehiculo(p, k);
                vehiculos[cantVehiculos]=v;
                cantVehiculos++;
            }
        }

        public int Buscar(string p)
        {
            for (int i = 0; i < cantVehiculos; i++)
            {
                if( vehiculos[i].VerPatentes() == p)
                {  return i; }
            }
            return -1;
        }
        public void CargarViaje(double k, string p)
        {
            int idx = Buscar(p);
            if (idx >= 0 && idx < 15)
            {
                vehiculos[idx].CargarViaje(k);
                cantViajes++;
            }
        }

        public void Ordenar()
        {
            for (int i = 0; i < cantVehiculos - 1; i++)
            {
                for (int j = i + 1; j < cantVehiculos; j++) 
                {
                    if (vehiculos[i].VerKilometraje() < vehiculos[j].VerKilometraje())
                   intercambio(i,j);
                }
            }
        }

        void intercambio(int i, int j)
        {
            Vehiculo auxk = vehiculos[j];
            vehiculos[j]=vehiculos[i];
            vehiculos[i] = auxk;

        }

        public int VerCantidadVehiculos()
        {
            return cantVehiculos;
        }

        public int VerCantidadViajes()
        {
            return cantViajes;
        }

        public string VerVehiculo(int ind)
        {
            string rtn = $"km: {vehiculos[ind].VerKilometraje()} Patente: {vehiculos[ind].VerPatentes()}";
            return rtn;
        }

        public string CalcularProm()
        {
            double acum = 0;
            for (int i = 0; i < cantVehiculos; i++)
            {
                acum += vehiculos[i].VerKilometraje();

            }
            double prom = acum / cantViajes;
            string rtn = $"Kilometros de viaje promedio: {prom}";

            return rtn;
        }
    }

}
