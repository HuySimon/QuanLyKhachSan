namespace HotelManagement.GUI
{
    partial class FormDanhSachKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDanhSachKhachHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewImageColumn();
            this.buttonImport = new HotelManagement.CTControls.CTButton();
            this.ctPanel1 = new CTPanel.CTPanel();
            this.buttonExport = new HotelManagement.CTControls.CTButton();
            this.CTButtonThemKhachHang = new HotelManagement.CTControls.CTButton();
            this.CTTextBoxTimKhachHangTheoTen = new HotelManagement.CTControls.CTTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::HotelManagement.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(50, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 30);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeColumns = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.grid.ColumnHeadersHeight = 50;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.grid.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle14;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.Location = new System.Drawing.Point(70, 100);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.grid.RowHeadersVisible = false;
            this.grid.RowHeadersWidth = 40;
            this.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid.RowTemplate.Height = 40;
            this.grid.RowTemplate.ReadOnly = true;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(1097, 659);
            this.grid.TabIndex = 31;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            this.grid.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellMouseLeave);
            this.grid.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_CellMouseMove);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 175F;
            this.Column2.HeaderText = "Mã khách hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 200F;
            this.Column3.HeaderText = "Họ và tên";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 200F;
            this.Column4.HeaderText = "CCCD/Passport";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 150F;
            this.Column5.HeaderText = "Số điện thoại";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 150F;
            this.Column6.HeaderText = "Quốc tịch";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 150F;
            this.Column7.HeaderText = "Giới tính";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle12.NullValue")));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle12;
            this.Column8.FillWeight = 50F;
            this.Column8.HeaderText = "Sửa";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle13.NullValue")));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column9.DefaultCellStyle = dataGridViewCellStyle13;
            this.Column9.FillWeight = 50F;
            this.Column9.HeaderText = "Xóa";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // buttonImport
            // 
            this.buttonImport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(192)))), ((int)(((byte)(47)))));
            this.buttonImport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(192)))), ((int)(((byte)(47)))));
            this.buttonImport.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(192)))), ((int)(((byte)(47)))));
            this.buttonImport.BorderRadius = 10;
            this.buttonImport.BorderSize = 0;
            this.buttonImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonImport.FlatAppearance.BorderSize = 0;
            this.buttonImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImport.ForeColor = System.Drawing.Color.Black;
            this.buttonImport.Location = new System.Drawing.Point(673, 30);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(150, 40);
            this.buttonImport.TabIndex = 32;
            this.buttonImport.Text = "Nhập file Excel";
            this.buttonImport.TextColor = System.Drawing.Color.Black;
            this.buttonImport.UseVisualStyleBackColor = false;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // ctPanel1
            // 
            this.ctPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctPanel1.BackColor = System.Drawing.Color.White;
            this.ctPanel1.BorderRadius = 50;
            this.ctPanel1.ForeColor = System.Drawing.Color.Black;
            this.ctPanel1.GradientAngle = 90F;
            this.ctPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.ctPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.ctPanel1.Location = new System.Drawing.Point(45, 95);
            this.ctPanel1.Name = "ctPanel1";
            this.ctPanel1.Size = new System.Drawing.Size(1142, 704);
            this.ctPanel1.TabIndex = 30;
            // 
            // buttonExport
            // 
            this.buttonExport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(192)))), ((int)(((byte)(47)))));
            this.buttonExport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(192)))), ((int)(((byte)(47)))));
            this.buttonExport.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(192)))), ((int)(((byte)(47)))));
            this.buttonExport.BorderRadius = 10;
            this.buttonExport.BorderSize = 0;
            this.buttonExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExport.FlatAppearance.BorderSize = 0;
            this.buttonExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExport.ForeColor = System.Drawing.Color.Black;
            this.buttonExport.Location = new System.Drawing.Point(840, 30);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(150, 40);
            this.buttonExport.TabIndex = 28;
            this.buttonExport.Text = "Xuất file Excel";
            this.buttonExport.TextColor = System.Drawing.Color.Black;
            this.buttonExport.UseVisualStyleBackColor = false;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // CTButtonThemKhachHang
            // 
            this.CTButtonThemKhachHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CTButtonThemKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(172)))), ((int)(((byte)(62)))));
            this.CTButtonThemKhachHang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(172)))), ((int)(((byte)(62)))));
            this.CTButtonThemKhachHang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(172)))), ((int)(((byte)(62)))));
            this.CTButtonThemKhachHang.BorderRadius = 10;
            this.CTButtonThemKhachHang.BorderSize = 0;
            this.CTButtonThemKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTButtonThemKhachHang.FlatAppearance.BorderSize = 0;
            this.CTButtonThemKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CTButtonThemKhachHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTButtonThemKhachHang.ForeColor = System.Drawing.Color.White;
            this.CTButtonThemKhachHang.Location = new System.Drawing.Point(1021, 30);
            this.CTButtonThemKhachHang.Name = "CTButtonThemKhachHang";
            this.CTButtonThemKhachHang.Size = new System.Drawing.Size(166, 40);
            this.CTButtonThemKhachHang.TabIndex = 6;
            this.CTButtonThemKhachHang.Text = "Thêm khách hàng";
            this.CTButtonThemKhachHang.TextColor = System.Drawing.Color.White;
            this.CTButtonThemKhachHang.UseVisualStyleBackColor = false;
            this.CTButtonThemKhachHang.Click += new System.EventHandler(this.CTButtonThemKhachHang_Click);
            // 
            // CTTextBoxTimKhachHangTheoTen
            // 
            this.CTTextBoxTimKhachHangTheoTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CTTextBoxTimKhachHangTheoTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.CTTextBoxTimKhachHangTheoTen.BorderColor = System.Drawing.Color.Gray;
            this.CTTextBoxTimKhachHangTheoTen.BorderFocusColor = System.Drawing.Color.Black;
            this.CTTextBoxTimKhachHangTheoTen.BorderRadius = 5;
            this.CTTextBoxTimKhachHangTheoTen.BorderSize = 1;
            this.CTTextBoxTimKhachHangTheoTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTTextBoxTimKhachHangTheoTen.ForeColor = System.Drawing.Color.DimGray;
            this.CTTextBoxTimKhachHangTheoTen.IsFocused = false;
            this.CTTextBoxTimKhachHangTheoTen.Location = new System.Drawing.Point(45, 30);
            this.CTTextBoxTimKhachHangTheoTen.Margin = new System.Windows.Forms.Padding(4);
            this.CTTextBoxTimKhachHangTheoTen.Multiline = false;
            this.CTTextBoxTimKhachHangTheoTen.Name = "CTTextBoxTimKhachHangTheoTen";
            this.CTTextBoxTimKhachHangTheoTen.Padding = new System.Windows.Forms.Padding(40, 7, 7, 7);
            this.CTTextBoxTimKhachHangTheoTen.PasswordChar = false;
            this.CTTextBoxTimKhachHangTheoTen.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.CTTextBoxTimKhachHangTheoTen.PlaceholderText = "Nhập thông tin cần tìm (cccd,tên,..)";
            this.CTTextBoxTimKhachHangTheoTen.ReadOnly = false;
            this.CTTextBoxTimKhachHangTheoTen.Size = new System.Drawing.Size(294, 36);
            this.CTTextBoxTimKhachHangTheoTen.TabIndex = 4;
            this.CTTextBoxTimKhachHangTheoTen.TabStop = false;
            this.CTTextBoxTimKhachHangTheoTen.Texts = "";
            this.CTTextBoxTimKhachHangTheoTen.UnderlineedStyle = false;
            this.CTTextBoxTimKhachHangTheoTen._TextChanged += new System.EventHandler(this.CTTextBoxTimKhachHangTheoTen__TextChanged);
            this.CTTextBoxTimKhachHangTheoTen.Load += new System.EventHandler(this.CTTextBoxTimKhachHangTheoTen_Load);
            // 
            // FormDanhSachKhachHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1260, 833);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.ctPanel1);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.CTButtonThemKhachHang);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CTTextBoxTimKhachHangTheoTen);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDanhSachKhachHang";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormQuanLyKhachHang";
            this.Load += new System.EventHandler(this.FormDanhSachKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CTControls.CTButton CTButtonThemKhachHang;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CTControls.CTTextBox CTTextBoxTimKhachHangTheoTen;
        private CTControls.CTButton buttonExport;
        private System.Windows.Forms.DataGridView grid;
        private CTPanel.CTPanel ctPanel1;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewImageColumn Column8;
        private System.Windows.Forms.DataGridViewImageColumn Column9;
        private CTControls.CTButton buttonImport;
    }
}