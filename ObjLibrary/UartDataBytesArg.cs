using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjLibrary
{
    public class UartDataBytesArg : EventArgs
    {
        public byte[] ary_byte { get; private set; }

        public UartDataBytesArg(byte[] ary_byte_)
        {
            ary_byte = ary_byte_;
        }
    }
}
