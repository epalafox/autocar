using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public abstract class AAuto : IAuto
    {
        public int Id;
        public int Year;
        public string Brand;
        public string Model;
        public float Price;
        public int Km;
        public string ExtColor;
        public string IntColor;
        public float Liters;
        public int Doors;

        public abstract string GetNombre();
    }
}
