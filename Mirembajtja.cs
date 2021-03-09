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
    public partial class Mirembajtja : Form
    {
        public Mirembajtja()
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

            chart1.Series["Numri i punetoreve"].Points.AddXY("Drejtor", 3);
            chart1.Series["Numri i punetoreve"].Points.AddXY("Minator", 600);
            chart1.Series["Numri i punetoreve"].Points.AddXY("Teknik", 300);
            chart1.Series["Numri i punetoreve"].Points.AddXY("Mbikqyres", 100);
            chart1.Series["Numri i punetoreve"].Points.AddXY("Vozites", 5);
            chart1.Series["Numri i punetoreve"].Points.AddXY("Mirembajtes", 120);


            chart1.Series["Paga"].Points.AddXY("Drejtor", 1200);
            chart1.Series["Paga"].Points.AddXY("Minator", 900);
            chart1.Series["Paga"].Points.AddXY("Teknik", 600);
            chart1.Series["Paga"].Points.AddXY("Mbikqyres", 800);
            chart1.Series["Paga"].Points.AddXY("Vozites", 1000);
            chart1.Series["Paga"].Points.AddXY("Mirembajtes", 1300);


        }

        private void ttbtn1_Popup(object sender, PopupEventArgs e)
        {
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            
            lblUser1.Visible = true;
            lblUser2.Visible = true;
            lblUser3.Visible = true;

            lblZyrtari1.Visible = true;
            lblZyrtari2.Visible = true;
            lblZyrtari3.Visible = true;

            btnShto.Visible = true;
            btnRegjistro.Visible = true;
            btnFshij.Visible = true;

            txtEmri.Visible = false;
            txtMbiemri.Visible = false;
            lblEmri.Visible = false;
            lblMbiemri.Visible = false;

            dateTimePicker1.Visible = false;
            iconButton1.Visible = false; 

            chart1.Visible = false;
            dataGridView1.Visible = false;

            lblThenie.Visible = false;
           
            button1.BackColor = Color.FromArgb(28, 30, 33);
            button1.Text = "Zyrtaret";
            button1.ForeColor = Color.FromArgb(255, 255, 255);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(50, 128, 51);
            button1.Text = "";
        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(28, 30, 33);
            button5.BackColor = Color.FromArgb(28, 30, 33);
            button5.Text = "Modi i Erret";
            button5.ForeColor = Color.FromArgb(255, 255, 255);


        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void button5_Leave(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(50, 128, 51);
            button5.Text = "";
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(60, 138, 61);
            button4.BackColor = Color.FromArgb(28, 30, 33);
            button4.Text = "Modi i Gjelbert";
            button4.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void button4_Leave(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(50, 128, 51);
            button4.Text = "";
        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            lblUser1.Visible = false;
            lblUser2.Visible = false;
            lblUser3.Visible = false;
            lblUser4.Visible = false;

            lblZyrtari1.Visible = false;
            lblZyrtari2.Visible = false;
            lblZyrtari3.Visible = false;
            lblZyrtari4.Visible = false;

            lblEmri.Visible = true;
            lblMbiemri.Visible = true;
            txtEmri.Visible = true;
            txtMbiemri.Visible = true;
            dateTimePicker1.Visible = false;
            iconButton1.Visible = false;


            chart1.Visible = false;
           dataGridView1.Visible = false;
            lblThenie.Visible = false;

           
        }

        private void btnShto_Leave(object sender, EventArgs e)
        {
            
        }

        

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(38, 41, 43);
            button3.BackColor = Color.FromArgb(28, 30, 33);
            button3.Text = "Modi Normal";
            button3.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void button3_Leave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(50, 128, 51);
            button3.Text = "";
        }

        private void btn2_Click(object sender, EventArgs e)

        {
            btn2.Text = "Grafi Pozitat";
            btn2.BackColor = Color.FromArgb(28, 30, 33);
            lblUser1.Visible = false;
            lblUser2.Visible = false;
            lblUser3.Visible = false;
            lblUser4.Visible = false;
            btnFshij.Visible = false;

            lblZyrtari1.Visible = false;
            lblZyrtari2.Visible = false;
            lblZyrtari3.Visible = false;
            lblZyrtari4.Visible = false;

            lblEmri.Visible = false;
            lblMbiemri.Visible = false;
            txtEmri.Visible = false;
            txtMbiemri.Visible = false;
            btnRegjistro.Visible = false;
            btnShto.Visible = false;
            dateTimePicker1.Visible = false;
            iconButton1.Visible = false;



            chart1.Visible = true;
            dataGridView1.Visible = true;

            lblThenie.Visible = false;
           
        }

        private void btnRegjistro_MouseClick(object sender, MouseEventArgs e)
        {
            lblUser3.Text = txtEmri.Text + " " + txtMbiemri.Text;
            lblUser1.Visible = true;
            lblUser2.Visible = true;
            lblUser3.Visible = true;

            lblZyrtari1.Visible = true;
            lblZyrtari2.Visible = true;
            lblZyrtari3.Visible = true;

            lblEmri.Visible = false;
            lblMbiemri.Visible = false;

            txtEmri.Visible = false;
            txtMbiemri.Visible = false;
            dateTimePicker1.Visible = false;
            iconButton1.Visible = false;


            chart1.Visible = false;
            dataGridView1.Visible = false;
            lblThenie.Visible = false;
        }

        private void tbnFshij_Click(object sender, EventArgs e)
        {
            txtEmri.Text = "";
            txtMbiemri.Text = "";
            lblUser3.Text = "";
            lblUser1.Visible = true;
            lblUser2.Visible = true;
            lblUser3.Visible = true;
            lblUser4.Visible = false;
            

            lblZyrtari1.Visible = true;
            lblZyrtari2.Visible = true;
            lblZyrtari3.Visible = true;
            lblZyrtari4.Visible = false;

            lblEmri.Visible = false;
            lblMbiemri.Visible = false;
            txtEmri.Visible = false;
            txtMbiemri.Visible = false;

            chart1.Visible = false;
            iconButton1.Visible = false;

            dataGridView1.Visible = false;
            lblThenie.Visible = false;
            dateTimePicker1.Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "Reflektim";
            button2.BackColor = Color.FromArgb(28, 30, 33);
            lblUser1.Visible = false;
            lblUser2.Visible = false;
            lblUser3.Visible = false;

            lblZyrtari1.Visible = false;
            lblZyrtari2.Visible = false;
            lblZyrtari3.Visible = false;

            btnShto.Visible = false;
            btnRegjistro.Visible = false;
            btnFshij.Visible = false;

            txtEmri.Visible = false;
            txtMbiemri.Visible = false;
            lblEmri.Visible = false;
            lblMbiemri.Visible = false;

            chart1.Visible = false;
            dataGridView1.Visible = false;
            dateTimePicker1.Visible = false;
            iconButton1.Visible = false;

            lblThenie.Visible = true;
        }

        private void button2_Leave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(50, 128, 51);
            button2.Text = "";
        }

        private void btn2_Leave(object sender, EventArgs e)
        {
            btn2.BackColor = Color.FromArgb(50, 128, 51);
            btn2.Text = "";
        }

        private void lblThenie_Click(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            btn4.Text = "Pamje e kostimizuar";
            btn4.BackColor = Color.FromArgb(28, 30, 33);
           
            panel2.BorderStyle = BorderStyle.FixedSingle;
            dateTimePicker1.Visible = true;
            iconButton1.Visible = false;

        }

        private void btn4_Leave(object sender, EventArgs e)
        {
            btn4.BackColor = Color.FromArgb(50, 128, 51);
            btn4.Text = "";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            iconButton1.Visible = true;
            btn3.Text = "Largohu";
            btn3.BackColor = Color.FromArgb(28, 30, 33);
        }

        private void btn3_Leave(object sender, EventArgs e)
        {
            btn3.BackColor = Color.FromArgb(50, 128, 51);
            btn3.Text = "";
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            

        }
    }
}
