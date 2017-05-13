using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ObjLibrary
{
    public class UartDataBuffer
    {
        #region fields

        Queue<AnQueueString> uart_string_queue_input;
        Queue<AnQueueString> sub_string_queue_output;
        Queue<AnQueueString> err_string_queue_output;
        Queue<AnQueueString> uart_string_queue_output;

        SсhemaAcsMessageParser sсhemaAcsMessageParser;


        #endregion

        #region properties

        public bool IS_UART_STRING_QUEUE_INPUT_NOT_EMPTY
        {
            get { return uart_string_queue_input.Count > 0; }
        }

        public bool IS_UART_STRING_QUEUE_OUTPUT_NOT_EMPTY
        {
            get { return uart_string_queue_output.Count > 0; }
        }

        public bool IS_SUB_STRING_QUEUE_NOT_EMPTY
        {
            get { return sub_string_queue_output.Count > 0; }
        }

        public bool IS_ERR_STRING_QUEUE_NOT_EMPTY
        {
            get { return err_string_queue_output.Count > 0; }
        }

        #endregion


        #region cstor

        public UartDataBuffer()
        {
            uart_string_queue_input = new Queue<AnQueueString>();
            sub_string_queue_output = new Queue<AnQueueString>();
            err_string_queue_output = new Queue<AnQueueString>();
            uart_string_queue_output = new Queue<AnQueueString>();

            sсhemaAcsMessageParser = new SсhemaAcsMessageParser();
        }

        #endregion

        #region functions

        /// <summary>
        /// store sended from UART data as string
        /// </summary>
        /// <param name="str_new_data_"></param>
        public void AddUartDataString(AnQueueString new_q_bytes)
        {
            Debug.Assert(!string.IsNullOrEmpty(new_q_bytes.DATA_STRING));
            uart_string_queue_input.Enqueue(new_q_bytes);
        }

        /// <summary>
        /// return null in case uart_string_queue is empty
        /// </summary>
        /// <returns>sended from UART data as string or null</returns>
        public AnQueueString GetUartDataString()
        {
            if (IS_UART_STRING_QUEUE_INPUT_NOT_EMPTY) return uart_string_queue_input.Dequeue();
            else return null;
        }

        /// <summary>
        /// return null in case uart_string_queue is empty
        /// make a copy for output
        /// </summary>
        /// <returns>sended from UART data as string or null</returns>
        public AnQueueString GetUartDataStringWithOutputCopy()
        {
            if (IS_UART_STRING_QUEUE_INPUT_NOT_EMPTY)
            {
                AnQueueString qs = uart_string_queue_input.Dequeue();
                uart_string_queue_output.Enqueue(qs);
                return qs;
            }
            else return null;
        }

        /// <summary>
        /// store selected from UART sub_string
        /// </summary>
        /// <param name="str_new_msg_"></param>
        public void AddCompletedSubString(AnQueueString new_q_substr)
        {
            Debug.Assert(!string.IsNullOrEmpty(new_q_substr.DATA_STRING));
            sub_string_queue_output.Enqueue(new_q_substr);
        }

        /// <summary>
        /// return null in case accs_message_queue is empty
        /// </summary>
        /// <returns>sended from UART data as string or null</returns>
        public AnQueueString GetCompletedSubString()
        {
            if (IS_SUB_STRING_QUEUE_NOT_EMPTY) return sub_string_queue_output.Dequeue();
            else return null;
        }

        /// <summary>
        /// store selected from UART sub_string
        /// </summary>
        /// <param name="str_new_msg_"></param>
        public void AddErrSubString(AnQueueString new_q_err_substr)
        {
            Debug.Assert(!string.IsNullOrEmpty(new_q_err_substr.DATA_STRING));
            err_string_queue_output.Enqueue(new_q_err_substr);
        }

        /// <summary>
        /// return null in case accs_message_queue is empty
        /// </summary>
        /// <returns>sended from UART data as string or null</returns>
        public AnQueueString GetErrSubstring()
        {
            if (IS_ERR_STRING_QUEUE_NOT_EMPTY) return err_string_queue_output.Dequeue();
            else return null;
        }

        public List<AnQueueString> GetListOfErrorSubStringsAndCompletedSubStrings()
        {
            List<AnQueueString> list_q_str = new List<AnQueueString>(sub_string_queue_output.Count + err_string_queue_output.Count);

            while (IS_SUB_STRING_QUEUE_NOT_EMPTY) list_q_str.Add(sub_string_queue_output.Dequeue());
            while (IS_ERR_STRING_QUEUE_NOT_EMPTY) list_q_str.Add(err_string_queue_output.Dequeue());

            return list_q_str;
        }

        /// <summary>
        /// Is returned only completed substrings 
        /// NOT errors, NOT original uart data bytes, NOT pre_substring 
        /// </summary>
        /// <returns></returns>
        public List<AcsDataMessage> GetAcsDataMessagesList()
        {
            //List<AcsDataMessage> list_adm = new List<AcsDataMessage>(uart_sub_string_queue_output.Count + uart_err_string_queue_output.Count + 2);
            List<AcsDataMessage> list_adm = new List<AcsDataMessage>(sub_string_queue_output.Count);

            while (IS_SUB_STRING_QUEUE_NOT_EMPTY)
            {
                AcsDataMessage acsDataMessage = sсhemaAcsMessageParser.ParseMessageString(sub_string_queue_output.Dequeue());

                list_adm.Add(acsDataMessage);
            }

            return list_adm;
        }

    }

    #endregion


}
