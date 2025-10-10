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

            // Get summary buckets (2..5 where 5 = 5 or more)
            var summary = reservationController.GetLoyalCountsByDateRange(startDate, endDate);

            // Always show a table with the four categories (even if zero)
            DataTable table = new DataTable();
            table.Columns.Add("Times Booked");         // 2,3,4,5
            table.Columns.Add("Number of Guests");    // how many guests have that many bookings

            for (int times = 2; times <= 5; times++)
            {
                int guests = summary.ContainsKey(times) ? summary[times] : 0;
                table.Rows.Add(times.ToString(), guests);
            }

            loyaltyGridView.DataSource = table;

            // Build chart
            chart.Series.Clear();
            chart.ChartAreas[0].AxisX.Interval = 1;
            chart.ChartAreas[0].AxisX.Title = "Times Booked";
            chart.ChartAreas[0].AxisY.Title = "Number of Guests";
            chart.Legends.Clear();

            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Guests");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series.IsValueShownAsLabel = true;

            // Add points in order 2,3,4,5 so X axis is consistent
            for (int times = 2; times <= 5; times++)
            {
                int guests = summary.ContainsKey(times) ? summary[times] : 0;
                series.Points.AddXY(times.ToString(), guests);
            }

            chart.Series.Add(series);

            dataPanel.Visible = true;
            reportCreatedDate.Text = "Report Created on: " + DateTime.Now.ToString("yyyy-MM-dd");
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
