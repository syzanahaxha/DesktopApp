
namespace TrepcaApp
{
    partial class Pagat
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
            System.Windows.Forms.Button btnZgjedhPunetorin;
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPaga = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMbiemri = new System.Windows.Forms.TextBox();
            this.txtEmri = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtMosha = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            btnZgjedhPunetorin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnZgjedhPunetorin
            // 
            btnZgjedhPunetorin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            btnZgjedhPunetorin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(138)))), ((int)(((byte)(61)))));
            btnZgjedhPunetorin.FlatAppearance.BorderSize = 0;
            btnZgjedhPunetorin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnZgjedhPunetorin.ForeColor = System.Drawing.SystemColors.Window;
            btnZgjedhPunetorin.Location = new System.Drawing.Point(425, 26);
            btnZgjedhPunetorin.Name = "btnZgjedhPunetorin";
            btnZgjedhPunetorin.Size = new System.Drawing.Size(141, 50);
            btnZgjedhPunetorin.TabIndex = 8;
            btnZgjedhPunetorin.Text = "&Zgjedh &Punetorin";
            btnZgjedhPunetorin.UseVisualStyleBackColor = false;
            btnZgjedhPunetorin.Click += new System.EventHandler(this.btnZgjedhPunetorin_Click_1);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(22, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 470);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(btnZgjedhPunetorin);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPaga);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMbiemri);
            this.groupBox1.Controls.Add(this.txtEmri);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.txtMosha);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 470);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informatat e Punetorit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Paga";
            // 
            // txtPaga
            // 
            this.txtPaga.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaga.Location = new System.Drawing.Point(224, 353);
            this.txtPaga.Name = "txtPaga";
            this.txtPaga.ReadOnly = true;
            this.txtPaga.Size = new System.Drawing.Size(171, 42);
            this.txtPaga.TabIndex = 6;
            this.txtPaga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPaga.TextChanged += new System.EventHandler(this.txtPaga_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mbiemri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pozita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Emri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // txtMbiemri
            // 
            this.txtMbiemri.Location = new System.Drawing.Point(117, 195);
            this.txtMbiemri.Name = "txtMbiemri";
            this.txtMbiemri.ReadOnly = true;
            this.txtMbiemri.Size = new System.Drawing.Size(152, 27);
            this.txtMbiemri.TabIndex = 3;
            // 
            // txtEmri
            // 
            this.txtEmri.Location = new System.Drawing.Point(117, 144);
            this.txtEmri.Name = "txtEmri";
            this.txtEmri.ReadOnly = true;
            this.txtEmri.Size = new System.Drawing.Size(152, 27);
            this.txtEmri.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(117, 96);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(152, 27);
            this.txtId.TabIndex = 1;
            // 
            // txtMosha
            // 
            this.txtMosha.Location = new System.Drawing.Point(117, 244);
            this.txtMosha.Name = "txtMosha";
            this.txtMosha.ReadOnly = true;
            this.txtMosha.Size = new System.Drawing.Size(152, 27);
            this.txtMosha.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(652, 24);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // Pagat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(652, 522);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(652, 522);
            this.MinimumSize = new System.Drawing.Size(652, 522);
            this.Name = "Pagat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagat";
            this.Load += new System.EventHandler(this.Pagat_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox txtPaga;
        public System.Windows.Forms.TextBox txtMbiemri;
        public System.Windows.Forms.TextBox txtEmri;
        public System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.TextBox txtMosha;
    }
}