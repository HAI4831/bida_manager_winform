namespace QuanLyBanBida
{
    partial class TableManager1
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
            this.txtSum = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nmudDiscount = new System.Windows.Forms.NumericUpDown();
            this.dtpkToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpkFromDate = new System.Windows.Forms.DateTimePicker();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nmudCount = new System.Windows.Forms.NumericUpDown();
            this.cbbFood = new System.Windows.Forms.ComboBox();
            this.btnCallFood = new System.Windows.Forms.Button();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbWitchTable = new System.Windows.Forms.ComboBox();
            this.btnWitchTable = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmudDiscount)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmudCount)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txtSum);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.flpTable);
            this.panel1.Controls.Add(this.lsvBill);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 668);
            this.panel1.TabIndex = 0;
            // 
            // txtSum
            // 
            this.txtSum.BackColor = System.Drawing.Color.Black;
            this.txtSum.BorderRadius = 23;
            this.txtSum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSum.DefaultText = "Tổng Tiền";
            this.txtSum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSum.FillColor = System.Drawing.Color.SandyBrown;
            this.txtSum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSum.ForeColor = System.Drawing.Color.White;
            this.txtSum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSum.Location = new System.Drawing.Point(634, 76);
            this.txtSum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSum.Name = "txtSum";
            this.txtSum.PasswordChar = '\0';
            this.txtSum.PlaceholderText = "";
            this.txtSum.SelectedText = "";
            this.txtSum.Size = new System.Drawing.Size(274, 46);
            this.txtSum.TabIndex = 6;
            this.txtSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.nmudDiscount);
            this.panel3.Controls.Add(this.dtpkToDate);
            this.panel3.Controls.Add(this.dtpkFromDate);
            this.panel3.Controls.Add(this.btnCheckout);
            this.panel3.Location = new System.Drawing.Point(597, 482);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(378, 196);
            this.panel3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Giảm giá:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Thời gian kết thúc:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "thời gian bắt đầu:";
            // 
            // nmudDiscount
            // 
            this.nmudDiscount.Location = new System.Drawing.Point(175, 108);
            this.nmudDiscount.Name = "nmudDiscount";
            this.nmudDiscount.Size = new System.Drawing.Size(120, 26);
            this.nmudDiscount.TabIndex = 7;
            // 
            // dtpkToDate
            // 
            this.dtpkToDate.CustomFormat = "dd-MM-yyyy";
            this.dtpkToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkToDate.Location = new System.Drawing.Point(175, 61);
            this.dtpkToDate.Name = "dtpkToDate";
            this.dtpkToDate.Size = new System.Drawing.Size(200, 26);
            this.dtpkToDate.TabIndex = 6;
            // 
            // dtpkFromDate
            // 
            this.dtpkFromDate.CustomFormat = "dd-MM-yyyy";
            this.dtpkFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkFromDate.Location = new System.Drawing.Point(175, 15);
            this.dtpkFromDate.Name = "dtpkFromDate";
            this.dtpkFromDate.Size = new System.Drawing.Size(200, 26);
            this.dtpkFromDate.TabIndex = 5;
            // 
            // btnCheckout
            // 
            this.btnCheckout.AutoEllipsis = true;
            this.btnCheckout.BackColor = System.Drawing.Color.SandyBrown;
            this.btnCheckout.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(134, 143);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(100, 41);
            this.btnCheckout.TabIndex = 4;
            this.btnCheckout.Text = "Thanh toán";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.nmudCount);
            this.panel4.Controls.Add(this.cbbFood);
            this.panel4.Controls.Add(this.btnCallFood);
            this.panel4.Controls.Add(this.cbbCategory);
            this.panel4.Location = new System.Drawing.Point(597, 141);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(375, 128);
            this.panel4.TabIndex = 5;
            // 
            // nmudCount
            // 
            this.nmudCount.Location = new System.Drawing.Point(178, 77);
            this.nmudCount.Name = "nmudCount";
            this.nmudCount.Size = new System.Drawing.Size(120, 26);
            this.nmudCount.TabIndex = 7;
            // 
            // cbbFood
            // 
            this.cbbFood.FormattingEnabled = true;
            this.cbbFood.Location = new System.Drawing.Point(23, 60);
            this.cbbFood.Name = "cbbFood";
            this.cbbFood.Size = new System.Drawing.Size(121, 28);
            this.cbbFood.TabIndex = 6;
            // 
            // btnCallFood
            // 
            this.btnCallFood.AutoEllipsis = true;
            this.btnCallFood.BackColor = System.Drawing.Color.SandyBrown;
            this.btnCallFood.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCallFood.ForeColor = System.Drawing.Color.White;
            this.btnCallFood.Location = new System.Drawing.Point(182, 3);
            this.btnCallFood.Name = "btnCallFood";
            this.btnCallFood.Size = new System.Drawing.Size(100, 53);
            this.btnCallFood.TabIndex = 4;
            this.btnCallFood.Text = "Gọi món";
            this.btnCallFood.UseVisualStyleBackColor = false;
            // 
            // cbbCategory
            // 
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(13, 16);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(121, 28);
            this.cbbCategory.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.cbbWitchTable);
            this.panel2.Controls.Add(this.btnWitchTable);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(597, 317);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 130);
            this.panel2.TabIndex = 5;
            // 
            // cbbWitchTable
            // 
            this.cbbWitchTable.FormattingEnabled = true;
            this.cbbWitchTable.Location = new System.Drawing.Point(158, 19);
            this.cbbWitchTable.Name = "cbbWitchTable";
            this.cbbWitchTable.Size = new System.Drawing.Size(121, 28);
            this.cbbWitchTable.TabIndex = 6;
            // 
            // btnWitchTable
            // 
            this.btnWitchTable.AutoEllipsis = true;
            this.btnWitchTable.BackColor = System.Drawing.Color.SandyBrown;
            this.btnWitchTable.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnWitchTable.ForeColor = System.Drawing.Color.White;
            this.btnWitchTable.Location = new System.Drawing.Point(122, 69);
            this.btnWitchTable.Name = "btnWitchTable";
            this.btnWitchTable.Size = new System.Drawing.Size(112, 49);
            this.btnWitchTable.TabIndex = 4;
            this.btnWitchTable.Text = "Chuyển bàn";
            this.btnWitchTable.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Chuyển bàn:";
            // 
            // flpTable
            // 
            this.flpTable.Location = new System.Drawing.Point(24, 76);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(241, 602);
            this.flpTable.TabIndex = 1;
            this.flpTable.Paint += new System.Windows.Forms.PaintEventHandler(this.flpTable_Paint);
            // 
            // lsvBill
            // 
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(271, 76);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(291, 602);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            // 
            // TableManager1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 668);
            this.Controls.Add(this.panel1);
            this.Name = "TableManager1";
            this.Text = "TableManager1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmudDiscount)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmudCount)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnWitchTable;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCallFood;
        private System.Windows.Forms.ComboBox cbbWitchTable;
        private System.Windows.Forms.ComboBox cbbFood;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.DateTimePicker dtpkToDate;
        private System.Windows.Forms.DateTimePicker dtpkFromDate;
        private System.Windows.Forms.NumericUpDown nmudDiscount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmudCount;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtSum;
    }
}