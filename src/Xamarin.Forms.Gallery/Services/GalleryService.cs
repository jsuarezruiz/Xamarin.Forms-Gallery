using System.Collections.Generic;
using Xamarin.Forms.Gallery.Models;

namespace Xamarin.Forms.Gallery.Services
{
    public class GalleryService
    {
        static GalleryService _instance;

        public static GalleryService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GalleryService();
                return _instance;
            }
        }

        public List<ShowcaseItem> GetShowcaseItems()
        {
            return new List<ShowcaseItem>
            {
                new ShowcaseItem { Name = "ShoppingList", Image = "expander_showcase.png", Description = "Xamarin.Forms goodlooking UI sample using Expander." },
                new ShowcaseItem { Name = "FavFighters", Image = "swipeview_showcase.png", Description = "Xamarin.Forms goodlooking UI sample using SwipeView." },
                new ShowcaseItem { Name = "DrinksGallery", Image = "carouselview_showcase.png", Description = "Xamarin.Forms goodlooking UI sample using CarouselView." },
            };
        }

        public List<GalleryCategory> GetGalleryItems()
        {
            return new List<GalleryCategory>
            {
                new GalleryCategory { Name = "Views for presentation", Items = new List<GalleryItem>
                {
                    new GalleryItem { Name = "BoxView", Icon = "boxview.png", Color = Color.FromHex("#f8eff8"), Description = "BoxView displays a solid rectangle colored by the Color property." },
                    new GalleryItem { Name = "Expander", Icon = "expander.png", Color = Color.FromHex("#eceefc"), Description = "Expander provides an expandable container to host any content, and is comprised of a header and content." },
                    new GalleryItem { Name = "Label", Icon = "label.png", Color = Color.FromHex("#e4f2fa"), Description = "Label displays single-line text strings or multi-line blocks of text, either with constant or variable formatting." },
                    new GalleryItem { Name = "Image", Icon = "image.png", Color = Color.FromHex("#abb9f3"), Description = "Image displays a bitmap. Bitmaps can be downloaded over the Web, embedded as resources in the common project or platform projects, or created using a .NET Stream object." },
                    new GalleryItem { Name = "Map", Icon = "map.png", Color = Color.FromHex("#ddf3ab"), Description = "Map displays a map." },
                    new GalleryItem { Name = "MediaElement", Icon = "mediaplayer.png", Color = Color.FromHex("#f3abb9"), Description = "MediaElement plays video or audio. Media can be played from a URL or from a local file." },
                    new GalleryItem { Name = "OpenGLView", Icon = "openglview.png", Color = Color.FromHex("#abf3e5"), Description = "OpenGLView displays OpenGL graphics." },
                    new GalleryItem { Name = "WebView", Icon = "webview.png", Color = Color.FromHex("#abddf3"), Description = "WebView displays Web pages or HTML content." },
                } },
                new GalleryCategory { Name = "Views that initiate commands", Items = new List<GalleryItem>
                {
                    new GalleryItem { Name = "Button", Icon = "button.png", Color = Color.FromHex("#f3c1ab"), Description = "Button is a rectangular object that displays text, and which fires a Clicked event when it's been pressed." },
                    new GalleryItem { Name = "ImageButton", Icon = "imagebutton.png", Color = Color.FromHex("#f3e5ab"), Description = "ImageButton is a rectangular object that displays an image, and which fires a Clicked event when it's been pressed." },
                    new GalleryItem { Name = "RadioButton", Icon = "radiobutton.png", Color = Color.FromHex("#eef8fd"), Description = "RadioButton allows the selection of one option from a set, and fires a CheckedChanged event when selection occurs." },
                    new GalleryItem { Name = "RefreshView", Icon = "refreshview.png", Color = Color.FromHex("#efefef"), Description = "RefreshView is a container control that provides pull-to-refresh functionality for scrollable content." },
                    new GalleryItem { Name = "SearchBar", Icon = "searchbar.png", Color = Color.FromHex("#ffffd2"), Description = "SearchBar displays an area for the user to type a text string, and a button (or a keyboard key) that signals the application to perform a search." },
                    new GalleryItem { Name = "SwipeView", Icon = "swipeview.png", Color = Color.FromHex("#ddb9ff"), Description = "SwipeView is a container control that wraps around an item of content, and provides context menu items that are revealed by a swipe gesture." },
                } },
                new GalleryCategory { Name = "Views for setting values", Items = new List<GalleryItem>
                {
                    new GalleryItem { Name = "CheckBox", Icon = "checkbox.png", Color = Color.FromHex("#d2e9ff"), Description = "CheckBox allows the user to select a Boolean value using a type of button that can either be checked or empty." },
                    new GalleryItem { Name = "Slider", Icon = "slider.png", Color = Color.FromHex("#df97f3"), Description = "Slider allows the user to select a double value from a continuous range specified with the Minimum and Maximum properties." },
                    new GalleryItem { Name = "Stepper", Icon = "stepper.png", Color = Color.FromHex("#d2ffff"), Description = "Stepper allows the user to select a double value from a range of incremental values specified with the Minimum, Maximum, and Increment properties." },
                    new GalleryItem { Name = "Switch", Icon = "switch_icon.png", Color = Color.FromHex("#cfcfcf"), Description = "Switch takes the form of an on/off switch to allow the user to select a Boolean value." },
                    new GalleryItem { Name = "DatePicker", Icon = "datepicker.png", Color = Color.FromHex("#f8c5ea"), Description = "DatePicker allows the user to select a date with the platform date picker." },
                    new GalleryItem { Name = "TimePicker", Icon = "timepicker.png", Color = Color.FromHex("#f5c1ae"), Description = "TimePicker allows the user to select a time with the platform time picker." },
                } },
                new GalleryCategory { Name = "Views for editing text", Items = new List<GalleryItem>
                {
                    new GalleryItem { Name = "Entry", Icon = "entry.png", Color = Color.FromHex("#d81943"), Description = "Entry allows the user to enter and edit a single line of text." },
                    new GalleryItem { Name = "Editor", Icon = "editor.png", Color = Color.FromHex("#97f3df"), Description = "Editor allows the user to enter and edit multiple lines of text." },
                } },
                new GalleryCategory { Name = "Views to indicate activity", Items = new List<GalleryItem>
                {
                    new GalleryItem { Name = "ActivityIndicator", Icon = "activityindicator.png", Color = Color.FromHex("#f3df97"), Description = "ActivityIndicator uses an animation to show that the application is engaged in a lengthy activity without giving any indication of progress." },
                    new GalleryItem { Name = "ProgressBar", Icon = "progressbar.png", Color = Color.FromHex("#f6c3ae"), Description = "ProgressBar uses an animation to show that the application is progressing through a lengthy activity." },
                } },
                new GalleryCategory { Name = "Views that display collection", Items = new List<GalleryItem>
                {
                    new GalleryItem { Name = "CarouselView", Icon = "carouselview.png", Color = Color.FromHex("#97d9f3"), Description = "CarouselView displays a scrollable list of data items." },
                    new GalleryItem { Name = "CollectionView", Icon = "collectionview.png", Color = Color.FromHex("#d9f397"), Description = "CollectionView displays a scrollable list of selectable data items, using different layout specifications." },
                    new GalleryItem { Name = "IndicatorView", Icon = "indicatorview.png", Color = Color.FromHex("#97f3b1"), Description = "IndicatorView displays indicators that represent the number of items in a CarouselView." },
                    new GalleryItem { Name = "ListView", Icon = "listview.png", Color = Color.FromHex("#f397d9"), Description = "ListView derives from ItemsView and displays a scrollable list of selectable data items." },
                    new GalleryItem { Name = "Picker", Icon = "picker.png", Color = Color.FromHex("#fbe5dc"), Description = "Picker displays a selected item from a list of text strings, and allows selecting that item when the view is tapped." },
                    new GalleryItem { Name = "TableView", Icon = "tableview.png", Color = Color.FromHex("#dce3fb"), Description = "TableView displays a list of rows of type Cell with optional headers and subheaders." }
                } }
            };
        }
    }
}