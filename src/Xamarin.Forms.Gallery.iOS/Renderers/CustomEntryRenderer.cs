using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Gallery.Controls;
using Xamarin.Forms.Gallery.iOS.Renderers;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(BordelessEntry), typeof(CustomEntryRenderer))]
namespace Xamarin.Forms.Gallery.iOS.Renderers
{
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
                Control.BorderStyle = UITextBorderStyle.None;
        }
    }
}