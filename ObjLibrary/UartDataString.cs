using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace ObjLibrary
{
    // raw data bytes from UART as is
    // sending by UartAdapter
    // contains full or part of message 
    // from Wiegand or BlueTooth 
    // <=xxx!  or  @<=xxx!w  or  <?time!  or <?t    ime!

    public class UartDataString
    {

        #region fields

        SсhemaSubString schemaSubString;


        public EventHandler<AnQueueStringArg> completedSubString;
        public EventHandler<AnQueueStringArg> errorSubString;

        AnQueueString queue_string;


        #endregion

        #region properties


        #endregion

        #region cstor

        public UartDataString()
        {
            schemaSubString = new SсhemaSubString();
        }

        #endregion

        #region functions

        public void ParseIntoSubStrings(AnQueueString queue_string_)
        {
            Debug.Assert(!string.IsNullOrEmpty(queue_string_.DATA_STRING));

            queue_string = queue_string_;

            indexing_start_end_string(queue_string);
        }

        void indexing_start_end_string(AnQueueString queue_string_)
        {
            

            for (int ix = 0; ix < queue_string_.DATA_LENGTH; ix++)
            {
                schemaSubString.CheckChar(queue_string_.DATA_STRING[ix]);

                if (schemaSubString.IS_SUCCESSFULLY_COMPLETED)
                {
                    AnQueueString an_queue_string = new AnQueueString(schemaSubString.CUR_SUB_STRING, queue_string_.DATE_TIME, BUFFER_DATA_TYPE.BFDT_SUB_STRING);

                    on_substring_completed(an_queue_string);

                    schemaSubString.Reset();
                }
                else if (schemaSubString.IS_ERROR_STATE)
                {
                    AnQueueString an_queue_string = new AnQueueString(schemaSubString.CUR_SUB_STRING, queue_string_.DATE_TIME, BUFFER_DATA_TYPE.BFDT_ERR_STRING);

                    on_substring_error(an_queue_string);

                    schemaSubString.Reset();
                }
            }
        }
        
        void on_substring_completed(AnQueueString q_substring_bytes_)
        {
            EventHandler<AnQueueStringArg> subStringCompleted = completedSubString;

            subStringCompleted?.Invoke(this, new AnQueueStringArg(q_substring_bytes_));
        }

        void on_substring_error(AnQueueString q_errstring_bytes_)
        {
            EventHandler<AnQueueStringArg> subStringError = errorSubString;

            subStringError?.Invoke(this, new AnQueueStringArg(q_errstring_bytes_));
        }

        #endregion
    }
}
