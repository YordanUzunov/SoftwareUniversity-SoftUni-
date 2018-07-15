﻿using System.Data.SqlClient;

namespace _01.InitialSetup
{
    public class StartUp
    {
        public static void Main()
        {
            using (SqlConnection connection = new SqlConnection(Configuration.ConnectionString))
            {
                connection.Open();

                string databaseSql = "CREATE DATABASE MinionsDB";

                ExecNonQuery(connection, databaseSql);

                connection.ChangeDatabase("MinionsDB");

                string tableCountries = "CREATE TABLE Countries (Id INT PRIMARY KEY IDENTITY,Name VARCHAR(50))";

                string tableTowns = "CREATE TABLE Towns(Id INT PRIMARY KEY IDENTITY,Name VARCHAR(50), " +
                    "CountryCode INT FOREIGN KEY REFERENCES Countries(Id))";

                string tableMinioins = "CREATE TABLE Minions(Id INT PRIMARY KEY IDENTITY,Name VARCHAR(30), " +
                    "Age INT, TownId INT FOREIGN KEY REFERENCES Towns(Id))";

                string tableEvilnessFactors = "CREATE TABLE EvilnessFactors(Id INT PRIMARY KEY IDENTITY, Name VARCHAR(50))";

                string tableVillians = "CREATE TABLE Villains (Id INT PRIMARY KEY IDENTITY, Name VARCHAR(50), " +
                    "EvilnessFactorId INT FOREIGN KEY REFERENCES EvilnessFactors(Id))";

                string tableMinionsVillians = "CREATE TABLE MinionsVillains (MinionId INT FOREIGN KEY REFERENCES Minions(Id)," +
                    "VillainId INT FOREIGN KEY REFERENCES Villains(Id),CONSTRAINT PK_MinionsVillains PRIMARY KEY (MinionId, VillainId))";

                ExecNonQuery(connection, tableCountries);
                ExecNonQuery(connection, tableTowns);
                ExecNonQuery(connection, tableMinioins);
                ExecNonQuery(connection, tableEvilnessFactors);
                ExecNonQuery(connection, tableVillians);
                ExecNonQuery(connection, tableMinionsVillians);

                string insertCountries = "INSERT INTO Countries ([Name]) VALUES ('Bulgaria'),('England'),('Cyprus'),('Germany'),('Norway')";

                string instertTowns = "INSERT INTO Towns ([Name], CountryCode) VALUES ('Plovdiv', 1),('Varna', 1),('Burgas', 1)," +
                    "('Sofia', 1),('London', 2),('Southampton', 2),('Bath', 2),('Liverpool', 2),('Berlin', 3),('Frankfurt', 3),('Oslo', 4)";

                string insertMinions = "INSERT INTO Minions (Name,Age, TownId) VALUES('Bob', 42, 3),('Kevin', 1, 1),('Bob ', 32, 6)," +
                    "('Simon', 45, 3),('Cathleen', 11, 2),('Carry ', 50, 10),('Becky', 125, 5),('Mars', 21, 1),('Misho', 5, 10),('Zoe', 125, 5),('Json', 21, 1)";

                string insertEvilnessFactor = "INSERT INTO EvilnessFactors (Name) VALUES ('Super good'),('Good'),('Bad'), ('Evil'),('Super evil')";

                string insertVillians = "INSERT INTO Villains (Name, EvilnessFactorId) VALUES ('Gru',2),('Victor',1),('Jilly',3),('Miro',4),('Rosen',5),('Dimityr',1),('Dobromir',2)";

                string insertMinionsVillians = "INSERT INTO MinionsVillains (MinionId, VillainId) VALUES (4,2),(1,1),(5,7),(3,5),(2,6),(11,5),(8,4),(9,7),(7,1),(1,3),(7,3),(5,3),(4,3),(1,2),(2,1),(2,7)";

                ExecNonQuery(connection, insertCountries);
                ExecNonQuery(connection, instertTowns);
                ExecNonQuery(connection, insertMinions);        
                ExecNonQuery(connection, insertEvilnessFactor);
                ExecNonQuery(connection, insertVillians);
                ExecNonQuery(connection, insertMinionsVillians);

                connection.Close();
            }
        }

        private static void ExecNonQuery(SqlConnection connection, string databaseSql)
        {
            using (SqlCommand command = new SqlCommand(databaseSql, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}
