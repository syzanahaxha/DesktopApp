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
    public partial class Regjistrimi : Form
    {
        DataTable table = new DataTable("table");
        int index;
        public Regjistrimi()
        {
            InitializeComponent();
        }
        bool isEditing = false;

        private void Regjistrimi_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Id", Type.GetType("System.String"));
            table.Columns.Add("Emri", Type.GetType("System.String"));
            table.Columns.Add("Mbiemri", Type.GetType("System.String"));
            table.Columns.Add("Mosha", Type.GetType("System.String"));
            table.Columns.Add("Gjinia", Type.GetType("System.String"));
            table.Columns.Add("Adresa", Type.GetType("System.String"));
            table.Columns.Add("Telefoni", Type.GetType("System.String"));
            table.Columns.Add("Pozita", Type.GetType("System.String"));
            table.Columns.Add("DataPunesimit", Type.GetType("System.String"));
            dataGridViewRegjistrimi.DataSource = table;
        }

        private void dataGridViewRegjistrimi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnShto_Click(object sender, EventArgs e)
        {
            
            
            if (txtId.Text != "" && txtEmri.Text != "" && txtMbiemri.Text != "" && txtDataLindjes.Text != "" 
                && txtAdresa.Text != "" && txtTelefoni.Text !="" && txtDataPunesimit.Text !="")
            {

               

                table.Rows.Add(txtId.Text, txtEmri.Text, txtMbiemri.Text, txtDataLindjes.Text, cbGjinia.Text,
                               txtAdresa.Text, txtTelefoni.Text, cbPozita.Text, txtDataPunesimit.Text);

                MessageBox.Show("Punetori u shtua me sukses");
                txtId.Text = String.Empty;
                txtEmri.Text = String.Empty;
                txtMbiemri.Text = String.Empty;
                txtDataLindjes.Text = String.Empty;
                txtAdresa.Text = String.Empty;
                txtTelefoni.Text = String.Empty;
                txtDataPunesimit.Text = String.Empty;
                cbGjinia.SelectedItem = null;
                cbPozita.SelectedItem = null;
                return;
                
            }
            else
            {
                MessageBox.Show("Plotesoni fushat!");
            }
        }

        private void btnFshij_Click(object sender, EventArgs e)
        {
            txtId.Text = String.Empty;
            txtEmri.Text = String.Empty;
            txtMbiemri.Text = String.Empty;
            txtDataLindjes.Text = String.Empty;
            txtAdresa.Text = String.Empty;
            txtTelefoni.Text = String.Empty;
            txtDataPunesimit.Text = String.Empty;
            cbGjinia.SelectedItem = null;
            cbPozita.SelectedItem = null;


        }

        private void dataGridViewRegjistrimi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridViewRegjistrimi.Rows[index];
            //if(row == dataGridViewRegjistrimi.Rows[0])
            //{
            txtId.Text = row.Cells[0].Value.ToString();
            
            //}
            txtEmri.Text = row.Cells[1].Value.ToString();
            txtMbiemri.Text = row.Cells[2].Value.ToString();
            txtDataLindjes.Text = row.Cells[3].Value.ToString();
            cbGjinia.Text = row.Cells[4].Value.ToString();
            txtAdresa.Text = row.Cells[5].Value.ToString();
            txtTelefoni.Text = row.Cells[6].Value.ToString();
            cbPozita.Text = row.Cells[7].Value.ToString();
            txtDataPunesimit.Text = row.Cells[8].Value.ToString();


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnnNdrysho_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata = dataGridViewRegjistrimi.Rows[index];
            if (txtId.Text != newdata.Cells[0].Value)
            {
                lblNdrysho.Text = "Id ekziston!";

            
            };
                newdata.Cells[1].Value = txtEmri.Text;
                newdata.Cells[2].Value = txtMbiemri.Text;
                newdata.Cells[3].Value = txtDataLindjes.Text;
                newdata.Cells[4].Value = cbGjinia.Text;
                newdata.Cells[5].Value = txtAdresa.Text;
                newdata.Cells[6].Value = txtTelefoni.Text;
                newdata.Cells[7].Value = cbPozita.Text;
                newdata.Cells[8].Value = txtDataPunesimit.Text;


            txtId.Text = String.Empty;
            txtEmri.Text = String.Empty;
            txtMbiemri.Text = String.Empty;
            txtDataLindjes.Text = String.Empty;
            txtAdresa.Text = String.Empty;
            txtTelefoni.Text = String.Empty;
            txtDataPunesimit.Text = String.Empty;
            cbGjinia.SelectedItem = null;
            cbPozita.SelectedItem = null;



        }

        private void btnFshij_Click_1(object sender, EventArgs e)
        {
            index = dataGridViewRegjistrimi.CurrentCell.RowIndex;
            dataGridViewRegjistrimi.Rows.RemoveAt(index);
            txtId.Text = String.Empty;
            txtEmri.Text = String.Empty;
            txtMbiemri.Text = String.Empty;
            txtDataLindjes.Text = String.Empty;
            txtAdresa.Text = String.Empty;
            txtTelefoni.Text = String.Empty;
            txtDataPunesimit.Text = String.Empty;
            cbGjinia.SelectedItem = null;
            cbPozita.SelectedItem = null;
            MessageBox.Show("Punetori u fshij me sukses");
        }

        private void txtDataLindjes_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsDigit(ch) && ch !=8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Mosha duhet te jete numer!");
                return;
            }
        }

        public void dataGridViewRegjistrimi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Pagat pagat = new Pagat();
            pagat.txtPaga.Text = "";
            pagat.txtId.Text = this.dataGridViewRegjistrimi.CurrentRow.Cells[0].Value.ToString();
            pagat.txtEmri.Text = this.dataGridViewRegjistrimi.CurrentRow.Cells[1].Value.ToString();
            pagat.txtMbiemri.Text = this.dataGridViewRegjistrimi.CurrentRow.Cells[2].Value.ToString();
            pagat.txtMosha.Text = this.dataGridViewRegjistrimi.CurrentRow.Cells[7].Value.ToString();
            if (this.cbPozita.SelectedItem == "Teknik")
            {
                
                pagat.txtPaga.Text = "400 euro";
            }
            else if (this.cbPozita.SelectedItem == "Drejtor")
            {
                pagat.txtPaga.Text = "1200 euro";
            }
            else
            {
                pagat.txtPaga.Text = "800 euro";
            }

            pagat.ShowDialog();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefoni_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dataGridViewRegjistrimi_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
          

        }


    

    

        private void txtDataLindjes_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtId_Validated(object sender, EventArgs e)
        {
            
        }

        private void btnShto_Validated(object sender, EventArgs e)
        {
            
        }

        private void btnFshij_Validating(object sender, CancelEventArgs e)
        {
           
        }

       
    }
}
