using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Common;
using System.Configuration;

namespace HospitalSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---HospitalSystem---");
            string provider = ConfigurationManager.AppSettings["provider"];
            string connectionString = ConfigurationManager.AppSettings["connectionString"];

            DbProviderFactory factory = DbProviderFactories.GetFactory(provider);

            using (DbConnection connection = factory.CreateConnection())
            {
                if (connection == null)
                {
                    Console.WriteLine("Connection to database failed");
                    Console.ReadKey();
                    return;
                }
                connection.ConnectionString = connectionString;

                connection.Open();

                DbCommand command = connection.CreateCommand();

                if (command == null)
                {
                    Console.WriteLine("Command error");
                    Console.ReadKey();
                    return;
                }

                command.Connection = connection; // Perhaps useless

                Console.WriteLine("Insert a command");

                while (true)
                {
                    Console.Write(">");
                    string cmd = Console.ReadLine();
                    switch (cmd)
                    {
                        case "show":
                            command.CommandText = "SELECT * FROM Patients";
                            using (DbDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read() == true)
                                {
                                    Console.WriteLine($"{reader["id"]} {reader["Name"].ToString().TrimEnd()} {reader["Age"]}" +
                                        $" is currently suffering of {reader["Status"]}");
                                }

                            }
                            break;
                        case "del":
                            Console.Write("Delete ID: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            command.CommandText = $"DELETE FROM Patients WHERE ID={id}";
                            command.ExecuteNonQuery();
                            break;
                        case "create":
                            Console.Write("Name: ");
                            string name = Console.ReadLine();
                            Console.Write("Age: ");
                            int age = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Status: ");
                            string status = Console.ReadLine();

                            command.CommandText = $"INSERT INTO Patients (Name, Age, Status) VALUES ('{name}',{age}, '{status}')";
                            command.ExecuteNonQuery();
                            break;
                        case "show pat":
                            Console.Write("Patient Name: ");
                            string pat = Console.ReadLine();
                            command.CommandText = $"SELECT * FROM Patients WHERE Name='{pat}'";

                            using (DbDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read() == true)
                                {
                                    Console.WriteLine($"{reader["id"]} {reader["Name"].ToString().TrimEnd()} {reader["Age"]}" +
                                        $" is currently suffering of {reader["Status"]}");
                                }
                            }
                            break;
                        case "clr":
                            Console.Clear();
                            Console.WriteLine("---HospitalSystem---");
                            break;
                        case "change stat":
                            Console.Write("Name/ID: ");
                            //var nameId = int.TryParse(Console.ReadLine(), out );
                            break;
                        case "sql":
                            command.CommandText = Console.ReadLine();
                            command.ExecuteNonQuery();
                            break;
                        default:
                            Console.WriteLine("Invalid command.");
                            break;
                    }
                }

                command.CommandText = "INSERT INTO Patients (Name, Age, Status)" +
                    " VALUES ('Gustaf Linder', 16, 'Strong')";
                command.ExecuteNonQuery();


                Console.ReadKey();
            }
        }
    }
}
