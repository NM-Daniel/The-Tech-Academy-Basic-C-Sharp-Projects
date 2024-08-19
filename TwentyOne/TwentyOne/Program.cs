using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using Casino2;
using Casino2.TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel and Casino";

            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name.", casinoName);
            string playerName = Console.ReadLine();

            //This block is to pull up a list of all the exceptions if the user is an admin
            if (playerName.ToLower() == "admin")
            {
                //Make a list of the entity that you are pulling from the database
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.Read();
                return; //If someone enters admin they aren't going to play
            }

            //Checks user's input. While loop will be hit
            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
            }

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\natha\OneDrive\Documents\GitHub\The-Tech-Academy-Basic-C-Sharp-Projects\TwentyOne\TwentyOne\Log\log.txt", true)) //
                {
                    file.WriteLine(player.Id);
                }
                Game game = new TwentyOneGame();
                game += player;
                player.IsActivelyPlaying = true;
                while (player.IsActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred. Please contact your System Administrator.");
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();
        }
        //Making a private method for logging
        //Private - Only used in this class. Static - Do not need to create a Program object. Void - Does not return anything just does it's thing.
        private static void UpdateDbWithException(Exception ex) //All Exceptions inherit from Exception. Could take FraudException
        {
            //ADO.NET
            string connectionString = @"Data Source = (localdb)\ProjectsV13; Initial Catalog = TwentyOneGame; Integrated Security = True;
                                        Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite;
                                        MultiSubnetFailover = False";
            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                                    (@ExceptionType, @ExceptionMessage, @TimeStamp)";

            //using controls unmanaged resources. Shuts down connection after }
            using (SqlConnection connection = new SqlConnection(connectionString)) //Creates a SqlConnection object
            {
                SqlCommand command = new SqlCommand(queryString, connection); //Creates a new SqlCommand object that passes in our queryString and the SqlConnection
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar); //Added one Parameters name and declares its data type. Protects SQL injection
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString(); //Parameters is a List. Specify which collection item when assigning values. GetType() returns Type. We want it in string.
                command.Parameters["@ExceptionMessage"].Value = ex.Message; //ExceptionMessage is already a string.
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery(); //A Query would be a SELECT statement. This is an INSERT statement
                connection.Close();
            }
        }
        private static List<ExceptionEntity> ReadExceptions() //ReadExceptions returns a List of ExceptionEntity data types
        {
            string connectionString = @"Data Source = (localdb)\ProjectsV13; Initial Catalog = TwentyOneGame; Integrated Security = True;
                                        Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite;
                                        MultiSubnetFailover = False";
            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp From Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader(); //Creating a SqlDataReader object called reader

                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]); //Getting back SQL and need to turn it into C#.
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);
                }
                connection.Close();
            }
            return Exceptions;
        }
    }
}

//TwentyOneGame game = new TwentyOneGame();
//game.Players = new List<string>() { "Nathan", "Bill", "Bob" };
//game.ListPlayers();
//Console.ReadLine();

//Overloading comparison operators
//Game game = new TwentyOneGame();
//game.Players = new List<Player>();
//Player player = new Player();
//player.Name = "Nathan";
//game += player;
//game -= player;


//Takes a path and input for parameters. Creates a logs.txt file in the folder chosen
/*string text = File.ReadAllText(@"C:\Users\natha\Logs\log.txt");*/ //@ says to read the string exactly as is. No need for escape characters

//DateTime dateTime = new DateTime(1997, 4, 14, 13, 40, 15);
//DateTime yearOfGraduation = new DateTime(2015, 6, 4, 12, 30, 0);

//TimeSpan ageAtGraduation = yearOfGraduation - dateTime;
//Console.WriteLine(ageAtGraduation.Days);