using System.Collections.Generic;
using Xamarin.Forms.Gallery.Models;
using Xamarin.Forms.Gallery.ViewModels.Base;
using Xamarin.Forms.Gallery.Views;

namespace Xamarin.Forms.Gallery.ViewModels
{
    public class MainViewModel : BaseGalleryViewModel
	{
		protected override IEnumerable<SectionModel> CreateItems() => new[]
		{
			new SectionModel(typeof(LayoutsPage), "Core",
				"Behaviors lets you add functionality to user interface controls without having to subclass them. Behaviors are written in code and added to controls in XAML or code"),

			new SectionModel(typeof(LayoutsPage), "Layouts",
				"Behaviors lets you add functionality to user interface controls without having to subclass them. Behaviors are written in code and added to controls in XAML or code"),

			new SectionModel(typeof(ControlsPage), "Controls",
				"Converters let you convert bindings of a certain type to a different value, based on custom logic"),

			new SectionModel(typeof(OthersPage), "User Interface Concepts",
				"Effects are used to add visual customization on a control by control bases"),

			new SectionModel(typeof(OthersPage), "Others Concepts",
				"Effects are used to add visual customization on a control by control bases")
		};
	}
}