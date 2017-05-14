using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;


namespace ObjLibrary
{
    public class UartAdapter
    {
        #region fields

        SerialPort serialPort;

        string com_port_name;

        public event EventHandler EventHandlerReceiveUartData;

        #endregion

        #region properties

        public bool IS_COM_PORT_CREATED
        {
            get { return serialPort != null; }
        }

        public bool IS_COM_PORT_OPENED
        {
            get
            {
                return (IS_COM_PORT_CREATED) ? serialPort.IsOpen : false;
            }
        }

        public bool IS_COM_PORT_CLOSED
        {
            get
            {
                return ((IS_COM_PORT_CREATED) && (!IS_COM_PORT_OPENED));
            }
        }
        
        public string COM_PORT_NAME
        {
            get { return com_port_name; }
        }

        #endregion

        #region cstor

        public UartAdapter(string com_port_name_ = "")
        {
            if (!string.IsNullOrEmpty(com_port_name_))
            {
                ConnectToPort(com_port_name_);
            }
        }
        
        #endregion

        #region functions

        public void SendStringToUart(string str_data_)
        {
            if (open_com_port())
            {
                serialPort.Write(str_data_);
            }
        }
        
        public void SendBytesToUart(byte[] ary_bytes_)
        {
            open_com_port();

            serialPort.Write(ary_bytes_, 0, ary_bytes_.Count());
        }
        


        private void serialPort_ReceiveData(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;

            string str = sp.ReadExisting();

            if (!String.IsNullOrEmpty(str))
            {
                EventHandlerReceiveUartData?.Invoke(this, new DataStringArg(str));
            }
        }

        private void close_com_port()
        {
            if (serialPort != null)
            {
                serialPort.Close();
            }

        }

        public bool OpenComPort()
        {

            if (IS_COM_PORT_OPENED)
                return true;
            else if (!IS_COM_PORT_CREATED) return false;
            else if (IS_COM_PORT_CREATED || IS_COM_PORT_CLOSED)
                return open_com_port();
            else return false;
        }


        private bool open_com_port()
        {
            // UnauthorizedAccessException
            // ArgumentOutOfRangeException
            // ArgumentException
            // IOException
            // InvalidOperationException

            if (IS_COM_PORT_OPENED) return true;
            else if (!IS_COM_PORT_CREATED) return false;
            else
            {
                try { serialPort.Open(); }
                catch (Exception e)
                {

                }
            }
            return IS_COM_PORT_OPENED;
        }

        public bool ConnectToPort(string str_com_port_name_)
        {
            com_port_name = str_com_port_name_;

            if (IS_COM_PORT_OPENED)
            {
                close_com_port();
            }
                       
            serialPort?.Dispose();

            // Исключения:
            // T:System.IO.IOException:
            // Не удается найти или открыть указанный порт.

            try
            {
                serialPort = new SerialPort(com_port_name);
            }
            catch (System.IO.IOException e)
            {
                serialPort = null;
            }

            if (IS_COM_PORT_CREATED)
            {
                serialPort.DataReceived += serialPort_ReceiveData;
            }

            return IS_COM_PORT_CREATED;
        }

        #endregion

    }
}
