using System.Data;
using MySql.Data.MySqlClient;
using dotenv.net;

namespace Internet_Kafe_Proje.VeriTabani
{
    public class DatabaseManager : IDisposable
    {
        private readonly MySqlConnection _connection;

        public DatabaseManager()
        {
            var Env = DotEnv.Read();

            string connectionString = $"Server={Env["MYSQL_HOST"]};" +
                            $"Port={Env["MYSQL_PORT"]};" +
                            $"Database={Env["MYSQL_DATABASE"]};" +
                            $"Uid={Env["MYSQL_USER"]};" +
                            $"Pwd={Env["MYSQL_PASSWORD"]};";

            _connection = new MySqlConnection(connectionString);
            _connection.Open();
        }

        public void ExecuteNonQuery(string sql, params MySqlParameter[] parameters)
        {
            using var command = new MySqlCommand(sql, _connection);
            command.Parameters.AddRange(parameters);
            command.ExecuteNonQuery();
        }

        public DataTable ExecuteQuery(string sql, params MySqlParameter[] parameters)
        {
            using var command = new MySqlCommand(sql, _connection);
            command.Parameters.AddRange(parameters);

            using var adapter = new MySqlDataAdapter(command);
            var table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public object GetSingle(string sql, params MySqlParameter[] parameters)
        {
            using var command = new MySqlCommand(sql, _connection);
            command.Parameters.AddRange(parameters);
            return command.ExecuteScalar();
        }

        public void Dispose()
        {
            _connection?.Close();
            _connection?.Dispose();
            GC.SuppressFinalize(this); // Fix for CA1816
        }
    }
}
