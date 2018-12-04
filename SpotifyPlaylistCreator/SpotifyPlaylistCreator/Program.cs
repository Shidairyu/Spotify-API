using SpotifyAPI.Web.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SpotifyPlaylistCreator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var spotify = SpotifyConnection.Get();

            var searchItem = spotify.SearchItems("Asap+Rocky", SearchType.Artist);
            var artistId = searchItem.Artists.Items.First().Id.ToString();
            var albums = spotify.GetArtistsAlbums(artistId, AlbumType.Album);

            foreach(var album in albums.Items)
            {
                Console.WriteLine(album.Name);
                var tracks = spotify.GetAlbumTracks(album.Id);
                tracks.Items.ForEach(i => Console.WriteLine(i.Name));
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
