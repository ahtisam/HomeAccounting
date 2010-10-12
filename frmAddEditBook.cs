using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using HomeAccounting.DataSources;
using HomeAccounting.Properties;
using HomeAccounting.MultilanguageInterface;

namespace HomeAccounting
{
    public partial class frmAddEditBook : Form
    {
        private BookType bType;
        private bool _isEditing;

        public frmAddEditBook(BookFormCreatingReason reason)
        {
            InitializeComponent();
            try
            {
                bType = new BookType();
                bookTypeBindingSource.DataSource = bType;

                switch (reason)
                {
                    case BookFormCreatingReason.NewBook:
                        Text = "Новая книга учета";
                        break;
                    case BookFormCreatingReason.EditBook:
                        Text = "Редактировать книгу учета";
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace, "Ooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
        }

        private void tbTitle_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = tbTitle.Text.Trim().Length > 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }

    public enum BookFormCreatingReason
    {
        NewBook,
        EditBook
    }
}
