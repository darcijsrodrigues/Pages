using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Pages
{
	public partial class SampleNavigationPage_Xaml : ContentPage
	{
		public SampleNavigationPage_Xaml()
		{
			InitializeComponent();
		}

		async void onPushButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new SampleContentPage_CSharp());
		}

		async void onPushModalButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new ModalPage());
		}

		// Classe interna 
		public class ModalPage : ContentPage
		{
			public ModalPage()
			{
				Content = new StackLayout
				{
					Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0),

					Children = {
					new Label { Text = "Modal Page" },
					new Button() {
						Text = "Pop Modal",
						Command = new Command(() => Navigation.PopModalAsync())
					}
				}
				};
			}
		}
	}
}
