using System.Data;
using MySql.Data.MySqlClient;

namespace Internet_Kafe_Proje.VeriTabani
{
    public class ItemUpdateDo
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal? Price { get; set; }
    }


    internal class Itemler
    {
        internal static DataTable GetAllItems()
        {
            using var databaseManager = new DatabaseManager();

            string sql = "SELECT * FROM items;";

            var resultTable = databaseManager.ExecuteQuery(sql);
            return resultTable;
        }

        internal static void InsertItem(string itemName, decimal itemPrice)
        {
            using var databaseManager = new DatabaseManager();

            string sql = @"
                INSERT INTO users (name, price)
                VALUES (@name, @price);
            ";

            var parameters = new MySqlParameter[] {
                new("@name", itemName),
                new("@price", itemPrice)
            };

            databaseManager.ExecuteNonQuery(sql, parameters);
        }

        internal static void DeleteItemById(int id)
        {
            using var databaseManager = new DatabaseManager();

            string sql = @"
                DELETE FROM users WHERE id = @id;
            ";

            var parameters = new MySqlParameter[] {
                new("@id", id)
            };

            databaseManager.ExecuteNonQuery(sql, parameters);
        }

        internal static void UpdateItem(ItemUpdateDo item)
        {
            using var databaseManager = new DatabaseManager();

            var updates = new List<string>();
            var parameters = new List<MySqlParameter>();

            if (!string.IsNullOrEmpty(item.Name)) {
                updates.Add("name = @name");
                parameters.Add(new MySqlParameter("@name", item.Name));
            }

            if (item.Price.HasValue)
            {
                updates.Add("price = @price");
                parameters.Add(new MySqlParameter("@price", item.Price));
            }

            if (updates.Count == 0)
            {
                throw new ArgumentException("No fields provided to update.");
            }

            string sql = @$"
                UPDATE items
                SET {string.Join(", ", updates)}
                WHERE id = @id;
            ";

            parameters.Add(new MySqlParameter("@id", item.Id));

            databaseManager.ExecuteNonQuery(sql, [.. parameters]);
        }
    }
}
