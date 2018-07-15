using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using _01.InitialSetup;

namespace _07.PrintAllMinionNames
{
    public class StartUp
    {
        public static void Main()
        {
            using (SqlConnection connection = new SqlConnection(Configuration.ConnectionString))
            {
                connection.Open();

                List<string> minionsNames = new List<string>();
                GetNames(minionsNames,connection);

                for (int i = 0; i < minionsNames.Count / 2; i++)
                {
                    Console.WriteLine(minionsNames[i]);
                    Console.WriteLine(minionsNames[minionsNames.Count - i - 1]);
                }

                connection.Close();
            }
        }

        private static void GetNames(List<string> minionsNames, SqlConnection connection)
        {
            string allNames = "SELECT Name FROM Minions";

            using (SqlCommand command = new SqlCommand(allNames, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        minionsNames.Add((string)reader[0]);
                    }
                }
            }
        }
    }
}
