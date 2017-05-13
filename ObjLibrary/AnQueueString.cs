using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ObjLibrary
{
    public class AnQueueString
    {
        #region fields

        protected DateTime dt;
        protected const string PATTERN_IS_ASKING_DATE_TIME_BIN = "<?time!";
        protected const string PATTERN_IS_ASKING_DATE_TIME_BCD = "<?bcdtime!";
        
        protected BUFFER_DATA_TYPE buffer_data_type;
        string an_queue_string;

        #endregion

        #region properties

        public BUFFER_DATA_TYPE BFR_DATA_TYPE
        {
            get { return buffer_data_type; }

        }

        public DateTime DATE_TIME
        {
            get { return dt; }
        }

        public string DATE_AS_STRING
        {
            get { return dt.ToShortDateString(); }
        }

        public string TIME_AS_STRING
        {
            get { return dt.ToLongTimeString(); }
        }

        public int DATA_LENGTH
        {
            get
            {
                return an_queue_string.Length;
            }
        }

        public bool IS_DATE_TIME_BIN_ASKING
        {
            get { return an_queue_string == PATTERN_IS_ASKING_DATE_TIME_BIN; ; }
        }

        public bool IS_DATE_TIME_BCD_ASKING
        {
            get { return an_queue_string == PATTERN_IS_ASKING_DATE_TIME_BCD; ; }
        }

        public string DATA_STRING
        {
            get { return an_queue_string; }
        }


        #endregion

        #region cstor

        public AnQueueString(string an_queue_string_, BUFFER_DATA_TYPE buffer_data_type_)
        {
            Debug.Assert(!string.IsNullOrEmpty(an_queue_string_));

            dt = DateTime.Now;

            an_queue_string = an_queue_string_;

            buffer_data_type = buffer_data_type_;

        }

        public AnQueueString(string an_queue_string_, DateTime dt_, BUFFER_DATA_TYPE buffer_data_type_)
        {
            Debug.Assert(!string.IsNullOrEmpty(an_queue_string_));
            dt = dt_;
            an_queue_string = an_queue_string_;

            buffer_data_type = buffer_data_type_;
        }



        #endregion

        #region functions



        #endregion
    }
}
