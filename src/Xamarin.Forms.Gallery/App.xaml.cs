using Xamarin.Forms.Gallery.Views;

namespace Xamarin.Forms.Gallery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CustomNavigationPage(new GalleryView());
        }

        public static string AppTheme { get; set; }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
