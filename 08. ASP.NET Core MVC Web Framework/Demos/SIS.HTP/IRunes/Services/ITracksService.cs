namespace IRunes.Services
{
    using IRunes.ViewModels.Tracks;

    public interface ITracksService
    {
        void Create(string albumId, string name, string link, decimal price);

        DrtailsViewModel GetDetails(string trackId);
    }
}