namespace TeamBuilder.App
{
    using TeamBuilder.App.Core;
    using TeamBuilder.App.Utilities;

    public class StartUp
    {
        public static void Main()
        {
            DbTools.ResetDb();

            Engine engine = new Engine(new CommandDispatcher());
            engine.Run();
        }
    }
}
