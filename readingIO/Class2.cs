using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readingIO
{
    class BalanceException : Exception
    {
        public string name;
        
        public BalanceException()
        {

        }
        public BalanceException(string name) : base (string.Format("Error loading the Balance of {0}",name))
        {
            this.name = name;
        }

    }
}
