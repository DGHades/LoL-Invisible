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
            txt_currentStatus = new TextBox();
            label1 = new Label();
            btn_away = new Button();
            btn_exit = new Button();
            SuspendLayout();
            // 
            // btn_connect
            // 
            btn_connect.BackColor = Color.FromArgb(64, 64, 64);
            btn_connect.FlatStyle = FlatStyle.Flat;
            btn_connect.ForeColor = Color.White;
            btn_connect.Location = new Point(8, 13);
            btn_connect.Name = "btn_connect";
            btn_connect.Size = new Size(112, 34);
            btn_connect.TabIndex = 0;
            btn_connect.Text = "Connect";
            btn_connect.UseVisualStyleBackColor = false;
            btn_connect.Click += btn_connect_Click;
            // 
            // txt_connection
            // 
            txt_connection.BorderStyle = BorderStyle.None;
            txt_connection.ForeColor = Color.White;
            txt_connection.Location = new Point(126, 13);
            txt_connection.Name = "txt_connection";
            txt_connection.ReadOnly = true;
            txt_connection.Size = new Size(197, 24);
            txt_connection.TabIndex = 1;
            // 
            // btn_offline
            // 
            btn_offline.BackColor = Color.FromArgb(64, 64, 64);
            btn_offline.FlatStyle = FlatStyle.Flat;
            btn_offline.ForeColor = Color.White;
            btn_offline.Location = new Point(244, 96);
            btn_offline.Name = "btn_offline";
            btn_offline.Size = new Size(112, 34);
            btn_offline.TabIndex = 2;
            btn_offline.Text = "Offline";
            btn_offline.UseVisualStyleBackColor = false;
            btn_offline.Click += btn_offline_Click;
            // 
            // btn_online
            // 
            btn_online.BackColor = Color.FromArgb(64, 64, 64);
            btn_online.FlatStyle = FlatStyle.Flat;
            btn_online.ForeColor = Color.White;
            btn_online.Location = new Point(8, 96);
            btn_online.Name = "btn_online";
            btn_online.Size = new Size(112, 34);
            btn_online.TabIndex = 3;
            btn_online.Text = "Online";
            btn_online.UseVisualStyleBackColor = false;
            btn_online.Click += btn_online_Click;
            // 
            // txt_currentStatus
            // 
            txt_currentStatus.BackColor = Color.FromArgb(0, 192, 0);
            txt_currentStatus.BorderStyle = BorderStyle.None;
            txt_currentStatus.Enabled = false;
            txt_currentStatus.Location = new Point(141, 50);
            txt_currentStatus.Name = "txt_currentStatus";
            txt_currentStatus.ReadOnly = true;
            txt_currentStatus.Size = new Size(31, 24);
            txt_currentStatus.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(8, 50);
            label1.Name = "label1";
            label1.Size = new Size(127, 25);
            label1.TabIndex = 5;
            label1.Text = "Current Status:";
            // 
            // btn_away
            // 
            btn_away.BackColor = Color.FromArgb(64, 64, 64);
            btn_away.FlatStyle = FlatStyle.Flat;
            btn_away.ForeColor = Color.White;
            btn_away.Location = new Point(126, 96);
            btn_away.Name = "btn_away";
            btn_away.Size = new Size(112, 34);
            btn_away.TabIndex = 6;
            btn_away.Text = "Away";
            btn_away.UseVisualStyleBackColor = false;
            btn_away.Click += btn_away_Click;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.FromArgb(192, 0, 0);
            btn_exit.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            btn_exit.FlatAppearance.BorderSize = 0;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.Location = new Point(329, 12);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(49, 48);
            btn_exit.TabIndex = 7;
            btn_exit.Text = "X";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(10F, 25F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(64, 64, 64);
            this.ClientSize = new Size(392, 152);
            this.Controls.Add(btn_exit);
            this.Controls.Add(btn_away);
            this.Controls.Add(label1);
            this.Controls.Add(txt_currentStatus);
            this.Controls.Add(btn_online);
            this.Controls.Add(btn_offline);
            this.Controls.Add(txt_connection);
            this.Controls.Add(btn_connect);
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximumSize = new Size(392, 152);
            this.MinimumSize = new Size(392, 152);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Main";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_connect;
        private TextBox txt_connection;
        private Button btn_offline;
        private Button btn_online;
        private TextBox txt_currentStatus;
        private Label label1;
        private Button btn_away;
        private Button btn_exit;
    }
}