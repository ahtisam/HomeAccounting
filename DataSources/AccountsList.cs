using System;
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace HomeAccounting.DataSources
{
    
    public class AccountsListDataTable : DataTable
    {
        public AccountsListDataTable()
        {
            this.TableName = "Account";

            this.Columns.Add(new DataColumn("accountId", typeof(int)));
            this.Columns.Add(new DataColumn("title", typeof(string)));
        }

    }
    public class AccountsListDS: DataSet
    {
        public AccountsListDS()
        {
            this.Tables.Add(new AccountsListDataTable());
        }
    }
}
