using System;

using Xamarin.Forms;

namespace Pages
{
	public class SampleMasterDetailPage_CSharp : MasterDetailPage
	{
		public SampleMasterDetailPage_CSharp()
		{
			this.Master = MasterPage();
			this.Detail = new PageDetail();
		}


		public Page MasterPage()
		{

			return new ContentPage
			{
				Title = "MasterPage",
				BackgroundColor=Color.Blue,
				Content = new Label
				{

					Text = "Master Page",
					VerticalOptions = LayoutOptions.CenterAndExpand,
					HorizontalOptions = LayoutOptions.CenterAndExpand,
				},
			};
		}

		public Page DetailPage()
		{
			return new ContentPage
			{
				BackgroundColor = Color.Green,
				Content = new Label
				{
					Text = "Detail Page",
					VerticalOptions = LayoutOptions.CenterAndExpand,
					HorizontalOptions = LayoutOptions.CenterAndExpand,

				},
			};
		}
	}
}

