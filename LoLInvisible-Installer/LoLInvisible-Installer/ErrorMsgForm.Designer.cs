namespace LoLInvisible_Installer
{
    partial class ErrorMsgForm
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
            btn_OK = new Button();
            Error_Lbl = new Label();
            richTextBox_ErrorMsg = new RichTextBox();
            SuspendLayout();
            // 
            // btn_OK
            // 
            btn_OK.Location = new Point(676, 406);
            btn_OK.Name = "btn_OK";
            btn_OK.Size = new Size(112, 34);
            btn_OK.TabIndex = 5;
            btn_OK.Text = "OK";
            btn_OK.UseVisualStyleBackColor = true;
            btn_OK.Click += btn_OK_Click;
            // 
            // Error_Lbl
            // 
            Error_Lbl.AutoSize = true;
            Error_Lbl.ForeColor = Color.Red;
            Error_Lbl.Location = new Point(12, 11);
            Error_Lbl.Name = "Error_Lbl";
            Error_Lbl.Size = new Size(429, 25);
            Error_Lbl.TabIndex = 4;
            Error_Lbl.Text = "Oops! An Error occured! The Error Message is below:";
            // 
            // richTextBox_ErrorMsg
            // 
            richTextBox_ErrorMsg.Location = new Point(12, 52);
            richTextBox_ErrorMsg.Name = "richTextBox_ErrorMsg";
            richTextBox_ErrorMsg.ReadOnly = true;
            richTextBox_ErrorMsg.Size = new Size(776, 347);
            richTextBox_ErrorMsg.TabIndex = 3;
            richTextBox_ErrorMsg.Text = "";
            // 
            // ErrorMsgForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_OK);
            Controls.Add(Error_Lbl);
            Controls.Add(richTextBox_ErrorMsg);
            Name = "ErrorMsgForm";
            Text = "Error";
            FormClosed += ErrorMsgForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_OK;
        private Label Error_Lbl;
        private RichTextBox richTextBox_ErrorMsg;
    }
}