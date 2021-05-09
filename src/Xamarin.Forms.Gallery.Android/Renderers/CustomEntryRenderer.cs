using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Gallery.Droid.Renderers;
using Xamarin.Forms.Gallery.Controls;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(BordelessEntry), typeof(CustomEntryRenderer))]
namespace Xamarin.Forms.Gallery.Droid.Renderers
{
    public class CustomEntryRenderer : EntryRenderer
    {
        public CustomEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
                Control.Background = null;
        }
    }
}