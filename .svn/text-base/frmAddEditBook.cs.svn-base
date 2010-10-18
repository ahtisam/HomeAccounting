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
    public partial class frmAddEditBook : Form
    {
        private BookType bType;
        private bool _isEditing;

        public frmAddEditBook(FormCreatingReason reason)
        {
            InitializeComponent();
            try
            {
                bType = new BookType();
                bookTypeBindingSource.DataSource = bType;

                switch (reason)
                {
                    case FormCreatingReason.NewItem:
                        Text = "Новая книга учета";
                        _isEditing = false;
                        break;
                    case FormCreatingReason.EditItem:
                        tbTitle.Text = SelectedBook.Instance.Title;
                        cbBookType.SelectedValue = SelectedBook.Instance.Type;

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
            try
            {
                if (!_isEditing)
                {
                    BookManager.NewBook(tbTitle.Text, cbBookType.SelectedValue.ToString(), SelectedAccount.Instance.AccountId);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    if (cbBookType.SelectedValue.ToString() != SelectedBook.Instance.Type)
                    {
                        if (cbBookType.SelectedValue.ToString() == "i")
                        {
                            if (MessageBox.Show("Записи в книге типа \"Только приход\" не могут иметь записей в графе \"Расход\",\n" +
                                "поэтому если таковые имеются, то они будут удалены.\n\nВы уверены, что хотите этого?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                            {
                                return;
                            }
                        }
                        if (cbBookType.SelectedValue.ToString() == "o")
                        {
                            if (MessageBox.Show("Записи в книге типа \"Только расход\" не могут иметь записей в графе \"Приход\",\n" +
                                "поэтому если таковые имеются, то они будут удалены.\n\nВы уверены, что хотите этого?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                            {
                                return;
                            }
                        }
                    }
                    BookManager.EditBook(SelectedBook.Instance.BookId, tbTitle.Text, cbBookType.SelectedValue.ToString());
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace, "Ooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
            DialogResult = DialogResult.OK;
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {
        }
    }

    
}
