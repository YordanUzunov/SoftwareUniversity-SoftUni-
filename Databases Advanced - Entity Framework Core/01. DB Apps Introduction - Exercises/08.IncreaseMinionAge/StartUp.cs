using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using _01.InitialSetup;

namespace _08.IncreaseMinionAge
{
    public class StartUp
    {
        public static void Main()
        {
            using (SqlConnection connection = new SqlConnection(Configuration.ConnectionString))
            {
                connection.Open();

                int[] selectedIds = Console.ReadLine().Split().Select(int.Parse).ToArray();

                List<int> minionIds = new List<int>();
                List<string> minionNames = new List<string>();
                List<int> minionAges = new List<int>();

                GetSelectedMinions(selectedIds, minionIds, minionNames, minionAges, connection);
                UpdateSelectedMinions(minionIds, minionNames, minionAges, connection);
                PrintAllMinions(connection);


                connection.Close();
            }
        }

        private static void PrintAllMinions(SqlConnection connection)
        {
            string tableMinionsSql = "SELECT * FROM Minions";

            using (SqlCommand command = new SqlCommand(tableMinionsSql, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{(int)reader["Id"]} {(string)reader["Name"]} {(int)reader["Age"]}");
                    }
                }
            }
        }

        private static void UpdateSelectedMinions(List<int> minionIds, List<string> minionNames, List<int> minionAges, SqlConnection connection)
        {
            for (int i = 0; i < minionIds.Count; i++)
            {
                int id = minionIds[i];
                string name = String.Join(" ", minionNames[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList().Select(n => n = char.ToUpper(n.First()) + n.Substring(1).ToLower()).ToArray());
                int age = minionAges[i] + 1;

                SqlCommand command = new SqlCommand("UPDATE Minions SET Name = @name, Age = @age WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@age", age);
                command.Parameters.AddWithValue("@id", id);

                command.ExecuteNonQuery();
            }
        }

        private static void GetSelectedMinions(int[] selectedIds, List<int> minionIds, List<string> minionNames, List<int> minionAges, SqlConnection connection)
        {
            string minionDataSql = $"SELECT * FROM Minions WHERE Id IN ({String.Join(", ", selectedIds)})";

            using (SqlCommand command = new SqlCommand(minionDataSql, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        minionIds.Add((int)reader["Id"]);
                        minionNames.Add((string)reader["Name"]);
                        minionAges.Add((int)reader["Age"]);
                    }
                }
            }
        }
    }
}
