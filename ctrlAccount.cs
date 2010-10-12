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


        private void ShowBookForm(BookFormCreatingReason reason)
        {
            frmAddEditBook f = new frmAddEditBook(reason);
            if (f.ShowDialog() == DialogResult.OK)
            {

            }
        }
        private void GetBooks()
        {
            try
            {
                dsBooks = BooksListDataSetFiller.FillData(SelectedAccount.Instance.AccountId);
                bookBindingSource.DataSource = dsBooks;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace,
                                "Ooops!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
