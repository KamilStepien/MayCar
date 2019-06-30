using MyCar.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyCar.Data
{
    public class LocalDatabase
    {
        private readonly SQLiteAsyncConnection database;

      
        public LocalDatabase(string filepath)
        {
            database = new SQLiteAsyncConnection(filepath);
            database.CreateTableAsync<Vehicle>().Wait();
            database.CreateTableAsync<HistorySQL>().Wait();
            database.CreateTableAsync<Trip>().Wait();
            database.CreateTableAsync<Petrol>().Wait();
            
        }


        public async Task<List<Vehicle>> GetVehicles()
      {
          return await database.Table<Vehicle>().ToListAsync();
      }

        internal async Task<Vehicle> GetVehicleById(int id)
        {
            return await database.Table<Vehicle>().Where(x => x.Id == id).FirstOrDefaultAsync();
        }
        internal async Task<Petrol> GetPetrolById(int id)
        {
            return await database.Table<Petrol>().Where(x => x.Id == id).FirstOrDefaultAsync();
        }
        internal async Task<Trip> GetTripById(int id)
        {
            return await database.Table<Trip>().Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<Petrol>> GetPetrol()
        {
            return await database.Table<Petrol>().ToListAsync();
        }
        public async Task<List<HistorySQL>> GetHistory() 
        {
           
            return await database.Table<HistorySQL>().ToListAsync();

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
