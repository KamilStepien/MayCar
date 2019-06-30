using System;
using System.Collections.Generic;
using System.Text;
using MyCar.Data;

namespace MyCar.Model
{
    public class Drive: ISqliteModel
    {
        [SQLite.AutoIncrement, SQLite.PrimaryKey]
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public int NumberOfKm { get; set; }
        public string StartPoint { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime Date { get; set; }

    }
}
