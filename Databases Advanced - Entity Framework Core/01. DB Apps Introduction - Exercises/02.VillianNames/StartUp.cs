using _01.InitialSetup;
using System.Data.SqlClient;
using System;

namespace _02.VillianNames
{
    public class StartUp
    {
        public static void Main()
        {
            using (SqlConnection connection = new SqlConnection(Configuration.ConnectionString))
            {
                connection.Open();

                string villiansNames = @"SELECT v.Name, COUNT(mv.MinionId) AS [minionsNumber] " +
                                       "FROM Villains AS v JOIN MinionsVillains AS mv ON mv.VillainId = v.Id " +
                                       "GROUP BY mv.VillainId, v.Name HAVING COUNT(mv.MinionId) > 3 ORDER BY[minionsNumber] DESC";

                using (SqlCommand command = new SqlCommand(villiansNames, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"{reader[0]} - {reader[1]}");
                        }
                    }
                }

                connection.Close();
            }
        }
    }
}
