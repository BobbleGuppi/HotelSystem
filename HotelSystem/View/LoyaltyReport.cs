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
        private PaymentController paymentController = new PaymentController();
        #endregion

        #region Constructor
        public LoyaltyReport()
        {
            InitializeComponent();
            paymentController = new PaymentController();

        }
        #endregion

        #region Generate Report Methods

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            DateTime startDate = startDatePicker.Value.Date;
            DateTime endDate = endDatePicker.Value.Date;

            // Filter payments by date range and exclude FullyPaid
            var filteredPayments = paymentController.AllPayments
                .Where(p => p.DatePaid.Date >= startDate && p.DatePaid.Date <= endDate)
                .Where(p => !string.Equals(p.PaymentType, "Paid", StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (filteredPayments.Count == 0)
            {
                MessageBox.Show("No payments found for the selected date range (excluding FullyPaid).");
                return;
            }

            // Group by payment status (Deposit / Paid / Unpaid)
            var groupedStatus = filteredPayments
                .GroupBy(p => p.PaymentType)
                .Select(g => new
                {
                    Status = g.Key,
                    Count = g.Count()
                })
                .ToList();

            // Normalize to percentages out of 100
            double totalCount = groupedStatus.Sum(g => g.Count);

            var percentageData = groupedStatus
                .Select(g => new PaymentPercentage
                {
                    Status = g.Status,
                    Percentage = Math.Round((g.Count / totalCount) * 100, 2)
                })
                .ToList();

            DisplayPieChart(percentageData);

        }

        /*
         * Helper Method
         * 
         */
        public class PaymentPercentage
        {
            public string Status { get; set; }
            public double Percentage { get; set; }
        }

        private void DisplayPieChart(List<PaymentPercentage> percentageData)
        {
            paymentChart.Series.Clear();
            paymentChart.Titles.Clear();
            paymentChart.Titles.Add("Payment Status Distribution");

            Series series = new Series
            {
                Name = "PaymentStatus",
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true
            };

            foreach (var item in percentageData)
            {
                // Add data points
                DataPoint point = new DataPoint(0, item.Percentage);
                point.AxisLabel = item.Status; // Legend label
                point.LegendText = $"{item.Status}"; // Legend text
                point.Label = $"{item.Status}: {item.Percentage}%"; // On-chart label
                series.Points.Add(point);
            }

            paymentChart.Series.Add(series);

            // Beautify chart
            paymentChart.ChartAreas[0].Area3DStyle.Enable3D = true;
            paymentChart.Legends[0].Enabled = true;
            paymentChart.Legends[0].Docking = Docking.Right;

            dataPanel.Visible = true;
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
