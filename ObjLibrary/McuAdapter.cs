using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Diagnostics;

namespace ObjLibrary
{
    public class McuAdapter
    {
        #region fields

        UartAdapter uart_adapter;
        UartDataBuffer uartDataBuffer;
        UartDataString uartRawString;

        BackgroundWorker bwr;

        RtcDateTime rtcDateTime;

        FileLogger fileLogger;

        int file_log_err_count;

        public EventHandler<AnObjectArg> OnCompleteDoWorkEventHandler;


        #endregion


        #region properties

        public int FILE_LOG_ERR_COUNT
        {
            get { return file_log_err_count; }
        }


        #endregion

        #region cstor

        public McuAdapter(string str_com_port_name_= "")
        {
            file_log_err_count = 0;

            fileLogger = new FileLogger();

            rtcDateTime = new RtcDateTime();

            uartDataBuffer = new UartDataBuffer();

            uartRawString = new UartDataString();
            uartRawString.completedSubString += on_sub_string_completed;
            uartRawString.errorSubString += on_sub_string_error;




            bwr = new BackgroundWorker();
            bwr.WorkerReportsProgress = false;
            bwr.WorkerSupportsCancellation = false;

            bwr.DoWork += do_work_parse_uart_data_into_substring;
            bwr.RunWorkerCompleted += do_work_completed;

            uart_adapter = new UartAdapter();

            uart_adapter.EventHandlerReceiveUartData += on_uart_adapter;

        }

        #endregion

        #region functions

        #region private

        private void do_work_completed(object sender, RunWorkerCompletedEventArgs e)
        {
            List<AcsDataMessage> list_adm = uartDataBuffer.GetAcsDataMessagesList();

            if (list_adm.Count > 0)
            {
                bool rec_result = false;
                int atempt_count = 5;
                file_log_err_count = 0;

                while (!rec_result)
                {
                    rec_result = fileLogger.WriteListOfStrings(list_adm);

                    if (rec_result == false)
                    {
                        file_log_err_count++;

                        if (--atempt_count == 0) rec_result = true;
                    }

                }


                //if (!fileLogger.WriteListOfStrings(list_q_str)) file_log_err_count++;
            }

            EventHandler<AnObjectArg> onCompleteDoWorkEventHandler = OnCompleteDoWorkEventHandler;

            onCompleteDoWorkEventHandler?.Invoke(this, new AnObjectArg(list_adm));


        }

        private void on_sub_string_completed(object sender, AnQueueStringArg e)
        {
            if (e.an_queue_string.IS_DATE_TIME_BIN_ASKING)
            {
                byte[] ary_dt_bytes = rtcDateTime.GetDateTimeBytesFromNow();
                uart_adapter.SendBytesToUart(ary_dt_bytes);
            }
            else if (e.an_queue_string.IS_DATE_TIME_BCD_ASKING)
            {
                byte[] ary_dt_bytes = rtcDateTime.GetDateTimeBytesFromNow();
                uart_adapter.SendBytesToUart(ary_dt_bytes);
            }
            else
            {
                uartDataBuffer.AddCompletedSubString(e.an_queue_string);
            }

        }

        private void on_sub_string_error(object sender, AnQueueStringArg e)
        {
            uartDataBuffer.AddErrSubString(e.an_queue_string);
        }

        void do_work_parse_uart_data_into_substring(object sender, DoWorkEventArgs e)
        {
            while (uartDataBuffer.IS_UART_STRING_QUEUE_INPUT_NOT_EMPTY)
            {
                uartRawString.ParseIntoSubStrings(uartDataBuffer.GetUartDataStringWithOutputCopy());
            }
        }



        private void on_uart_adapter(object sender, EventArgs e)
        {
            string uart_string = ((DataStringArg)e).str;

            Debug.Assert(!string.IsNullOrEmpty(uart_string));

            uartDataBuffer.AddUartDataString(new AnQueueString(uart_string, BUFFER_DATA_TYPE.BFDT_RAW_IO_BYTES));

            if (!bwr.IsBusy) bwr.RunWorkerAsync();
        }


        #endregion

        #region public

        public bool ConnectToPort(string str_com_port_name_)
        {
            return uart_adapter.ConnectToPort(str_com_port_name_);
        }

        public void SendStringToComPort(string str_string_to_uart)
        {
            
            uart_adapter.SendStringToUart(str_string_to_uart);

        }

        public void TestAryBytes(byte[] ary_bytes_)
        {
            //on_uart_adapter(this, new UartDataBytesArg(ary_bytes_));
        }

        public void TestDataPath(string str_)
        {
            //on_uart_adapter(this, new UartDataBytesArg(ary_bytes));
        }

        public bool OpenCurrentComPort()
        {
            return uart_adapter.OpenComPort(); 
        }

        #endregion

        #endregion

    }
}
