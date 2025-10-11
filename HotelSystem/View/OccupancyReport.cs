using HotelSystem.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace HotelSystem.View
{
    public partial class OccupancyReport : Form
    {

        #region Fields
        private ReservationController reservationController;
        #endregion 

        #region Constructor
        public OccupancyReport()
        {
            InitializeComponent();
            reservationController = new ReservationController(); // create new controller

            dataPanel.Visible = false;
        }
        #endregion

        #region Generate Button
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            DateTime start = startDatePicker.Value.Date;
            DateTime end = endDatePicker.Value.Date;

            if (end < start)
            {
                MessageBox.Show("End date cannot be earlier than start date!");
                return;
            }

            var dailyData = reservationController.CalculateDailyOccupancy(start, end);
            double avgOccupancy = reservationController.CalculateAverageOccupancy(start, end);

            // --- Chart Setup ---
            chart.Series.Clear();
            chart.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea();
            chartArea.AxisX.Title = "Date";
            chartArea.AxisY.Title = "Occupancy (%)";
            chart.ChartAreas.Add(chartArea);

            Series series = new Series("Daily Occupancy");
            series.ChartType = SeriesChartType.Column; // bar chart
            chart.Series.Add(series);

            foreach (var kvp in dailyData)
            {
                series.Points.AddXY(kvp.Key.ToString("dd MMM"), kvp.Value);
            }

            // --- Add Average Line ---
            Series avgLine = new Series("Average");
            avgLine.ChartType = SeriesChartType.Line;
            avgLine.BorderWidth = 2;
            avgLine.Color = System.Drawing.Color.Red;
            foreach (var kvp in dailyData)
            {
                avgLine.Points.AddXY(kvp.Key.ToString("dd MMM"), avgOccupancy);
            }
            chart.Series.Add(avgLine);

            // --- Display average occupancy in a textbox ---
            averageTextBox.Text = $"{avgOccupancy:F2}%";
            reportCreatedDate.Text = "Generated on: [" + DateTime.Now.ToString("yyyy-MM-dd") + "]";

            dataPanel.Visible = true;
        }
        #endregion

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void overviewLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
