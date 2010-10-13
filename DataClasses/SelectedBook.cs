using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeAccounting.DataClasses
{
    public sealed class SelectedBook
    {
        #region Singleton declaration
        private static readonly SelectedBook _instance = new SelectedBook();
        private SelectedBook() { }
        public static SelectedBook Instance
        {
            get
            {
                return _instance;
            }
        }
        #endregion

        private int _bookId;
        private int _account;
        private string _title;
        private string _type;
        private DateTime _added;

        public DateTime Added
        {
            get { return _added; }
            set { _added = value; }
        }
        public int BookId
        {
            get { return _bookId; }
            set { _bookId = value; }
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public int Account
        {
            get { return _account; }
            set { _account = value; }
        }
    }
}
