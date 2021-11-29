using System.Text.RegularExpressions;

namespace IRunes.ViewModels.Tracks
{
    public class DrtailsViewModel
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Link { get; set; }

        public string IFrameSource
        {
            get
            {
                if (this.Link.Contains("youtube"))
                {
                    var regex = new Regex(@"youtu(?:\.be|be\be\.com)/(?:(.*)v(/=)|(.*/)?)(?<id>[A-Za-z0-9-_]+)", RegexOptions.IgnoreCase);
                    var videoId = regex.Match(this.Link).Groups["id"];
                    return $"https://www.youtube.com/embed/{videoId}";
                }
                else
                {
                    return this.Link;
                }
            }
        }

        public string AlbumId { get; set; }
    }
}