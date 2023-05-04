namespace LoLInvisible_Installer
{
    partial class MainForm
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
            CB_CreateDesktopShortcut = new CheckBox();
            InstSettings_Lbl = new Label();
            InstSuccess_Lbl = new Label();
            CloseInstaller_Btn = new Button();
            SuspendLayout();
            // 
            // btn_Other
            // 
            btn_Other.Location = new Point(676, 97);
            btn_Other.Name = "btn_Other";
            btn_Other.Size = new Size(112, 34);
            btn_Other.TabIndex = 0;
            btn_Other.Text = "Other...";
            btn_Other.UseVisualStyleBackColor = true;
            btn_Other.Click += btn_Other_Click;
            // 
            // textBox_InstallPath
            // 
            textBox_InstallPath.Location = new Point(12, 97);
            textBox_InstallPath.Name = "textBox_InstallPath";
            textBox_InstallPath.ReadOnly = true;
            textBox_InstallPath.Size = new Size(658, 31);
            textBox_InstallPath.TabIndex = 1;
            // 
            // FilePath_Lbl
            // 
            FilePath_Lbl.AutoSize = true;
            FilePath_Lbl.Location = new Point(12, 69);
            FilePath_Lbl.Name = "FilePath_Lbl";
            FilePath_Lbl.Size = new Size(160, 25);
            FilePath_Lbl.TabIndex = 2;
            FilePath_Lbl.Text = "Choose a File Path:";
            // 
            // btn_Install
            // 
            btn_Install.Location = new Point(676, 137);
            btn_Install.Name = "btn_Install";
            btn_Install.Size = new Size(112, 34);
            btn_Install.TabIndex = 3;
            btn_Install.Text = "Install";
            btn_Install.UseVisualStyleBackColor = true;
            btn_Install.Click += btn_Install_Click;
            // 
            // CB_CreateDesktopShortcut
            // 
            CB_CreateDesktopShortcut.AutoSize = true;
            CB_CreateDesktopShortcut.Location = new Point(12, 37);
            CB_CreateDesktopShortcut.Name = "CB_CreateDesktopShortcut";
            CB_CreateDesktopShortcut.Size = new Size(232, 29);
            CB_CreateDesktopShortcut.TabIndex = 4;
            CB_CreateDesktopShortcut.Text = "Create Desktop Shortcut";
            CB_CreateDesktopShortcut.UseVisualStyleBackColor = true;
            // 
            // InstSettings_Lbl
            // 
            InstSettings_Lbl.AutoSize = true;
            InstSettings_Lbl.Location = new Point(12, 9);
            InstSettings_Lbl.Name = "InstSettings_Lbl";
            InstSettings_Lbl.Size = new Size(171, 25);
            InstSettings_Lbl.TabIndex = 5;
            InstSettings_Lbl.Text = "Installation Settings:";
            // 
            // InstSuccess_Lbl
            // 
            InstSuccess_Lbl.AutoSize = true;
            InstSuccess_Lbl.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            InstSuccess_Lbl.ForeColor = Color.OliveDrab;
            InstSuccess_Lbl.Location = new Point(217, 9);
            InstSuccess_Lbl.Name = "InstSuccess_Lbl";
            InstSuccess_Lbl.Size = new Size(230, 28);
            InstSuccess_Lbl.TabIndex = 6;
            InstSuccess_Lbl.Text = "Installation Successful!";
            InstSuccess_Lbl.Visible = false;
            // 
            // CloseInstaller_Btn
            // 
            CloseInstaller_Btn.Location = new Point(244, 37);
            CloseInstaller_Btn.Name = "CloseInstaller_Btn";
            CloseInstaller_Btn.Size = new Size(174, 34);
            CloseInstaller_Btn.TabIndex = 7;
            CloseInstaller_Btn.Text = "Close Installer";
            CloseInstaller_Btn.UseVisualStyleBackColor = true;
            CloseInstaller_Btn.Visible = false;
            CloseInstaller_Btn.Click += CloseInstaller_Btn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 180);
            Controls.Add(CloseInstaller_Btn);
            Controls.Add(InstSuccess_Lbl);
            Controls.Add(InstSettings_Lbl);
            Controls.Add(CB_CreateDesktopShortcut);
            Controls.Add(btn_Install);
            Controls.Add(FilePath_Lbl);
            Controls.Add(textBox_InstallPath);
            Controls.Add(btn_Other);
            Name = "MainForm";
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
        private CheckBox CB_CreateDesktopShortcut;
        private Label InstSettings_Lbl;
        private Label InstSuccess_Lbl;
        private Button CloseInstaller_Btn;
    }
}