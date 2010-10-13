using System;
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace HomeAccounting.DataSources
{
    public class CategoriesListDataTable: DataTable
    {
        public CategoriesListDataTable()
        {
            this.TableName = "Category";

            this.Columns.Add(new DataColumn("rowId", typeof(int)));
            this.Columns.Add(new DataColumn("categoryId", typeof(int)));
            this.Columns.Add(new DataColumn("type", typeof(string)));
            this.Columns.Add(new DataColumn("title", typeof(string)));
            this.Columns.Add(new DataColumn("income", typeof(decimal)));
            this.Columns.Add(new DataColumn("expense", typeof(decimal)));
            this.Columns.Add(new DataColumn("total", typeof(decimal)));

            this.Columns["total"].Expression = "income - expense";
        }
    }
    public class CategoriesListDS : DataSet
    {
        public CategoriesListDS()
        {
            this.Tables.Add(new CategoriesListDataTable());
        }
    }
}
