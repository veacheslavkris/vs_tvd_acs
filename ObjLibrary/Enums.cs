using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjLibrary
{
    //public enum UART_STATE
    //{
    //    UART_IS_UNDEFINED,
    //    UART_IS_LISTENING,
    //    UART_IS_TRANSMITING,
    //    UART_IS_RECEIVING
    //}


    public enum BUFFER_DATA_TYPE
    {
        BFDT_ERR_STRING,
        BFDT_SUB_STRING,
        BFDT_RAW_IO_BYTES,
        BFDT_SUB_STRING_BLDR

    }

    [Flags]
    public enum ACS_MSG_STATE
    {
        AMS_OK_STATE = 0,
        AMS_ERR_SRC_DATA_FIELD = 1,
        AMS_ERR_START_TIME_FIELD = 2,
        AMS_ERR_START_DATE_FIELD = 4,
        AMS_ERR_START_IX_NUM_FIELD = 8,
        AMS_ERR_START_ACS_NUM_FIELD = 16


    }

    public enum SIGN_POSITION_TYPE
    {
        SPT_START_INPUT = 0,
        SPT_SRC_DATA = 1,

        SPT_START_TIME = 2,
        SPT_START_DATE = 3,
        SPT_START_IX_NUM = 4,
        SPT_START_ACS_NUM = 5,

        SPT_END_INPUT = 6
    }

    public struct StructFieldAcsMsg
    {
        public SignType signType;
        public char sign_;
        public SIGN_POSITION_TYPE sign_position_type;
        public int sign_position;
        public int data_length;
        public char[] ary_chars;

        public StructFieldAcsMsg(SIGN_POSITION_TYPE spt_, int sign_pos_, int data_length_)
        {
            signType = SignType.CreateSignType(spt_);
            sign_ = SignType.GetSignByType(spt_);
            sign_position_type = spt_;
            sign_position = sign_pos_;
            data_length = data_length_;
            ary_chars = new char[data_length];
        }

    }




}
