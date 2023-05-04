using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoLInvisible_Installer
{
    public partial class InstallationForm : Form
    {
        private int _CurrStep = 0;
        private Validator _Validator;
        private string ErrorText = "";
        private TextBox _TextBox_InstallPath;
        private CheckBox _CB_CreateDesktopShortcut;
        private bool WasSuccessfull = false;

        public InstallationForm(int pSteps, TextBox pTextBox_InstallPath, CheckBox pCB_CreateDesktopShortcut)
        {
            InitializeComponent();
            _Validator = new Validator();
            progressBar_InstallStep.Maximum = pSteps;
            _TextBox_InstallPath = pTextBox_InstallPath;
            _CB_CreateDesktopShortcut = pCB_CreateDesktopShortcut;
        }

        public void StartInstallation()
        {
            this.Show();
            NextStep("Validating Path...");
            if (!_Validator.ValidatePath(ref ErrorText, _TextBox_InstallPath.Text))
            {
                Close();
                ErrorMsgForm errorForm = new ErrorMsgForm(ErrorText);
                if (errorForm.ShowDialog() == DialogResult.OK)
                {
                    WasSuccessfull = false;
                    this.Close();
                    return;
                }
            }

            ScriptCreator scriptCreator = new ScriptCreator(_TextBox_InstallPath.Text);
            NextStep("Creating .Bat...");
            scriptCreator.CreateBat();
            NextStep("Creating .ps1...");
            scriptCreator.CreatePowershellScript();

            NextStep("Setting up additional Settings...");
            Extras _Extras = new Extras(_TextBox_InstallPath.Text, _CB_CreateDesktopShortcut.Checked);
            WasSuccessfull = true;
            this.Close();
        }

        public void NextStep(string pCurrentStep)
        {
            _CurrStep++;
            InstallationSteb_Lbl.Text = pCurrentStep;
            progressBar_InstallStep.Value = _CurrStep;
        }

        private void InstallationForm_Load(object sender, EventArgs e)
        {

        }

        private void InstallationForm_Shown(object sender, EventArgs e)
        {
            StartInstallation();
        }

        private void InstallationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (WasSuccessfull)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
