using Rdio.Simple;

namespace WoodenHorse
{
    public class RdioService : IPlaylist
    {
        public bool PushSongToPlaylist(string artist, string title)
        {
            var rdioAuth = new OAuth.Consumer()
            var rdio = new RdioClient(rdioAuth);
            rdio.Call()
        }
    }
}