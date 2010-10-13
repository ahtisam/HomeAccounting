using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeAccounting.DataSources
{
    public class BooksListdataTable : DataTable
    {
        public BooksListdataTable()
        {
            this.TableName = "Book";
            this.Columns.Add(new DataColumn("bookId", typeof(int)));
            this.Columns.Add(new DataColumn("account", typeof(int)));
            this.Columns.Add(new DataColumn("type", typeof(string)));
            this.Columns.Add(new DataColumn("title", typeof(string)));
            this.Columns.Add(new DataColumn("added", typeof(DateTime)));
        }
    }
    public class BooksListDS:DataSet
    {
        public BooksListDS()
        {
            this.Tables.Add(new BooksListdataTable());
        }
    }
}
