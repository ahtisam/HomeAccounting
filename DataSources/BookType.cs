using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeAccounting.DataSources
{
    public class BookType: Dictionary<char,string>
    {
        public BookType()
        {
            this.Add('b', "Приход/расход");
            this.Add('o', "Только расход");
            this.Add('i', "Только приход");
        }

    }
}
