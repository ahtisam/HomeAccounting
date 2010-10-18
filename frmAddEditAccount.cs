using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using HomeAccounting.DataClasses;

namespace HomeAccounting
{
    public partial class frmAddEditAccount : Form
    {
        private bool _isEditing;

        private bool CheckDetails()
        {
            return (tbPassword.Text == tbPasswordAgain.Text) && (tbTitle.Text.Trim() != string.Empty)
                && (tbPassword.Text != string.Empty);
            
        }
        public frmAddEditAccount(FormCreatingReason reason)
        {
            InitializeComponent();
            switch (reason)
            {
                case FormCreatingReason.EditItem:
                    _isEditing = true;
                    tbTitle.Text = SelectedAccount.Instance.Title;
                    tbPassword.Text = SelectedAccount.Instance.Password;
                    tbPasswordAgain.Text = SelectedAccount.Instance.Password;
                    break;
                case FormCreatingReason.NewItem:
                    _isEditing = false;
                    break;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_isEditing)
                {
                    AccountManager.NewAccount(tbTitle.Text, tbPassword.Text);
                }
                else
                {
                    SelectedAccount.Instance.Title = tbTitle.Text;
                    SelectedAccount.Instance.Password = tbPassword.Text;
                    AccountManager.EditAccount(SelectedAccount.Instance.AccountId, tbTitle.Text, tbPassword.Text);
                    
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

        private void tbTitle_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = CheckDetails();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = CheckDetails();
        }

        private void tbPasswordAgain_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = CheckDetails();
        }
    }
}
