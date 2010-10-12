using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeAccounting.DataClasses
{
    public sealed class SelectedAccount
    {
        #region Singleton declaration
        private static readonly SelectedAccount _instance = new SelectedAccount();
        private SelectedAccount() { }
        public static SelectedAccount Instance
        {
            get
            {
                return _instance;
            }
        }
        #endregion

        private int _accountId;
        private string _title;
        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public int AccountId
        {
            get { return _accountId; }
            set { _accountId = value; }
        }
    }
}
