namespace LoL_Invisible
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
            btn_connect = new Button();
            txt_connection = new TextBox();
            btn_offline = new Button();
            btn_online = new Button();
            SuspendLayout();
            // 
            // btn_connect
            // 
            btn_connect.Location = new Point(12, 12);
            btn_connect.Name = "btn_connect";
            btn_connect.Size = new Size(112, 34);
            btn_connect.TabIndex = 0;
            btn_connect.Text = "Connect";
            btn_connect.UseVisualStyleBackColor = true;
            btn_connect.Click += btn_connect_Click;
            // 
            // txt_connection
            // 
            txt_connection.Location = new Point(130, 12);
            txt_connection.Name = "txt_connection";
            txt_connection.ReadOnly = true;
            txt_connection.Size = new Size(658, 31);
            txt_connection.TabIndex = 1;
            // 
            // btn_offline
            // 
            btn_offline.Location = new Point(12, 131);
            btn_offline.Name = "btn_offline";
            btn_offline.Size = new Size(112, 34);
            btn_offline.TabIndex = 2;
            btn_offline.Text = "Offline";
            btn_offline.UseVisualStyleBackColor = true;
            btn_offline.Click += btn_offline_Click;
            // 
            // btn_online
            // 
            btn_online.Location = new Point(12, 171);
            btn_online.Name = "btn_online";
            btn_online.Size = new Size(112, 34);
            btn_online.TabIndex = 3;
            btn_online.Text = "Online";
            btn_online.UseVisualStyleBackColor = true;
            btn_online.Click += btn_online_Click;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(10F, 25F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(btn_online);
            this.Controls.Add(btn_offline);
            this.Controls.Add(txt_connection);
            this.Controls.Add(btn_connect);
            this.Name = "Form1";
            this.Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_connect;
        private TextBox txt_connection;
        private Button btn_offline;
        private Button btn_online;
    }
}