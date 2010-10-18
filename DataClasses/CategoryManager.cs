using System;
using System.Data;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using HomeAccounting.Properties;

namespace HomeAccounting.DataClasses
{
    public static class CategoryManager
    {
        public static void NewCategory(int account, string title, string type)
        {
            using (SQLiteConnection con = new SQLiteConnection(Settings.Default.AccountingConnectionString))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "INSERT INTO main.category VALUES (NULL, @title, @type, @account)";

                    SQLiteParameter pTitle = new SQLiteParameter("title", title);
                    pTitle.Direction = ParameterDirection.Input;

                    SQLiteParameter pAccount = new SQLiteParameter("account", account);
                    pAccount.Direction = ParameterDirection.Input;

                    SQLiteParameter pType = new SQLiteParameter("type", type);
                    pType.Direction = ParameterDirection.Input;

                    cmd.Parameters.AddRange(new SQLiteParameter[] { pTitle, pAccount, pType });
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
        public static void EditCategory(int category, string title, string type)
        {
            using (SQLiteConnection con = new SQLiteConnection(Settings.Default.AccountingConnectionString))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "UPDATE main.category SET title=@title, type=@type WHERE categoryId = @categoryId";

                    SQLiteParameter pTitle = new SQLiteParameter("title", title);
                    pTitle.Direction = ParameterDirection.Input;

                    SQLiteParameter pCategory = new SQLiteParameter("categoryId", category);
                    pCategory.Direction = ParameterDirection.Input;

                    SQLiteParameter pType = new SQLiteParameter("type", type);
                    pType.Direction = ParameterDirection.Input;

                    cmd.Parameters.AddRange(new SQLiteParameter[] { pTitle, pCategory, pType });
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

            }
        }
        public static void DeleteCategory(int category)
        {
            using (SQLiteConnection con = new SQLiteConnection(Settings.Default.AccountingConnectionString))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "DELETE FROM main.category WHERE categoryId = @categoryId";

                    SQLiteParameter pCategory = new SQLiteParameter("categoryId", category);
                    pCategory.Direction = ParameterDirection.Input;

                    cmd.Parameters.AddRange(new SQLiteParameter[] { pCategory });
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
    }
}
