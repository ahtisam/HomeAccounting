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
            try
            {

                dsCategories = CategoriesListDataSetFiller.FillData(SelectedAccount.Instance.AccountId);

                categoryBindingSource.DataSource = dsCategories;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace,
                                "Ooops!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            
        }

        private void frmCategoryManagement_Load(object sender, EventArgs e)
        {
            GetCategories();
        }

        private void dgCategories_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            
        }

        private void dgCategories_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                if ((decimal)dsCategories.Tables["Category"].Rows[e.RowIndex]["total"] < 0)
                    e.CellStyle.BackColor = Settings.Default.NegativeTotalRowColor;

                if ((decimal)dsCategories.Tables["Category"].Rows[e.RowIndex]["total"] > 0)
                    e.CellStyle.BackColor = Settings.Default.PositiveTotalRowColor;

            }
        }
    }
}
