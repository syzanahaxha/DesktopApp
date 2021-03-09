using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace TrepcaApp
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)                

        {
            txtUsername.Focus();

            if (txtUsername.Text == "syzanahaxha" && txtPassword.Text == "1234")
            {
               
                new panelSideMenu().Show();
                this.Hide();
               
            }
            else if (txtUsername.Text == "edonisabajraktari" && txtPassword.Text == "1234")
            {
                new panelSideMenu().Show();
                this.Hide();
              
            }
            else
            {
                MessageBox.Show("Llogaria nuk ekziston!");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            this.Focus();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wPram, int lParam);


        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
    }
}
