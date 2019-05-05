using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IDatabase
    {
        List<Auto> GetAutos();
        void InsertAuto(Auto auto);
        void UpdateAuto(Auto auto);
        void DeleteAuto(Auto auto);
    }
}
