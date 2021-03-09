
namespace TrepcaApp
{
    partial class Raporti
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.muaji = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shitjet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tatime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mirembajtje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.muaji,
            this.viti,
            this.shitjet,
            this.paga,
            this.tatime,
            this.mirembajtje});
            this.dataGridView1.Location = new System.Drawing.Point(12, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // muaji
            // 
            this.muaji.HeaderText = "Muaji";
            this.muaji.Name = "muaji";
            this.muaji.ReadOnly = true;
            // 
            // viti
            // 
            this.viti.HeaderText = "Viti";
            this.viti.Name = "viti";
            this.viti.ReadOnly = true;
            // 
            // shitjet
            // 
            this.shitjet.HeaderText = "Shitjet";
            this.shitjet.Name = "shitjet";
            this.shitjet.ReadOnly = true;
            // 
            // paga
            // 
            this.paga.HeaderText = "Pagat";
            this.paga.Name = "paga";
            this.paga.ReadOnly = true;
            // 
            // tatime
            // 
            this.tatime.HeaderText = "Tatime";
            this.tatime.Name = "tatime";
            this.tatime.ReadOnly = true;
            // 
            // mirembajtje
            // 
            this.mirembajtje.HeaderText = "Mirembajtje";
            this.mirembajtje.Name = "mirembajtje";
            this.mirembajtje.ReadOnly = true;
            // 
            // Raporti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Raporti";
            this.Text = "Raporti";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn muaji;
        private System.Windows.Forms.DataGridViewTextBoxColumn viti;
        private System.Windows.Forms.DataGridViewTextBoxColumn shitjet;
        private System.Windows.Forms.DataGridViewTextBoxColumn paga;
        private System.Windows.Forms.DataGridViewTextBoxColumn tatime;
        private System.Windows.Forms.DataGridViewTextBoxColumn mirembajtje;
    }
}