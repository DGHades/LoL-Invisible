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
            CB_CreateDesktopShortcut.Checked = true;
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
            InstallationForm installationForm = new InstallationForm(4, textBox_InstallPath, CB_CreateDesktopShortcut);
            if (installationForm.ShowDialog() == DialogResult.OK)
            {
                InstallationSuccessfull();
            }
            else
            {
                InstallationUnSuccessfull();
            }
        }

        private void InstallationSuccessfull()
        {
            InstSettings_Lbl.Visible = false;
            CB_CreateDesktopShortcut.Visible = false;
            textBox_InstallPath.Visible = false;
            btn_Install.Visible = false;
            btn_Other.Visible = false;
            FilePath_Lbl.Visible = false;

            CloseInstaller_Btn.Visible = true;
            InstSuccess_Lbl.Visible = true;
        }

        private void InstallationUnSuccessfull()
        {
            InstSettings_Lbl.Visible = false;
            CB_CreateDesktopShortcut.Visible = false;
            textBox_InstallPath.Visible = false;
            btn_Install.Visible = false;
            btn_Other.Visible = false;
            FilePath_Lbl.Visible = false;

            CloseInstaller_Btn.Visible = true;
            InstSuccess_Lbl.Visible = true;
            InstSuccess_Lbl.ForeColor = System.Drawing.Color.Red;
            InstSuccess_Lbl.Text = "Installation Unsuccesfull.";
        }

        private void CloseInstaller_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}