using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace ObjLibrary
{
    public class AcsDataMessage
    {
        #region fields

        readonly string reader;
        readonly string str_hour;
        readonly string str_minute;
        readonly string str_second;

        readonly string str_day;
        readonly string str_month;
        readonly string str_year;

        readonly string str_ix_number;

        readonly string str_acs_number;

        DateTime acsDateTime;
        DateTime logDateTime;

        ACS_MSG_STATE state;

        #endregion

        #region properties

        public string READER
        {
            get { return reader; }
        }

        public string ACS_TIME_STRING
        {
            get { return acsDateTime.TimeOfDay.ToString(); }

        }

        public string ACS_DATE_STRING
        {
            get { return acsDateTime.Date.ToShortDateString(); }
        } 

        public string ACS_TIME_DATE_STRING
        {
            get { return String.Format("{0} {1}", ACS_TIME_STRING, ACS_DATE_STRING); }
        }

        public string LOG_TIME_STRING
        {
            get { return logDateTime.ToLongTimeString(); }

        }

        public string LOG_DATE_STRING
        {
            get { return logDateTime.Date.ToShortDateString(); }
        }

        public string LOG_TIME_DATE_STRING
        {
            get { return String.Format("{0} {1}", LOG_TIME_STRING, LOG_DATE_STRING); }
        }

        public string STR_IX_NUMBER
        {
            get { return str_ix_number; }
        }

        public string STR_ACS_NUMBER
        {
            get { return str_acs_number; }
        }

        public string FILE_LOG_STR
        {
            get { return String.Format("{0} | {1} {2} [{3}] : {4}", LOG_TIME_DATE_STRING, READER, ACS_TIME_DATE_STRING, STR_IX_NUMBER, STR_ACS_NUMBER); }
        }

        #endregion

        #region cstor

        public AcsDataMessage(StructFieldAcsMsg[] ary_StructFieldAcsMsg_/*, ACS_MSG_STATE state_*/)
        {
            //ary_StructFieldAcsMsg[0] = structDataSrc;
            //ary_StructFieldAcsMsg[1] = structStartTime;
            //ary_StructFieldAcsMsg[2] = structStartDate;
            //ary_StructFieldAcsMsg[3] = structStartIxNum;
            //ary_StructFieldAcsMsg[4] = structStartAcsNum;
            logDateTime = DateTime.Now;

            //state = state_;

            reader = new String(ary_StructFieldAcsMsg_[0].ary_chars, 0, ary_StructFieldAcsMsg_[0].data_length);

            str_hour = new String(ary_StructFieldAcsMsg_[1].ary_chars, 0, 2);
            str_minute = new String(ary_StructFieldAcsMsg_[1].ary_chars, 2, 2);
            str_second = new String(ary_StructFieldAcsMsg_[1].ary_chars, 4, 2);

            str_day = new String(ary_StructFieldAcsMsg_[2].ary_chars, 0, 2);
            str_month = new String(ary_StructFieldAcsMsg_[2].ary_chars, 2, 2);
            str_year = new String(ary_StructFieldAcsMsg_[2].ary_chars, 4, 2);

            str_ix_number = new String(ary_StructFieldAcsMsg_[3].ary_chars, 0, 2);

            str_acs_number = new String(ary_StructFieldAcsMsg_[4].ary_chars, 0, 10);

            acsDateTime = new DateTime(2000 + int.Parse(str_year), int.Parse(str_month), int.Parse(str_day), int.Parse(str_hour), int.Parse(str_minute), int.Parse(str_second));


        }

        #endregion

        #region functions

        #endregion

    }
}
