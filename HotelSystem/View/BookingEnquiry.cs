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
    public partial class BookingEnquiry : Form
    {
        private Size originalFormSize;
        private Dictionary<Control, Rectangle> controlBounds = new Dictionary<Control, Rectangle>();
        public BookingEnquiry()
        {
            InitializeComponent();
            this.Load += BookingEnquiry_Load;
            this.Resize += BookingEnquiry_Resize;
        }

        private void BookingEnquiry_ResizeEvent(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
            string reservationId = richTextBox1.Text;
            richTextBox1.Visible= false;
            reservLabel.Visible= false;
            confirmButton.Visible= false;
            label1.Visible= false;
        }

        private void BookingEnquiry_Load(object sender, EventArgs e)
        {
            originalFormSize = this.ClientSize;

            foreach (Control c in panel1.Controls)
            {
                controlBounds[c] = c.Bounds;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BookingEnquiry_Resize(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
            //Console.WriteLine("Resize event fired!");
            if (originalFormSize.Width == 0 || originalFormSize.Height == 0)
                return;

            float xRatio = (float)this.ClientSize.Width / originalFormSize.Width;
            float yRatio = (float)this.ClientSize.Height / originalFormSize.Height;

            foreach (Control ctrl in panel1.Controls)
            {
                Rectangle orig = controlBounds[ctrl];
                ctrl.Width = (int)(orig.Width * xRatio);
                ctrl.Height = (int)(orig.Height * yRatio);
                ctrl.Left = (int)(orig.Left * xRatio);
                ctrl.Top = (int)(orig.Top * yRatio);
            }

            // Resize the panel to fill the form
            panel1.Width = this.ClientSize.Width;
            panel1.Height = this.ClientSize.Height;
            
        }
        
    }
}
