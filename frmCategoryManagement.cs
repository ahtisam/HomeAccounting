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
        private void ShowEditForm(FormCreatingReason reason)
        {
            frmAddEditCategory frm;
            switch (reason)
            {
                case FormCreatingReason.NewItem:
                    frm = new frmAddEditCategory();
                    break;
                case FormCreatingReason.EditItem:
                    frm = new frmAddEditCategory(
                        (int)dsCategories.Tables["Category"].Rows[categoryBindingSource.Position]["categoryId"],
                        dsCategories.Tables["Category"].Rows[categoryBindingSource.Position]["title"].ToString(),
                        dsCategories.Tables["Category"].Rows[categoryBindingSource.Position]["innerType"].ToString());
                    break;
                default:
                    frm = new frmAddEditCategory();
                    break;
            }
            if (frm.ShowDialog() == DialogResult.OK)
            {
                GetCategories();
            }
        }
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
            ShowEditForm(FormCreatingReason.NewItem);
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

        private void btnEditRecord_Click(object sender, EventArgs e)
        {
            ShowEditForm(FormCreatingReason.EditItem);
        }

        private void categoryBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            btnEditRecord.Enabled = categoryBindingSource.Current != null;
            btnDeleteRecord.Enabled = btnEditRecord.Enabled;
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Удалить выбранную категорию?\n\nИмейте в виду, что вместе с категорией удалятся все записи,\nк ней относящиеся.",
                    "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    CategoryManager.DeleteCategory((int)dsCategories.Tables["Category"].Rows[categoryBindingSource.Position]["categoryId"]);
                    GetCategories();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace,
                                "Ooops!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
