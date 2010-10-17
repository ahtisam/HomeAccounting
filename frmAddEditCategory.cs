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
        private CategoryType cType;
        private bool _isEditing;

        public frmAddEditCategory(FormCreatingReason reason)
        {
            InitializeComponent();
            try
            {
                cType = new CategoryType();
                categoryTypeBindingSource.DataSource = cType;

                switch (reason)
                {
                    case FormCreatingReason.NewItem:
                        Text = "Новая категория";
                        _isEditing = false;
                        break;
                    case FormCreatingReason.EditItem:
                        tbTitle.Text = SelectedBook.Instance.Title;
                        cbCategoryType.SelectedValue = SelectedBook.Instance.Type;
                        Text = "Редактировать книгу учета";
                        _isEditing = true;
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace, "Ooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
        }
    }

    
}
