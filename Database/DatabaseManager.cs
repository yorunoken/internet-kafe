using System.Data;
using MySql.Data.MySqlClient;
using dotenv.net;

namespace Internet_Kafe_Proje.Database
{
    public class DatabaseManager : IDisposable
    {
        // MySQL bağlantısı için nesne
        private readonly MySqlConnection _connection;

        // Ortam değişkenlerinden (dotenv) bağlantı bilgilerini alır ve bağlantıyı açar
        public DatabaseManager()
        {
            var Env = DotEnv.Read();

            // Bağlantı dizesi oluşturuluyor, .env dosyasındaki bilgiler kullanılıyor
            string connectionString = $"Server={Env["MYSQL_HOST"]};" +
                            $"Port={Env["MYSQL_PORT"]};" +
                            $"Database={Env["MYSQL_DATABASE"]};" +
                            $"Uid={Env["MYSQL_USER"]};" +
                            $"Pwd={Env["MYSQL_PASSWORD"]};";

            _connection = new MySqlConnection(connectionString);
            _connection.Open(); // Veritabanı bağlantısı açılır
        }

        // Sonuç döndürmeyen sorgular (INSERT, UPDATE, DELETE gibi) çalıştırmak için kullanılır
        public void ExecuteNonQuery(string sql, params MySqlParameter[] parameters)
        {
            using var command = new MySqlCommand(sql, _connection);
            command.Parameters.AddRange(parameters); // Parametreler ekleniyor
            command.ExecuteNonQuery(); // Sorgu çalıştırılır
        }

        // Sonuç döndüren sorgular (SELECT gibi) çalıştırmak için kullanılır, DataTable döner
        public DataTable ExecuteQuery(string sql, params MySqlParameter[] parameters)
        {
            using var command = new MySqlCommand(sql, _connection);
            command.Parameters.AddRange(parameters);

            using var adapter = new MySqlDataAdapter(command);
            var table = new DataTable();
            adapter.Fill(table); // Sonuçlar tabloya doldurulur
            return table;
        }

        // Tek bir değer döndüren sorgular için (ör: COUNT, MAX)
        public object GetSingle(string sql, params MySqlParameter[] parameters)
        {
            using var command = new MySqlCommand(sql, _connection);
            command.Parameters.AddRange(parameters);
            return command.ExecuteScalar(); // Tek bir değer döndürülür
        }

        // Bağlantıyı kapatır ve kaynakları serbest bırakır
        public void Dispose()
        {
            _connection?.Close();
            _connection?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
