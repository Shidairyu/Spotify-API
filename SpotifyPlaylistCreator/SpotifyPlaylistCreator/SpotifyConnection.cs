using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;
using SpotifyAPI.Web.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyPlaylistCreator
{
    internal sealed class SpotifyConnection
    {
        private SpotifyConnection() { }

        public static SpotifyWebAPI Get()
        {
            var webApiFactory = new WebAPIFactory(
                      "http://localhost",
                     8000,
                     "0c7796d077fd4539bb0b08fdcd67dbc0",
                     Scope.UserReadPrivate,
                     TimeSpan.FromSeconds(20)
            );

            try
            {
                return webApiFactory.GetWebApi().Result;
            }
            catch (Exception ex)
            {
                throw new Exception("The Authentication with the Spotify service failed.", ex);
            }
        }
    }
}
