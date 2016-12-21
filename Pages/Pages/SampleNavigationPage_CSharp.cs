using System;

using Xamarin.Forms;

namespace Pages
{
	public class SampleNavigationPage_CSharp : ContentPage
	{
		public SampleNavigationPage_CSharp()
		{
			Padding = new Thickness(0, Device.OnPlatform(10, 0, 0), 0, 0);
				
			Content = new StackLayout
			{
				Orientation = StackOrientation.Vertical,
				VerticalOptions = LayoutOptions.Center,
				BackgroundColor = Color.FromHex("#D7DCDE"),//<<<<<<
				Children = {
					new Label{
						Text="NavigationPage_CSharp",
						TextColor=Color.Black
					},
					new Button{
						Text = "Push",
						BackgroundColor = Color.Gray,//<<<<<<
						TextColor = Color.Black,//<<<<<<<
						Command = new Command(() => Navigation.PushAsync( new SampleContentPage_CSharp()))
							
					},

					new Button{
						Text = "Push Modal",
						BackgroundColor = Color.Gray,//<<<<<<
						TextColor = Color.Black,//<<<<<<<
						Command = new Command(() => Navigation.PushModalAsync(new ModalPage()))
					}
				}
			};
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

