using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using ObjLibrary;

//using System.Timers;


namespace TVD_ACS
{
    public partial class FormMain : Form
    {
        #region fields

        McuAdapter mcu_adapter;

        delegate void BindDataCallback(List<AcsDataMessage> lqs);


        BindingList<AcsDataMessage> blist_q_acs_messages;



        #endregion

        #region cstor

        public FormMain()
        {
            InitializeComponent();
        }
        
        #endregion

        #region functions
        
        private void FormMain_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            blist_q_acs_messages = new BindingList<AcsDataMessage>();

            scan_available_uart_ports();

            mcu_adapter = new McuAdapter();

            mcu_adapter.OnCompleteDoWorkEventHandler += on_do_work_uart_receive_completed;

            bsAcsDataMessages.DataSource = blist_q_acs_messages;

            Cursor.Current = Cursors.Default;
        }

        void scan_available_uart_ports()
        {
            toolStripComboBoxUARTS.ComboBox.Items.Clear();

            foreach (string s in SerialPort.GetPortNames())
            {
                toolStripComboBoxUARTS.ComboBox.Items.Add(s);

            }
        }

        private void toolStripBtnUartCnct_Click(object sender, EventArgs e)
        {
            string str_com_port_name = string.Empty;

            if (toolStripComboBoxUARTS.ComboBox.SelectedItem == null)
            {
                toolStripStatusLabelInfo.Text = "Com Port не выбран";
            }
            else
            {
                str_com_port_name = toolStripComboBoxUARTS.ComboBox.SelectedItem.ToString();
                if (connect_to_com_port(str_com_port_name))
                {
                    mcu_adapter.OpenCurrentComPort();
                }
            }
        }

        private bool connect_to_com_port(string str_com_port_name_)
        {
            bool result;

            if (mcu_adapter.ConnectToPort(str_com_port_name_))
            {
                toolStripStatusLabelInfo.Text = String.Format("{0} is created", str_com_port_name_);
                result = true;
            }
            else
            {
                toolStripStatusLabelInfo.Text = String.Format("{0} is NOT created", str_com_port_name_);
                result = false;

            }

            return result;
        }

        private void toolStripBtnScanUARTS_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            scan_available_uart_ports();

            Cursor.Current = Cursors.Default;
        }

        private void toolStripBtnStart_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripBtnStop_Click(object sender, EventArgs e)
        {

        }

        private void toolStripBtnMeasure_Click(object sender, EventArgs e)
        {


        }

        private void toolStripButtonSyncTime_Click(object sender, EventArgs e)
        {
            
            //RtcDateTime rtc_date_time = new RtcDateTime();

            //byte[] ary = rtc_date_time.GetDateTimeBytesFromNow();


        }
    
        private void btnSend_Click(object sender, EventArgs e)
        {

            //mcu_adapter.SendStringToComPort(textBoxForUart.Text);
            mcu_adapter.TestDataPath(textBoxForUart.Text);

        }

        private void toolStripBtnTest_Click(object sender, EventArgs e)
        {
            RtcDateTime rtc = new RtcDateTime();
            byte[] ary_bcd = rtc.GetDateTimeBytesFromNow();

            int x = 0;

        }


        void on_do_work_uart_receive_completed(object sender, AnObjectArg e)
        {



            List<AcsDataMessage> lqs = ((List<AcsDataMessage>)e.an_object);

            show_list(lqs);




        }


        void show_list(List<AcsDataMessage> lqs)
        {
            if (dgw.InvokeRequired)
            {
                BindDataCallback cb = new BindDataCallback(show_list);
                dgw.Invoke(cb, new object[] { lqs });

            }
            else
            {
                foreach (AcsDataMessage qs in lqs) blist_q_acs_messages.Add(qs);
                bsAcsDataMessages.MoveLast();

            }


        }

        //void add_list_box_text(ListBox list_box_, string str_)
        //{
        //    if (list_box_.InvokeRequired)
        //    {
        //        AddListBoxStringCallback cb = new AddListBoxStringCallback(add_list_box_text);
        //        list_box_.Invoke(cb, new object[] { list_box_, str_ });
        //    }
        //    else
        //    {
        //        list_box_.Items.Add(str_);
        //    }
        //}



        #endregion

        private void toolStripBtnTest2_Click(object sender, EventArgs e)
        {
            //dgw.DataSource = null;
            //SignType st = SignType.CreateSignType(SIGN_POSITION_TYPE.SPT_START_ACS_NUM);

            #region 0006911775 [ 3:04:55 05.02.2017 ]
            //0x3C '<'
            //0x3D '='
            //0x72 'r'
            //0x64 'd'
            //0x31 '1'
            //0x24 '$'
            //0x03
            //0x04
            //0x31 '1'
            //0x25 '%'
            //0x05
            //0x02
            //0x11
            //0x40 '@'
            //0x0B
            //0x23 '#'
            //0x00
            //0x00
            //0x69 'i'
            //0x77 'w'
            //0x1F
            //0x21 '!' 
            #endregion

            ////0x3C,0x3D,0x72,0x64,0x31,0x24,0x03,0x03,0x31,0x25,0x05,0x02,0x11,0x40,0x0B,0x23,0x00,0x00,0x69,0x77,0x1F,0x21

            byte[] ary = { 0x3C, 0x3D, 0x72, 0x64, 0x31, 0x24, 0x03, 0x04, 0x31, 0x25, 0x05, 0x02, 0x11, 0x40, 0x0B, 0x23, 0x00, 0x00, 0x69, 0x77, 0x1F, 0x21 };

            //SсhemaAcsMessageParser schm = new SсhemaAcsMessageParser();
            mcu_adapter.TestAryBytes(ary);


            //AcsDataMessage dm = schm.ParseMessageString(ary);

        }
    }
}
