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
    public partial class Bilanci : Form
    {
        public Bilanci()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            lblMuaji.Text = listBox1.SelectedItem.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        { 
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)

        {
            lblBilanciMujor.Visible = true;
            lblShpenzimeTotal.Visible = false;
            lblBilanciPaPaga.Visible = false;
            if (txtShitjet.Text =="" || txtShpenzimePagat.Text =="" || txtTatimi.Text =="" || txtMirembajtje.Text =="")

            {
                MessageBox.Show("Plotesoni fushat!");
                return;
            }
            else
            {
            double shitjet = double.Parse(txtShitjet.Text);
            double  pagat= double.Parse(txtShpenzimePagat.Text);
            double tatimi = double.Parse(txtTatimi.Text);
            double mirembajtje = double.Parse(txtMirembajtje.Text);

                double rezultati = 0;
                rezultati = shitjet - pagat - tatimi-mirembajtje;
                lblBilanciMujor.Text = rezultati.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblBilanciMujor.Visible = false;
            lblShpenzimeTotal.Visible = true;
            lblBilanciPaPaga.Visible = false;
            if (txtShitjet.Text == "" || txtShpenzimePagat.Text == "" || txtTatimi.Text == "" || txtMirembajtje.Text == "")

            {
                MessageBox.Show("Plotesoni fushat!");
                return;
            }
            else
            {
                double shitjet = double.Parse(txtShitjet.Text);
                double shpenzimet = double.Parse(txtShpenzimePagat.Text);
                double shpenzimetTjera = double.Parse(txtTatimi.Text);
                double mirembajtje = double.Parse(txtMirembajtje.Text);
                double rezultati = 0;
                rezultati = shpenzimet + shpenzimetTjera + mirembajtje;
                lblShpenzimeTotal.Text = rezultati.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)

        {
            lblBilanciMujor.Visible = false;
            lblShpenzimeTotal.Visible = false;
            lblBilanciPaPaga.Visible = true;

            if (txtShitjet.Text == "" || txtShpenzimePagat.Text == "" || txtTatimi.Text == "" || txtMirembajtje.Text == "")

            {
                MessageBox.Show("Plotesoni fushat!");
                return;
            }
            else
            {
                double shitjet = double.Parse(txtShitjet.Text);
                double shpenzimet = double.Parse(txtShpenzimePagat.Text);
                double shpenzimetTjera = double.Parse(txtTatimi.Text);
                double mirembajtje = double.Parse(txtMirembajtje.Text);
                double rezultati = 0;
                rezultati = shitjet - shpenzimetTjera - mirembajtje;
                lblBilanciPaPaga.Text = rezultati.ToString();
            }
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            lblMuaji.Text = listBox1.SelectedItem.ToString();
        }

        private void listBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            lblViti.Text = listBox2.SelectedItem.ToString();
        }

        private void lblViti_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtShitjet_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Duhet te jete numer!");
                return;
            }
        }

        private void txtShpenzimePagat_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Duhet te jete numer!");
                return;
            }
        }

        private void txtTatimi_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Duhet te jete numer!");
                return;
            }
        }

        private void txtMirembajtje_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Duhet te jete numer!");
                return;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView1.Rows.Add(lblViti.Text, lblMuaji.Text, txtShitjet.Text, txtShpenzimePagat.Text, txtTatimi.Text,
                txtMirembajtje.Text, lblBilanciMujor.Text, lblShpenzimeTotal.Text) ;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Visible = false;
            lblViti.Text = "";
            lblMuaji.Text = "";
            lblBilanciMujor.Text = "";
            lblBilanciPaPaga.Text = "";
            lblShpenzimeTotal.Text = "";
            txtShitjet.Text = "";
            txtShpenzimePagat.Text = "";
            txtTatimi.Text = "";
            txtMirembajtje.Text = "";




        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtShitjet_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtShitjet.Text = "";
            lblBilanciMujor.Text = "";
            lblBilanciPaPaga.Text = "";
            lblShpenzimeTotal.Text = "";

        }

        private void txtShpenzimePagat_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtShpenzimePagat.Text = "";
        }

        private void txtTatimi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtTatimi.Text = "";
        }

        private void txtMirembajtje_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtMirembajtje.Text = "";
        }
    }
}
