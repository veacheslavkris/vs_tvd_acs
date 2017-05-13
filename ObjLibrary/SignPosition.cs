using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjLibrary
{
    public class SignPosition
    {
        #region fields

        SignType signType;

        int ix_position;
        int ix_count;

        #endregion

        #region properties

        public SIGN_POSITION_TYPE SIGN_POS_TYPE
        {
            get { return signType.SIGN_POS_TYPE; }
        }

        public char SIGN
        {
            get { return signType.SIGN; }
        }

        public int IX_POSITION
        {
            get { return ix_position; }
            set { ix_position = value; }
        }

        public bool IS_SIGN_SET
        {
            get { return ix_position >= 0; }
        }

        public bool IS_MULTIPLE_POSITION_ERROR
        {
            get { return ix_count > 1; }
        }

        #endregion

        #region cstor

        public SignPosition(SIGN_POSITION_TYPE sign_position_type_/*, int def_ix_position_ = 0*/)
        {
            signType = SignType.CreateSignType(sign_position_type_);
         
            ix_position = -1;
            ix_count = 0;
        }

        #endregion

        #region functions

        public void Reset()
        {
            ix_position = -1;
            ix_count = 0;
        }
  

        
        /// <summary>
        /// return is sign equal char
        /// </summary>
        /// <param name="ch_"></param>
        /// <param name="position_"></param>
        /// <returns></returns>
        public bool CheckEqulity(char ch_, int position_)
        {
            return check_equlity(ch_, position_);

        }

        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ch_"></param>
        /// <param name="position_"></param>
        /// <returns></returns>
        bool check_equlity(char ch_, int position_)
        {
            if (signType.CheckSignEquality(ch_))
            {
                ix_count++;

                if (!IS_SIGN_SET) ix_position = position_;

                return true;
            }
            else return false;
            
        }

        #endregion
    }
}
