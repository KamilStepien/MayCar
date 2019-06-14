using System;
using System.Collections.Generic;
using System.Text;

namespace MyCar.Model
{
    public class Vehicle : ISqliteModel
    {
        [SQLite.AutoIncrement, SQLite.PrimaryKey]
        public int Id { get ; set  ; }
        public string Name { get; set; }
        public string Model { get; set; }
        public DateTime DateOfCreation { get; set; }
        
    }
}
