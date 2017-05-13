using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjLibrary
{
    public class DataStringArg : EventArgs
    {
        public string str { get; private set; }

        public DataStringArg(string str_)
        {
            str = str_;
        }
    }
}
