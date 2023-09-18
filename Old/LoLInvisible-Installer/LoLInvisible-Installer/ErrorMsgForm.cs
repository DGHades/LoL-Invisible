using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoLInvisible_Installer
{
    public partial class ErrorMsgForm : Form
    {
        public ErrorMsgForm(string pErrorMsg)
        {
            InitializeComponent();
            richTextBox_ErrorMsg.Text = pErrorMsg;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ErrorMsgForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
