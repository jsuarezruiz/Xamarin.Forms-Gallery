using System;
using System.Collections.Generic;
using Microcharts;
using SkiaSharp;
using Xamarin.Forms.Gallery.ViewModels;

namespace Xamarin.Forms.Gallery.Views
{
    public partial class GalleryView : ContentPage
    {
        public GalleryView()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            LoadChartData();
        }

        void OnSettingsClicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new SettingsView());
        }

        void LoadChartData()
        {
            if (!(BindingContext is GalleryViewModel vm))
                return;

            var repositoryInfo = vm.RepositoryInfo;

            Application.Current.Resources.TryGetValue("StarsColor", out object starsColor);
            string starsColorHex = ((Color)starsColor).ToHex();

            Application.Current.Resources.TryGetValue("IssuesColor", out object issuesColor);
            string issuesColorHex = ((Color)issuesColor).ToHex();

            Application.Current.Resources.TryGetValue("PullRequestsColor", out object pullRequestsColor);
            string pullRequestsColorHex = ((Color)pullRequestsColor).ToHex();

            var entries = new List<ChartEntry>
            {
                new ChartEntry(repositoryInfo.PRs) { Label = "Pull Requests", Color = SKColor.Parse(starsColorHex) },
                new ChartEntry(repositoryInfo.Issues) { Label = "Issues", Color = SKColor.Parse(issuesColorHex) },
                new ChartEntry(repositoryInfo.Stars) { Label = "Stars", Color = SKColor.Parse(pullRequestsColorHex) }
            };

            // TODO: Create Custom ChartView using SkiaSharp.
            Chartview.Chart = new RadialGaugeChart()
            {
                BackgroundColor = SKColors.Transparent,
                LabelTextSize = 0,
                MaxValue = 5000,
                Entries = entries
            };
        }
    }
}