using Xamarin.Forms.Gallery.Models;

namespace Xamarin.Forms.Gallery.Services
{
    public class GitHubService
    {
        static GitHubService _instance;

        public static GitHubService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GitHubService();
                return _instance;
            }
        }


        public RepositoryInfo GetRepositoryInfo()
        {
            // TODO: Use octokit to get real data.
            return new RepositoryInfo
            {
                Stars = 4450,
                Issues = 2253,
                PRs = 135
            };
        }
    }
}