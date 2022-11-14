namespace _3.PL.View
{
    partial class FrmTheLoai
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_MaTheLoai = new System.Windows.Forms.TextBox();
            this.Ho = new System.Windows.Forms.Label();
            this.tbx_Mota = new System.Windows.Forms.TextBox();
            this.Btn_TimKiem = new System.Windows.Forms.Button();
            this.Btn_Xoa = new System.Windows.Forms.Button();
            this.Btn_Sua = new System.Windows.Forms.Button();
            this.Btn_Them = new System.Windows.Forms.Button();
            this.tbt_TimKiem = new System.Windows.Forms.TextBox();
            this.dgrid_Theloai = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgrid_ChiTietTheLoai = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_TenTheLoai = new System.Windows.Forms.TextBox();
            this.cmb_MaTheLoai = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Theloai)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ChiTietTheLoai)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(462, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý thể loại";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgrid_Theloai);
            this.groupBox1.Controls.Add(this.tbt_TimKiem);
            this.groupBox1.Controls.Add(this.Btn_TimKiem);
            this.groupBox1.Controls.Add(this.Btn_Xoa);
            this.groupBox1.Controls.Add(this.Btn_Sua);
            this.groupBox1.Controls.Add(this.Btn_Them);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbx_MaTheLoai);
            this.groupBox1.Controls.Add(this.Ho);
            this.groupBox1.Controls.Add(this.tbx_Mota);
            this.groupBox1.Location = new System.Drawing.Point(12, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1186, 329);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thể loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Mã thể loại";
            // 
            // tbx_MaTheLoai
            // 
            this.tbx_MaTheLoai.Location = new System.Drawing.Point(99, 26);
            this.tbx_MaTheLoai.Name = "tbx_MaTheLoai";
            this.tbx_MaTheLoai.Size = new System.Drawing.Size(308, 27);
            this.tbx_MaTheLoai.TabIndex = 44;
            // 
            // Ho
            // 
            this.Ho.AutoSize = true;
            this.Ho.Location = new System.Drawing.Point(9, 85);
            this.Ho.Name = "Ho";
            this.Ho.Size = new System.Drawing.Size(48, 20);
            this.Ho.TabIndex = 43;
            this.Ho.Text = "Mô tả";
            // 
            // tbx_Mota
            // 
            this.tbx_Mota.Location = new System.Drawing.Point(99, 78);
            this.tbx_Mota.Name = "tbx_Mota";
            this.tbx_Mota.Size = new System.Drawing.Size(308, 27);
            this.tbx_Mota.TabIndex = 42;
            // 
            // Btn_TimKiem
            // 
            this.Btn_TimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.Btn_TimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_TimKiem.Location = new System.Drawing.Point(423, 122);
            this.Btn_TimKiem.Name = "Btn_TimKiem";
            this.Btn_TimKiem.Size = new System.Drawing.Size(123, 30);
            this.Btn_TimKiem.TabIndex = 49;
            this.Btn_TimKiem.Text = "Tìm Kiếm";
            this.Btn_TimKiem.UseVisualStyleBackColor = false;
            // 
            // Btn_Xoa
            // 
            this.Btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.Btn_Xoa.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Xoa.Location = new System.Drawing.Point(763, 85);
            this.Btn_Xoa.Name = "Btn_Xoa";
            this.Btn_Xoa.Size = new System.Drawing.Size(157, 52);
            this.Btn_Xoa.TabIndex = 46;
            this.Btn_Xoa.Text = "Xóa";
            this.Btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // Btn_Sua
            // 
            this.Btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.Btn_Sua.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Sua.Location = new System.Drawing.Point(869, 16);
            this.Btn_Sua.Name = "Btn_Sua";
            this.Btn_Sua.Size = new System.Drawing.Size(157, 52);
            this.Btn_Sua.TabIndex = 47;
            this.Btn_Sua.Text = "Sửa";
            this.Btn_Sua.UseVisualStyleBackColor = false;
            // 
            // Btn_Them
            // 
            this.Btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.Btn_Them.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Them.Location = new System.Drawing.Point(676, 16);
            this.Btn_Them.Name = "Btn_Them";
            this.Btn_Them.Size = new System.Drawing.Size(157, 52);
            this.Btn_Them.TabIndex = 48;
            this.Btn_Them.Text = "Thêm";
            this.Btn_Them.UseVisualStyleBackColor = false;
            // 
            // tbt_TimKiem
            // 
            this.tbt_TimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tbt_TimKiem.Location = new System.Drawing.Point(9, 122);
            this.tbt_TimKiem.Name = "tbt_TimKiem";
            this.tbt_TimKiem.PlaceholderText = "Tìm kiếm theo mã, tên ";
            this.tbt_TimKiem.Size = new System.Drawing.Size(398, 30);
            this.tbt_TimKiem.TabIndex = 50;
            // 
            // dgrid_Theloai
            // 
            this.dgrid_Theloai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_Theloai.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgrid_Theloai.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.dgrid_Theloai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_Theloai.Location = new System.Drawing.Point(33, 171);
            this.dgrid_Theloai.Name = "dgrid_Theloai";
            this.dgrid_Theloai.RowHeadersWidth = 51;
            this.dgrid_Theloai.RowTemplate.Height = 29;
            this.dgrid_Theloai.Size = new System.Drawing.Size(1074, 140);
            this.dgrid_Theloai.TabIndex = 51;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_MaTheLoai);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbx_TenTheLoai);
            this.groupBox2.Controls.Add(this.dgrid_ChiTietTheLoai);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Location = new System.Drawing.Point(12, 493);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1186, 287);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thể loại chi tiết";
            // 
            // dgrid_ChiTietTheLoai
            // 
            this.dgrid_ChiTietTheLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_ChiTietTheLoai.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgrid_ChiTietTheLoai.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.dgrid_ChiTietTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_ChiTietTheLoai.Location = new System.Drawing.Point(33, 170);
            this.dgrid_ChiTietTheLoai.Name = "dgrid_ChiTietTheLoai";
            this.dgrid_ChiTietTheLoai.RowHeadersWidth = 51;
            this.dgrid_ChiTietTheLoai.RowTemplate.Height = 29;
            this.dgrid_ChiTietTheLoai.Size = new System.Drawing.Size(1074, 107);
            this.dgrid_ChiTietTheLoai.TabIndex = 61;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(6, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Tìm kiếm theo mã, tên ";
            this.textBox1.Size = new System.Drawing.Size(404, 30);
            this.textBox1.TabIndex = 60;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(423, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 30);
            this.button1.TabIndex = 59;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(1004, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 52);
            this.button2.TabIndex = 56;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(1004, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 52);
            this.button3.TabIndex = 57;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(841, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(157, 52);
            this.button4.TabIndex = 58;
            this.button4.Text = "Thêm";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "Mã thể loại chi tiết";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(139, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(271, 27);
            this.textBox2.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 53;
            this.label4.Text = "Mô tả";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(139, 73);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(271, 27);
            this.textBox3.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 65;
            this.label5.Text = "Mã thể loại ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(423, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 63;
            this.label6.Text = "Tên thể loại";
            // 
            // tbx_TenTheLoai
            // 
            this.tbx_TenTheLoai.Location = new System.Drawing.Point(517, 77);
            this.tbx_TenTheLoai.Name = "tbx_TenTheLoai";
            this.tbx_TenTheLoai.Size = new System.Drawing.Size(242, 27);
            this.tbx_TenTheLoai.TabIndex = 62;
            // 
            // cmb_MaTheLoai
            // 
            this.cmb_MaTheLoai.FormattingEnabled = true;
            this.cmb_MaTheLoai.Location = new System.Drawing.Point(517, 23);
            this.cmb_MaTheLoai.Name = "cmb_MaTheLoai";
            this.cmb_MaTheLoai.Size = new System.Drawing.Size(242, 28);
            this.cmb_MaTheLoai.TabIndex = 66;
            // 
            // FrmTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1198, 782);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTheLoai";
            this.Text = "FrmTheLoai";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Theloai)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ChiTietTheLoai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_MaTheLoai;
        private System.Windows.Forms.Label Ho;
        private System.Windows.Forms.TextBox tbx_Mota;
        private System.Windows.Forms.Button Btn_TimKiem;
        private System.Windows.Forms.Button Btn_Xoa;
        private System.Windows.Forms.Button Btn_Sua;
        private System.Windows.Forms.Button Btn_Them;
        private System.Windows.Forms.TextBox tbt_TimKiem;
        private System.Windows.Forms.DataGridView dgrid_Theloai;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_TenTheLoai;
        private System.Windows.Forms.DataGridView dgrid_ChiTietTheLoai;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox cmb_MaTheLoai;
    }
}