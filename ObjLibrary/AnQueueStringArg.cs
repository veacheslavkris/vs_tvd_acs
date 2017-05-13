using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjLibrary
{
    public class AnQueueStringArg : EventArgs
    {
        #region fields

        public AnQueueString an_queue_string { get; private set; }


        #endregion

        #region cstor

        public AnQueueStringArg(AnQueueString an_queue_string_)
        {
            an_queue_string = an_queue_string_;
        }

        #endregion

    }
}
