using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ObjLibrary
{
    public class AnObjectArg : EventArgs
    {

        #region fields

        public Object an_object { get; private set; }
        
        #endregion

        #region cstor

        public AnObjectArg(Object an_object_)
        {
            Debug.Assert(an_object_ != null);

            an_object = an_object_;
        }

        #endregion
    }
}
