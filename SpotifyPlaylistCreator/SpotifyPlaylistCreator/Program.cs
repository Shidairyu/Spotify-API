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
            Console.WriteLine("Which artist do you want to search?");
            var searchInput = Console.ReadLine();

            var spotify = SpotifyConnection.Get();

            var searchItem = spotify.SearchItems(searchInput, SearchType.Artist);
            var artistId = searchItem.Artists.Items.First().Id;
            var albums = spotify.GetArtistsAlbums(artistId, AlbumType.Album);

            foreach(var album in albums.Items)
            {
                Console.WriteLine($"Album: {album.Name}");
                var tracks = spotify.GetAlbumTracks(album.Id);
                tracks.Items.ForEach(i => Console.WriteLine(i.Name));
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
