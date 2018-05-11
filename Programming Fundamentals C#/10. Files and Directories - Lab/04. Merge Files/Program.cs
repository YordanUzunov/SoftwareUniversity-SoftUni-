namespace _04._Merge_Files
{
    using System.IO;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string[] allData = File.ReadAllLines("../../../FirstFile.txt");
            allData = allData.Concat(File.ReadAllLines("../../../SecondFile.txt")).ToArray();
            File.WriteAllLines(@"..\..\..\ThirdFile.txt", allData.OrderBy(x => x));
        }
    }
}
