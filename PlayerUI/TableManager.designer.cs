namespace QuanLyBanBida
{
    partial class f_TableManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_TableManager));
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBoxFood = new System.Windows.Forms.ComboBox();
            this.nmFoodCount = new System.Windows.Forms.NumericUpDown();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.btn_AddFood = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cb_SwitchTable = new System.Windows.Forms.ComboBox();
            this.btn_SwitchTable = new System.Windows.Forms.Button();
            this.txttongtien = new Guna.UI2.WinForms.Guna2TextBox();
            this.nm_Discount = new System.Windows.Forms.NumericUpDown();
            this.btn_Checkout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_StartTime = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_EndTime = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_Discount)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.GridLines = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(252, 12);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(231, 554);
            this.lsvBill.TabIndex = 1;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            this.lsvBill.SelectedIndexChanged += new System.EventHandler(this.lsvBill_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 122;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 75;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 104;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 117;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.comboBoxFood);
            this.panel4.Controls.Add(this.nmFoodCount);
            this.panel4.Controls.Add(this.comboBoxCategory);
            this.panel4.Controls.Add(this.btn_AddFood);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(517, 80);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(324, 73);
            this.panel4.TabIndex = 8;
            // 
            // comboBoxFood
            // 
            this.comboBoxFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.comboBoxFood.ForeColor = System.Drawing.Color.White;
            this.comboBoxFood.FormattingEnabled = true;
            this.comboBoxFood.Location = new System.Drawing.Point(3, 42);
            this.comboBoxFood.Name = "comboBoxFood";
            this.comboBoxFood.Size = new System.Drawing.Size(121, 28);
            this.comboBoxFood.TabIndex = 35;
            // 
            // nmFoodCount
            // 
            this.nmFoodCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.nmFoodCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmFoodCount.ForeColor = System.Drawing.Color.White;
            this.nmFoodCount.Location = new System.Drawing.Point(186, 46);
            this.nmFoodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmFoodCount.Name = "nmFoodCount";
            this.nmFoodCount.Size = new System.Drawing.Size(104, 25);
            this.nmFoodCount.TabIndex = 3;
            this.nmFoodCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmFoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.comboBoxCategory.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(3, 3);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(121, 28);
            this.comboBoxCategory.TabIndex = 34;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // btn_AddFood
            // 
            this.btn_AddFood.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_AddFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddFood.ForeColor = System.Drawing.Color.White;
            this.btn_AddFood.Location = new System.Drawing.Point(186, 3);
            this.btn_AddFood.Name = "btn_AddFood";
            this.btn_AddFood.Size = new System.Drawing.Size(104, 44);
            this.btn_AddFood.TabIndex = 2;
            this.btn_AddFood.Text = "Gọi món";
            this.btn_AddFood.UseVisualStyleBackColor = false;
            this.btn_AddFood.Click += new System.EventHandler(this.btn_AddFood_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.cb_SwitchTable);
            this.panel3.Controls.Add(this.btn_SwitchTable);
            this.panel3.Location = new System.Drawing.Point(506, 173);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(324, 111);
            this.panel3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(27, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Chuyển bàn";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(1, -144);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(323, 52);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Tổng tiền";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb_SwitchTable
            // 
            this.cb_SwitchTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cb_SwitchTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_SwitchTable.ForeColor = System.Drawing.Color.White;
            this.cb_SwitchTable.FormattingEnabled = true;
            this.cb_SwitchTable.Location = new System.Drawing.Point(185, 14);
            this.cb_SwitchTable.Name = "cb_SwitchTable";
            this.cb_SwitchTable.Size = new System.Drawing.Size(127, 28);
            this.cb_SwitchTable.TabIndex = 4;
            this.cb_SwitchTable.SelectedIndexChanged += new System.EventHandler(this.cb_SwitchTable_SelectedIndexChanged);
            // 
            // btn_SwitchTable
            // 
            this.btn_SwitchTable.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_SwitchTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SwitchTable.ForeColor = System.Drawing.Color.White;
            this.btn_SwitchTable.Location = new System.Drawing.Point(119, 57);
            this.btn_SwitchTable.Name = "btn_SwitchTable";
            this.btn_SwitchTable.Size = new System.Drawing.Size(81, 40);
            this.btn_SwitchTable.TabIndex = 6;
            this.btn_SwitchTable.Text = "Chuyển bàn";
            this.btn_SwitchTable.UseVisualStyleBackColor = false;
            this.btn_SwitchTable.Click += new System.EventHandler(this.btn_SwitchTable_Click);
            // 
            // txttongtien
            // 
            this.txttongtien.Animated = true;
            this.txttongtien.AutoRoundedCorners = true;
            this.txttongtien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txttongtien.BorderRadius = 23;
            this.txttongtien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttongtien.DefaultText = "Tổng Tiền";
            this.txttongtien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttongtien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttongtien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttongtien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttongtien.FillColor = System.Drawing.Color.SandyBrown;
            this.txttongtien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttongtien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txttongtien.ForeColor = System.Drawing.Color.White;
            this.txttongtien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttongtien.Location = new System.Drawing.Point(516, 13);
            this.txttongtien.Margin = new System.Windows.Forms.Padding(4);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.PasswordChar = '\0';
            this.txttongtien.PlaceholderForeColor = System.Drawing.Color.White;
            this.txttongtien.PlaceholderText = "";
            this.txttongtien.SelectedText = "";
            this.txttongtien.Size = new System.Drawing.Size(325, 48);
            this.txttongtien.TabIndex = 33;
            this.txttongtien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nm_Discount
            // 
            this.nm_Discount.BackColor = System.Drawing.Color.Black;
            this.nm_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_Discount.ForeColor = System.Drawing.Color.White;
            this.nm_Discount.Location = new System.Drawing.Point(185, 131);
            this.nm_Discount.Name = "nm_Discount";
            this.nm_Discount.Size = new System.Drawing.Size(127, 25);
            this.nm_Discount.TabIndex = 4;
            this.nm_Discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Checkout
            // 
            this.btn_Checkout.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_Checkout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Checkout.ForeColor = System.Drawing.Color.White;
            this.btn_Checkout.Location = new System.Drawing.Point(104, 181);
            this.btn_Checkout.Name = "btn_Checkout";
            this.btn_Checkout.Size = new System.Drawing.Size(109, 40);
            this.btn_Checkout.TabIndex = 4;
            this.btn_Checkout.Text = "Thanh toán";
            this.btn_Checkout.UseVisualStyleBackColor = false;
            this.btn_Checkout.Click += new System.EventHandler(this.btn_Checkout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Thời gian bắt đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(17, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Thời gian kết thúc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(17, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Giảm giá";
            // 
            // txt_StartTime
            // 
            this.txt_StartTime.Animated = true;
            this.txt_StartTime.AutoRoundedCorners = true;
            this.txt_StartTime.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txt_StartTime.BorderRadius = 11;
            this.txt_StartTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_StartTime.DefaultText = "";
            this.txt_StartTime.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_StartTime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_StartTime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_StartTime.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_StartTime.FillColor = System.Drawing.Color.SandyBrown;
            this.txt_StartTime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_StartTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txt_StartTime.ForeColor = System.Drawing.Color.White;
            this.txt_StartTime.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_StartTime.Location = new System.Drawing.Point(183, 20);
            this.txt_StartTime.Margin = new System.Windows.Forms.Padding(4);
            this.txt_StartTime.Name = "txt_StartTime";
            this.txt_StartTime.PasswordChar = '\0';
            this.txt_StartTime.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_StartTime.PlaceholderText = "";
            this.txt_StartTime.SelectedText = "";
            this.txt_StartTime.Size = new System.Drawing.Size(128, 24);
            this.txt_StartTime.TabIndex = 34;
            this.txt_StartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_EndTime
            // 
            this.txt_EndTime.Animated = true;
            this.txt_EndTime.AutoRoundedCorners = true;
            this.txt_EndTime.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txt_EndTime.BorderRadius = 11;
            this.txt_EndTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_EndTime.DefaultText = "";
            this.txt_EndTime.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_EndTime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_EndTime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_EndTime.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_EndTime.FillColor = System.Drawing.Color.SandyBrown;
            this.txt_EndTime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_EndTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txt_EndTime.ForeColor = System.Drawing.Color.White;
            this.txt_EndTime.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_EndTime.Location = new System.Drawing.Point(185, 79);
            this.txt_EndTime.Margin = new System.Windows.Forms.Padding(4);
            this.txt_EndTime.Name = "txt_EndTime";
            this.txt_EndTime.PasswordChar = '\0';
            this.txt_EndTime.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_EndTime.PlaceholderText = "";
            this.txt_EndTime.SelectedText = "";
            this.txt_EndTime.Size = new System.Drawing.Size(128, 24);
            this.txt_EndTime.TabIndex = 35;
            this.txt_EndTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txt_EndTime);
            this.panel1.Controls.Add(this.txt_StartTime);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Checkout);
            this.panel1.Controls.Add(this.nm_Discount);
            this.panel1.Location = new System.Drawing.Point(516, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 224);
            this.panel1.TabIndex = 9;
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.BackColor = System.Drawing.Color.Aquamarine;
            this.flpTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flpTable.Location = new System.Drawing.Point(12, 12);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(234, 554);
            this.flpTable.TabIndex = 5;
            this.flpTable.Paint += new System.Windows.Forms.PaintEventHandler(this.flpTable_Paint);
            // 
            // f_TableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1187, 574);
            this.Controls.Add(this.txttongtien);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lsvBill);
            this.Controls.Add(this.flpTable);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "f_TableManager";
            this.Text = "Quản lý bàn";
            this.Load += new System.EventHandler(this.f_TableManager_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_Discount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nmFoodCount;
        private System.Windows.Forms.Button btn_AddFood;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cb_SwitchTable;
        private System.Windows.Forms.Button btn_SwitchTable;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txttongtien;
        private System.Windows.Forms.NumericUpDown nm_Discount;
        private System.Windows.Forms.Button btn_Checkout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txt_StartTime;
        private Guna.UI2.WinForms.Guna2TextBox txt_EndTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ComboBox comboBoxFood;
    }
}