using SpotifyAPI.Web;
using SpotifyAPI.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyPlaylistCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            var spotify = new SpotifyWebAPI()
            {
                UseAuth = false,
            };

            var fullTrack = spotify.GetTrack("3Hvu1pq89D4R0lyPBoujSv");
            Console.Write(fullTrack.Name);
        }
    }
}
