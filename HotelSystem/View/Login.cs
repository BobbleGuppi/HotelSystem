using HotelSystem.Logic;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HotelSystem.View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            CenterPanel(panel1);
        }

        private void Login_Resize(object sender, EventArgs e)
        {
            CenterPanel(panel1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Receptionist rec = new Receptionist("1", "Phumla", "0123456789", "123 Street", "Strawberry", "phumla@hote1");
            if (rec.login(usernamebtn.Text, passwordbtn.Text))
            {
                MessageBox.Show("Login Successful");
                this.Hide();
                Home frm = new Home();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login Failed. Please try again.");
            }
        }

        private void CenterPanel(Panel panel)
        {
            panel.Location = new Point(
                (this.ClientSize.Width - panel.Width) / 2,
                (this.ClientSize.Height - panel.Height) / 2
            );
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}

