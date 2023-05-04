namespace LoLInvisible_Installer
{
    partial class InstallationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            InstallationSteb_Lbl = new Label();
            InstallStepCaption_Lbl = new Label();
            progressBar_InstallStep = new ProgressBar();
            SuspendLayout();
            // 
            // InstallationSteb_Lbl
            // 
            InstallationSteb_Lbl.AutoSize = true;
            InstallationSteb_Lbl.Location = new Point(12, 34);
            InstallationSteb_Lbl.Name = "InstallationSteb_Lbl";
            InstallationSteb_Lbl.Size = new Size(0, 25);
            InstallationSteb_Lbl.TabIndex = 11;
            // 
            // InstallStepCaption_Lbl
            // 
            InstallStepCaption_Lbl.AutoSize = true;
            InstallStepCaption_Lbl.Location = new Point(12, 9);
            InstallStepCaption_Lbl.Name = "InstallStepCaption_Lbl";
            InstallStepCaption_Lbl.Size = new Size(142, 25);
            InstallStepCaption_Lbl.TabIndex = 10;
            InstallStepCaption_Lbl.Text = "Installation Step:";
            // 
            // progressBar_InstallStep
            // 
            progressBar_InstallStep.Location = new Point(12, 62);
            progressBar_InstallStep.Name = "progressBar_InstallStep";
            progressBar_InstallStep.Size = new Size(776, 34);
            progressBar_InstallStep.TabIndex = 9;
            // 
            // InstallationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 108);
            Controls.Add(InstallationSteb_Lbl);
            Controls.Add(InstallStepCaption_Lbl);
            Controls.Add(progressBar_InstallStep);
            Name = "InstallationForm";
            Text = "InstallationForm";
            FormClosed += InstallationForm_FormClosed;
            Load += InstallationForm_Load;
            Shown += InstallationForm_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label InstallationSteb_Lbl;
        private Label InstallStepCaption_Lbl;
        private ProgressBar progressBar_InstallStep;
    }
}