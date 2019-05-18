using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using DataLayer;

namespace AutoCarMobile.ViewModels
{
    public class AutoVM : INotifyPropertyChanged
    {
        public AutoVM()
        {
            LoadCars();
        }
        bool _isLoading = false;
        public bool IsLoading
        {
            get { return _isLoading; }
            set {
                if(_isLoading != value)
                {
                    _isLoading = value;
                    OnPropertyChanged();
                }
            }
        }
        private ObservableCollection<Auto> _autos;
        public ObservableCollection<Auto> Autos
        {
            get
            {
                return _autos;
            }
            set
            {
                if(_autos != value)
                {
                    _autos = value;
                    OnPropertyChanged();
                }
            }
        }
        private void LoadCars()
        {
            IDatabase db = LiteDBDatabase.GetInstance(Interfaces.IDevice.dir);
            /*Auto auto = new Auto();
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
            db.InsertAuto(auto);*/
            Autos = new ObservableCollection<Auto>(db.GetAutos());
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
