namespace _3.PL.View
{
    partial class FrmKho
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_MaKho = new System.Windows.Forms.TextBox();
            this.Btn_Xoa = new System.Windows.Forms.Button();
            this.Btn_Sua = new System.Windows.Forms.Button();
            this.Btn_Them = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Ho = new System.Windows.Forms.Label();
            this.tbx_NgayXuat = new System.Windows.Forms.TextBox();
            this.tbx_NgayNhap = new System.Windows.Forms.TextBox();
            this.tbx_SoLuong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_SlConLai = new System.Windows.Forms.TextBox();
            this.dgrid_Kho = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Kho)).BeginInit();
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
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(462, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý Kho";
            // 
            // tbt_TimKiem
            // 
            this.tbt_TimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tbt_TimKiem.Location = new System.Drawing.Point(42, 434);
            this.tbt_TimKiem.Name = "tbt_TimKiem";
            this.tbt_TimKiem.PlaceholderText = "Tìm kiếm theo mã, tên ";
            this.tbt_TimKiem.Size = new System.Drawing.Size(728, 30);
            this.tbt_TimKiem.TabIndex = 43;
            // 
            // Btn_TimKiem
            // 
            this.Btn_TimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.Btn_TimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_TimKiem.Location = new System.Drawing.Point(1004, 391);
            this.Btn_TimKiem.Name = "Btn_TimKiem";
            this.Btn_TimKiem.Size = new System.Drawing.Size(157, 52);
            this.Btn_TimKiem.TabIndex = 42;
            this.Btn_TimKiem.Text = "Tìm Kiếm";
            this.Btn_TimKiem.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Mã kho";
            // 
            // tbx_MaKho
            // 
            this.tbx_MaKho.Location = new System.Drawing.Point(186, 168);
            this.tbx_MaKho.Name = "tbx_MaKho";
            this.tbx_MaKho.Size = new System.Drawing.Size(308, 27);
            this.tbx_MaKho.TabIndex = 40;
            // 
            // Btn_Xoa
            // 
            this.Btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.Btn_Xoa.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Xoa.Location = new System.Drawing.Point(1004, 313);
            this.Btn_Xoa.Name = "Btn_Xoa";
            this.Btn_Xoa.Size = new System.Drawing.Size(157, 52);
            this.Btn_Xoa.TabIndex = 37;
            this.Btn_Xoa.Text = "Xóa";
            this.Btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // Btn_Sua
            // 
            this.Btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.Btn_Sua.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Sua.Location = new System.Drawing.Point(1004, 231);
            this.Btn_Sua.Name = "Btn_Sua";
            this.Btn_Sua.Size = new System.Drawing.Size(157, 52);
            this.Btn_Sua.TabIndex = 38;
            this.Btn_Sua.Text = "Sửa";
            this.Btn_Sua.UseVisualStyleBackColor = false;
            // 
            // Btn_Them
            // 
            this.Btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.Btn_Them.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Them.Location = new System.Drawing.Point(1004, 143);
            this.Btn_Them.Name = "Btn_Them";
            this.Btn_Them.Size = new System.Drawing.Size(157, 52);
            this.Btn_Them.TabIndex = 39;
            this.Btn_Them.Text = "Thêm";
            this.Btn_Them.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Ngày xuất";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "Ngày nhập";
            // 
            // Ho
            // 
            this.Ho.AutoSize = true;
            this.Ho.Location = new System.Drawing.Point(42, 227);
            this.Ho.Name = "Ho";
            this.Ho.Size = new System.Drawing.Size(69, 20);
            this.Ho.TabIndex = 36;
            this.Ho.Text = "Số lượng";
            // 
            // tbx_NgayXuat
            // 
            this.tbx_NgayXuat.Location = new System.Drawing.Point(186, 324);
            this.tbx_NgayXuat.Name = "tbx_NgayXuat";
            this.tbx_NgayXuat.Size = new System.Drawing.Size(308, 27);
            this.tbx_NgayXuat.TabIndex = 32;
            // 
            // tbx_NgayNhap
            // 
            this.tbx_NgayNhap.Location = new System.Drawing.Point(186, 272);
            this.tbx_NgayNhap.Name = "tbx_NgayNhap";
            this.tbx_NgayNhap.Size = new System.Drawing.Size(308, 27);
            this.tbx_NgayNhap.TabIndex = 31;
            // 
            // tbx_SoLuong
            // 
            this.tbx_SoLuong.Location = new System.Drawing.Point(186, 220);
            this.tbx_SoLuong.Name = "tbx_SoLuong";
            this.tbx_SoLuong.Size = new System.Drawing.Size(308, 27);
            this.tbx_SoLuong.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "Số lượng còn lại";
            // 
            // tbx_SlConLai
            // 
            this.tbx_SlConLai.Location = new System.Drawing.Point(186, 370);
            this.tbx_SlConLai.Name = "tbx_SlConLai";
            this.tbx_SlConLai.Size = new System.Drawing.Size(308, 27);
            this.tbx_SlConLai.TabIndex = 44;
            // 
            // dgrid_Kho
            // 
            this.dgrid_Kho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_Kho.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgrid_Kho.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.dgrid_Kho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_Kho.Location = new System.Drawing.Point(42, 534);
            this.dgrid_Kho.Name = "dgrid_Kho";
            this.dgrid_Kho.RowHeadersWidth = 51;
            this.dgrid_Kho.RowTemplate.Height = 29;
            this.dgrid_Kho.Size = new System.Drawing.Size(1119, 236);
            this.dgrid_Kho.TabIndex = 46;
            // 
            // FrmKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1198, 782);
            this.Controls.Add(this.dgrid_Kho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_SlConLai);
            this.Controls.Add(this.tbt_TimKiem);
            this.Controls.Add(this.Btn_TimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_MaKho);
            this.Controls.Add(this.Btn_Xoa);
            this.Controls.Add(this.Btn_Sua);
            this.Controls.Add(this.Btn_Them);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Ho);
            this.Controls.Add(this.tbx_NgayXuat);
            this.Controls.Add(this.tbx_NgayNhap);
            this.Controls.Add(this.tbx_SoLuong);
            this.Controls.Add(this.panel1);
            this.Name = "FrmKho";
            this.Text = "FrmKho";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Kho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbt_TimKiem;
        private System.Windows.Forms.Button Btn_TimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_MaKho;
        private System.Windows.Forms.Button Btn_Xoa;
        private System.Windows.Forms.Button Btn_Sua;
        private System.Windows.Forms.Button Btn_Them;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Ho;
        private System.Windows.Forms.TextBox tbx_NgayXuat;
        private System.Windows.Forms.TextBox tbx_NgayNhap;
        private System.Windows.Forms.TextBox tbx_SoLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_SlConLai;
        private System.Windows.Forms.DataGridView dgrid_Kho;
    }
}