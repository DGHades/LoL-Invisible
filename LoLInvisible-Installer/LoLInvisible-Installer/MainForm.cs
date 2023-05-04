using System.ComponentModel.DataAnnotations;

namespace LoLInvisible_Installer
{
    public partial class MainForm : Form
    {
        private Validator _Validator;
        private string ErrorText = "";
        public MainForm()
        {
            InitializeComponent();
            _Validator = new Validator();
            BrowserDialog.InitialDirectory = "C:\\Program Files";
            textBox_InstallPath.Text = "C:\\Program Files";
        }

        private void btn_Other_Click(object sender, EventArgs e)
        {
            if (BrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBox_InstallPath.Text = BrowserDialog.SelectedPath;
            }
        }

        private void btn_Install_Click(object sender, EventArgs e)
        {
            if (!_Validator.ValidateData(ref ErrorText, textBox_InstallPath.Text))
            {
                ErrorMsgForm errorForm = new ErrorMsgForm(ErrorText);
                if (errorForm.ShowDialog() == DialogResult.OK)
                {
                    return;
                }
            }

            ScriptCreator scriptCreator = new ScriptCreator(textBox_InstallPath.Text);
            scriptCreator.CreateBat();
            scriptCreator.CreatePowershellScript();
        }
    }
}