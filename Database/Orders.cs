using System.Data;
using MySql.Data.MySqlClient;

namespace Internet_Kafe_Proje.Database
{
    public class OrderUpdateArgs
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? ItemId { get; set; }
        public int? Quantity { get; set; }
        public bool? Delivered { get; set; }
    }

    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public bool Delivered { get; set; }
    }

    internal class Orders
    {
        internal static List<Order> GetAllOrders()
        {
            using var databaseManager = new DatabaseManager();

            string sql = "SELECT id, user_id, item_id, quantity, delivered FROM orders;";
            var resultTable = databaseManager.ExecuteQuery(sql);

            var orders = new List<Order>();

            foreach (DataRow row in resultTable.Rows)
            {
                var order = new Order
                {
                    Id = Convert.ToInt32(row["id"]),
                    UserId = Convert.ToInt32(row["user_id"]),
                    ItemId = Convert.ToInt32(row["item_id"]),
                    Quantity = Convert.ToInt32(row["quantity"]),
                    Delivered = Convert.ToBoolean(row["delivered"]),
                };
                orders.Add(order);
            }

            return orders;
        }

        // Yeni sipariş ekler (INSERT INTO orders)
        internal static void InsertOrder(int userId, int itemId, int quantity = 1)
        {
            using var databaseManager = new DatabaseManager();

            string sql = @"
                INSERT INTO orders (user_id, item_id, quantity)
                VALUES (@user_id, @item_id, @quantity);
            ";

            var parameters = new MySqlParameter[]
            {
                new("@user_id", userId),
                new("@item_id", itemId),
                new("@quantity", quantity)
            };

            databaseManager.ExecuteNonQuery(sql, parameters);
        }

        // Siparişi id ile siler (DELETE FROM orders WHERE id = ...)
        internal static void DeleteOrderById(int id)
        {
            using var databaseManager = new DatabaseManager();

            string sql = @"
                DELETE FROM orders WHERE id = @id;
            ";

            var parameters = new MySqlParameter[]
            {
                new("@id", id)
            };

            databaseManager.ExecuteNonQuery(sql, parameters);
        }

        // Sipariş bilgilerini günceller (UPDATE orders SET ...)
        internal static void UpdateOrder(OrderUpdateArgs order)
        {
            using var databaseManager = new DatabaseManager();

            var updates = new List<string>();
            var parameters = new List<MySqlParameter>();

            // Sadece verilen alanlar güncellenir
            if (order.UserId.HasValue)
            {
                updates.Add("user_id = @user_id");
                parameters.Add(new MySqlParameter("@user_id", order.UserId.Value));
            }

            if (order.ItemId.HasValue)
            {
                updates.Add("item_id = @item_id");
                parameters.Add(new MySqlParameter("@item_id", order.ItemId.Value));
            }

            if (order.Quantity.HasValue)
            {
                updates.Add("quantity = @quantity");
                parameters.Add(new MySqlParameter("@quantity", order.Quantity.Value));
            }

            if (order.Delivered.HasValue)
            {
                updates.Add("delivered = @delivered");
                parameters.Add(new MySqlParameter("@delivered", order.Delivered.Value ? 1 : 0));
            }

            if (updates.Count == 0)
            {
                throw new ArgumentException("Güncellenecek alan yok.");
            }

            string sql = @$"
                UPDATE orders
                SET {string.Join(", ", updates)}
                WHERE id = @id;
            ";

            parameters.Add(new MySqlParameter("@id", order.Id));

            databaseManager.ExecuteNonQuery(sql, parameters.ToArray());
        }
    }
}
