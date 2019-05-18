using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using AutoCarMobile.ViewModels;

namespace AutoCarMobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new AutoVM();
            lvCars.ItemsSource = ((AutoCarMobile.ViewModels.AutoVM)BindingContext).Autos;
        }
    }
}
