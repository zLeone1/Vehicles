using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Vehicle
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Vehicle(string brand, string model)
        {
            Marca = brand;
            Modelo = model;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Brand: {Marca} \nModel: {Modelo}");
        }
    }
}
