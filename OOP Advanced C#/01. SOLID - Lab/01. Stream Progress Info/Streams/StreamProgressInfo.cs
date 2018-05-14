namespace _01._Stream_Progress_Info.Streams
{
    using Interfaces;

    public class StreamProgressInfo : StreamProgressor
    {
        public StreamProgressInfo(IStreamable file) : base(file)
        {
        }
    }
}
