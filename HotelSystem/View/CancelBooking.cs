using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelSystem.Logic;
using HotelSystem.Database;

namespace HotelSystem.View
{
    public partial class CancelBooking : Form
    {
        private ReservationController Rcontroller;
        private Reservation foundReservation;
        private ReservationDB reservationDB;
        private GuestController guestController;
        private Guest foundGuest;
        private Size originalFormSize;
        private Dictionary<Control, Rectangle> controlBounds = new Dictionary<Control, Rectangle>();

        private int screen = 0; // 0= entering the ID screen 1= booking found confirmation 2= final delete confrimation
        

        public CancelBooking()
        {
            InitializeComponent();
            Rcontroller = new ReservationController();
            reservationDB = new ReservationDB();
            guestController = new GuestController();
            this.Resize += CancelBooking_Resize;
            this.Load += CancelBooking_Load;


            ResetToScreen0(); // this is the Initial state
        }

        private void CancelBooking_Load(object sender, EventArgs e)
        {
            ResetToScreen0();
        }

        

        public void reservationNumLabel_Click(object sender, EventArgs e)
        {

        }
        private void ConfirmButton_Click_1(object sender, EventArgs e)
        {
            if (screen == 0)
            {
                string reservationid = textBoxForReservationID.Text.Trim();

                if (string.IsNullOrWhiteSpace(reservationid))
                {
                    MessageBox.Show("Reservation ID field must not be empty.",
                        "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    foundReservation = Rcontroller.find(reservationid);
                }catch
                {
                    MessageBox.Show("Reservation not found. Please try again.\n\n" +
                        "Note: ID is made from Guest initials, Month, Start Date and number of days reserved.",
                        "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                

                try
                {
                    foundGuest = guestController.find(foundReservation.GuestID);
                }catch
                {
                    MessageBox.Show("Guest could not be found for this reservation.",
                        "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                

                
                ShowScreen1(); // we move to screen 1
            }
            else if (screen == 1)
            {
                
                ShowScreen2(); // we move to screen 2
            }
            else if (screen == 2)
            {
               
                Rcontroller.DataMaintenance(foundReservation, DB.DBOperation.Delete);
                Rcontroller.FinalizeChanges(foundReservation);

                ShowScreen3();
            }
        }

        
        private void prevPageButton_Click(object sender, EventArgs e)
        {
            if (screen == 1)
            {
                
                ResetToScreen0();
            }
            else if (screen == 2)
            {
                
                ShowScreen1();
            }
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void goToHomeCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelBooking_Resize(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;

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


        private void ResetToScreen0()
        {
            // Input screen visible
            reservationNumLabel.Visible = true;
            reservationIDinputLabel.Visible = true;
            textBoxForReservationID.Visible = true;
            ConfirmButton.Visible = true;

            // Others hidden
            richTextBox1.Visible = false;
            doneButton.Visible = false;
            prevPageButton.Visible = false;
            goToHomeCancelButton.Visible = false;

            screen = 0;
        }

        private void ShowScreen1()
        {
            reservationNumLabel.Visible = false;
            reservationIDinputLabel.Visible = false;
            textBoxForReservationID.Visible = false;
            goToHomeCancelButton.Visible = false;

            richTextBox1.Visible = true;
            richTextBox1.Text =
                $"Guest booking found!\n\nDo you wish to proceed to cancel the existing guest booking?\n\n" +
                $"Full name: {foundGuest.Name}\n" +
                $"Address: {foundGuest.Address}\n" +
                $"ID: {foundGuest.ID}\n\n" +
                $"{foundReservation.reservationDetails()}";

            prevPageButton.Visible = true;
            prevPageButton.Text = "Previous page";
            ConfirmButton.Visible = true;
            ConfirmButton.Text = "Confirm";

            doneButton.Visible = false;
            screen = 1;
        }

        private void ShowScreen2()
        {
            richTextBox1.Visible = true;
            richTextBox1.Text =
                $"\n\nGuest booking for ({foundReservation.ReservationID}) will be cancelled.\n" +
                $"This action cannot be undone.\n\nAre you sure you want to cancel this booking?";

            prevPageButton.Visible = true;
            ConfirmButton.Visible = true;
            ConfirmButton.Text = "Confirm";

            doneButton.Visible = false;
            screen = 2;
        }

        private void ShowScreen3()
        {
            richTextBox1.Text =
                $"\n\nGuest booking ({foundReservation.ReservationID}) has been successfully cancelled!\n\n" +
                $"Hotel occupancy levels have been adjusted accordingly.";

            ConfirmButton.Visible = false;
            prevPageButton.Visible = false;
            doneButton.Visible = true;
            doneButton.Text = "Done";

            screen = 3;
        }
    }
}
