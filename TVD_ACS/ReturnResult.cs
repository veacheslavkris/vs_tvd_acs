using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TVD_ACS
{
    public class ReturnResult
    {
        #region vars

        public const uint ERROR_FREE    =   0x00000000;
        public const uint COMMON_ERROR  =   0x80000000;


        readonly object obj_result;
        readonly uint cod_result;
        readonly string message_result;

        #endregion

        public object OBJ_RESULT
        {
            get { return obj_result; }
        }

        public uint COD_RESULT
        {
            get { return cod_result; }
        }

        public string MESSAGE_RESULT
        {
            get { return message_result; }
        }

        #region properties
        #endregion

        #region cstr

        public ReturnResult(uint cod_result_, object obj_result_ = null, string message_result_ = "")
        {
            Debug.Assert(cod_result_ <= COMMON_ERROR, "COMMON_ERROR is exceded");   
            cod_result = cod_result_;
            obj_result = obj_result_;
            message_result = message_result_;
        }

        #endregion



    }
}
