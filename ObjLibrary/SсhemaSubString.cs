using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjLibrary
{
    public class SсhemaSubString
    {
        #region fields

        SignPosition sign_input;        //  '<'
        SignPosition sign_end;          //  '!'

        const byte mask_8_bit = 0x80;
        StringBuilder sb;

        #endregion

        #region properties

        /// <summary>
        /// IS_START_END_INDEXED && ERROR_FREE
        /// </summary>
        public bool IS_SUCCESSFULLY_COMPLETED
        {
            get { return IS_SET_START_END && IS_MULTIPLE_ERROR_FREE; }
        }

        #region ERROR STATES

        #region MULTIPLE POS ERRORS

        public bool IS_MULTIPLE_ERROR_FREE
        {
            get { return !IS_MULTIPLE_ERROR; }
        }

        public bool IS_MULTIPLE_ERROR
        {
            get { return (IS_MULTIPLE_START_ERR || IS_MULTIPLE_END_ERR); }
        }

        public bool IS_MULTIPLE_START_ERR
        {
            get { return sign_input.IS_MULTIPLE_POSITION_ERROR; }
        }

        public bool IS_MULTIPLE_END_ERR
        {
            get { return sign_end.IS_MULTIPLE_POSITION_ERROR; }
        }


        #endregion

        /// <summary>
        /// END position is alone
        /// START position is absent
        /// </summary>
        public bool IS_END_ALONE_ERROR
        {
            get { return ((!IS_START_SET) && (IS_END_SET)); }
        }

        public bool IS_ERROR_STATE
        {
            get { return (IS_MULTIPLE_ERROR || IS_END_ALONE_ERROR); }
        }

        #endregion


        #region IS SET START END OR BOTH

        public bool IS_START_SET
        {
            get { return sign_input.IS_SIGN_SET; }
        }

        public bool IS_END_SET
        {
            get { return sign_end.IS_SIGN_SET; }
        }

        public bool IS_SET_START_END
        {
            get { return IS_START_SET && IS_END_SET; }
        }

        #endregion

        public int SUB_STR_LENGTH
        {
            get { return sb.Length; }
        }

        public string CUR_SUB_STRING
        {
            get { return sb.ToString(); }
        }

        #endregion

        #region cstor

        public SсhemaSubString()
        {
            sb = new StringBuilder();

            sign_input = new SignPosition(SIGN_POSITION_TYPE.SPT_START_INPUT);
            sign_end = new SignPosition(SIGN_POSITION_TYPE.SPT_END_INPUT);
        }

        #endregion

        #region functions

        public void Reset()
        {
            sign_input.Reset();
            sign_end.Reset();
            sb.Clear();
        }

        public void CheckChar(char ch_)
        {
            if (!sign_input.CheckEqulity(ch_, sb.Length))
            {
                sign_end.CheckEqulity(ch_, sb.Length);
            }

            sb.Append(ch_);
        }


        #endregion
    }
}
