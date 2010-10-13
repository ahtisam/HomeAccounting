using System;
using System.Data;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using HomeAccounting.DataSources;
using HomeAccounting.Properties;
using HomeAccounting.accountingDataSetTableAdapters;

namespace HomeAccounting.DataClasses
{
    public static class CategoriesListDataSetFiller
    {
        public static CategoriesListDS FillData(int account)
        {
            CategoriesListDS _dsSource = new CategoriesListDS();

            
            int rowId = 1;
            using (SQLiteConnection con = new SQLiteConnection(Settings.Default.AccountingConnectionString))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = @"SELECT categoryId, type, title, (SELECT SUM(records.thesum) FROM records WHERE records.category=categoryId AND records.income='True') as 'income', (SELECT SUM(records.thesum) FROM records WHERE records.category=categoryId AND records.income='False') as 'expense' FROM category WHERE category.account=@account";

                    SQLiteParameter pAccount = new SQLiteParameter("account", account);
                    pAccount.Direction = ParameterDirection.Input;


                    cmd.Parameters.Add(pAccount);
                    con.Open();
                    using (SQLiteDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (rdr.Read())
                        {
                            decimal income = rdr.GetValue(3).GetType() == typeof(DBNull)?0:rdr.GetDecimal(3);
                            decimal expense = rdr.GetValue(4).GetType() == typeof(DBNull) ? 0 : rdr.GetDecimal(4);
                            _dsSource.Tables["Category"].Rows.Add(new object[] {
                                rowId++,
                                rdr.GetInt32(0),
                                rdr.GetString(1),
                                rdr.GetString(2),
                                income,
                                expense
                            });

                        }
                    }
                    
                }
            }

            return _dsSource;
        }
    }
}
