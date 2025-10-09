namespace HotelSystem.View
{
    partial class SummaryReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SummaryReport));
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.promptLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.promptPanel = new System.Windows.Forms.Panel();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.occupancyLabel = new System.Windows.Forms.Label();
            this.averageTextBox = new System.Windows.Forms.RichTextBox();
            this.overviewLabel = new System.Windows.Forms.Label();
            this.reportCreatedDate = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.promptPanel.SuspendLayout();
            this.dataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // startDatePicker
            // 
            this.startDatePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.startDatePicker.Location = new System.Drawing.Point(474, 3);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(200, 20);
            this.startDatePicker.TabIndex = 0;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.endDatePicker.Location = new System.Drawing.Point(474, 46);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(200, 20);
            this.endDatePicker.TabIndex = 1;
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.promptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptLabel.Location = new System.Drawing.Point(30, 17);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(412, 25);
            this.promptLabel.TabIndex = 2;
            this.promptLabel.Text = "Select a date range to generate the report";
            // 
            // startDateLabel
            // 
            this.startDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.startDateLabel.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateLabel.Location = new System.Drawing.Point(3, 0);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(375, 19);
            this.startDateLabel.TabIndex = 3;
            this.startDateLabel.Text = "Start Date:";
            // 
            // endDateLabel
            // 
            this.endDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.endDateLabel.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateLabel.Location = new System.Drawing.Point(3, 43);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(375, 19);
            this.endDateLabel.TabIndex = 4;
            this.endDateLabel.Text = "End Date:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.67405F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.32595F));
            this.tableLayoutPanel1.Controls.Add(this.startDatePicker, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.endDateLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.endDatePicker, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.startDateLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(64, 56);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.38272F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.61728F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(767, 88);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // promptPanel
            // 
            this.promptPanel.Controls.Add(this.GenerateButton);
            this.promptPanel.Controls.Add(this.tableLayoutPanel1);
            this.promptPanel.Controls.Add(this.promptLabel);
            this.promptPanel.Location = new System.Drawing.Point(12, 12);
            this.promptPanel.Name = "promptPanel";
            this.promptPanel.Size = new System.Drawing.Size(1286, 597);
            this.promptPanel.TabIndex = 6;
            this.promptPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // GenerateButton
            // 
            this.GenerateButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GenerateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GenerateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GenerateButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateButton.Location = new System.Drawing.Point(868, 84);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(112, 34);
            this.GenerateButton.TabIndex = 8;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = false;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.reportCreatedDate);
            this.dataPanel.Controls.Add(this.overviewLabel);
            this.dataPanel.Controls.Add(this.averageTextBox);
            this.dataPanel.Controls.Add(this.occupancyLabel);
            this.dataPanel.Controls.Add(this.chart);
            this.dataPanel.Location = new System.Drawing.Point(12, 177);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(1286, 432);
            this.dataPanel.TabIndex = 7;
            // 
            // chart
            // 
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(28, 21);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(711, 390);
            this.chart.TabIndex = 5;
            this.chart.Text = "chart";
            this.chart.Click += new System.EventHandler(this.chart_Click);
            // 
            // occupancyLabel
            // 
            this.occupancyLabel.AutoSize = true;
            this.occupancyLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.occupancyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occupancyLabel.Location = new System.Drawing.Point(796, 196);
            this.occupancyLabel.Name = "occupancyLabel";
            this.occupancyLabel.Size = new System.Drawing.Size(252, 24);
            this.occupancyLabel.TabIndex = 10;
            this.occupancyLabel.Text = "Overall Average Occupancy:";
            // 
            // averageTextBox
            // 
            this.averageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageTextBox.Location = new System.Drawing.Point(1087, 192);
            this.averageTextBox.Name = "averageTextBox";
            this.averageTextBox.ReadOnly = true;
            this.averageTextBox.Size = new System.Drawing.Size(112, 39);
            this.averageTextBox.TabIndex = 9;
            this.averageTextBox.Text = "";
            this.averageTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // overviewLabel
            // 
            this.overviewLabel.AutoSize = true;
            this.overviewLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.overviewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overviewLabel.Location = new System.Drawing.Point(757, 21);
            this.overviewLabel.Name = "overviewLabel";
            this.overviewLabel.Size = new System.Drawing.Size(515, 144);
            this.overviewLabel.TabIndex = 12;
            this.overviewLabel.Text = resources.GetString("overviewLabel.Text");
            // 
            // reportCreatedDate
            // 
            this.reportCreatedDate.AutoSize = true;
            this.reportCreatedDate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.reportCreatedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportCreatedDate.Location = new System.Drawing.Point(796, 391);
            this.reportCreatedDate.Name = "reportCreatedDate";
            this.reportCreatedDate.Size = new System.Drawing.Size(35, 20);
            this.reportCreatedDate.TabIndex = 13;
            this.reportCreatedDate.Text = "text";
            // 
            // SummaryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1310, 634);
            this.Controls.Add(this.dataPanel);
            this.Controls.Add(this.promptPanel);
            this.Name = "SummaryReport";
            this.Text = "Occupancy Rate Summary";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.promptPanel.ResumeLayout(false);
            this.promptPanel.PerformLayout();
            this.dataPanel.ResumeLayout(false);
            this.dataPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel promptPanel;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.RichTextBox averageTextBox;
        private System.Windows.Forms.Label occupancyLabel;
        private System.Windows.Forms.Label overviewLabel;
        private System.Windows.Forms.Label reportCreatedDate;
    }
}