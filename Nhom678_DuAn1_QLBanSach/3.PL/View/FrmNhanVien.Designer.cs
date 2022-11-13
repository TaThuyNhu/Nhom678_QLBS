namespace _3.PL.View
{
    partial class FrmNhanVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbx_MaNv = new System.Windows.Forms.TextBox();
            this.rdbtn_Nam = new System.Windows.Forms.RadioButton();
            this.dgrid_NhanVien = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_TimKiem = new System.Windows.Forms.Button();
            this.Btn_Xoa = new System.Windows.Forms.Button();
            this.Btn_Sua = new System.Windows.Forms.Button();
            this.Btn_Them = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_HoTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_Tuoi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_QueQuan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_MaCv = new System.Windows.Forms.ComboBox();
            this.cmb_MaCh = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbx_Sdt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbx_Email = new System.Windows.Forms.TextBox();
            this.rdbtn_Nu = new System.Windows.Forms.RadioButton();
            this.rdbtn_Co = new System.Windows.Forms.RadioButton();
            this.rdbtn_Khong = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbt_TimKiem = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_NhanVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(168)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1198, 125);
            this.panel1.TabIndex = 1;
            // 
            // tbx_MaNv
            // 
            this.tbx_MaNv.Location = new System.Drawing.Point(151, 156);
            this.tbx_MaNv.Name = "tbx_MaNv";
            this.tbx_MaNv.Size = new System.Drawing.Size(228, 27);
            this.tbx_MaNv.TabIndex = 0;
            // 
            // rdbtn_Nam
            // 
            this.rdbtn_Nam.AutoSize = true;
            this.rdbtn_Nam.Location = new System.Drawing.Point(0, 4);
            this.rdbtn_Nam.Name = "rdbtn_Nam";
            this.rdbtn_Nam.Size = new System.Drawing.Size(62, 24);
            this.rdbtn_Nam.TabIndex = 2;
            this.rdbtn_Nam.TabStop = true;
            this.rdbtn_Nam.Text = "Nam";
            this.rdbtn_Nam.UseVisualStyleBackColor = true;
            // 
            // dgrid_NhanVien
            // 
            this.dgrid_NhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_NhanVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgrid_NhanVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.dgrid_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_NhanVien.Location = new System.Drawing.Point(32, 547);
            this.dgrid_NhanVien.Name = "dgrid_NhanVien";
            this.dgrid_NhanVien.RowHeadersWidth = 51;
            this.dgrid_NhanVien.RowTemplate.Height = 29;
            this.dgrid_NhanVien.Size = new System.Drawing.Size(1137, 223);
            this.dgrid_NhanVien.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(462, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 34);
            this.label2.TabIndex = 17;
            this.label2.Text = "Quản lý nhân viên";
            // 
            // Btn_TimKiem
            // 
            this.Btn_TimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.Btn_TimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_TimKiem.Location = new System.Drawing.Point(1012, 445);
            this.Btn_TimKiem.Name = "Btn_TimKiem";
            this.Btn_TimKiem.Size = new System.Drawing.Size(157, 52);
            this.Btn_TimKiem.TabIndex = 4;
            this.Btn_TimKiem.Text = "Tìm Kiếm";
            this.Btn_TimKiem.UseVisualStyleBackColor = false;
            // 
            // Btn_Xoa
            // 
            this.Btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.Btn_Xoa.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Xoa.Location = new System.Drawing.Point(1012, 331);
            this.Btn_Xoa.Name = "Btn_Xoa";
            this.Btn_Xoa.Size = new System.Drawing.Size(157, 52);
            this.Btn_Xoa.TabIndex = 5;
            this.Btn_Xoa.Text = "Xóa";
            this.Btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // Btn_Sua
            // 
            this.Btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.Btn_Sua.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Sua.Location = new System.Drawing.Point(1012, 249);
            this.Btn_Sua.Name = "Btn_Sua";
            this.Btn_Sua.Size = new System.Drawing.Size(157, 52);
            this.Btn_Sua.TabIndex = 6;
            this.Btn_Sua.Text = "Sửa";
            this.Btn_Sua.UseVisualStyleBackColor = false;
            // 
            // Btn_Them
            // 
            this.Btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.Btn_Them.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Them.Location = new System.Drawing.Point(1012, 161);
            this.Btn_Them.Name = "Btn_Them";
            this.Btn_Them.Size = new System.Drawing.Size(157, 52);
            this.Btn_Them.TabIndex = 7;
            this.Btn_Them.Text = "Thêm";
            this.Btn_Them.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ Tên";
            // 
            // tbx_HoTen
            // 
            this.tbx_HoTen.Location = new System.Drawing.Point(151, 208);
            this.tbx_HoTen.Name = "tbx_HoTen";
            this.tbx_HoTen.Size = new System.Drawing.Size(228, 27);
            this.tbx_HoTen.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tuổi";
            // 
            // tbx_Tuoi
            // 
            this.tbx_Tuoi.Location = new System.Drawing.Point(151, 252);
            this.tbx_Tuoi.Name = "tbx_Tuoi";
            this.tbx_Tuoi.Size = new System.Drawing.Size(228, 27);
            this.tbx_Tuoi.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Quê Quán";
            // 
            // tbx_QueQuan
            // 
            this.tbx_QueQuan.Location = new System.Drawing.Point(151, 308);
            this.tbx_QueQuan.Name = "tbx_QueQuan";
            this.tbx_QueQuan.Size = new System.Drawing.Size(228, 27);
            this.tbx_QueQuan.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giới tính";
            // 
            // cmb_MaCv
            // 
            this.cmb_MaCv.FormattingEnabled = true;
            this.cmb_MaCv.Location = new System.Drawing.Point(620, 156);
            this.cmb_MaCv.Name = "cmb_MaCv";
            this.cmb_MaCv.Size = new System.Drawing.Size(250, 28);
            this.cmb_MaCv.TabIndex = 8;
            this.cmb_MaCv.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmb_MaCh
            // 
            this.cmb_MaCh.FormattingEnabled = true;
            this.cmb_MaCh.Location = new System.Drawing.Point(620, 207);
            this.cmb_MaCh.Name = "cmb_MaCh";
            this.cmb_MaCh.Size = new System.Drawing.Size(250, 28);
            this.cmb_MaCh.TabIndex = 8;
            this.cmb_MaCh.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(509, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã chức vụ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(509, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã cửa hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(509, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Số điện thoại";
            // 
            // tbx_Sdt
            // 
            this.tbx_Sdt.Location = new System.Drawing.Point(620, 252);
            this.tbx_Sdt.Name = "tbx_Sdt";
            this.tbx_Sdt.Size = new System.Drawing.Size(251, 27);
            this.tbx_Sdt.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(509, 315);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Email";
            // 
            // tbx_Email
            // 
            this.tbx_Email.Location = new System.Drawing.Point(620, 308);
            this.tbx_Email.Name = "tbx_Email";
            this.tbx_Email.Size = new System.Drawing.Size(251, 27);
            this.tbx_Email.TabIndex = 0;
            // 
            // rdbtn_Nu
            // 
            this.rdbtn_Nu.AutoSize = true;
            this.rdbtn_Nu.Location = new System.Drawing.Point(127, 4);
            this.rdbtn_Nu.Name = "rdbtn_Nu";
            this.rdbtn_Nu.Size = new System.Drawing.Size(50, 24);
            this.rdbtn_Nu.TabIndex = 2;
            this.rdbtn_Nu.TabStop = true;
            this.rdbtn_Nu.Text = "Nữ";
            this.rdbtn_Nu.UseVisualStyleBackColor = true;
            // 
            // rdbtn_Co
            // 
            this.rdbtn_Co.AutoSize = true;
            this.rdbtn_Co.Location = new System.Drawing.Point(6, 0);
            this.rdbtn_Co.Name = "rdbtn_Co";
            this.rdbtn_Co.Size = new System.Drawing.Size(48, 24);
            this.rdbtn_Co.TabIndex = 2;
            this.rdbtn_Co.TabStop = true;
            this.rdbtn_Co.Text = "Có";
            this.rdbtn_Co.UseVisualStyleBackColor = true;
            // 
            // rdbtn_Khong
            // 
            this.rdbtn_Khong.AutoSize = true;
            this.rdbtn_Khong.Location = new System.Drawing.Point(163, 0);
            this.rdbtn_Khong.Name = "rdbtn_Khong";
            this.rdbtn_Khong.Size = new System.Drawing.Size(73, 24);
            this.rdbtn_Khong.TabIndex = 2;
            this.rdbtn_Khong.TabStop = true;
            this.rdbtn_Khong.Text = "Không";
            this.rdbtn_Khong.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(509, 379);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Trạng thái";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtn_Nu);
            this.groupBox1.Controls.Add(this.rdbtn_Nam);
            this.groupBox1.Location = new System.Drawing.Point(151, 379);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 50);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbtn_Co);
            this.groupBox2.Controls.Add(this.rdbtn_Khong);
            this.groupBox2.Location = new System.Drawing.Point(620, 383);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 49);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "1";
            // 
            // tbt_TimKiem
            // 
            this.tbt_TimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tbt_TimKiem.Location = new System.Drawing.Point(224, 457);
            this.tbt_TimKiem.Name = "tbt_TimKiem";
            this.tbt_TimKiem.PlaceholderText = "Tìm kiếm theo mã, tên ";
            this.tbt_TimKiem.Size = new System.Drawing.Size(728, 30);
            this.tbt_TimKiem.TabIndex = 14;
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1198, 782);
            this.Controls.Add(this.tbt_TimKiem);
            this.Controls.Add(this.cmb_MaCh);
            this.Controls.Add(this.cmb_MaCv);
            this.Controls.Add(this.Btn_TimKiem);
            this.Controls.Add(this.Btn_Xoa);
            this.Controls.Add(this.Btn_Sua);
            this.Controls.Add(this.Btn_Them);
            this.Controls.Add(this.tbx_Email);
            this.Controls.Add(this.tbx_Sdt);
            this.Controls.Add(this.tbx_QueQuan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbx_Tuoi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbx_HoTen);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbx_MaNv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgrid_NhanVien);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Location = new System.Drawing.Point(462, 30);
            this.Name = "FrmNhanVien";
            this.Text = "FrmNhanVien";
            this.Load += new System.EventHandler(this.FrmNhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_NhanVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbx_MaNv;
        private System.Windows.Forms.RadioButton rdbtn_Nam;
        private System.Windows.Forms.DataGridView dgrid_NhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_TimKiem;
        private System.Windows.Forms.Button Btn_Xoa;
        private System.Windows.Forms.Button Btn_Sua;
        private System.Windows.Forms.Button Btn_Them;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_HoTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_Tuoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_QueQuan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_MaCv;
        private System.Windows.Forms.ComboBox cmb_MaCh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbx_Sdt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbx_Email;
        private System.Windows.Forms.RadioButton rdbtn_Nu;
        private System.Windows.Forms.RadioButton rdbtn_Co;
        private System.Windows.Forms.RadioButton rdbtn_Khong;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbt_TimKiem;
    }
}