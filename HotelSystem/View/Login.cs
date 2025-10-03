using HotelSystem.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSystem.View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

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
    }
}
