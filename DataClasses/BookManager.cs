using System;
using System.Data;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using HomeAccounting.Properties;


namespace HomeAccounting.DataClasses
{
    public static class BookManager
    {
        public static void NewBook(string title, string booktype, int account)
        {
            using (SQLiteConnection con = new SQLiteConnection(Settings.Default.AccountingConnectionString))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "INSERT INTO main.book VALUES (NULL, @account, @title, CURRENT_DATE, @booktype)";

                    SQLiteParameter pTitle = new SQLiteParameter("title", title);
                    pTitle.Direction = ParameterDirection.Input;

                    SQLiteParameter pAccount = new SQLiteParameter("account", account);
                    pAccount.Direction = ParameterDirection.Input;

                    SQLiteParameter pBookType = new SQLiteParameter("booktype", booktype);
                    pBookType.Direction = ParameterDirection.Input;

                    cmd.Parameters.AddRange(new SQLiteParameter[] { pTitle, pAccount, pBookType });
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
        public static void EditBook(int bookId, string title, string booktype)
        {
            using (SQLiteConnection con = new SQLiteConnection(Settings.Default.AccountingConnectionString))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "UPDATE main.book SET title = @title, booktype=@booktype WHERE bookId=@bookId";

                    SQLiteParameter pTitle = new SQLiteParameter("title", title);
                    pTitle.Direction = ParameterDirection.Input;

                    SQLiteParameter pBookId = new SQLiteParameter("bookId", bookId);
                    pBookId.Direction = ParameterDirection.Input;

                    SQLiteParameter pBookType = new SQLiteParameter("booktype", booktype);
                    pBookType.Direction = ParameterDirection.Input;

                    cmd.Parameters.AddRange(new SQLiteParameter[] { pTitle, pBookId, pBookType });
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
        public static void DeleteBook(int id)
        {
            using (SQLiteConnection con = new SQLiteConnection(Settings.Default.AccountingConnectionString))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "DELETE FROM main.book WHERE bookId=@id;";
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
