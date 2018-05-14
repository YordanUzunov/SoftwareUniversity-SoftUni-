namespace P06_Twitter.Interfaces
{
    public interface IClient
    {
        void WriteTweet(string message);

        void SendTweetToServer(string message);
    }
}
