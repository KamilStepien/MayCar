using MyCar.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyCar.Data
{
    public class LocalDatabase
    {
        private readonly SQLiteAsyncConnection database;

      
        public LocalDatabase(string filepath)
        {
            database = new SQLiteAsyncConnection(filepath);
            database.CreateTableAsync<Vehicle>().Wait();
        }
     
      
       
      public async Task<List<Vehicle>> GetVehicles()
      {
          return await database.Table<Vehicle>().ToListAsync();
      }
        
     public async Task<List<T>> GetItemsAsync<T>() where T : class, new()
     {
         return await database.Table<T>().ToListAsync();
     }
        
     public async Task<T> GetItemByIdAsync<T>(int id) where T : class, ISqliteModel, new()
     {
            return await database.Table<T>().Where(x => x.Id == id).FirstOrDefaultAsync();
     }

     public async Task<int> SaveItemAsync<T>(T item) where T: class, ISqliteModel, new()
     {
           var result = await database.UpdateAsync(item);

            if (result == 0)
            {
                result = await database.InsertAsync(item);
            }

            return result;
        }

        public async Task<int> DeleteItemAsync<T>(T item) where T : class, ISqliteModel, new()
        {
            return await database.DeleteAsync(item);
        }

    }
}
