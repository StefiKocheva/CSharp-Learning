namespace IRunes.Services
{
    using IRunes.Models;
    using IRunes.ViewModels.Albums;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AlbumsService : IAlbumsService
    {
        private readonly ApplicationDbContext db;

        public AlbumsService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public void Create(string name, string cover)
        {
            var album = new Album
            {
                Name = name,
                Cover = cover,
                Price = 0.00M
            };

            this.db.Albums.Add(album);
            this.db.SaveChanges();
        }

        public IEnumerable<T> GetAll<T>(Func<Album, T> selectFunc)
        {
            var allAlbums = this.db.Albums.Select(selectFunc).ToList();

            return allAlbums;
        }

        public AlbumDetailsViewModel GetDetails(string id)
        {
            var album = this.db.Albums.Where(x => x.Id == id)
                .Select(x => new AlbumDetailsViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Cover = x.Cover,
                    Price = x.Price,
                    Tracks = x.Tracks.Select(t => new TrackInfoViewModel
                    {
                        Id = t.Id,
                        Name = t.Name,
                    })
                }).FirstOrDefault();

            return album;
        }
    }
}