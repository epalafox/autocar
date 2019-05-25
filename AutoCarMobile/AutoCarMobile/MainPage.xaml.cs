using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using AutoCarMobile.ViewModels;
using System.Collections.ObjectModel;

namespace AutoCarMobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new AutoVM();
            lvCars.ItemsSource = ((AutoCarMobile.ViewModels.AutoVM)BindingContext).Autos;

			Add.Clicked += (e, a) =>
			{
				Navigation.PushAsync(new AddPage());
			};

			MessagingCenter.Subscribe<AutoViewModel, ObservableCollection<DataLayer.Auto>>(this, "NewAuto", (sender, data) => {
				Device.BeginInvokeOnMainThread(() =>
				{
					((AutoCarMobile.ViewModels.AutoVM)BindingContext).Autos = data;
					lvCars.ItemsSource = ((AutoCarMobile.ViewModels.AutoVM)BindingContext).Autos;
				});
			});
		}
    }
}
