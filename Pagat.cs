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
    public partial class Pagat : Form
    {
        public Pagat()
        {
            InitializeComponent();
        }

        

        private void Pagat_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = "Paga e " + txtEmri.Text + " " + txtMbiemri.Text;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnZgjedhPunetorin_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }


        //Drag Form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wPram, int lParam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtPaga_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
