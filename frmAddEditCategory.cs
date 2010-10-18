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
    public partial class frmAddEditCategory : Form
    {
        private BookType cType;
        private bool _isEditing;
        private int _categoryId;
        private string _originalType;

        public frmAddEditCategory()
        {
            InitializeComponent();
            try
            {
                cType = new BookType();
                bookTypeBindingSource.DataSource = cType;

                Text = "Новая категория";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace, "Ooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
        }
        public frmAddEditCategory(int categoryId, string title, string type)
        {
            InitializeComponent();
            try
            {
                cType = new BookType();
                bookTypeBindingSource.DataSource = cType;

                tbTitle.Text = title;
                cbCategoryType.SelectedValue = type;
                _categoryId = categoryId;
                _originalType = type;

                Text = "Редактировать категорию";
                _isEditing = true;
                

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace, "Ooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
                
        }

        private void tbTitle_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = tbTitle.Text.Trim() != string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_isEditing)
            {
                if (cbCategoryType.SelectedValue.ToString() != _originalType)
                {
                    if (cbCategoryType.SelectedValue.ToString() == "i")
                    {
                        if (MessageBox.Show("Записи в категории \"Только приход\" не могут иметь записей в графе \"Расход\",\n" +
                            "поэтому если таковые имеются, то они будут удалены.\n\nВы уверены, что хотите этого?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                        {
                            return;
                        }
                    }
                    if (cbCategoryType.SelectedValue.ToString() == "o")
                    {
                        if (MessageBox.Show("Записи в категории \"Только расход\" не могут иметь записей в графе \"Приход\",\n" +
                            "поэтому если таковые имеются, то они будут удалены.\n\nВы уверены, что хотите этого?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                        {
                            return;
                        }
                    }
                }
                try
                {
                    CategoryManager.EditCategory(_categoryId, tbTitle.Text.Trim(), cbCategoryType.SelectedValue.ToString());
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace, "Ooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.None;
                }
            }
            else
            {
                try
                {
                    CategoryManager.NewCategory(SelectedAccount.Instance.AccountId, tbTitle.Text.Trim(), cbCategoryType.SelectedValue.ToString());
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace, "Ooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.None;
                }
            }
        }
    }

    
}
