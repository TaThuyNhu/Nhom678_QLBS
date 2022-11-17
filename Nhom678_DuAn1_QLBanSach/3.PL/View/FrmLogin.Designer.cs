using System.Windows.Forms;

namespace _3.PL.View
{
    partial class FrmLogin
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
            this.btn_login = new System.Windows.Forms.Button();
            this.lb_quenmk = new System.Windows.Forms.Label();
            this.tbx_MK = new System.Windows.Forms.TextBox();
            this.tbx_DN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckb_save = new System.Windows.Forms.CheckBox();
            this.ptb_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Red;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(54, 481);
            this.btn_login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(370, 60);
            this.btn_login.TabIndex = 13;
            this.btn_login.Text = "ĐĂNG NHẬP";
            this.btn_login.UseVisualStyleBackColor = false;
            // 
            // lb_quenmk
            // 
            this.lb_quenmk.AutoSize = true;
            this.lb_quenmk.ForeColor = System.Drawing.Color.Red;
            this.lb_quenmk.Location = new System.Drawing.Point(317, 400);
            this.lb_quenmk.Name = "lb_quenmk";
            this.lb_quenmk.Size = new System.Drawing.Size(116, 20);
            this.lb_quenmk.TabIndex = 12;
            this.lb_quenmk.Text = "Quên mật khẩu?";
            // 
            // tbx_MK
            // 
            this.tbx_MK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_MK.Location = new System.Drawing.Point(54, 341);
            this.tbx_MK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_MK.Multiline = true;
            this.tbx_MK.Name = "tbx_MK";
            this.tbx_MK.PasswordChar = '*';
            this.tbx_MK.PlaceholderText = "Nhập mật khẩu";
            this.tbx_MK.Size = new System.Drawing.Size(370, 29);
            this.tbx_MK.TabIndex = 11;
            // 
            // tbx_DN
            // 
            this.tbx_DN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_DN.Location = new System.Drawing.Point(54, 281);
            this.tbx_DN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_DN.Multiline = true;
            this.tbx_DN.Name = "tbx_DN";
            this.tbx_DN.PlaceholderText = "Nhập tài khoản";
            this.tbx_DN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_DN.Size = new System.Drawing.Size(370, 29);
            this.tbx_DN.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(115, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 46);
            this.label1.TabIndex = 9;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // ckb_save
            // 
            this.ckb_save.AutoSize = true;
            this.ckb_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.ckb_save.ForeColor = System.Drawing.Color.Red;
            this.ckb_save.Location = new System.Drawing.Point(61, 400);
            this.ckb_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckb_save.Name = "ckb_save";
            this.ckb_save.Size = new System.Drawing.Size(124, 24);
            this.ckb_save.TabIndex = 14;
            this.ckb_save.Text = "Nhớ mật khẩu";
            this.ckb_save.UseVisualStyleBackColor = false;
            // 
            // ptb_logo
            // 
            this.ptb_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.ptb_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_logo.Location = new System.Drawing.Point(-2, -1);
            this.ptb_logo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ptb_logo.Name = "ptb_logo";
            this.ptb_logo.Size = new System.Drawing.Size(489, 163);
            this.ptb_logo.TabIndex = 8;
            this.ptb_logo.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(485, 591);
            this.Controls.Add(this.ckb_save);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lb_quenmk);
            this.Controls.Add(this.tbx_MK);
            this.Controls.Add(this.tbx_DN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptb_logo);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmLogin";
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_login;
        private Label lb_quenmk;
        private TextBox tbx_MK;
        private TextBox tbx_DN;
        private Label label1;
        private CheckBox ckb_save;
        private PictureBox ptb_logo;
    }
}
