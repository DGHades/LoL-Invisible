namespace LoLInvisible_Installer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Other = new Button();
            textBox_InstallPath = new TextBox();
            BrowserDialog = new FolderBrowserDialog();
            FilePath_Lbl = new Label();
            btn_Install = new Button();
            SuspendLayout();
            // 
            // btn_Other
            // 
            btn_Other.Location = new Point(676, 371);
            btn_Other.Name = "btn_Other";
            btn_Other.Size = new Size(112, 34);
            btn_Other.TabIndex = 0;
            btn_Other.Text = "Other...";
            btn_Other.UseVisualStyleBackColor = true;
            btn_Other.Click += btn_Other_Click;
            // 
            // textBox_InstallPath
            // 
            textBox_InstallPath.Location = new Point(12, 371);
            textBox_InstallPath.Name = "textBox_InstallPath";
            textBox_InstallPath.ReadOnly = true;
            textBox_InstallPath.Size = new Size(658, 31);
            textBox_InstallPath.TabIndex = 1;
            // 
            // FilePath_Lbl
            // 
            FilePath_Lbl.AutoSize = true;
            FilePath_Lbl.Location = new Point(12, 343);
            FilePath_Lbl.Name = "FilePath_Lbl";
            FilePath_Lbl.Size = new Size(160, 25);
            FilePath_Lbl.TabIndex = 2;
            FilePath_Lbl.Text = "Choose a File Path:";
            // 
            // btn_Install
            // 
            btn_Install.Location = new Point(676, 411);
            btn_Install.Name = "btn_Install";
            btn_Install.Size = new Size(112, 34);
            btn_Install.TabIndex = 3;
            btn_Install.Text = "Install";
            btn_Install.UseVisualStyleBackColor = true;
            btn_Install.Click += btn_Install_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Install);
            Controls.Add(FilePath_Lbl);
            Controls.Add(textBox_InstallPath);
            Controls.Add(btn_Other);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_Other;
        private TextBox textBox_InstallPath;
        private FolderBrowserDialog BrowserDialog;
        private Label FilePath_Lbl;
        private Button btn_Install;
    }
}