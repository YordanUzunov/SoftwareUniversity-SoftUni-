using System;
using System.Data.SqlClient;
using _01.InitialSetup;

namespace _03.MinionNames
{
    public class StartUp
    {
        public static void Main()
        {
            int villainId = int.Parse(Console.ReadLine());

            using (SqlConnection connection = new SqlConnection(Configuration.ConnectionString))
            {
                connection.Open();

                string villianName = GetVillianName(villainId, connection); 

                if (villianName == null)
                {
                    Console.WriteLine($"No villain with ID {villainId} exists in the database.");
                }
                else
                {
                    Console.WriteLine($"Villian: {villianName}");
                    PrintNames(villainId, connection);
                }

                connection.Close();
            }
        }

        private static void PrintNames(int villianId, SqlConnection connection)
        {
            string minionsSql = "SELECT Name, Age FROM Minions AS m JOIN MinionsVillains AS mv ON mv.MinionId = m.Id WHERE mv.VillainId = @Id";

            using (SqlCommand command = new SqlCommand(minionsSql, connection))
            {
                command.Parameters.AddWithValue("@Id", villianId);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        Console.WriteLine("(no minions)");
                    }
                    else
                    {
                        int row = 1;

                        while(reader.Read())
                        {
                            Console.WriteLine($"{row++}. {reader[0]} {reader[1]}");
                        }

                    }
                }
            }
        }

        private static string GetVillianName(int villianId, SqlConnection connection)
        {
            string nameSql = "SELECT Name FROM Villains WHERE Id = @id";

            using (SqlCommand command = new SqlCommand(nameSql, connection))
            {
                command.Parameters.AddWithValue("@id", villianId);
                return (string)command.ExecuteScalar();
            }
        }
    }
}
