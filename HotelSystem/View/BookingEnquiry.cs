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
    public partial class BookingEnquiryForm : Form
    {
        public BookingEnquiryForm()
        {
            InitializeComponent();
        }

        private void reservLabel_Click(object sender, EventArgs e)
        {

        }

        private void RIDTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string reservationID = richTextBox1.Text;
        }

        private void BookingEnquiryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
