namespace _3.PL.View
{
    partial class FrmSach
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
            this.tbt_TimKiem = new System.Windows.Forms.TextBox();
            this.Btn_TimKiem = new System.Windows.Forms.Button();
            this.Btn_Xoa = new System.Windows.Forms.Button();
            this.Btn_Sua = new System.Windows.Forms.Button();
            this.Btn_Them = new System.Windows.Forms.Button();
            this.tbx_MoTa = new System.Windows.Forms.TextBox();
            this.tbx_SoTrang = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbx_AnBan = new System.Windows.Forms.TextBox();
            this.tbx_MaSach = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgrid_Sach = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dttime_NgayXuatBan = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Sach)).BeginInit();
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
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(506, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý Sách";
            // 
            // tbt_TimKiem
            // 
            this.tbt_TimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tbt_TimKiem.Location = new System.Drawing.Point(41, 457);
            this.tbt_TimKiem.Name = "tbt_TimKiem";
            this.tbt_TimKiem.PlaceholderText = "Tìm kiếm theo mã, tên ";
            this.tbt_TimKiem.Size = new System.Drawing.Size(728, 30);
            this.tbt_TimKiem.TabIndex = 40;
            // 
            // Btn_TimKiem
            // 
            this.Btn_TimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.Btn_TimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_TimKiem.Location = new System.Drawing.Point(911, 440);
            this.Btn_TimKiem.Name = "Btn_TimKiem";
            this.Btn_TimKiem.Size = new System.Drawing.Size(157, 52);
            this.Btn_TimKiem.TabIndex = 32;
            this.Btn_TimKiem.Text = "Tìm Kiếm";
            this.Btn_TimKiem.UseVisualStyleBackColor = false;
            // 
            // Btn_Xoa
            // 
            this.Btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.Btn_Xoa.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Xoa.Location = new System.Drawing.Point(911, 326);
            this.Btn_Xoa.Name = "Btn_Xoa";
            this.Btn_Xoa.Size = new System.Drawing.Size(157, 52);
            this.Btn_Xoa.TabIndex = 33;
            this.Btn_Xoa.Text = "Xóa";
            this.Btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // Btn_Sua
            // 
            this.Btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.Btn_Sua.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Sua.Location = new System.Drawing.Point(911, 244);
            this.Btn_Sua.Name = "Btn_Sua";
            this.Btn_Sua.Size = new System.Drawing.Size(157, 52);
            this.Btn_Sua.TabIndex = 34;
            this.Btn_Sua.Text = "Sửa";
            this.Btn_Sua.UseVisualStyleBackColor = false;
            // 
            // Btn_Them
            // 
            this.Btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.Btn_Them.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Them.Location = new System.Drawing.Point(911, 156);
            this.Btn_Them.Name = "Btn_Them";
            this.Btn_Them.Size = new System.Drawing.Size(157, 52);
            this.Btn_Them.TabIndex = 35;
            this.Btn_Them.Text = "Thêm";
            this.Btn_Them.UseVisualStyleBackColor = false;
            // 
            // tbx_MoTa
            // 
            this.tbx_MoTa.Location = new System.Drawing.Point(152, 365);
            this.tbx_MoTa.Name = "tbx_MoTa";
            this.tbx_MoTa.Size = new System.Drawing.Size(250, 27);
            this.tbx_MoTa.TabIndex = 28;
            // 
            // tbx_SoTrang
            // 
            this.tbx_SoTrang.Location = new System.Drawing.Point(152, 308);
            this.tbx_SoTrang.Name = "tbx_SoTrang";
            this.tbx_SoTrang.Size = new System.Drawing.Size(250, 27);
            this.tbx_SoTrang.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 372);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "Mô tả";
            // 
            // tbx_AnBan
            // 
            this.tbx_AnBan.Location = new System.Drawing.Point(152, 252);
            this.tbx_AnBan.Name = "tbx_AnBan";
            this.tbx_AnBan.Size = new System.Drawing.Size(250, 27);
            this.tbx_AnBan.TabIndex = 25;
            // 
            // tbx_MaSach
            // 
            this.tbx_MaSach.Location = new System.Drawing.Point(152, 156);
            this.tbx_MaSach.Name = "tbx_MaSach";
            this.tbx_MaSach.Size = new System.Drawing.Size(250, 27);
            this.tbx_MaSach.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Số trang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ấn bản";
            // 
            // dgrid_Sach
            // 
            this.dgrid_Sach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_Sach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgrid_Sach.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.dgrid_Sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_Sach.Location = new System.Drawing.Point(33, 547);
            this.dgrid_Sach.Name = "dgrid_Sach";
            this.dgrid_Sach.RowHeadersWidth = 51;
            this.dgrid_Sach.RowTemplate.Height = 29;
            this.dgrid_Sach.Size = new System.Drawing.Size(1035, 223);
            this.dgrid_Sach.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Ngày xuất bản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Mã Sách";
            // 
            // dttime_NgayXuatBan
            // 
            this.dttime_NgayXuatBan.Location = new System.Drawing.Point(152, 208);
            this.dttime_NgayXuatBan.Name = "dttime_NgayXuatBan";
            this.dttime_NgayXuatBan.Size = new System.Drawing.Size(250, 27);
            this.dttime_NgayXuatBan.TabIndex = 42;
            // 
            // Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1198, 782);
            this.Controls.Add(this.dttime_NgayXuatBan);
            this.Controls.Add(this.tbt_TimKiem);
            this.Controls.Add(this.Btn_TimKiem);
            this.Controls.Add(this.Btn_Xoa);
            this.Controls.Add(this.Btn_Sua);
            this.Controls.Add(this.Btn_Them);
            this.Controls.Add(this.tbx_MoTa);
            this.Controls.Add(this.tbx_SoTrang);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbx_AnBan);
            this.Controls.Add(this.tbx_MaSach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgrid_Sach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Sach";
            this.Text = "Sach";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Sach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbt_TimKiem;
        private System.Windows.Forms.Button Btn_TimKiem;
        private System.Windows.Forms.Button Btn_Xoa;
        private System.Windows.Forms.Button Btn_Sua;
        private System.Windows.Forms.Button Btn_Them;
        private System.Windows.Forms.TextBox tbx_MoTa;
        private System.Windows.Forms.TextBox tbx_SoTrang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbx_AnBan;
        private System.Windows.Forms.TextBox tbx_MaSach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgrid_Sach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dttime_NgayXuatBan;
    }
}