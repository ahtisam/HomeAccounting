using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using HomeAccounting.Properties;

namespace HomeAccounting.DataClasses
{
    public static class Connection
    {
        public static readonly string String =
            "Database=" + Settings.Default.DBPath + ";";
    }
}
