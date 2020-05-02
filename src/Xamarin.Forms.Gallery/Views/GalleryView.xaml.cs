using System;

namespace Xamarin.Forms.Gallery.Views
{
    public partial class GalleryView : ContentPage
    {
        public GalleryView()
        {
            InitializeComponent();
        }

        void OnSettingsClicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new SettingsView());
        }
    }
}