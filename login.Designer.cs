
namespace TrepcaApp
{
    partial class login
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconClose = new FontAwesome.Sharp.IconPictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnKyqu = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(128)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 343);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.panel3.Controls.Add(this.iconClose);
            this.panel3.Controls.Add(this.txtPassword);
            this.panel3.Controls.Add(this.txtUsername);
            this.panel3.Controls.Add(this.btnKyqu);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.iconPictureBox2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.iconPictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(345, 333);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // iconClose
            // 
            this.iconClose.BackColor = System.Drawing.Color.Transparent;
            this.iconClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconClose.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconClose.IconSize = 19;
            this.iconClose.Location = new System.Drawing.Point(321, 3);
            this.iconClose.Name = "iconClose";
            this.iconClose.Size = new System.Drawing.Size(21, 19);
            this.iconClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconClose.TabIndex = 8;
            this.iconClose.TabStop = false;
            this.iconClose.Click += new System.EventHandler(this.iconClose_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.Location = new System.Drawing.Point(64, 194);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(217, 20);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsername.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtUsername.Location = new System.Drawing.Point(64, 118);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(217, 20);
            this.txtUsername.TabIndex = 6;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // btnKyqu
            // 
            this.btnKyqu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.btnKyqu.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnKyqu.FlatAppearance.BorderSize = 0;
            this.btnKyqu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKyqu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKyqu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKyqu.Location = new System.Drawing.Point(114, 257);
            this.btnKyqu.Name = "btnKyqu";
            this.btnKyqu.Size = new System.Drawing.Size(108, 34);
            this.btnKyqu.TabIndex = 5;
            this.btnKyqu.Text = "&Vazhdo";
            this.btnKyqu.UseVisualStyleBackColor = false;
            this.btnKyqu.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Location = new System.Drawing.Point(31, 220);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 2);
            this.panel5.TabIndex = 4;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ActiveBorder;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 27;
            this.iconPictureBox2.Location = new System.Drawing.Point(31, 190);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(27, 32);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox2.TabIndex = 3;
            this.iconPictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(137, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kyçu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Location = new System.Drawing.Point(31, 145);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 2);
            this.panel4.TabIndex = 2;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ActiveBorder;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 27;
            this.iconPictureBox1.Location = new System.Drawing.Point(31, 114);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(27, 32);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(345, 343);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnKyqu;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconClose;
    }
}