using System;

using Xamarin.Forms;

namespace Pages
{
	public class SampleTabbedpage_CSharp : TabbedPage
	{
		public SampleTabbedpage_CSharp()
		{
			this.Title = "SampleTabbedPage";

			this.Children.Add(new ContentPage
			{
				Title = "1ª",
				Icon = "icon.png",
				Padding = new Thickness(0, Device.OnPlatform(10, 0, 0), 0, 0),
				Content = new StackLayout
				{
					Children = {
					new Label{
							HorizontalTextAlignment = TextAlignment.Center,
						VerticalTextAlignment = TextAlignment.Center,
							Text="Page one"}
				  }
				}
			});
			this.Children.Add(new ContentPage
			{
				Title = "2ª",
				Icon = "icon.png",
				Padding = new Thickness(0, Device.OnPlatform(10, 0, 0), 0, 0),
				Content = new StackLayout
				{
					Children = {

					new Label{
							HorizontalTextAlignment = TextAlignment.Center,
						VerticalTextAlignment = TextAlignment.Center,
							Text="Page two"}
				  }
				}
			});
			this.Children.Add(new ContentPage
			{
				Title = "3ª",
				Icon = "icon.png",
				Content = new StackLayout
				{
					Children = {
					new Label{
							HorizontalTextAlignment = TextAlignment.Center,
						VerticalTextAlignment = TextAlignment.Center,
							Text="Page three"}
				  }
				}
			});
			this.Children.Add(new ContentPage
			{
				Title = "4ª",
				Icon = "icon.png",
				Padding = new Thickness(0, Device.OnPlatform(10, 0, 0), 0, 0),
				Content = new StackLayout
				{
					Children = {
					new Label{
							HorizontalTextAlignment = TextAlignment.Center,
						VerticalTextAlignment = TextAlignment.Center,
							Text="Page four"}
				  }
				}
			});
			this.Children.Add(new ContentPage
			{
				Title = "5ª",
				Icon = "icon.png",
				Padding = new Thickness(0, Device.OnPlatform(10, 0, 0), 0, 0),
				Content = new StackLayout
				{
					Padding = new Thickness(0, Device.OnPlatform(10, 0, 0), 0, 0),
					Children = {
					new Label{
							HorizontalTextAlignment = TextAlignment.Center,
						VerticalTextAlignment = TextAlignment.Center,
							Text="Page five"}
				  }
				}
			});
			this.Children.Add(new ContentPage
			{
				Padding = new Thickness(0, Device.OnPlatform(10, 0, 0), 0, 0),
				Title = "6ª",
				Icon = "icon.png",
				Content = new StackLayout
				{
					Children = {
					new Label{
							HorizontalTextAlignment = TextAlignment.Center,
						VerticalTextAlignment = TextAlignment.Center,
							Text="Page six"}
				  }
				}
			});
		}
	}
}

