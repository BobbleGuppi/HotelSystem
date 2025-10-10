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
using System.Windows.Forms.DataVisualization.Charting;

namespace HotelSystem.View
{
    public partial class LoyaltyReport : Form
    {
        #region Fields
        private ReservationController reservationController;
        #endregion

        #region Constructor
        public LoyaltyReport()
        {
            InitializeComponent();
            reservationController = new ReservationController();
            dataPanel.Visible = false;

        }
        #endregion

        #region Generate Report Methods
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            DateTime startDate = startDatePicker.Value.Date;
            DateTime endDate = endDatePicker.Value.Date;

            if (endDate < startDate)
            {
                MessageBox.Show("End date cannot be earlier than start date.");
                return;
            }

            var loyalGuests = reservationController.GetLoyalGuestsByDateRange(startDate, endDate);

            if (loyalGuests.Count == 0)
            {
                MessageBox.Show("No loyal guests found for the selected date range.");
                loyaltyGridView.DataSource = null;
                return;
            }

            // Build table for grid
            DataTable table = new DataTable();
            table.Columns.Add("Guest ID");
            table.Columns.Add("Reservation Count");

            foreach (var entry in loyalGuests)
            {
                table.Rows.Add(entry.Key, entry.Value);
            }

            loyaltyGridView.DataSource = table;

            // Optional chart visualization
            chart.Series.Clear();
            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Loyal Guests");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            foreach (var entry in loyalGuests.OrderByDescending(x => x.Value))
            {
                series.Points.AddXY(entry.Key, entry.Value);
            }

            chart.Series.Add(series);
            dataPanel.Visible = true;
            reportCreatedDate.Text = "Report Created on: " + DateTime.Today;
        }

        #endregion


        private void ExceptionReport_Load(object sender, EventArgs e) { }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}
