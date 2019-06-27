using System;
using System.Collections.Generic;
using System.Text;

namespace MyCar.Model
{
    public class HistorySQL : ISqliteModel
    {

        [SQLite.AutoIncrement, SQLite.PrimaryKey]
        public int Id { get; set; }
        public string Typ { get; set; }
        public int IdClass { get; set; }
    }
        
}
