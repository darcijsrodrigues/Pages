using System;

using Xamarin.Forms;

namespace Pages
{
	public class SampleCaroulselPage_CSharp : CarouselPage 
	{
		public SampleCaroulselPage_CSharp()
		{
			StackLayout stlOne = new StackLayout { 
				Orientation = StackOrientation.Vertical, 
				BackgroundColor = Color.Blue,
				Children = { 
					new Label{
						Text = "First Page", 
						FontSize=15, 
						TextColor = Color.White, 
						VerticalOptions = LayoutOptions.CenterAndExpand, 
						HorizontalTextAlignment = TextAlignment.Center}
				}
			};

			StackLayout stlSecond = new StackLayout
			{
				Orientation = StackOrientation.Vertical,
				BackgroundColor = Color.Yellow,
				Children = {
					new Label{
						Text = "Second Page",
						FontSize=15,
						TextColor = Color.Black,
						VerticalOptions = LayoutOptions.CenterAndExpand,
						HorizontalTextAlignment = TextAlignment.Center}
				}
			};

			StackLayout stlThird = new StackLayout
			{
				Orientation = StackOrientation.Vertical,
				BackgroundColor = Color.Red,
				Children = {
					new Label{
						Text = "Third Page",
						FontSize=15,
						TextColor = Color.White,
						VerticalOptions = LayoutOptions.CenterAndExpand,
						HorizontalTextAlignment = TextAlignment.Center}
				}
			};

			Children.Add(new ContentPage { Content = stlOne });
			Children.Add(new ContentPage { Content = stlSecond });
			Children.Add(new ContentPage { Content = stlThird });

		}
	}
}

