using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms.Gallery.Models;

namespace Xamarin.Forms.Gallery.ViewModels.Base
{
	public abstract class BaseGalleryViewModel : BaseViewModel
	{
		public BaseGalleryViewModel()
		{
			Items = CreateItems().ToList();
			Filter();
			FilterCommand = new Command(Filter);
		}

		public IReadOnlyList<SectionModel> Items { get; }

		public ICommand FilterCommand { get; }

		public string FilterValue { private get; set; } = string.Empty;

		public IEnumerable<SectionModel> FilteredItems { get; private set; } = Enumerable.Empty<SectionModel>();

		protected abstract IEnumerable<SectionModel> CreateItems();

		void Filter()
		{
			FilterValue ??= string.Empty;
			FilteredItems = Items.Where(item => item.Title.IndexOf(FilterValue, StringComparison.InvariantCultureIgnoreCase) >= 0);
			OnPropertyChanged(nameof(FilteredItems));
		}
	}
}