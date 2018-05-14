namespace _01._Stream_Progress_Info.Interfaces
{
    public interface IStreamable : ISource
    {
        int BytesSent { get; }
    }
}
