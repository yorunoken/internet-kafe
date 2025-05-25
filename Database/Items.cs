using System.Data;
using MySql.Data.MySqlClient;

namespace Internet_Kafe_Proje.Database
{
    public class ItemUpdateArgs
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal? Price { get; set; }
    }

    public class Item
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public decimal Price { get; set; }
    }

    internal class Items
    {
        // Tüm ürünleri getirir (SELECT * FROM items)
        internal static List<Item> GetAllItems()
        {
            using var databaseManager = new DatabaseManager();

            string sql = "SELECT id, name, price FROM items;";
            var resultTable = databaseManager.ExecuteQuery(sql);

            var items = new List<Item>();

            foreach (DataRow row in resultTable.Rows)
            {
                var item = new Item
                {
                    Id = Convert.ToInt32(row["id"]),
                    Name = Convert.ToString(row["name"]) ?? "",
                    Price = Convert.ToDecimal(row["price"])
                };
                items.Add(item);    
            }

            return items;
        }

        // Yeni ürün ekler (INSERT INTO items)
        internal static void InsertItem(string itemName, decimal itemPrice)
        {
            using var databaseManager = new DatabaseManager();

            // Dikkat: Burada tablo adı yanlışlıkla 'users' yazılmış, 'items' olmalı!
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

        // Belirli bir ürünü id ile siler (DELETE FROM items WHERE id = ...)
        internal static void DeleteItemById(int id)
        {
            using var databaseManager = new DatabaseManager();

            // Dikkat: Burada da tablo adı yanlışlıkla 'users' yazılmış, 'items' olmalı!
            string sql = @"
                DELETE FROM users WHERE id = @id;
            ";

            var parameters = new MySqlParameter[] {
                new("@id", id)
            };

            databaseManager.ExecuteNonQuery(sql, parameters);
        }

        // Ürün bilgilerini günceller (UPDATE items SET ...)
        internal static void UpdateItem(ItemUpdateArgs item)
        {
            using var databaseManager = new DatabaseManager();

            var updates = new List<string>();
            var parameters = new List<MySqlParameter>();

            // Sadece verilen alanlar güncellenir
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
                throw new ArgumentException("Güncellenecek alan yok.");
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
