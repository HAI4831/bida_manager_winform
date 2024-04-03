namespace QuanLyBanBida
{
    partial class AdminTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminTable));
            this.lbl_NameCategory = new System.Windows.Forms.Label();
            this.lbl_CategoryID = new System.Windows.Forms.Label();
            this.btn_ViewTable = new System.Windows.Forms.Button();
            this.btn_EditTable = new System.Windows.Forms.Button();
            this.btn_DeleteTable = new System.Windows.Forms.Button();
            this.btn_AddTable = new System.Windows.Forms.Button();
            this.btn_SearchTable = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_LastCategory = new System.Windows.Forms.Button();
            this.btn_PrevioursCategory = new System.Windows.Forms.Button();
            this.btn_FristCategory = new System.Windows.Forms.Button();
            this.btn_NextCategory = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cb_TableStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_TableName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_idtable = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgv_Table = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_SearchTableName = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Table)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_NameCategory
            // 
            this.lbl_NameCategory.AutoSize = true;
            this.lbl_NameCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NameCategory.ForeColor = System.Drawing.Color.White;
            this.lbl_NameCategory.Location = new System.Drawing.Point(33, 113);
            this.lbl_NameCategory.Name = "lbl_NameCategory";
            this.lbl_NameCategory.Size = new System.Drawing.Size(114, 26);
            this.lbl_NameCategory.TabIndex = 2;
            this.lbl_NameCategory.Text = "Tên Bàn: ";
            // 
            // lbl_CategoryID
            // 
            this.lbl_CategoryID.AutoSize = true;
            this.lbl_CategoryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CategoryID.ForeColor = System.Drawing.Color.White;
            this.lbl_CategoryID.Location = new System.Drawing.Point(97, 29);
            this.lbl_CategoryID.Name = "lbl_CategoryID";
            this.lbl_CategoryID.Size = new System.Drawing.Size(50, 26);
            this.lbl_CategoryID.TabIndex = 1;
            this.lbl_CategoryID.Text = "ID: ";
            // 
            // btn_ViewTable
            // 
            this.btn_ViewTable.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_ViewTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewTable.ForeColor = System.Drawing.Color.White;
            this.btn_ViewTable.Location = new System.Drawing.Point(513, 4);
            this.btn_ViewTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ViewTable.Name = "btn_ViewTable";
            this.btn_ViewTable.Size = new System.Drawing.Size(84, 66);
            this.btn_ViewTable.TabIndex = 4;
            this.btn_ViewTable.Text = "Xem";
            this.btn_ViewTable.UseVisualStyleBackColor = false;
            this.btn_ViewTable.Click += new System.EventHandler(this.btn_ViewTable_Click);
            // 
            // btn_EditTable
            // 
            this.btn_EditTable.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_EditTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditTable.ForeColor = System.Drawing.Color.White;
            this.btn_EditTable.Location = new System.Drawing.Point(344, 4);
            this.btn_EditTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_EditTable.Name = "btn_EditTable";
            this.btn_EditTable.Size = new System.Drawing.Size(84, 66);
            this.btn_EditTable.TabIndex = 3;
            this.btn_EditTable.Text = "Sửa";
            this.btn_EditTable.UseVisualStyleBackColor = false;
            this.btn_EditTable.Click += new System.EventHandler(this.btn_EditTable_Click);
            // 
            // btn_DeleteTable
            // 
            this.btn_DeleteTable.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_DeleteTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteTable.ForeColor = System.Drawing.Color.White;
            this.btn_DeleteTable.Location = new System.Drawing.Point(172, 4);
            this.btn_DeleteTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_DeleteTable.Name = "btn_DeleteTable";
            this.btn_DeleteTable.Size = new System.Drawing.Size(84, 66);
            this.btn_DeleteTable.TabIndex = 2;
            this.btn_DeleteTable.Text = "Xóa";
            this.btn_DeleteTable.UseVisualStyleBackColor = false;
            this.btn_DeleteTable.Click += new System.EventHandler(this.btn_DeleteTable_Click);
            // 
            // btn_AddTable
            // 
            this.btn_AddTable.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_AddTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddTable.ForeColor = System.Drawing.Color.White;
            this.btn_AddTable.Location = new System.Drawing.Point(3, 4);
            this.btn_AddTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_AddTable.Name = "btn_AddTable";
            this.btn_AddTable.Size = new System.Drawing.Size(84, 66);
            this.btn_AddTable.TabIndex = 1;
            this.btn_AddTable.Text = "Thêm";
            this.btn_AddTable.UseVisualStyleBackColor = false;
            this.btn_AddTable.Click += new System.EventHandler(this.btn_AddTable_Click);
            // 
            // btn_SearchTable
            // 
            this.btn_SearchTable.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_SearchTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchTable.ForeColor = System.Drawing.Color.White;
            this.btn_SearchTable.Location = new System.Drawing.Point(616, 24);
            this.btn_SearchTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SearchTable.Name = "btn_SearchTable";
            this.btn_SearchTable.Size = new System.Drawing.Size(154, 45);
            this.btn_SearchTable.TabIndex = 5;
            this.btn_SearchTable.Text = "Tìm kiếm";
            this.btn_SearchTable.UseVisualStyleBackColor = false;
            this.btn_SearchTable.Click += new System.EventHandler(this.btn_SearchTable_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_LastCategory);
            this.panel1.Controls.Add(this.btn_PrevioursCategory);
            this.panel1.Controls.Add(this.btn_FristCategory);
            this.panel1.Controls.Add(this.btn_NextCategory);
            this.panel1.Location = new System.Drawing.Point(477, 544);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 66);
            this.panel1.TabIndex = 17;
            // 
            // btn_LastCategory
            // 
            this.btn_LastCategory.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_LastCategory.FlatAppearance.BorderSize = 0;
            this.btn_LastCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LastCategory.Image = ((System.Drawing.Image)(resources.GetObject("btn_LastCategory.Image")));
            this.btn_LastCategory.Location = new System.Drawing.Point(516, 18);
            this.btn_LastCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_LastCategory.Name = "btn_LastCategory";
            this.btn_LastCategory.Size = new System.Drawing.Size(84, 29);
            this.btn_LastCategory.TabIndex = 32;
            this.btn_LastCategory.UseVisualStyleBackColor = false;
            this.btn_LastCategory.Click += new System.EventHandler(this.btn_LastCategory_Click);
            // 
            // btn_PrevioursCategory
            // 
            this.btn_PrevioursCategory.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_PrevioursCategory.FlatAppearance.BorderSize = 0;
            this.btn_PrevioursCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PrevioursCategory.Image = ((System.Drawing.Image)(resources.GetObject("btn_PrevioursCategory.Image")));
            this.btn_PrevioursCategory.Location = new System.Drawing.Point(172, 18);
            this.btn_PrevioursCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_PrevioursCategory.Name = "btn_PrevioursCategory";
            this.btn_PrevioursCategory.Size = new System.Drawing.Size(84, 29);
            this.btn_PrevioursCategory.TabIndex = 34;
            this.btn_PrevioursCategory.UseVisualStyleBackColor = false;
            this.btn_PrevioursCategory.Click += new System.EventHandler(this.btn_PrevioursCategory_Click);
            // 
            // btn_FristCategory
            // 
            this.btn_FristCategory.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_FristCategory.FlatAppearance.BorderSize = 0;
            this.btn_FristCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FristCategory.Image = ((System.Drawing.Image)(resources.GetObject("btn_FristCategory.Image")));
            this.btn_FristCategory.Location = new System.Drawing.Point(3, 18);
            this.btn_FristCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_FristCategory.Name = "btn_FristCategory";
            this.btn_FristCategory.Size = new System.Drawing.Size(84, 29);
            this.btn_FristCategory.TabIndex = 33;
            this.btn_FristCategory.UseVisualStyleBackColor = false;
            this.btn_FristCategory.Click += new System.EventHandler(this.btn_FristCategory_Click);
            // 
            // btn_NextCategory
            // 
            this.btn_NextCategory.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_NextCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_NextCategory.BackgroundImage")));
            this.btn_NextCategory.FlatAppearance.BorderSize = 0;
            this.btn_NextCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NextCategory.Image = ((System.Drawing.Image)(resources.GetObject("btn_NextCategory.Image")));
            this.btn_NextCategory.Location = new System.Drawing.Point(339, 18);
            this.btn_NextCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_NextCategory.Name = "btn_NextCategory";
            this.btn_NextCategory.Size = new System.Drawing.Size(84, 29);
            this.btn_NextCategory.TabIndex = 35;
            this.btn_NextCategory.UseVisualStyleBackColor = false;
            this.btn_NextCategory.Click += new System.EventHandler(this.btn_NextCategory_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.cb_TableStatus);
            this.panel4.Controls.Add(this.txt_TableName);
            this.panel4.Controls.Add(this.txt_idtable);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.lbl_NameCategory);
            this.panel4.Controls.Add(this.lbl_CategoryID);
            this.panel4.Location = new System.Drawing.Point(477, 253);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(597, 258);
            this.panel4.TabIndex = 15;
            // 
            // cb_TableStatus
            // 
            this.cb_TableStatus.AutoRoundedCorners = true;
            this.cb_TableStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb_TableStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.cb_TableStatus.BorderRadius = 17;
            this.cb_TableStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_TableStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TableStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cb_TableStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_TableStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_TableStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_TableStatus.ForeColor = System.Drawing.Color.White;
            this.cb_TableStatus.ItemHeight = 30;
            this.cb_TableStatus.Items.AddRange(new object[] {
            "Trống",
            "Đang Hoạt Động"});
            this.cb_TableStatus.Location = new System.Drawing.Point(169, 186);
            this.cb_TableStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_TableStatus.Name = "cb_TableStatus";
            this.cb_TableStatus.Size = new System.Drawing.Size(374, 36);
            this.cb_TableStatus.TabIndex = 18;
            this.cb_TableStatus.SelectedIndexChanged += new System.EventHandler(this.cb_TableStatus_SelectedIndexChanged);
            // 
            // txt_TableName
            // 
            this.txt_TableName.Animated = true;
            this.txt_TableName.AutoRoundedCorners = true;
            this.txt_TableName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_TableName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txt_TableName.BorderRadius = 18;
            this.txt_TableName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TableName.DefaultText = "";
            this.txt_TableName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TableName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TableName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TableName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TableName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_TableName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TableName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txt_TableName.ForeColor = System.Drawing.Color.White;
            this.txt_TableName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TableName.Location = new System.Drawing.Point(169, 102);
            this.txt_TableName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_TableName.Name = "txt_TableName";
            this.txt_TableName.PasswordChar = '\0';
            this.txt_TableName.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_TableName.PlaceholderText = "";
            this.txt_TableName.SelectedText = "";
            this.txt_TableName.Size = new System.Drawing.Size(376, 38);
            this.txt_TableName.TabIndex = 33;
            // 
            // txt_idtable
            // 
            this.txt_idtable.Animated = true;
            this.txt_idtable.AutoRoundedCorners = true;
            this.txt_idtable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_idtable.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txt_idtable.BorderRadius = 18;
            this.txt_idtable.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_idtable.DefaultText = "";
            this.txt_idtable.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_idtable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_idtable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_idtable.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_idtable.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_idtable.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_idtable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txt_idtable.ForeColor = System.Drawing.Color.White;
            this.txt_idtable.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_idtable.Location = new System.Drawing.Point(169, 18);
            this.txt_idtable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_idtable.Name = "txt_idtable";
            this.txt_idtable.PasswordChar = '\0';
            this.txt_idtable.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_idtable.PlaceholderText = "";
            this.txt_idtable.SelectedText = "";
            this.txt_idtable.Size = new System.Drawing.Size(376, 38);
            this.txt_idtable.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Trạng thái: ";
            // 
            // dtgv_Table
            // 
            this.dtgv_Table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgv_Table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgv_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Table.Location = new System.Drawing.Point(16, 148);
            this.dtgv_Table.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgv_Table.Name = "dtgv_Table";
            this.dtgv_Table.RowHeadersWidth = 51;
            this.dtgv_Table.RowTemplate.Height = 24;
            this.dtgv_Table.Size = new System.Drawing.Size(433, 520);
            this.dtgv_Table.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.btn_ViewTable);
            this.panel5.Controls.Add(this.btn_EditTable);
            this.panel5.Controls.Add(this.btn_DeleteTable);
            this.panel5.Controls.Add(this.btn_AddTable);
            this.panel5.Location = new System.Drawing.Point(473, 129);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(601, 74);
            this.panel5.TabIndex = 14;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.txt_SearchTableName);
            this.panel6.Controls.Add(this.btn_SearchTable);
            this.panel6.Location = new System.Drawing.Point(16, 34);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1254, 74);
            this.panel6.TabIndex = 16;
            // 
            // txt_SearchTableName
            // 
            this.txt_SearchTableName.Animated = true;
            this.txt_SearchTableName.AutoRoundedCorners = true;
            this.txt_SearchTableName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txt_SearchTableName.BorderRadius = 21;
            this.txt_SearchTableName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SearchTableName.DefaultText = "";
            this.txt_SearchTableName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_SearchTableName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_SearchTableName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SearchTableName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SearchTableName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_SearchTableName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SearchTableName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txt_SearchTableName.ForeColor = System.Drawing.Color.White;
            this.txt_SearchTableName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SearchTableName.Location = new System.Drawing.Point(4, 24);
            this.txt_SearchTableName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_SearchTableName.Name = "txt_SearchTableName";
            this.txt_SearchTableName.PasswordChar = '\0';
            this.txt_SearchTableName.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_SearchTableName.PlaceholderText = "";
            this.txt_SearchTableName.SelectedText = "";
            this.txt_SearchTableName.Size = new System.Drawing.Size(586, 45);
            this.txt_SearchTableName.TabIndex = 30;
            this.txt_SearchTableName.TextChanged += new System.EventHandler(this.txt_SearchTableName_TextChanged);
            // 
            // AdminTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1342, 786);
            this.Controls.Add(this.dtgv_Table);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminTable";
            this.Text = "AdminTable";
            this.Load += new System.EventHandler(this.AdminTable_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Table)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_NameCategory;
        private System.Windows.Forms.Label lbl_CategoryID;
        private System.Windows.Forms.Button btn_ViewTable;
        private System.Windows.Forms.Button btn_EditTable;
        private System.Windows.Forms.Button btn_DeleteTable;
        private System.Windows.Forms.Button btn_AddTable;
        private System.Windows.Forms.Button btn_SearchTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dtgv_Table;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_TableName;
        private Guna.UI2.WinForms.Guna2TextBox txt_idtable;
        private Guna.UI2.WinForms.Guna2ComboBox cb_TableStatus;
        private Guna.UI2.WinForms.Guna2TextBox txt_SearchTableName;
        private System.Windows.Forms.Button btn_LastCategory;
        private System.Windows.Forms.Button btn_PrevioursCategory;
        private System.Windows.Forms.Button btn_FristCategory;
        private System.Windows.Forms.Button btn_NextCategory;
    }
}