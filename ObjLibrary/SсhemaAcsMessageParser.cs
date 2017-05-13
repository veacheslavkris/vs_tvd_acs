using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjLibrary
{
    public class SсhemaAcsMessageParser
    {

        #region fields

        //const uint32_t IX_ANSI_START_F = 0;
        //const uint32_t IX_ANSI_SRC_F = 1;
        //const uint32_t IX_ANSI_SRC_2 = 2;
        //const uint32_t IX_ANSI_SRC_1 = 3;
        //const uint32_t IX_ANSI_SRC_0 = 4;
        //const uint32_t IX_ANSI_TIME_F = 5;
        //const uint32_t IX_ANSI_HOUR_1 = 6;
        //const uint32_t IX_ANSI_HOUR_0 = 7;
        //const uint32_t IX_ANSI_MINUTE_1 = 8;
        //const uint32_t IX_ANSI_MINUTE_0 = 9;
        //const uint32_t IX_ANSI_SECOND_1 = 10;
        //const uint32_t IX_ANSI_SECOND_0 = 11;
        //const uint32_t IX_ANSI_DATE_F = 12;
        //const uint32_t IX_ANSI_DAY_1 = 13;
        //const uint32_t IX_ANSI_DAY_0 = 14;
        //const uint32_t IX_ANSI_MONTH_1 = 15;
        //const uint32_t IX_ANSI_MONTH_0 = 16;
        //const uint32_t IX_ANSI_YEAR_1 = 17;
        //const uint32_t IX_ANSI_YEAR_0 = 18;
        //const uint32_t IX_ANSI_IX_NUM_F = 19;
        //const uint32_t IX_ANSI_IX_NUM_1 = 20;
        //const uint32_t IX_ANSI_IX_NUM_0 = 21;
        //const uint32_t IX_ANSI_ACS_NUM_F = 22;
        //const uint32_t IX_ANSI_ACS_NUM_9 = 23;
        //const uint32_t IX_ANSI_ACS_NUM_8 = 24;
        //const uint32_t IX_ANSI_ACS_NUM_7 = 25;
        //const uint32_t IX_ANSI_ACS_NUM_6 = 26;
        //const uint32_t IX_ANSI_ACS_NUM_5 = 27;
        //const uint32_t IX_ANSI_ACS_NUM_4 = 28;
        //const uint32_t IX_ANSI_ACS_NUM_3 = 29;
        //const uint32_t IX_ANSI_ACS_NUM_2 = 30;
        //const uint32_t IX_ANSI_ACS_NUM_1 = 31;
        //const uint32_t IX_ANSI_ACS_NUM_0 = 32;
        //const uint32_t IX_ANSI_END_F = 33;

        StructFieldAcsMsg structDataSrc;
        StructFieldAcsMsg structStartTime;
        StructFieldAcsMsg structStartDate;
        StructFieldAcsMsg structStartIxNum;
        StructFieldAcsMsg structStartAcsNum;

        StructFieldAcsMsg[] ary_StructFieldAcsMsg;

        string original_sub_string;

        string reader;
        int hour;
        int minute;
        int second;

        int day;
        int month;
        int year;

        int acs_number;

        






        #endregion

        #region properties

        #endregion

        #region cstor

        public SсhemaAcsMessageParser()
        {
            structDataSrc = new StructFieldAcsMsg(SIGN_POSITION_TYPE.SPT_SRC_DATA, 1, 3);
            structStartTime = new StructFieldAcsMsg(SIGN_POSITION_TYPE.SPT_START_TIME, 5, 6);
            structStartDate = new StructFieldAcsMsg(SIGN_POSITION_TYPE.SPT_START_DATE, 12, 6);
            structStartIxNum = new StructFieldAcsMsg(SIGN_POSITION_TYPE.SPT_START_IX_NUM, 19, 2);
            structStartAcsNum = new StructFieldAcsMsg(SIGN_POSITION_TYPE.SPT_START_ACS_NUM, 22, 10);

            ary_StructFieldAcsMsg = new StructFieldAcsMsg[5];
            ary_StructFieldAcsMsg[0] = structDataSrc;
            ary_StructFieldAcsMsg[1] = structStartTime;
            ary_StructFieldAcsMsg[2] = structStartDate;
            ary_StructFieldAcsMsg[3] = structStartIxNum;
            ary_StructFieldAcsMsg[4] = structStartAcsNum;



        }

        #endregion

        #region functions



        public AcsDataMessage ParseMessageString(AnQueueString anQueueDataBytes_)
        {
            ACS_MSG_STATE state = ACS_MSG_STATE.AMS_OK_STATE;

            string an_subs_tring = anQueueDataBytes_.DATA_STRING;

            // structDataSrc
            // structStartTime
            // structStartDate
            // structStartIxNum
            // structStartAcsNum


            // 1. check positions

            foreach (StructFieldAcsMsg struct_field in ary_StructFieldAcsMsg)
            {
                if (an_subs_tring.Length > struct_field.sign_position)
                {
                    if (struct_field.sign_ != (char)an_subs_tring[struct_field.sign_position])
                    {
                        return null;
                    }
                }
                else return null;


            }

            // 2. Retreive data
            foreach (StructFieldAcsMsg struct_acs_msg in ary_StructFieldAcsMsg)
            {
                int start = struct_acs_msg.sign_position + 1;
                int end = start + struct_acs_msg.data_length;
                int ix_ary = 0;

                if (an_subs_tring.Length >= end)
                {
                    for (int ix = start; ix < end; ix++)
                    {
                        struct_acs_msg.ary_chars[ix_ary++] = an_subs_tring[ix];
                    }
                }
                else return null;




            }


            return new AcsDataMessage(ary_StructFieldAcsMsg);
        }

        #endregion
    }
}
