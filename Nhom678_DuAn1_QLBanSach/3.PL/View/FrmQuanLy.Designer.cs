namespace _3.PL.View
{
    partial class FrmQuanLy
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
            this.Btn_TimKiem = new System.Windows.Forms.Button();
            this.Btn_Xoa = new System.Windows.Forms.Button();
            this.Btn_Sua = new System.Windows.Forms.Button();
            this.btn_SanPham = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(531, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý ";
            // 
            // Btn_TimKiem
            // 
            this.Btn_TimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.Btn_TimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_TimKiem.Location = new System.Drawing.Point(62, 413);
            this.Btn_TimKiem.Name = "Btn_TimKiem";
            this.Btn_TimKiem.Size = new System.Drawing.Size(157, 52);
            this.Btn_TimKiem.TabIndex = 8;
            this.Btn_TimKiem.Text = "Kho";
            this.Btn_TimKiem.UseVisualStyleBackColor = false;
            // 
            // Btn_Xoa
            // 
            this.Btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.Btn_Xoa.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Xoa.Location = new System.Drawing.Point(62, 338);
            this.Btn_Xoa.Name = "Btn_Xoa";
            this.Btn_Xoa.Size = new System.Drawing.Size(157, 52);
            this.Btn_Xoa.TabIndex = 9;
            this.Btn_Xoa.Text = "Tác Giả";
            this.Btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // Btn_Sua
            // 
            this.Btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.Btn_Sua.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Sua.Location = new System.Drawing.Point(62, 256);
            this.Btn_Sua.Name = "Btn_Sua";
            this.Btn_Sua.Size = new System.Drawing.Size(157, 52);
            this.Btn_Sua.TabIndex = 10;
            this.Btn_Sua.Text = "Nhà xuất bản";
            this.Btn_Sua.UseVisualStyleBackColor = false;
            // 
            // btn_SanPham
            // 
            this.btn_SanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.btn_SanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_SanPham.Location = new System.Drawing.Point(62, 168);
            this.btn_SanPham.Name = "btn_SanPham";
            this.btn_SanPham.Size = new System.Drawing.Size(157, 52);
            this.btn_SanPham.TabIndex = 11;
            this.btn_SanPham.Text = "Sách";
            this.btn_SanPham.UseVisualStyleBackColor = false;
            // 
            // FrmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1198, 782);
            this.Controls.Add(this.Btn_TimKiem);
            this.Controls.Add(this.Btn_Xoa);
            this.Controls.Add(this.Btn_Sua);
            this.Controls.Add(this.btn_SanPham);
            this.Controls.Add(this.panel1);
            this.Name = "FrmQuanLy";
            this.Text = "FrmQuanLy";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_TimKiem;
        private System.Windows.Forms.Button Btn_Xoa;
        private System.Windows.Forms.Button Btn_Sua;
        private System.Windows.Forms.Button btn_SanPham;
    }
}