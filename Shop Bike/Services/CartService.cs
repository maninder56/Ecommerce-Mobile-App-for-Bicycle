using Shop_Bike.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Bike.Services
{
    public static class CartService
    {
        static SQLiteAsyncConnection db; 
        static async Task Init()
        {
            if (db != null) return;
            // Get an absolute path to the database file
            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Database.db");

            db = new SQLiteAsyncConnection(databasePath);

            await db.CreateTableAsync<Cart>();
        }

        public static async Task Additem(string name, string description, string image, double price)
        {
            await Init();
            var item = new Cart 
            { 
                Name = name, 
                Description = description, 
                Image = image, 
                Price = price 
            };

            await db.InsertAsync(item); 
        }

        public static async Task Removeitem(int id)
        {
            await Init();

            await db.DeleteAsync<Cart>(id); 
        }

        public static async Task<IEnumerable<Cart>> Getitem()
        {
            await Init();

            var cart = await db.Table<Cart>().ToListAsync();
            return cart; 
        }
    }
}
 