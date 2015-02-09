using FakeItEasy;
using Xunit;

namespace WoodenHorse.Tests
{
    public class SynchronizerTests
    {
        [Fact]
        public void SynchronizerShouldCopyTweetsToSpotify()
        {
            // Arrange
            var fakeTwitter = A.Fake<ITweets>();
            A.CallTo(() => fakeTwitter.NextTweet()).Returns("#nowplaying - Lila Downs - Agua De Rosas on #Wanderlust_Internet_Radio");

            var fakeSpotify = A.Fake<IPlaylist>();

            // Act
            var sut = new Synchronizer(fakeTwitter, fakeSpotify);
            sut.Synchronize();

            // Assert
            A.CallTo(() => fakeTwitter.NextTweet()).MustHaveHappened();
            A.CallTo(() => fakeSpotify.PushSongToPlaylist("Lila Downs", "Agua De Rosas")).MustHaveHappened();

        }
    }
}
