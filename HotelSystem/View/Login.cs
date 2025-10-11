using HotelSystem.Logic;
using System;
using System.Drawing;
using System.Threading.Tasks;
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

        private async void button1_Click(object sender, EventArgs e)
        {
            Receptionist rec = new Receptionist("1", "Dirk Snyman", "0123456789", "123 Street", "Clerk00", "phumla@hote1");

            if (rec.login(usernamebtn.Text, passwordbtn.Text))
            {
                // Hide the login panel
                panel1.Visible = false;
                this.BackColor = Color.FromArgb(10, 25, 60); // dark blue tone
                this.BackgroundImageLayout = ImageLayout.Stretch;

                // Create a welcome label
                Label welcomeLabel = new Label();
                welcomeLabel.Text = $"Welcome, {rec.Name}...";
                welcomeLabel.Font = new Font("Segoe UI", 28, FontStyle.Regular);
                welcomeLabel.ForeColor = Color.White;
                welcomeLabel.BackColor = Color.Transparent;
                welcomeLabel.AutoSize = true;

                // Center it on screen
                welcomeLabel.Left = (this.ClientSize.Width - welcomeLabel.Width) / 2;
                welcomeLabel.Top = (this.ClientSize.Height - welcomeLabel.Height) / 2;

                this.Controls.Add(welcomeLabel);
                welcomeLabel.BringToFront();

                // Wait 2.5 seconds
                await Task.Delay(2500);

                // Continue to Home form
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

