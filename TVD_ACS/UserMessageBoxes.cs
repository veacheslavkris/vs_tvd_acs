using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVD_ACS
{
    public static class UserMessageBoxes
    {
        public static void ErrorMessageBox(string message_, string caption_ = "ERROR")
        {
            MessageBox.Show(message_, caption_, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void InfoMessageBox(string message_, string caption_ = "INFO")
        {
            MessageBox.Show(message_, caption_, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult ConfirmationMessageBox(string message_, string caption_ = "CONFIRMATION")
        {
            return MessageBox.Show(message_, caption_, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        public static void WarningMessageBox(string message_, string caption_ = "WARNING")
        {
            MessageBox.Show(message_, caption_, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


    }
}
