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
using HomeAccounting.DataClasses;

namespace HomeAccounting
{
    public partial class frmLogin : Form
    {
        private AccountsListDS dsAccounts;

        private void GetAccountsList()
        {
            dsAccounts = AccountsListDataSetFiller.FillData();
            accountBindingSource.DataSource = dsAccounts;
        }
        private void TryLogin()
        {
            try
            {
               // LoginChecker lc = new LoginChecker();
                if (LoginChecker.Login((int)cbSelectAccount.SelectedValue, tbPassword.Text))
                {
                    SelectedAccount.Instance.AccountId = (int)cbSelectAccount.SelectedValue;
                    SelectedAccount.Instance.Title = cbSelectAccount.Text;
                    SelectedAccount.Instance.Password = tbPassword.Text;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Password is incorrect");
                    DialogResult = DialogResult.None;
                    tbPassword.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace, "Ooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public frmLogin()
        {
            InitializeComponent();
            GetAccountsList();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            TryLogin();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            tbPassword.Select();
        }

        private void lblAddNewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditAccount frm = new frmAddEditAccount(AccountFormCreatingReason.NewAccount);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                GetAccountsList();
            }
        }
    }
}
