using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using HomeAccounting.DataClasses;
using HomeAccounting.DataSources;
using HomeAccounting.Properties;
using HomeAccounting.MultilanguageInterface;

namespace HomeAccounting
{
    public partial class ctrlAccount : UserControl
    {
        private BooksListDS dsBooks;


        private void ShowBookForm(FormCreatingReason reason)
        {
            frmAddEditBook f = new frmAddEditBook(reason);
            if (f.ShowDialog() == DialogResult.OK)
            {
                GetBooks();
            }
        }
        private void GetBooks()
        {
            try
            {
                int pos = bookBindingSource.Position;

                dsBooks = BooksListDataSetFiller.FillData(SelectedAccount.Instance.AccountId);
                bookBindingSource.DataSource = dsBooks;

                bookBindingSource.Position = pos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace,
                                "Ooops!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GetRecords()
        {

        }
        public ctrlAccount()
        {
            InitializeComponent();
        }

        private void lblHideRecordDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (!Settings.Default.RecordDetailsWarningShown)
                {
                    MessageBox.Show("Отображение деталей записи можно включить в настройках программы",
                        "JFYI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Settings.Default.RecordDetailsWarningShown = true;
                }
                Settings.Default.ShowRecordDetails = false;
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace, 
                                "Ooops!", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctrlAccount_Load(object sender, EventArgs e)
        {
            GetBooks();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            ShowBookForm(FormCreatingReason.NewItem);
        }

        private void bookBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            tlpRecords.Enabled = bookBindingSource.Current != null;
            btnEditBook.Enabled = bookBindingSource.Current != null;
            btnDeleteBook.Enabled = bookBindingSource.Current != null;
            SelectedBook.Instance.BookId = bookBindingSource.Current != null ? (int)dsBooks.Tables["Book"].Rows[bookBindingSource.Position]["bookId"] : 0;
            SelectedBook.Instance.Account = bookBindingSource.Current != null ? (int)dsBooks.Tables["Book"].Rows[bookBindingSource.Position]["account"] : 0;
            SelectedBook.Instance.Type = bookBindingSource.Current != null ? dsBooks.Tables["Book"].Rows[bookBindingSource.Position]["type"].ToString() : string.Empty;
            SelectedBook.Instance.Title = bookBindingSource.Current != null ? dsBooks.Tables["Book"].Rows[bookBindingSource.Position]["title"].ToString() : string.Empty;
            SelectedBook.Instance.Added = bookBindingSource.Current != null ? (DateTime)dsBooks.Tables["Book"].Rows[bookBindingSource.Position]["added"] : DateTime.MinValue;
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            ShowBookForm(FormCreatingReason.EditItem);
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Уверены, что хотите удалить выбранную книгу учета?", "Отвечай!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                BookManager.DeleteBook(SelectedBook.Instance.BookId);
                GetBooks();
            }
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            frmCategoryManagement f = new frmCategoryManagement();
            f.ShowDialog();
        }
    }
}
