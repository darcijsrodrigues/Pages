using System;

using Xamarin.Forms;

namespace Pages
{
	public class SampleContentPage_CSharp : ContentPage
	{
		public SampleContentPage_CSharp()
		{
			Content = new StackLayout
			{
				Orientation = StackOrientation.Vertical,
				VerticalOptions = LayoutOptions.CenterAndExpand, 
				Padding = new Thickness(10,10,10,10),
				Children = {
					new Label { 
						HorizontalTextAlignment = TextAlignment.Center,
						VerticalTextAlignment = TextAlignment.Center,
						Text = "Hello ContentPage_C#",TextColor = Color.Black 
					},
					new Entry(),
					new Button{
						Text = "Clique", TextColor = Color.Black, BackgroundColor = Color.Gray
					}
				}

			};
		}
	}
}

