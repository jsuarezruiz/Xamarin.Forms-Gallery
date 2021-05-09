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
				"Application development fundamentals like Shell or Navigation."),

			new SectionModel(typeof(LayoutsPage), "Layouts",
				"Layouts are used to compose user-interface controls into visual structures."),

			new SectionModel(typeof(ControlsPage), "Controls",
				"Controls are the building blocks of cross-platform mobile user interfaces."),

			new SectionModel(typeof(OthersPage), "User Interface Concepts",
				"User interface concepts like Animations, Colors, Fonts and more."),

			new SectionModel(typeof(OthersPage), "Others Concepts",
				"Other options like Graphics.")
		};
	}
}