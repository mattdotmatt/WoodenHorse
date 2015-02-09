using System.Linq;

namespace WoodenHorse
{
    public class Synchronizer
    {
        private readonly ITweets _tweets;
        private readonly IPlaylist _playlist;

        public Synchronizer(ITweets tweets, IPlaylist playlist)
        {
            _tweets = tweets;
            _playlist = playlist;
        }

        public void Synchronize()
        {
            var tweet = _tweets.NextTweet();
            _playlist.PushSongToPlaylist(ArtistFromTweet(tweet), SongFromTweet(tweet));
        }

        /// <summary>
        /// Extract a song from a tweet of form #nowplaying - Lila Downs - Agua De Rosas on #Wanderlust_Internet_Radio
        /// where "Agua De Rosas" is the song
        /// </summary>
        /// <param name="tweet"></param>
        /// <returns></returns>
        private static string SongFromTweet(string tweet)
        {
            var songDetails = GetSongDetailsFromTweet(tweet);
            return (songDetails.Length == 2) ? songDetails[1] : string.Empty;
        }

        /// <summary>
        /// Extract an artist from a tweet of form #nowplaying - Lila Downs - Agua De Rosas on #Wanderlust_Internet_Radio
        /// where "Lila Downs" is the artist
        /// </summary>
        /// <param name="tweet"></param>
        /// <returns></returns>
        private static string ArtistFromTweet(string tweet)
        {
            var songDetails = GetSongDetailsFromTweet(tweet);
            return songDetails[0];
        }

        private static string[] GetSongDetailsFromTweet(string tweet)
        {
            return string.IsNullOrEmpty(tweet) ? new[] {""} : tweet.Replace("#nowplaying - ", "").Replace(" on #Wanderlust_Internet_Radio", "").Replace(" - ", "|").Split('|');
        }
    }
}