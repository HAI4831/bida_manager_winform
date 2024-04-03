namespace QuanLyBanBida
{
    partial class AdminBill1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpk_ToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpk_FromDate = new System.Windows.Forms.DateTimePicker();
            this.btn_ViewBill = new System.Windows.Forms.Button();
            this.dtgv_Bill = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Bill)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dtgv_Bill);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1201, 674);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.dtpk_ToDate);
            this.panel2.Controls.Add(this.dtpk_FromDate);
            this.panel2.Controls.Add(this.btn_ViewBill);
            this.panel2.Location = new System.Drawing.Point(207, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(724, 75);
            this.panel2.TabIndex = 2;
            // 
            // dtpk_ToDate
            // 
            this.dtpk_ToDate.CustomFormat = "dd-MM-yyyy";
            this.dtpk_ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_ToDate.Location = new System.Drawing.Point(505, 18);
            this.dtpk_ToDate.Name = "dtpk_ToDate";
            this.dtpk_ToDate.Size = new System.Drawing.Size(200, 26);
            this.dtpk_ToDate.TabIndex = 4;
            // 
            // dtpk_FromDate
            // 
            this.dtpk_FromDate.CustomFormat = "dd-MM-yyy";
            this.dtpk_FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_FromDate.Location = new System.Drawing.Point(12, 18);
            this.dtpk_FromDate.Name = "dtpk_FromDate";
            this.dtpk_FromDate.Size = new System.Drawing.Size(200, 26);
            this.dtpk_FromDate.TabIndex = 3;
            // 
            // btn_ViewBill
            // 
            this.btn_ViewBill.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_ViewBill.Location = new System.Drawing.Point(299, 3);
            this.btn_ViewBill.Name = "btn_ViewBill";
            this.btn_ViewBill.Size = new System.Drawing.Size(128, 60);
            this.btn_ViewBill.TabIndex = 2;
            this.btn_ViewBill.Text = "Thống kê";
            this.btn_ViewBill.UseVisualStyleBackColor = false;
            this.btn_ViewBill.Click += new System.EventHandler(this.btn_ViewBill_Click);
            // 
            // dtgv_Bill
            // 
            this.dtgv_Bill.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgv_Bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Bill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgv_Bill.Location = new System.Drawing.Point(327, 185);
            this.dtgv_Bill.Name = "dtgv_Bill";
            this.dtgv_Bill.RowHeadersWidth = 62;
            this.dtgv_Bill.RowTemplate.Height = 28;
            this.dtgv_Bill.Size = new System.Drawing.Size(505, 468);
            this.dtgv_Bill.TabIndex = 0;
            // 
            // AdminBill1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 674);
            this.Controls.Add(this.panel1);
            this.Name = "AdminBill1";
            this.Text = "AdminBill1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Bill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgv_Bill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_ViewBill;
        private System.Windows.Forms.DateTimePicker dtpk_ToDate;
        private System.Windows.Forms.DateTimePicker dtpk_FromDate;
    }
}