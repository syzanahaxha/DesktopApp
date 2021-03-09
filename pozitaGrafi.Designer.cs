
namespace TrepcaApp
{
    partial class pozitaGrafi
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMbyll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(1, 0);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Numri i punetoreve";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(523, 224);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 225);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnMbyll
            // 
            this.btnMbyll.Location = new System.Drawing.Point(455, 427);
            this.btnMbyll.Name = "btnMbyll";
            this.btnMbyll.Size = new System.Drawing.Size(75, 23);
            this.btnMbyll.TabIndex = 3;
            this.btnMbyll.Text = "Mbyll";
            this.btnMbyll.UseVisualStyleBackColor = true;
            this.btnMbyll.Click += new System.EventHandler(this.btnMbyll_Click);
            // 
            // pozitaGrafi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMbyll);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart2);
            this.Name = "pozitaGrafi";
            this.Text = "pozitaGrafi";
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMbyll;
    }
}