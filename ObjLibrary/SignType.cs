using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjLibrary
{
    public class SignType
    {
        #region fields
        
        static byte[,] ary = new byte[7, 2] { 
                                            {/*0*/ (byte)SIGN_POSITION_TYPE.SPT_START_INPUT, (byte)'<' },
                                            {/*1*/ (byte)SIGN_POSITION_TYPE.SPT_SRC_DATA, (byte)'='},
                                            {/*2*/ (byte)SIGN_POSITION_TYPE.SPT_START_TIME, (byte)'$'},
                                            {/*3*/ (byte)SIGN_POSITION_TYPE.SPT_START_DATE, (byte)'%'},
                                            {/*4*/ (byte)SIGN_POSITION_TYPE.SPT_START_IX_NUM, (byte)'@'},
                                            {/*5*/ (byte)SIGN_POSITION_TYPE.SPT_START_ACS_NUM, (byte)'#'},
                                            {/*6*/ (byte)SIGN_POSITION_TYPE.SPT_END_INPUT, (byte)'!'}
                                            };


        SIGN_POSITION_TYPE sign_position_type;
        char sign;

        #endregion

        #region properties

        public SIGN_POSITION_TYPE SIGN_POS_TYPE
        {
            get { return sign_position_type; }
        }

        public char SIGN
        {
            get { return sign; }
        }

        #endregion

        #region cstor

        SignType(SIGN_POSITION_TYPE sign_position_type_, char sign_)
        {
            sign_position_type = sign_position_type_;
            sign = sign_;
        }

        #endregion

        #region functions

        /// <summary>
        /// may return null
        /// </summary>
        /// <param name="sign_position_type_"></param>
        /// <returns></returns>
        public static SignType CreateSignType(SIGN_POSITION_TYPE sign_position_type_)
        {
            char sign = (char)ary[(int)sign_position_type_, 1];

            return new SignType(sign_position_type_, sign);
        }

        public static char GetSignByType(SIGN_POSITION_TYPE sign_position_type_)
        {
            return (char)ary[(int)sign_position_type_, 1];
        }

        public bool CheckSignEquality(char sign_)
        {
            return sign_ == sign;
        }

        #endregion


    }
}
