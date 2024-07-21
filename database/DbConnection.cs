using Npgsql;
using System;

namespace Management.database
{
    public class DbConnection : IDisposable
    {
        public NpgsqlConnection Connection { get; private set; }

        public DbConnection()
        {
            try
            {
                Connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=management;User Id=postgres;Password=douglasjknw0011;");
                Connection.Open();
                Console.WriteLine("Conexão aberta com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao abrir a conexão: {ex.Message}");
                Connection = null;
            }
        }

        public void Dispose()
        {
            try
            {
                Connection?.Dispose();
                Console.WriteLine("Conexão fechada com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao fechar a conexão: {ex.Message}");
            }
        }
    }
}
