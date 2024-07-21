using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Management.database
{
    public class Worker
    {
        public int id {  get; set; }
        public string nameWorker { get; set; }
        public double salary { get; set; }
        public string profession { get; set; }
        public int age { get; set; }
        public string phone { get; set; }
    }

    public class Controller
    {
        public List<Worker> Get()
        {
            using (var connection = new DbConnection())
            {
                if (connection.Connection == null)
                {
                    Console.WriteLine("A conexão com o banco de dados não foi estabelecida.");
                    return new List<Worker>();
                }

                string query = @"SELECT * FROM worker;";
                var workers = connection.Connection.Query<Worker>(query).ToList();
                return workers;
            }
        }

        public void InsertWorker(string nameWorker, string salary, string profession, string age, string phone)
        {
            if (!double.TryParse(salary, out double salaryValue))
            {
                Console.WriteLine("O valor do salário é inválido.");
                return;
            }

            if (!int.TryParse(age, out int ageValue))
            {
                Console.WriteLine("O valor da idade é inválido.");
                return;
            }

            var worker = new Worker
            {
                nameWorker = nameWorker,
                salary = salaryValue,
                profession = profession,
                age = ageValue,
                phone = phone
            };

            using (var connection = new DbConnection())
            {
                if (connection.Connection == null)
                {
                    Console.WriteLine("A conexão com o banco de dados não foi estabelecida.");
                    return;
                }

                string query = @"INSERT INTO worker (nameworker, salary, profession, age, phone)
                                 VALUES (@nameWorker, @salary, @profession, @age, @phone);";

                connection.Connection.Execute(query, worker);
                Console.WriteLine("Trabalhador inserido com sucesso.");
            }
        }

        public bool DeleteWorker(int id)
        {
            using (var connection = new DbConnection())
            {
                if (connection.Connection == null)
                {
                    Console.WriteLine("A conexão com o banco de dados não foi estabelecida.");
                    return false;
                }

               
                string checkQuery = @"SELECT COUNT(*) FROM worker WHERE id = @Id;";
                int count = connection.Connection.ExecuteScalar<int>(checkQuery, new { Id = id });

                if (count == 0)
                {
                    return false; 
                }

                // Exclui o trabalhador
                string deleteQuery = @"DELETE FROM worker WHERE id = @Id;";
                connection.Connection.Execute(deleteQuery, new { Id = id });
                return true; 
            }
        }
    }

}
