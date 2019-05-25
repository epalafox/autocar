using AutoCarMobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AutoCarMobile
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddPage : ContentPage
	{
		public AddPage ()
		{
			InitializeComponent ();
			Save.Clicked += (e, a) => {
				((ViewModels.AutoViewModel)BindingContext).SaveCommand.Execute(null);
			};

			MessagingCenter.Subscribe<AutoViewModel, ObservableCollection<DataLayer.Auto>>(this, "NewAuto", (sender, data) => {
				Device.BeginInvokeOnMainThread(() =>
				{
					Navigation.PopToRootAsync();
				});
			});
		}
	}
}