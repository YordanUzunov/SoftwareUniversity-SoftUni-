namespace UnitTests
{
    using Moq;
    using NUnit.Framework;
    using P06_Twitter.Interfaces;
    using P06_Twitter.Models;

    [TestFixture]
    public class P06_TweetTests
    {
        [Test]
        public void ReceiveMessageShouldInvokeItsClientToWriteTheMessage()
        {
            var client = new Mock<IClient>();
            client.Setup(c => c.WriteTweet(It.IsAny<string>()));
            var tweet = new Tweet(client.Object);

            tweet.ReceiveMessage("Test");

            client.Verify(c => c.WriteTweet(It.IsAny<string>()), Times.Once,
                "Tweet doesn't invoke its client to write the message");
        }

        [Test]
        public void ReceiveMessageShouldInvokeItsClientToSendTheMessageToTheServer()
        {
            var client = new Mock<IClient>();
            client.Setup(c => c.SendTweetToServer(It.IsAny<string>()));
            var tweet = new Tweet(client.Object);

            tweet.ReceiveMessage("Test");

            client.Verify(c => c.SendTweetToServer(It.IsAny<string>()), Times.Once,
                "Tweet doesn't invoke its client to send the message to the server");
        }
    }
}
