using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeAccounting.DataSources
{
    public class CategoryType : Dictionary<string, string>
    {
        public CategoryType()
        {
            this.Add("b", "Приход/расход");
            this.Add("o", "Только расход");
            this.Add("i", "Только приход");
        }

    }
}
