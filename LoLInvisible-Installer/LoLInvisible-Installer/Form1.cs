namespace LoLInvisible_Installer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        }
    }
}