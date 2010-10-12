using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using HomeAccounting.DataClasses;
using HomeAccounting.MultilanguageInterface;

namespace HomeAccounting
{
    public partial class frmMain : Form
    {
        private ctrlAccount _ctrlAccount;

        private DialogResult ShowLoginForm()
        {
            frmLogin frm = new frmLogin();
            return frm.ShowDialog();
        }
        private void ShowAccountControl()
        {
            try
            {
                lblLogin.Hide();
                _ctrlAccount = new ctrlAccount();
                pnlHost.Controls.Add(_ctrlAccount);
                _ctrlAccount.Dock = DockStyle.Fill;
                _ctrlAccount.Show();
                this.Text = SelectedAccount.Instance.Title;
                miDeleteAccount.Visible = true;
                miEditAccount.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace, "Ooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ShowDefaultForm()
        {
            try
            {
                lblLogin.Show();
                _ctrlAccount = null;

                SelectedAccount.Instance.AccountId = 0;
                SelectedAccount.Instance.Title = string.Empty;
                SelectedAccount.Instance.Password = string.Empty;

                this.Text = string.Empty;
                miDeleteAccount.Visible = false;
                miEditAccount.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace, "Ooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ShowAccountForm(AccountFormCreatingReason reason)
        {
            frmAddEditAccount f = new frmAddEditAccount(reason);
            if (f.ShowDialog() == DialogResult.OK)
            {
                ShowAccountControl();
            }
        }

        public frmMain()
        {
            InitializeComponent();
            
        }

        private void lblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ShowLoginForm() == DialogResult.OK)
            {
                ShowAccountControl();
            }
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            if (ShowLoginForm() == DialogResult.OK)
            {
                ShowAccountControl();
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void miSelectAccount_Click(object sender, EventArgs e)
        {
            if (ShowLoginForm() == DialogResult.OK)
            {
                ShowAccountControl();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Уверены?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No;
        }

        private void miEditAccount_Click(object sender, EventArgs e)
        {
            ShowAccountForm(AccountFormCreatingReason.EditAccount);
        }

        private void miNewAccount_Click(object sender, EventArgs e)
        {
            ShowAccountForm(AccountFormCreatingReason.NewAccount);
        }

        private void miDeleteAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Уверены, что хотите удалить выбранную учетную запись?", "Отвечай!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                AccountManager.DeleteAccount(SelectedAccount.Instance.AccountId);
                ShowDefaultForm();
            }

        }
    }
}
