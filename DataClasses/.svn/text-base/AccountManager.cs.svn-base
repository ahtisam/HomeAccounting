using System;
using System.Data;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using HomeAccounting.Properties;

namespace HomeAccounting.DataClasses
{
    public static class AccountManager
    {
        public static void NewAccount(string title, string password)
        {
            using (SQLiteConnection con = new SQLiteConnection(Settings.Default.AccountingConnectionString))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "INSERT INTO main.account VALUES (NULL, @title, CURRENT_DATE, @password)";

                    
                    SQLiteParameter pTitle = new SQLiteParameter("title", title);
                    pTitle.Direction = ParameterDirection.Input;

                    SQLiteParameter pPassword = new SQLiteParameter("password", password);
                    pPassword.Direction = ParameterDirection.Input;

                    cmd.Parameters.AddRange(new SQLiteParameter[] { pTitle, pPassword });
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
        public static void EditAccount(int id, string title, string password)
        {
            using (SQLiteConnection con = new SQLiteConnection(Settings.Default.AccountingConnectionString))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "UPDATE main.account SET title=@title, password=@password WHERE accountId=@id;";
                    SQLiteParameter pId = new SQLiteParameter("id", id);
                    pId.Direction = ParameterDirection.Input;

                    SQLiteParameter pTitle = new SQLiteParameter("title", title);
                    pTitle.Direction = ParameterDirection.Input;

                    SQLiteParameter pPassword = new SQLiteParameter("password", password);
                    pPassword.Direction = ParameterDirection.Input;

                    cmd.Parameters.AddRange(new SQLiteParameter[] { pId, pTitle, pPassword });
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
        public static void DeleteAccount(int id)
        {
            using (SQLiteConnection con = new SQLiteConnection(Settings.Default.AccountingConnectionString))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "DELETE FROM main.account WHERE accountId=@id;";
                    SQLiteParameter pId = new SQLiteParameter("id", id);
                    pId.Direction = ParameterDirection.Input;

                    cmd.Parameters.Add(pId);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
    }
}
