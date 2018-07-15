using P02_StudentSystemSeeding;

namespace P01_StudentSystem
{
    public class StartUp
    {
        public static void Main()
        {
            var initializer = new DatabaseInitializer();
            initializer.ResetDatabase();
        }
    }
}
