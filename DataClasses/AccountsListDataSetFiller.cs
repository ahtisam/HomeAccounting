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
    public static class AccountsListDataSetFiller
    {
        public static AccountsListDS FillData()
        {
            AccountsListDS _dsDestination = new AccountsListDS();

              using (vAccountsTableAdapter _taSource = new vAccountsTableAdapter())
                {
                    accountingDataSet.vAccountsDataTable _tblSource = _taSource.GetData();

                    foreach (accountingDataSet.vAccountsRow row in _tblSource.Rows)
                    {
                        _dsDestination.Tables["Account"].Rows.Add(new object[]{
                        row.__accountId_,
                        row.__title_
                    });
                    }
                }
            return _dsDestination;
        }
    }
}
