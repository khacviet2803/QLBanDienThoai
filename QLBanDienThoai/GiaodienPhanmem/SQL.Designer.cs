namespace GiaodienPhanmem
{
    partial class SQL
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelmain = new System.Windows.Forms.Panel();
            this.panel_connect = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cONNECTIONSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblwellcome = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtaccount = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelmain.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelmain
            // 
            this.panelmain.Controls.Add(this.panel_connect);
            this.panelmain.Controls.Add(this.menuStrip1);
            this.panelmain.Controls.Add(this.lblwellcome);
            this.panelmain.Controls.Add(this.button2);
            this.panelmain.Controls.Add(this.pictureBox1);
            this.panelmain.Controls.Add(this.btnlogin);
            this.panelmain.Controls.Add(this.txtaccount);
            this.panelmain.Controls.Add(this.txtpass);
            this.panelmain.Controls.Add(this.label1);
            this.panelmain.Controls.Add(this.label2);
            this.panelmain.Controls.Add(this.label3);
            this.panelmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmain.Location = new System.Drawing.Point(0, 0);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(951, 415);
            this.panelmain.TabIndex = 10;
            this.panelmain.MouseHover += new System.EventHandler(this.panelmain_MouseHover);
            // 
            // panel_connect
            // 
            this.panel_connect.Location = new System.Drawing.Point(428, 76);
            this.panel_connect.Name = "panel_connect";
            this.panel_connect.Size = new System.Drawing.Size(511, 327);
            this.panel_connect.TabIndex = 10;
            this.panel_connect.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_connect_MouseMove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cONNECTIONSQLToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(169, 29);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cONNECTIONSQLToolStripMenuItem
            // 
            this.cONNECTIONSQLToolStripMenuItem.BackColor = System.Drawing.Color.Brown;
            this.cONNECTIONSQLToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cONNECTIONSQLToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cONNECTIONSQLToolStripMenuItem.Name = "cONNECTIONSQLToolStripMenuItem";
            this.cONNECTIONSQLToolStripMenuItem.Size = new System.Drawing.Size(161, 25);
            this.cONNECTIONSQLToolStripMenuItem.Text = "CONNECTION SQL";
            this.cONNECTIONSQLToolStripMenuItem.Click += new System.EventHandler(this.cONNECTSQLToolStripMenuItem_Click);
            // 
            // lblwellcome
            // 
            this.lblwellcome.AutoSize = true;
            this.lblwellcome.BackColor = System.Drawing.Color.White;
            this.lblwellcome.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwellcome.ForeColor = System.Drawing.Color.Brown;
            this.lblwellcome.Location = new System.Drawing.Point(12, 33);
            this.lblwellcome.Name = "lblwellcome";
            this.lblwellcome.Size = new System.Drawing.Size(433, 26);
            this.lblwellcome.TabIndex = 2;
            this.lblwellcome.Text = "CHÀO MỪNG ĐẾN VỚI CỬA HÀNG ĐIỆN THOẠI HTL";
            this.lblwellcome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Brown;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(696, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 39);
            this.button2.TabIndex = 5;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GiaodienPhanmem.Properties.Resources.admin_login1;
            this.pictureBox1.Location = new System.Drawing.Point(70, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 327);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Brown;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnlogin.Location = new System.Drawing.Point(567, 219);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(116, 39);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Đăng nhập";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtaccount
            // 
            this.txtaccount.Location = new System.Drawing.Point(567, 134);
            this.txtaccount.Name = "txtaccount";
            this.txtaccount.Size = new System.Drawing.Size(224, 20);
            this.txtaccount.TabIndex = 1;
            this.txtaccount.TextChanged += new System.EventHandler(this.txtadmin_TextChanged);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(567, 176);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(224, 20);
            this.txtpass.TabIndex = 3;
            this.txtpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpass_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(536, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP TÀI KHOẢN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(452, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(486, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật Khẩu";
            // 
            // SQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(951, 415);
            this.Controls.Add(this.panelmain);
            this.Name = "SQL";
            this.Text = "SQL";
            this.Load += new System.EventHandler(this.SQL_Load);
            this.panelmain.ResumeLayout(false);
            this.panelmain.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelmain;
        private System.Windows.Forms.Panel panel_connect;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cONNECTIONSQLToolStripMenuItem;
        private System.Windows.Forms.Label lblwellcome;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtaccount;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}