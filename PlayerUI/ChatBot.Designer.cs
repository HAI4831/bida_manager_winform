namespace QuanLyBanBida
{
    partial class ChatBot
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
            this.btnSend = new Guna.UI2.WinForms.Guna2Button();
            this.txtMessage = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.listBoxMessages = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(529, 594);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(180, 45);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Gửi";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMessage.DefaultText = "";
            this.txtMessage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMessage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMessage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMessage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMessage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMessage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMessage.Location = new System.Drawing.Point(81, 594);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.PasswordChar = '\0';
            this.txtMessage.PlaceholderText = "";
            this.txtMessage.SelectedText = "";
            this.txtMessage.Size = new System.Drawing.Size(439, 45);
            this.txtMessage.TabIndex = 1;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(81, 20);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(228, 27);
            this.guna2HtmlLabel1.TabIndex = 3;
            this.guna2HtmlLabel1.Text = "Trò chuyện với trợ lý ảo";
            // 
            // listBoxMessages
            // 
            this.listBoxMessages.FormattingEnabled = true;
            this.listBoxMessages.ItemHeight = 25;
            this.listBoxMessages.Location = new System.Drawing.Point(81, 78);
            this.listBoxMessages.Name = "listBoxMessages";
            this.listBoxMessages.Size = new System.Drawing.Size(628, 479);
            this.listBoxMessages.TabIndex = 4;            // 
            // ChatBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 654);
            this.Controls.Add(this.listBoxMessages);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnSend);
            this.Name = "ChatBot";
            this.Text = "ChatBot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSend;
        private Guna.UI2.WinForms.Guna2TextBox txtMessage;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.ListBox listBoxMessages;
    }
}