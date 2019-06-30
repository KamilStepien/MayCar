using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyCar.Model
{
    public class Vehicle : ISqliteModel
    {
        [SQLite.AutoIncrement, SQLite.PrimaryKey]
        public int Id { get ; set  ; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Marka { get; set; }
        public int FuelTank { get; set; }
        public double LonHundredtKm{ get; set; }
        public DateTime EndCarReview { get; set; }
        public DateTime EndCarInsurance { get; set; }
        public DateTime DateOfCreation { get; set; }
        public string ImageSrc { get; set; }
        
    }
}
