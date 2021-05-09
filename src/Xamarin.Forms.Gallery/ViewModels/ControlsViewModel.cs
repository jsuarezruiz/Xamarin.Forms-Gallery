using System.Collections.Generic;
using Xamarin.Forms.Gallery.Models;
using Xamarin.Forms.Gallery.ViewModels.Base;
using Xamarin.Forms.Gallery.Views;

namespace Xamarin.Forms.Gallery.ViewModels
{
    public class ControlsViewModel : BaseGalleryViewModel
	{
		protected override IEnumerable<SectionModel> CreateItems() => new[]
		{
			new SectionModel(typeof(ActivityIndicatorPage), "ActivityIndicator",
				"Displays an animation to show that the application is engaged in a lengthy activity."),

			new SectionModel(typeof(EntryPage), "Entry",
				"The Entry control is used for single-line text input."),

			new SectionModel(typeof(EditorPage), "Editor",
				"The Editor control is used to accept multi-line input."),
		};
	}
}