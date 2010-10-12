using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using HomeAccounting.accountingDataSetTableAdapters;
using HomeAccounting.DataSources;
using HomeAccounting.MultilanguageInterface;
using HomeAccounting.Properties;

namespace HomeAccounting.DataClasses
{
    public static class BooksListDataSetFiller
    {
        public static BooksListDS FillData(int account)
        {
            BooksListDS _dsDestination = new BooksListDS();
            using (bookTableAdapter _taSource = new bookTableAdapter())
            {
                accountingDataSet.bookDataTable _tblSource = _taSource.GetData(account);
                foreach (accountingDataSet.bookRow row in _tblSource.Rows)
                {
                    _dsDestination.Tables["Book"].Rows.Add(new object[] {
                        row.bookId,
                        row.account,
                        row.booktype,
                        row.title,
                        row.created
                    });
                }
            }
            return _dsDestination;
        }
    }
}
