using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using HomeAccounting.DataSources;
using HomeAccounting.DataClasses;
using HomeAccounting.Properties;
using HomeAccounting.MultilanguageInterface;

namespace HomeAccounting
{
    public partial class frmCategoryManagement : Form
    {
        private CategoriesListDS dsCategories;

        private void GetCategories()
        {
            dsCategories = CategoriesListDataSetFiller.FillData(SelectedAccount.Instance.AccountId);

            categoryBindingSource.DataSource = dsCategories;
        }
        public frmCategoryManagement()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCategoryManagement_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            GetCategories();
        }
    }
}
