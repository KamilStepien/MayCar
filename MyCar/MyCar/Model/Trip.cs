﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyCar.Model
{
    public class Trip : ISqliteModel
    {
        [SQLite.AutoIncrement, SQLite.PrimaryKey]
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public int NumberOfKm { get; set; }
        public string Destination { get; set; }
        public string StartPoint { get; set; }
        public DateTime Start { get; set; }
        public DateTime Date { get; set; }

    }
}
