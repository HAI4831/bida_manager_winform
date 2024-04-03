namespace QuanLyBanBida
{
    partial class f_AdminBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_AdminBill));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ViewBill = new System.Windows.Forms.Button();
            this.dtpk_ToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpk_FromDate = new System.Windows.Forms.DateTimePicker();
            this.dtgv_Bill = new System.Windows.Forms.DataGridView();
            this.oDataServerModeSource1 = new DevExpress.Data.ODataLinq.ODataServerModeSource();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Bill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oDataServerModeSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_ViewBill);
            this.panel2.Controls.Add(this.dtpk_ToDate);
            this.panel2.Controls.Add(this.dtpk_FromDate);
            this.panel2.Location = new System.Drawing.Point(93, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 58);
            this.panel2.TabIndex = 3;
            // 
            // btn_ViewBill
            // 
            this.btn_ViewBill.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_ViewBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewBill.ForeColor = System.Drawing.Color.Black;
            this.btn_ViewBill.Image = ((System.Drawing.Image)(resources.GetObject("btn_ViewBill.Image")));
            this.btn_ViewBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ViewBill.Location = new System.Drawing.Point(336, 0);
            this.btn_ViewBill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ViewBill.Name = "btn_ViewBill";
            this.btn_ViewBill.Size = new System.Drawing.Size(146, 58);
            this.btn_ViewBill.TabIndex = 2;
            this.btn_ViewBill.Text = "   Thống kê";
            this.btn_ViewBill.UseVisualStyleBackColor = false;
            this.btn_ViewBill.Click += new System.EventHandler(this.btn_ViewBill_Click);
            // 
            // dtpk_ToDate
            // 
            this.dtpk_ToDate.CustomFormat = "dd-MM-yyy";
            this.dtpk_ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_ToDate.Location = new System.Drawing.Point(587, 16);
            this.dtpk_ToDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpk_ToDate.Name = "dtpk_ToDate";
            this.dtpk_ToDate.Size = new System.Drawing.Size(190, 26);
            this.dtpk_ToDate.TabIndex = 1;
            // 
            // dtpk_FromDate
            // 
            this.dtpk_FromDate.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtpk_FromDate.CustomFormat = "dd-MM-yyyy";
            this.dtpk_FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_FromDate.Location = new System.Drawing.Point(16, 16);
            this.dtpk_FromDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpk_FromDate.Name = "dtpk_FromDate";
            this.dtpk_FromDate.Size = new System.Drawing.Size(192, 26);
            this.dtpk_FromDate.TabIndex = 0;
            // 
            // dtgv_Bill
            // 
            this.dtgv_Bill.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgv_Bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Bill.Location = new System.Drawing.Point(205, 98);
            this.dtgv_Bill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgv_Bill.Name = "dtgv_Bill";
            this.dtgv_Bill.RowHeadersWidth = 51;
            this.dtgv_Bill.RowTemplate.Height = 24;
            this.dtgv_Bill.Size = new System.Drawing.Size(622, 590);
            this.dtgv_Bill.TabIndex = 3;
            // 
            // f_AdminBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1287, 782);
            this.Controls.Add(this.dtgv_Bill);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "f_AdminBill";
            this.Text = "Thông tin hóa đơn";
            this.Load += new System.EventHandler(this.f_AdminBill_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Bill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oDataServerModeSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_ViewBill;
        private System.Windows.Forms.DateTimePicker dtpk_ToDate;
        private System.Windows.Forms.DateTimePicker dtpk_FromDate;
        private System.Windows.Forms.DataGridView dtgv_Bill;
        private DevExpress.Data.ODataLinq.ODataServerModeSource oDataServerModeSource1;
    }
}