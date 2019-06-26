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
        public string ZbiornikPaliwa { get; set; }
        public string SpalanieNaSto{ get; set; }
        public DateTime KoniecPrzeglodu { get; set; }
        public DateTime KoniecUbezpieczenia { get; set; }


        public DateTime DateOfCreation { get; set; }
        public string ImageSrc { get; set; }
        
    }
}
