namespace TVD_ACS
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnScanUARTS = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBoxUARTS = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnUartCnct = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripBtnStart = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnMeasure = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSyncTime = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnTest = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnTest2 = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgw = new System.Windows.Forms.DataGridView();
            this.bsAcsDataMessages = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.label_err_cnt = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.textBoxForUart = new System.Windows.Forms.TextBox();
            this.LOG_TIME_DATE_STRING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEADERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACS_TIME_DATE_STRING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STR_IX_NUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STR_ACS_NUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStripMain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAcsDataMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelInfo});
            this.statusStripMain.Location = new System.Drawing.Point(0, 405);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(906, 22);
            this.statusStripMain.TabIndex = 14;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabelInfo
            // 
            this.toolStripStatusLabelInfo.Name = "toolStripStatusLabelInfo";
            this.toolStripStatusLabelInfo.Size = new System.Drawing.Size(133, 17);
            this.toolStripStatusLabelInfo.Text = "toolStripStatusLabelInfo";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnScanUARTS,
            this.toolStripSeparator2,
            this.toolStripComboBoxUARTS,
            this.toolStripSeparator1,
            this.toolStripBtnUartCnct,
            this.toolStripSeparator3,
            this.toolStripLabel1,
            this.toolStripBtnStart,
            this.toolStripSeparator4,
            this.toolStripBtnStop,
            this.toolStripSeparator5,
            this.toolStripBtnMeasure,
            this.toolStripSeparator6,
            this.toolStripButtonSyncTime,
            this.toolStripSeparator7,
            this.toolStripBtnTest,
            this.toolStripSeparator8,
            this.toolStripBtnTest2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(906, 25);
            this.toolStrip1.TabIndex = 45;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtnScanUARTS
            // 
            this.toolStripBtnScanUARTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnScanUARTS.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnScanUARTS.Image")));
            this.toolStripBtnScanUARTS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnScanUARTS.Name = "toolStripBtnScanUARTS";
            this.toolStripBtnScanUARTS.Size = new System.Drawing.Size(73, 22);
            this.toolStripBtnScanUARTS.Text = "scan UARTS";
            this.toolStripBtnScanUARTS.Click += new System.EventHandler(this.toolStripBtnScanUARTS_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripComboBoxUARTS
            // 
            this.toolStripComboBoxUARTS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxUARTS.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBoxUARTS.Name = "toolStripComboBoxUARTS";
            this.toolStripComboBoxUARTS.Size = new System.Drawing.Size(200, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripBtnUartCnct
            // 
            this.toolStripBtnUartCnct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnUartCnct.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnUartCnct.Image")));
            this.toolStripBtnUartCnct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnUartCnct.Name = "toolStripBtnUartCnct";
            this.toolStripBtnUartCnct.Size = new System.Drawing.Size(79, 22);
            this.toolStripBtnUartCnct.Text = "подключить";
            this.toolStripBtnUartCnct.Click += new System.EventHandler(this.toolStripBtnUartCnct_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(75, 22);
            this.toolStripLabel1.Text = "Автоматика:";
            // 
            // toolStripBtnStart
            // 
            this.toolStripBtnStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnStart.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnStart.Image")));
            this.toolStripBtnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnStart.Name = "toolStripBtnStart";
            this.toolStripBtnStart.Size = new System.Drawing.Size(42, 22);
            this.toolStripBtnStart.Text = "Старт";
            this.toolStripBtnStart.Click += new System.EventHandler(this.toolStripBtnStart_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripBtnStop
            // 
            this.toolStripBtnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnStop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnStop.Image")));
            this.toolStripBtnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnStop.Name = "toolStripBtnStop";
            this.toolStripBtnStop.Size = new System.Drawing.Size(38, 22);
            this.toolStripBtnStop.Text = "Стоп";
            this.toolStripBtnStop.Click += new System.EventHandler(this.toolStripBtnStop_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripBtnMeasure
            // 
            this.toolStripBtnMeasure.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnMeasure.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnMeasure.Image")));
            this.toolStripBtnMeasure.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnMeasure.Name = "toolStripBtnMeasure";
            this.toolStripBtnMeasure.Size = new System.Drawing.Size(65, 22);
            this.toolStripBtnMeasure.Text = "Измерить";
            this.toolStripBtnMeasure.Click += new System.EventHandler(this.toolStripBtnMeasure_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonSyncTime
            // 
            this.toolStripButtonSyncTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSyncTime.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSyncTime.Image")));
            this.toolStripButtonSyncTime.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSyncTime.Name = "toolStripButtonSyncTime";
            this.toolStripButtonSyncTime.Size = new System.Drawing.Size(65, 22);
            this.toolStripButtonSyncTime.Text = "sync. time";
            this.toolStripButtonSyncTime.Click += new System.EventHandler(this.toolStripButtonSyncTime_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripBtnTest
            // 
            this.toolStripBtnTest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnTest.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnTest.Image")));
            this.toolStripBtnTest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnTest.Name = "toolStripBtnTest";
            this.toolStripBtnTest.Size = new System.Drawing.Size(30, 22);
            this.toolStripBtnTest.Text = "test";
            this.toolStripBtnTest.Click += new System.EventHandler(this.toolStripBtnTest_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripBtnTest2
            // 
            this.toolStripBtnTest2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnTest2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnTest2.Image")));
            this.toolStripBtnTest2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnTest2.Name = "toolStripBtnTest2";
            this.toolStripBtnTest2.Size = new System.Drawing.Size(41, 22);
            this.toolStripBtnTest2.Text = "test_2";
            this.toolStripBtnTest2.Click += new System.EventHandler(this.toolStripBtnTest2_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgw);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(906, 380);
            this.splitContainer1.SplitterDistance = 390;
            this.splitContainer1.TabIndex = 46;
            // 
            // dgw
            // 
            this.dgw.AutoGenerateColumns = false;
            this.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LOG_TIME_DATE_STRING,
            this.rEADERDataGridViewTextBoxColumn,
            this.ACS_TIME_DATE_STRING,
            this.STR_IX_NUMBER,
            this.STR_ACS_NUMBER});
            this.dgw.DataSource = this.bsAcsDataMessages;
            this.dgw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw.Location = new System.Drawing.Point(0, 0);
            this.dgw.Name = "dgw";
            this.dgw.Size = new System.Drawing.Size(390, 380);
            this.dgw.TabIndex = 0;
            // 
            // bsAcsDataMessages
            // 
            this.bsAcsDataMessages.DataSource = typeof(ObjLibrary.AcsDataMessage);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.label_err_cnt);
            this.splitContainer2.Panel1.Controls.Add(this.btnSend);
            this.splitContainer2.Panel1.Controls.Add(this.textBoxForUart);
            this.splitContainer2.Size = new System.Drawing.Size(512, 380);
            this.splitContainer2.SplitterDistance = 120;
            this.splitContainer2.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ошибки записи";
            // 
            // label_err_cnt
            // 
            this.label_err_cnt.AutoSize = true;
            this.label_err_cnt.Location = new System.Drawing.Point(101, 81);
            this.label_err_cnt.Name = "label_err_cnt";
            this.label_err_cnt.Size = new System.Drawing.Size(52, 13);
            this.label_err_cnt.TabIndex = 2;
            this.label_err_cnt.Text = "err_count";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(346, 36);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "отправить";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // textBoxForUart
            // 
            this.textBoxForUart.Location = new System.Drawing.Point(14, 38);
            this.textBoxForUart.Name = "textBoxForUart";
            this.textBoxForUart.Size = new System.Drawing.Size(326, 20);
            this.textBoxForUart.TabIndex = 0;
            // 
            // LOG_TIME_DATE_STRING
            // 
            this.LOG_TIME_DATE_STRING.DataPropertyName = "LOG_TIME_DATE_STRING";
            this.LOG_TIME_DATE_STRING.HeaderText = "время записи";
            this.LOG_TIME_DATE_STRING.Name = "LOG_TIME_DATE_STRING";
            this.LOG_TIME_DATE_STRING.ReadOnly = true;
            this.LOG_TIME_DATE_STRING.Width = 130;
            // 
            // rEADERDataGridViewTextBoxColumn
            // 
            this.rEADERDataGridViewTextBoxColumn.DataPropertyName = "READER";
            this.rEADERDataGridViewTextBoxColumn.HeaderText = "ист";
            this.rEADERDataGridViewTextBoxColumn.Name = "rEADERDataGridViewTextBoxColumn";
            this.rEADERDataGridViewTextBoxColumn.ReadOnly = true;
            this.rEADERDataGridViewTextBoxColumn.Width = 50;
            // 
            // ACS_TIME_DATE_STRING
            // 
            this.ACS_TIME_DATE_STRING.DataPropertyName = "ACS_TIME_DATE_STRING";
            this.ACS_TIME_DATE_STRING.HeaderText = "время события";
            this.ACS_TIME_DATE_STRING.Name = "ACS_TIME_DATE_STRING";
            this.ACS_TIME_DATE_STRING.ReadOnly = true;
            this.ACS_TIME_DATE_STRING.Width = 130;
            // 
            // STR_IX_NUMBER
            // 
            this.STR_IX_NUMBER.DataPropertyName = "STR_IX_NUMBER";
            this.STR_IX_NUMBER.HeaderText = "индекс";
            this.STR_IX_NUMBER.Name = "STR_IX_NUMBER";
            this.STR_IX_NUMBER.ReadOnly = true;
            this.STR_IX_NUMBER.Width = 50;
            // 
            // STR_ACS_NUMBER
            // 
            this.STR_ACS_NUMBER.DataPropertyName = "STR_ACS_NUMBER";
            this.STR_ACS_NUMBER.HeaderText = "карта";
            this.STR_ACS_NUMBER.Name = "STR_ACS_NUMBER";
            this.STR_ACS_NUMBER.ReadOnly = true;
            this.STR_ACS_NUMBER.Width = 150;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 427);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStripMain);
            this.Name = "FormMain";
            this.Text = "UART";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAcsDataMessages)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelInfo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxUARTS;
        private System.Windows.Forms.ToolStripButton toolStripBtnScanUARTS;
        private System.Windows.Forms.ToolStripButton toolStripBtnUartCnct;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripBtnStart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripBtnStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripBtnMeasure;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButtonSyncTime;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox textBoxForUart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton toolStripBtnTest;
        private System.Windows.Forms.DataGridView dgw;
        private System.Windows.Forms.BindingSource bsAcsDataMessages;
        private System.Windows.Forms.ToolStripButton toolStripBtnTest2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_err_cnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOG_TIME_DATE_STRING;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEADERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACS_TIME_DATE_STRING;
        private System.Windows.Forms.DataGridViewTextBoxColumn STR_IX_NUMBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn STR_ACS_NUMBER;
    }
}

