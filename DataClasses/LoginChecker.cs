using System;
using System.Data;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using HomeAccounting.Properties;

namespace HomeAccounting.DataClasses
{
    public static class LoginChecker
    {
        public static bool Login(int accountId, string password)
        {
            using (SQLiteConnection con = new SQLiteConnection(Settings.Default.AccountingConnectionString))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT COUNT(accountId) FROM vAccountPassword WHERE accountId = @account AND password = @password";
                    SQLiteParameter pAccount = new SQLiteParameter("account",accountId);
                    pAccount.Direction = ParameterDirection.Input;

                    SQLiteParameter pPassword = new SQLiteParameter("password", password);
                    pPassword.Direction = ParameterDirection.Input;

                    cmd.Parameters.AddRange(new SQLiteParameter[] { pAccount, pPassword });
                    con.Open();
                    if (Convert.ToInt32(cmd.ExecuteScalar()) == 1)
                    {
                        con.Close();
                        return true;
                    }
                    con.Close();
                    return false;
                }
            }
        }
    }
}
