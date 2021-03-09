using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrepcaApp
{
    public partial class pozitaGrafi : Form
    {
        public pozitaGrafi()
        {
            InitializeComponent();

            DataTable Table = new DataTable();

            Table.Columns.Add("Pozita");
            Table.Columns.Add("Numri i punetoreve");
            Table.Columns.Add("Paga");


            Table.Rows.Add("Drejtor", 3, 1200);
            Table.Rows.Add("Vozites i lokomotives", 5, 1000);
            Table.Rows.Add("Mirembajtes", 120, 1300);
            Table.Rows.Add("Mbikqyres", 100, 800);
            Table.Rows.Add("Minator", 600, 900);
            Table.Rows.Add("Teknik", 300, 600);


            dataGridView1.DataSource = Table;

            chart2.Series["Numri i punetoreve"].Points.AddXY("Drejtor", 3);
            chart2.Series["Numri i punetoreve"].Points.AddXY("Minator", 600);
            chart2.Series["Numri i punetoreve"].Points.AddXY("Teknik", 300);
            chart2.Series["Numri i punetoreve"].Points.AddXY("Mbikqyres", 100);
            chart2.Series["Numri i punetoreve"].Points.AddXY("Vozites", 5);
            chart2.Series["Numri i punetoreve"].Points.AddXY("Mirembajtes", 120);

        }

        private void btnMbyll_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
