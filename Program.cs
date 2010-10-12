using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using HomeAccounting.Properties;
using HomeAccounting.DataClasses;
using HomeAccounting.MultilanguageInterface;

namespace HomeAccounting
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SQLiteConnectionStringBuilder b = new SQLiteConnectionStringBuilder();
            b.DataSource = Application.StartupPath + @"\accounting.sqlite";
            Settings.Default.AccountingConnectionString = b.ConnectionString;
            Settings.Default.Save();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
