using System;
using System.Collections.Generic;
using System.Text;

namespace MyCar.Model
{
   public class Petrol:Class, ISqliteModel
    {
        [SQLite.AutoIncrement, SQLite.PrimaryKey]
        public int Id { get; set; }
        public string TypeOfPetrol { get; set; }
        public double Price { get; set; }
        public double PricePerLiter { get; set; }
        public DateTime DateOfCreation { get; set; }
    }
}
