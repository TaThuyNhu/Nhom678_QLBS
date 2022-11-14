namespace _3.PL.View
{
    partial class FrmKhachHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_HoVaTen = new System.Windows.Forms.TextBox();
            this.Ho = new System.Windows.Forms.Label();
            this.Btn_ThemKh = new System.Windows.Forms.Button();
            this.Dgrid_KhachHang = new System.Windows.Forms.DataGridView();
            this.Dttime_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_Sdt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbx_DiaChi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_Email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rdbtn_co = new System.Windows.Forms.RadioButton();
            this.rdbtn_Khong = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbtn_Nam = new System.Windows.Forms.RadioButton();
            this.rdbtn_Nu = new System.Windows.Forms.RadioButton();
            this.Btn_SuaKh = new System.Windows.Forms.Button();
            this.Btn_XoaKh = new System.Windows.Forms.Button();
            this.Btn_TimKiemKh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_MaKh = new System.Windows.Forms.TextBox();
            this.tbt_TimKiem = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid_KhachHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(168)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1198, 125);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(407, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 34);
            this.label1.TabIndex = 17;
            this.label1.Text = "Quản Lý Khách Hàng";
            // 
            // tbx_HoVaTen
            // 
            this.tbx_HoVaTen.Location = new System.Drawing.Point(155, 212);
            this.tbx_HoVaTen.Name = "tbx_HoVaTen";
            this.tbx_HoVaTen.Size = new System.Drawing.Size(308, 27);
            this.tbx_HoVaTen.TabIndex = 1;
            // 
            // Ho
            // 
            this.Ho.AutoSize = true;
            this.Ho.Location = new System.Drawing.Point(11, 219);
            this.Ho.Name = "Ho";
            this.Ho.Size = new System.Drawing.Size(75, 20);
            this.Ho.TabIndex = 2;
            this.Ho.Text = "Họ và Tên";
            // 
            // Btn_ThemKh
            // 
            this.Btn_ThemKh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.Btn_ThemKh.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_ThemKh.Location = new System.Drawing.Point(1012, 156);
            this.Btn_ThemKh.Name = "Btn_ThemKh";
            this.Btn_ThemKh.Size = new System.Drawing.Size(157, 52);
            this.Btn_ThemKh.TabIndex = 3;
            this.Btn_ThemKh.Text = "Thêm";
            this.Btn_ThemKh.UseVisualStyleBackColor = false;
            // 
            // Dgrid_KhachHang
            // 
            this.Dgrid_KhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgrid_KhachHang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dgrid_KhachHang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.Dgrid_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgrid_KhachHang.Location = new System.Drawing.Point(62, 554);
            this.Dgrid_KhachHang.Name = "Dgrid_KhachHang";
            this.Dgrid_KhachHang.RowHeadersWidth = 51;
            this.Dgrid_KhachHang.RowTemplate.Height = 29;
            this.Dgrid_KhachHang.Size = new System.Drawing.Size(1078, 216);
            this.Dgrid_KhachHang.TabIndex = 5;
            // 
            // Dttime_NgaySinh
            // 
            this.Dttime_NgaySinh.Location = new System.Drawing.Point(668, 156);
            this.Dttime_NgaySinh.Name = "Dttime_NgaySinh";
            this.Dttime_NgaySinh.Size = new System.Drawing.Size(282, 27);
            this.Dttime_NgaySinh.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(524, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ngày Sinh";
            // 
            // tbx_Sdt
            // 
            this.tbx_Sdt.Location = new System.Drawing.Point(668, 212);
            this.tbx_Sdt.Name = "tbx_Sdt";
            this.tbx_Sdt.Size = new System.Drawing.Size(282, 27);
            this.tbx_Sdt.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(524, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Số điện thoại";
            // 
            // tbx_DiaChi
            // 
            this.tbx_DiaChi.Location = new System.Drawing.Point(668, 264);
            this.tbx_DiaChi.Name = "tbx_DiaChi";
            this.tbx_DiaChi.Size = new System.Drawing.Size(282, 27);
            this.tbx_DiaChi.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(524, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Địa chỉ";
            // 
            // tbx_Email
            // 
            this.tbx_Email.Location = new System.Drawing.Point(181, 326);
            this.tbx_Email.Name = "tbx_Email";
            this.tbx_Email.Size = new System.Drawing.Size(282, 27);
            this.tbx_Email.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(524, 333);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Trạng thái";
            // 
            // rdbtn_co
            // 
            this.rdbtn_co.AutoSize = true;
            this.rdbtn_co.Location = new System.Drawing.Point(6, 4);
            this.rdbtn_co.Name = "rdbtn_co";
            this.rdbtn_co.Size = new System.Drawing.Size(48, 24);
            this.rdbtn_co.TabIndex = 4;
            this.rdbtn_co.TabStop = true;
            this.rdbtn_co.Text = "Có";
            this.rdbtn_co.UseVisualStyleBackColor = true;
            // 
            // rdbtn_Khong
            // 
            this.rdbtn_Khong.AutoSize = true;
            this.rdbtn_Khong.Location = new System.Drawing.Point(165, 1);
            this.rdbtn_Khong.Name = "rdbtn_Khong";
            this.rdbtn_Khong.Size = new System.Drawing.Size(73, 24);
            this.rdbtn_Khong.TabIndex = 4;
            this.rdbtn_Khong.TabStop = true;
            this.rdbtn_Khong.Text = "Không";
            this.rdbtn_Khong.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtn_co);
            this.groupBox1.Controls.Add(this.rdbtn_Khong);
            this.groupBox1.Location = new System.Drawing.Point(668, 322);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 31);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbtn_Nam);
            this.groupBox2.Controls.Add(this.rdbtn_Nu);
            this.groupBox2.Location = new System.Drawing.Point(155, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 33);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " ";
            // 
            // rdbtn_Nam
            // 
            this.rdbtn_Nam.AutoSize = true;
            this.rdbtn_Nam.Location = new System.Drawing.Point(6, 4);
            this.rdbtn_Nam.Name = "rdbtn_Nam";
            this.rdbtn_Nam.Size = new System.Drawing.Size(62, 24);
            this.rdbtn_Nam.TabIndex = 4;
            this.rdbtn_Nam.TabStop = true;
            this.rdbtn_Nam.Text = "Nam";
            this.rdbtn_Nam.UseVisualStyleBackColor = true;
            // 
            // rdbtn_Nu
            // 
            this.rdbtn_Nu.AutoSize = true;
            this.rdbtn_Nu.Location = new System.Drawing.Point(198, 4);
            this.rdbtn_Nu.Name = "rdbtn_Nu";
            this.rdbtn_Nu.Size = new System.Drawing.Size(50, 24);
            this.rdbtn_Nu.TabIndex = 4;
            this.rdbtn_Nu.TabStop = true;
            this.rdbtn_Nu.Text = "Nữ";
            this.rdbtn_Nu.UseVisualStyleBackColor = true;
            // 
            // Btn_SuaKh
            // 
            this.Btn_SuaKh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.Btn_SuaKh.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_SuaKh.Location = new System.Drawing.Point(1012, 244);
            this.Btn_SuaKh.Name = "Btn_SuaKh";
            this.Btn_SuaKh.Size = new System.Drawing.Size(157, 52);
            this.Btn_SuaKh.TabIndex = 3;
            this.Btn_SuaKh.Text = "Sửa";
            this.Btn_SuaKh.UseVisualStyleBackColor = false;
            // 
            // Btn_XoaKh
            // 
            this.Btn_XoaKh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.Btn_XoaKh.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_XoaKh.Location = new System.Drawing.Point(1012, 326);
            this.Btn_XoaKh.Name = "Btn_XoaKh";
            this.Btn_XoaKh.Size = new System.Drawing.Size(157, 52);
            this.Btn_XoaKh.TabIndex = 3;
            this.Btn_XoaKh.Text = "Xóa";
            this.Btn_XoaKh.UseVisualStyleBackColor = false;
            // 
            // Btn_TimKiemKh
            // 
            this.Btn_TimKiemKh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.Btn_TimKiemKh.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_TimKiemKh.Location = new System.Drawing.Point(1012, 440);
            this.Btn_TimKiemKh.Name = "Btn_TimKiemKh";
            this.Btn_TimKiemKh.Size = new System.Drawing.Size(157, 52);
            this.Btn_TimKiemKh.TabIndex = 3;
            this.Btn_TimKiemKh.Text = "Tìm Kiếm";
            this.Btn_TimKiemKh.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã Khách hàng";
            // 
            // tbx_MaKh
            // 
            this.tbx_MaKh.Location = new System.Drawing.Point(155, 160);
            this.tbx_MaKh.Name = "tbx_MaKh";
            this.tbx_MaKh.Size = new System.Drawing.Size(308, 27);
            this.tbx_MaKh.TabIndex = 9;
            // 
            // tbt_TimKiem
            // 
            this.tbt_TimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tbt_TimKiem.Location = new System.Drawing.Point(194, 462);
            this.tbt_TimKiem.Name = "tbt_TimKiem";
            this.tbt_TimKiem.PlaceholderText = "Tìm kiếm theo mã, tên ";
            this.tbt_TimKiem.Size = new System.Drawing.Size(728, 30);
            this.tbt_TimKiem.TabIndex = 13;
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1198, 782);
            this.Controls.Add(this.tbt_TimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_MaKh);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Dttime_NgaySinh);
            this.Controls.Add(this.Dgrid_KhachHang);
            this.Controls.Add(this.Btn_TimKiemKh);
            this.Controls.Add(this.Btn_XoaKh);
            this.Controls.Add(this.Btn_SuaKh);
            this.Controls.Add(this.Btn_ThemKh);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Ho);
            this.Controls.Add(this.tbx_Email);
            this.Controls.Add(this.tbx_DiaChi);
            this.Controls.Add(this.tbx_Sdt);
            this.Controls.Add(this.tbx_HoVaTen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmKhachHang";
            this.Text = "FrmKhachHang";
            this.Load += new System.EventHandler(this.FrmKhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid_KhachHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_HoVaTen;
        private System.Windows.Forms.Label Ho;
        private System.Windows.Forms.Button Btn_ThemKh;
        private System.Windows.Forms.DataGridView Dgrid_KhachHang;
        private System.Windows.Forms.DateTimePicker Dttime_NgaySinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_Sdt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbx_DiaChi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbx_Email;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rdbtn_co;
        private System.Windows.Forms.RadioButton rdbtn_Khong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbtn_Nam;
        private System.Windows.Forms.RadioButton rdbtn_Nu;
        private System.Windows.Forms.Button Btn_SuaKh;
        private System.Windows.Forms.Button Btn_XoaKh;
        private System.Windows.Forms.Button Btn_TimKiemKh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_MaKh;
        private System.Windows.Forms.TextBox tbt_TimKiem;
    }
}