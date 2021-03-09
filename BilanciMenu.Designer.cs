
namespace TrepcaApp
{
    partial class BilanciMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kryefaqjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilanciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largohuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kryefaqjaToolStripMenuItem,
            this.bilanciToolStripMenuItem,
            this.largohuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kryefaqjaToolStripMenuItem
            // 
            this.kryefaqjaToolStripMenuItem.Name = "kryefaqjaToolStripMenuItem";
            this.kryefaqjaToolStripMenuItem.Size = new System.Drawing.Size(76, 21);
            this.kryefaqjaToolStripMenuItem.Text = "Kryefaqja";
            // 
            // bilanciToolStripMenuItem
            // 
            this.bilanciToolStripMenuItem.Name = "bilanciToolStripMenuItem";
            this.bilanciToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.bilanciToolStripMenuItem.Text = "Bilanci";
            this.bilanciToolStripMenuItem.Click += new System.EventHandler(this.bilanciToolStripMenuItem_Click);
            // 
            // largohuToolStripMenuItem
            // 
            this.largohuToolStripMenuItem.Name = "largohuToolStripMenuItem";
            this.largohuToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.largohuToolStripMenuItem.Text = "Largohu";
            // 
            // BilanciMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BilanciMenu";
            this.Text = "BilanciMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kryefaqjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilanciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largohuToolStripMenuItem;
    }
}