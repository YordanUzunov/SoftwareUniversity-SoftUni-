namespace P01_HospitalDatabase
{
    using P01_HospitalDatabase.Data;
    using P01_HospitalDatabase.Initializer;
    using System;

    public class StartUp
    {
        public static void Main()
        {
            using (HospitalContext context = new HospitalContext())
            {
                //DatabaseInitializer.InitialSeed(context);

            }
        }
    }
}
