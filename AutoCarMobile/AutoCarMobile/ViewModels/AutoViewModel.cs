using DataLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace AutoCarMobile.ViewModels
{
	public class AutoViewModel : INotifyPropertyChanged
	{
		private int _id;
		private int _year;
		private string _brand;
		private string _model;
		private float _price;
		private int _km;
		private string _extColor;
		private string _intColor;
		private float _liters;
		private int _doors;
		public int Id {
			get => _id;
			set {
				if(_id != value)
				{
					_id = value;
					OnPropertyChanged();
				}
			}
		}

		public int Year { get => _year;
			set {
				if (_year != value)
				{
					_year = value;
					OnPropertyChanged();
				}
			} }
		public string Brand { get => _brand;
			set
			{
				if (_brand != value)
				{
					_brand = value;
					OnPropertyChanged();
				}
			}
		}
		public string Model { get => _model;
			set {
				if(_model != value)
				{
					_model = value;
					OnPropertyChanged();
				}
				} }
		public float Price
		{
			get => _price; set
			{
				if (_price != value)
				{
					_price = value;
					OnPropertyChanged();
				}
			}
		}
		public int Km { get => _km; set {
				if (_km != value) {
					_km = value;
					OnPropertyChanged();
				}
			}
		}
		public string ExtColor { get => _extColor;
			set {
				if (_extColor != value)
				{
					_extColor = value;
					OnPropertyChanged();
				}
			}
		}
		public string IntColor
		{
			get => _intColor; set
			{
				if (_intColor != value)
				{
					_intColor = value;
					OnPropertyChanged();
				}
			}
		}
		public float Liters { get => _liters; set {
				if(_liters != value)
				{
					_liters = value;
					OnPropertyChanged();
				}
			} }
		public int Doors { get => _doors; set
			{ if (_doors != value)
				{ _doors = value; OnPropertyChanged(); } } }

		public Command SaveCommand
		{
			get {
				return new Command(() => {
					IDatabase db = LiteDBDatabase.GetInstance(Interfaces.IDevice.dir);
					Auto a = new Auto
					{
						Brand = this.Brand,
						Doors = this.Doors,
						ExtColor = this.ExtColor,
						IntColor = this.IntColor,
						Km = this.Km,
						Liters = this.Liters,
						Model = this.Model,
						Price = this.Price,
						Year = this.Year
					};
					db.InsertAuto(a);
					MessagingCenter.Send(this, "NewAuto", new ObservableCollection<DataLayer.Auto>(db.GetAutos()));
				});
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
