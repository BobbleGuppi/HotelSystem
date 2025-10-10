namespace HotelSystem.View
{
    partial class ChangeBooking
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
            this.PromptLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckInPicker = new System.Windows.Forms.DateTimePicker();
            this.reservationIDTextBox = new System.Windows.Forms.RichTextBox();
            this.CheckOutPicker = new System.Windows.Forms.DateTimePicker();
            this.RoomFoundPanel = new System.Windows.Forms.Panel();
            this.confirmChangeButton = new System.Windows.Forms.Button();
            this.cancelChangeButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.RoomFoundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PromptLabel
            // 
            this.PromptLabel.AutoSize = true;
            this.PromptLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PromptLabel.Font = new System.Drawing.Font("Eras Demi ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromptLabel.Location = new System.Drawing.Point(37, 28);
            this.PromptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PromptLabel.Name = "PromptLabel";
            this.PromptLabel.Size = new System.Drawing.Size(491, 39);
            this.PromptLabel.TabIndex = 1;
            this.PromptLabel.Text = "Provide a reservation number";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Font = new System.Drawing.Font("Eras Demi ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(703, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Reservation ID:\r\n";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Eras Demi ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(703, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "New Check-in Date:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ConfirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConfirmButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmButton.Location = new System.Drawing.Point(1081, 474);
            this.ConfirmButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(176, 61);
            this.ConfirmButton.TabIndex = 7;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainPanel.Controls.Add(this.tableLayoutPanel1);
            this.MainPanel.Controls.Add(this.ConfirmButton);
            this.MainPanel.Controls.Add(this.PromptLabel);
            this.MainPanel.Location = new System.Drawing.Point(16, 33);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1596, 593);
            this.MainPanel.TabIndex = 8;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.36428F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.63572F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CheckInPicker, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.reservationIDTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.CheckOutPicker, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(72, 106);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1472, 300);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Eras Demi ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(703, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "New Check-out Date:";
            // 
            // CheckInPicker
            // 
            this.CheckInPicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CheckInPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInPicker.Location = new System.Drawing.Point(940, 4);
            this.CheckInPicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CheckInPicker.Name = "CheckInPicker";
            this.CheckInPicker.Size = new System.Drawing.Size(303, 30);
            this.CheckInPicker.TabIndex = 9;
            this.CheckInPicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // reservationIDTextBox
            // 
            this.reservationIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.reservationIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationIDTextBox.Location = new System.Drawing.Point(940, 186);
            this.reservationIDTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reservationIDTextBox.Name = "reservationIDTextBox";
            this.reservationIDTextBox.Size = new System.Drawing.Size(303, 34);
            this.reservationIDTextBox.TabIndex = 8;
            this.reservationIDTextBox.Text = "";
            this.reservationIDTextBox.TextChanged += new System.EventHandler(this.reservationIDTextBox_TextChanged);
            // 
            // CheckOutPicker
            // 
            this.CheckOutPicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CheckOutPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutPicker.Location = new System.Drawing.Point(940, 95);
            this.CheckOutPicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CheckOutPicker.Name = "CheckOutPicker";
            this.CheckOutPicker.Size = new System.Drawing.Size(303, 30);
            this.CheckOutPicker.TabIndex = 10;
            this.CheckOutPicker.ValueChanged += new System.EventHandler(this.CheckOutPicker_ValueChanged);
            // 
            // RoomFoundPanel
            // 
            this.RoomFoundPanel.Controls.Add(this.confirmChangeButton);
            this.RoomFoundPanel.Controls.Add(this.cancelChangeButton);
            this.RoomFoundPanel.Controls.Add(this.dataGridView1);
            this.RoomFoundPanel.Controls.Add(this.label4);
            this.RoomFoundPanel.Location = new System.Drawing.Point(16, 33);
            this.RoomFoundPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RoomFoundPanel.Name = "RoomFoundPanel";
            this.RoomFoundPanel.Size = new System.Drawing.Size(1596, 593);
            this.RoomFoundPanel.TabIndex = 9;
            // 
            // confirmChangeButton
            // 
            this.confirmChangeButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.confirmChangeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirmChangeButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmChangeButton.Location = new System.Drawing.Point(1340, 474);
            this.confirmChangeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.confirmChangeButton.Name = "confirmChangeButton";
            this.confirmChangeButton.Size = new System.Drawing.Size(149, 42);
            this.confirmChangeButton.TabIndex = 14;
            this.confirmChangeButton.Text = "Confirm";
            this.confirmChangeButton.UseVisualStyleBackColor = false;
            this.confirmChangeButton.Click += new System.EventHandler(this.confirmChangeButton_Click);
            // 
            // cancelChangeButton
            // 
            this.cancelChangeButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelChangeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelChangeButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelChangeButton.Location = new System.Drawing.Point(1027, 474);
            this.cancelChangeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelChangeButton.Name = "cancelChangeButton";
            this.cancelChangeButton.Size = new System.Drawing.Size(149, 42);
            this.cancelChangeButton.TabIndex = 13;
            this.cancelChangeButton.Text = "Cancel";
            this.cancelChangeButton.UseVisualStyleBackColor = false;
            this.cancelChangeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(81, 197);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1425, 103);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Eras Demi ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(565, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(392, 39);
            this.label4.TabIndex = 11;
            this.label4.Text = "Available Room Found!";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ChangeBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1628, 697);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.RoomFoundPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChangeBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChangeBooking";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ChangeBooking_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.RoomFoundPanel.ResumeLayout(false);
            this.RoomFoundPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label PromptLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.RichTextBox reservationIDTextBox;
        private System.Windows.Forms.DateTimePicker CheckInPicker;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker CheckOutPicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel RoomFoundPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button confirmChangeButton;
        private System.Windows.Forms.Button cancelChangeButton;
    }
}