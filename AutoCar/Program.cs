using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace AutoCar
{
    class Program
    {
        static void Main(string[] args)
        {
            IDatabase database = LiteDBDatabase.GetInstance();
            /* Auto auto = new Auto();
             auto.Id = 1;
             auto.Year = 2017;
             auto.Brand = "Volskwagen";
             auto.Model = "Vento";
             auto.Doors = 4;
             auto.ExtColor = "Grafito";
             auto.IntColor = "Gris";
             auto.Km = 76000;
             auto.Liters = 1.6f;
             auto.Price = 173900;
             IDatabase database = LiteDBDatabase.GetInstance();
             database.InsertAuto(auto);*/

            var autos = database.GetAutos();

            foreach(var a in autos)
            {
                Console.WriteLine(a._id + " " + a.GetNombre());
            }

            Console.Read();
        }
    }
}
