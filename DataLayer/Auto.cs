using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Auto
    {
        public int _id { get; set; }
        public int Id { get; set; }
        public int Year { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public float Price { get; set; }
        public int Km { get; set; }
        public string ExtColor { get; set; }
        public string IntColor { get; set; }
        public float Liters { get; set; }
        public int Doors { get; set; }
        public string GetNombre()
        {
            return $"{Year} {Brand} {Model}";
        }
    }
}
