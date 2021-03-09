
namespace TrepcaApp
{
    partial class Bilanci
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muaji = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shitjet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tatimet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mirembajtja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bilancimujor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shpenzimetTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMirembajtje = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblViti = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblMuaji = new System.Windows.Forms.Label();
            this.txtTatimi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtShpenzimePagat = new System.Windows.Forms.TextBox();
            this.txtShitjet = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblBilanciPaPaga = new System.Windows.Forms.Label();
            this.lblShpenzimeTotal = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblBilanciMujor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.listBox1.ColumnWidth = 109;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Janar      \t",
            "Shkurt  ",
            "Mars",
            "Prill",
            "Maj",
            "Qeshor",
            "Korrik",
            "Gusht",
            "Shtator",
            "Tetor",
            "Nentor",
            "Dhjetor"});
            this.listBox1.Location = new System.Drawing.Point(85, 28);
            this.listBox1.MaximumSize = new System.Drawing.Size(218, 186);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(109, 160);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 389);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.25773F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.74227F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 389);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 383);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.viti,
            this.muaji,
            this.shitjet,
            this.pagat,
            this.tatimet,
            this.mirembajtja,
            this.bilancimujor,
            this.shpenzimetTotal});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.YellowGreen;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(383, 383);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // viti
            // 
            this.viti.HeaderText = "Viti";
            this.viti.Name = "viti";
            this.viti.ReadOnly = true;
            this.viti.Width = 46;
            // 
            // muaji
            // 
            this.muaji.HeaderText = "Muaji";
            this.muaji.Name = "muaji";
            this.muaji.ReadOnly = true;
            this.muaji.Width = 57;
            // 
            // shitjet
            // 
            this.shitjet.HeaderText = "Shitje";
            this.shitjet.Name = "shitjet";
            this.shitjet.ReadOnly = true;
            this.shitjet.Width = 58;
            // 
            // pagat
            // 
            this.pagat.HeaderText = "Paga";
            this.pagat.Name = "pagat";
            this.pagat.ReadOnly = true;
            this.pagat.Width = 57;
            // 
            // tatimet
            // 
            this.tatimet.HeaderText = "Tatime";
            this.tatimet.Name = "tatimet";
            this.tatimet.ReadOnly = true;
            this.tatimet.Width = 64;
            // 
            // mirembajtja
            // 
            this.mirembajtja.HeaderText = "Mirembajtje";
            this.mirembajtja.Name = "mirembajtja";
            this.mirembajtja.ReadOnly = true;
            this.mirembajtja.Width = 85;
            // 
            // bilancimujor
            // 
            this.bilancimujor.HeaderText = "Bilanci Mujor";
            this.bilancimujor.Name = "bilancimujor";
            this.bilancimujor.ReadOnly = true;
            this.bilancimujor.Width = 85;
            // 
            // shpenzimetTotal
            // 
            this.shpenzimetTotal.HeaderText = "Shpenzimet Total";
            this.shpenzimetTotal.Name = "shpenzimetTotal";
            this.shpenzimetTotal.ReadOnly = true;
            this.shpenzimetTotal.Width = 105;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.listBox2);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.listBox1);
            this.panel4.Location = new System.Drawing.Point(3, 94);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(377, 208);
            this.panel4.TabIndex = 5;
            // 
            // listBox2
            // 
            this.listBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.listBox2.ColumnWidth = 109;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2011"});
            this.listBox2.Location = new System.Drawing.Point(193, 28);
            this.listBox2.MaximumSize = new System.Drawing.Size(218, 186);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(109, 160);
            this.listBox2.TabIndex = 4;
            this.listBox2.SelectedValueChanged += new System.EventHandler(this.listBox2_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(191, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Viti";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(84, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Muaji ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(-5, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(385, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Zgjedh Muajin dhe Vitin ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.txtMirembajtje);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.txtTatimi);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtShpenzimePagat);
            this.panel3.Controls.Add(this.txtShitjet);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Location = new System.Drawing.Point(392, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(381, 383);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txtMirembajtje
            // 
            this.txtMirembajtje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMirembajtje.Location = new System.Drawing.Point(176, 186);
            this.txtMirembajtje.Name = "txtMirembajtje";
            this.txtMirembajtje.Size = new System.Drawing.Size(130, 20);
            this.txtMirembajtje.TabIndex = 4;
            this.txtMirembajtje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMirembajtje_KeyPress);
            this.txtMirembajtje.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtMirembajtje_MouseDoubleClick);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(11, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Mirembajtje (euro)";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.lblViti);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.lblMuaji);
            this.panel5.Location = new System.Drawing.Point(0, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(382, 74);
            this.panel5.TabIndex = 18;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // lblViti
            // 
            this.lblViti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblViti.AutoSize = true;
            this.lblViti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.lblViti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblViti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblViti.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViti.ForeColor = System.Drawing.Color.DarkKhaki;
            this.lblViti.Location = new System.Drawing.Point(265, 29);
            this.lblViti.Name = "lblViti";
            this.lblViti.Size = new System.Drawing.Size(2, 21);
            this.lblViti.TabIndex = 7;
            this.lblViti.Click += new System.EventHandler(this.lblViti_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(225, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Viti:";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(46, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Muaji:";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMuaji
            // 
            this.lblMuaji.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMuaji.AutoSize = true;
            this.lblMuaji.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.lblMuaji.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMuaji.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblMuaji.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMuaji.ForeColor = System.Drawing.Color.DarkKhaki;
            this.lblMuaji.Location = new System.Drawing.Point(118, 29);
            this.lblMuaji.Name = "lblMuaji";
            this.lblMuaji.Size = new System.Drawing.Size(2, 21);
            this.lblMuaji.TabIndex = 2;
            this.lblMuaji.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtTatimi
            // 
            this.txtTatimi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTatimi.Location = new System.Drawing.Point(176, 161);
            this.txtTatimi.Name = "txtTatimi";
            this.txtTatimi.Size = new System.Drawing.Size(130, 20);
            this.txtTatimi.TabIndex = 3;
            this.txtTatimi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTatimi_KeyPress);
            this.txtTatimi.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtTatimi_MouseDoubleClick);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(11, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tatimi (euro)";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(11, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Shpenzime per Paga";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(11, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Shitje (euro)";
            // 
            // txtShpenzimePagat
            // 
            this.txtShpenzimePagat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtShpenzimePagat.Location = new System.Drawing.Point(176, 136);
            this.txtShpenzimePagat.Name = "txtShpenzimePagat";
            this.txtShpenzimePagat.Size = new System.Drawing.Size(130, 20);
            this.txtShpenzimePagat.TabIndex = 2;
            this.txtShpenzimePagat.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtShpenzimePagat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShpenzimePagat_KeyPress);
            this.txtShpenzimePagat.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtShpenzimePagat_MouseDoubleClick);
            // 
            // txtShitjet
            // 
            this.txtShitjet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtShitjet.Location = new System.Drawing.Point(176, 111);
            this.txtShitjet.Name = "txtShitjet";
            this.txtShitjet.Size = new System.Drawing.Size(130, 20);
            this.txtShitjet.TabIndex = 1;
            this.txtShitjet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShitjet_KeyPress);
            this.txtShitjet.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtShitjet_MouseDoubleClick);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.lblBilanciPaPaga);
            this.panel6.Controls.Add(this.lblShpenzimeTotal);
            this.panel6.Controls.Add(this.button7);
            this.panel6.Controls.Add(this.button5);
            this.panel6.Controls.Add(this.button4);
            this.panel6.Controls.Add(this.button3);
            this.panel6.Controls.Add(this.lblBilanciMujor);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(0, 247);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(380, 135);
            this.panel6.TabIndex = 16;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // lblBilanciPaPaga
            // 
            this.lblBilanciPaPaga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBilanciPaPaga.AutoSize = true;
            this.lblBilanciPaPaga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.lblBilanciPaPaga.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBilanciPaPaga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBilanciPaPaga.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBilanciPaPaga.ForeColor = System.Drawing.Color.DarkKhaki;
            this.lblBilanciPaPaga.Location = new System.Drawing.Point(126, 36);
            this.lblBilanciPaPaga.Name = "lblBilanciPaPaga";
            this.lblBilanciPaPaga.Size = new System.Drawing.Size(2, 27);
            this.lblBilanciPaPaga.TabIndex = 19;
            this.lblBilanciPaPaga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBilanciPaPaga.Click += new System.EventHandler(this.label10_Click);
            // 
            // lblShpenzimeTotal
            // 
            this.lblShpenzimeTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblShpenzimeTotal.AutoSize = true;
            this.lblShpenzimeTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.lblShpenzimeTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShpenzimeTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblShpenzimeTotal.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShpenzimeTotal.ForeColor = System.Drawing.Color.DarkKhaki;
            this.lblShpenzimeTotal.Location = new System.Drawing.Point(126, 36);
            this.lblShpenzimeTotal.Name = "lblShpenzimeTotal";
            this.lblShpenzimeTotal.Size = new System.Drawing.Size(2, 27);
            this.lblShpenzimeTotal.TabIndex = 18;
            this.lblShpenzimeTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.button7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button7.Location = new System.Drawing.Point(281, 84);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(74, 42);
            this.button7.TabIndex = 6;
            this.button7.Text = "Raporti";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.button5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button5.Location = new System.Drawing.Point(193, 84);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 42);
            this.button5.TabIndex = 7;
            this.button5.Text = "Bilanci pa Paga";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.button4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button4.Location = new System.Drawing.Point(100, 84);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 42);
            this.button4.TabIndex = 6;
            this.button4.Text = "Shpenzime Total";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.button3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Location = new System.Drawing.Point(14, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 42);
            this.button3.TabIndex = 5;
            this.button3.Text = "Bilanci Mujor";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblBilanciMujor
            // 
            this.lblBilanciMujor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBilanciMujor.AutoSize = true;
            this.lblBilanciMujor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.lblBilanciMujor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBilanciMujor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBilanciMujor.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBilanciMujor.ForeColor = System.Drawing.Color.DarkKhaki;
            this.lblBilanciMujor.Location = new System.Drawing.Point(126, 36);
            this.lblBilanciMujor.Name = "lblBilanciMujor";
            this.lblBilanciMujor.Size = new System.Drawing.Size(2, 27);
            this.lblBilanciMujor.TabIndex = 15;
            this.lblBilanciMujor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(22, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Rezultati (euro)";
            // 
            // Bilanci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(776, 389);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bilanci";
            this.Text = "Bilanci";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblBilanciMujor;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button7;
        public System.Windows.Forms.Label lblMuaji;
        public System.Windows.Forms.TextBox txtShpenzimePagat;
        public System.Windows.Forms.TextBox txtShitjet;
        public System.Windows.Forms.Label lblViti;
        public System.Windows.Forms.TextBox txtTatimi;
        public System.Windows.Forms.TextBox txtMirembajtje;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn viti;
        private System.Windows.Forms.DataGridViewTextBoxColumn muaji;
        private System.Windows.Forms.DataGridViewTextBoxColumn shitjet;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagat;
        private System.Windows.Forms.DataGridViewTextBoxColumn tatimet;
        private System.Windows.Forms.DataGridViewTextBoxColumn mirembajtja;
        private System.Windows.Forms.Label lblBilanciPaPaga;
        private System.Windows.Forms.Label lblShpenzimeTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn bilancimujor;
        private System.Windows.Forms.DataGridViewTextBoxColumn shpenzimetTotal;
    }
}