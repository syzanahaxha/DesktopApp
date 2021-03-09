using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TrepcaApp
{
    public partial class panelSideMenu : Form

    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public panelSideMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(10, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            //Form 
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }

        //Structs
        private struct rgbColors
        {
            public static Color color1 = Color.FromArgb(38, 40, 42);
            public static Color color2 = Color.FromArgb(28, 30, 33);
            public static Color color3 = Color.FromArgb(163, 206, 95);
            public static Color color4 = Color.FromArgb(50, 128, 51);

            //public static Color color1 = Color.FromArgb(50, 128, 51);
            //public static Color color2 = Color.FromArgb(31, 37, 34);
            //public static Color color3 = Color.FromArgb(172, 126, 24);
        }

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(38, 40, 42);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //LeftborderPadding
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon Current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;

            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(28, 30, 33);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //Open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, rgbColors.color4);
            OpenChildForm(new Mirembajtja());


        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, rgbColors.color4);
            OpenChildForm(new Bilanci());


        }

        private void btnMineralet_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, rgbColors.color4);
            OpenChildForm(new Mineralet());

        }

        private void btnRegjistrimi_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, rgbColors.color4);
            OpenChildForm(new Regjistrimi());

         

        }

        private void btnPagat_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, rgbColors.color4);
            OpenChildForm(new Pagat());


        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.Ivory;
            lblTitleChildForm.Text = "Home";
        }


        //Drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wPram, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void iconExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
