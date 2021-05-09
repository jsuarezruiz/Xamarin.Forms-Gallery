using System;
using System.Windows.Input;
using Xamarin.Forms.Gallery.Models;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace Xamarin.Forms.Gallery.Views.Base
{
	public class BasePage : ContentPage
	{
		public BasePage()
		{
			On<iOS>().SetPrefersHomeIndicatorAutoHidden(true);

			NavigateCommand = new Command<SectionModel>(sectionModel =>
			{
				if (sectionModel != null)
					Navigation.PushAsync(PreparePage(sectionModel));
			});
		}

		public Color DetailColor { get; set; }

		public ICommand NavigateCommand { get; }

		Page PreparePage(SectionModel model)
		{
			var page = (ContentPage)Activator.CreateInstance(model.Type);
			page.Title = model.Title;

			return page;
		}
	}
}