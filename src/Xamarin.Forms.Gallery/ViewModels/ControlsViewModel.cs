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
				"The AvatarView represents a user's name by using the initials and a generated background color"),

			new SectionModel(typeof(EntryPage), "Entry",
				"The AvatarView represents a user's name by using the initials and a generated background color"),

			new SectionModel(typeof(EditorPage), "Editor",
				"The AvatarView represents a user's name by using the initials and a generated background color"),
		};
	}
}