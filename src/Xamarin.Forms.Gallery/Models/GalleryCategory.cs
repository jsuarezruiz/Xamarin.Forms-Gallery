using System.Collections.Generic;

namespace Xamarin.Forms.Gallery.Models
{
    public class GalleryCategory
    {
        public string Name { get; set; }
        public List<GalleryItem> Items { get; set; }
    }
}