using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace DataLayer
{
    public class LiteDBDatabase : IDatabase
    {
        private static LiteDBDatabase Instance;
        private LiteDatabase _db;
        private LiteDBDatabase()
        {
            System.IO.Directory.CreateDirectory(Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "AppData"));
            _db = new LiteDatabase(
                Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "AppData",
                "AutoCar.db"
                ));
        }
        public static LiteDBDatabase GetInstance()
        {
            if (Instance == null)
            {
                Instance = new LiteDBDatabase();
            }
            return Instance;
        }
        public void DeleteAuto(Auto auto)
        {
        }

        public List<Auto> GetAutos()
        {
            var col = _db.GetCollection<Auto>("Auto");
            var autos = col.FindAll().ToList();
            return autos;
        }

        public void InsertAuto(Auto auto)
        {
            var col = _db.GetCollection<Auto>("Auto");
            col.Insert(auto);
        }

        public void UpdateAuto(Auto auto)
        {
        }
    }
}
