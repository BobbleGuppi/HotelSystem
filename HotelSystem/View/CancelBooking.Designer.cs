namespace HotelSystem.View
{
    partial class CancelBooking
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxForReservationID = new System.Windows.Forms.TextBox();
            this.prevPageButton = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.reservationIDinputLabel = new System.Windows.Forms.Label();
            this.reservationNumLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.doneButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.doneButton);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.textBoxForReservationID);
            this.panel1.Controls.Add(this.prevPageButton);
            this.panel1.Controls.Add(this.ConfirmButton);
            this.panel1.Controls.Add(this.reservationIDinputLabel);
            this.panel1.Controls.Add(this.reservationNumLabel);
            this.panel1.Location = new System.Drawing.Point(27, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 378);
            this.panel1.TabIndex = 5;
            // 
            // textBoxForReservationID
            // 
            this.textBoxForReservationID.Location = new System.Drawing.Point(275, 225);
            this.textBoxForReservationID.Name = "textBoxForReservationID";
            this.textBoxForReservationID.Size = new System.Drawing.Size(224, 22);
            this.textBoxForReservationID.TabIndex = 14;
            // 
            // prevPageButton
            // 
            this.prevPageButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.prevPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prevPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.prevPageButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevPageButton.Location = new System.Drawing.Point(90, 361);
            this.prevPageButton.Margin = new System.Windows.Forms.Padding(4);
            this.prevPageButton.Name = "prevPageButton";
            this.prevPageButton.Size = new System.Drawing.Size(133, 67);
            this.prevPageButton.TabIndex = 13;
            this.prevPageButton.Text = "Previous page";
            this.prevPageButton.UseVisualStyleBackColor = false;
            this.prevPageButton.Click += new System.EventHandler(this.prevPageButton_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ConfirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConfirmButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmButton.Location = new System.Drawing.Point(530, 306);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(146, 41);
            this.ConfirmButton.TabIndex = 12;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click_1);
            // 
            // reservationIDinputLabel
            // 
            this.reservationIDinputLabel.AutoSize = true;
            this.reservationIDinputLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.reservationIDinputLabel.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationIDinputLabel.Location = new System.Drawing.Point(71, 225);
            this.reservationIDinputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reservationIDinputLabel.Name = "reservationIDinputLabel";
            this.reservationIDinputLabel.Size = new System.Drawing.Size(152, 23);
            this.reservationIDinputLabel.TabIndex = 5;
            this.reservationIDinputLabel.Text = "Reservation ID:\r\n";
            // 
            // reservationNumLabel
            // 
            this.reservationNumLabel.AutoSize = true;
            this.reservationNumLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.reservationNumLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reservationNumLabel.Font = new System.Drawing.Font("Eras Demi ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationNumLabel.Location = new System.Drawing.Point(25, 55);
            this.reservationNumLabel.Name = "reservationNumLabel";
            this.reservationNumLabel.Padding = new System.Windows.Forms.Padding(10, 0, 200, 0);
            this.reservationNumLabel.Size = new System.Drawing.Size(914, 39);
            this.reservationNumLabel.TabIndex = 4;
            this.reservationNumLabel.Text = "Provide the reservation number and details:";
            this.reservationNumLabel.Click += new System.EventHandler(this.reservationNumLabel_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(35, 55);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(803, 240);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(897, 338);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(100, 96);
            this.richTextBox2.TabIndex = 6;
            this.richTextBox2.Text = "";
            // 
            // doneButton
            // 
            this.doneButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.doneButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doneButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.doneButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneButton.Location = new System.Drawing.Point(366, 361);
            this.doneButton.Margin = new System.Windows.Forms.Padding(4);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(133, 67);
            this.doneButton.TabIndex = 17;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = false;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // CancelBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(942, 534);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CancelBooking";
            this.Text = "CancelBooking";
            this.Load += new System.EventHandler(this.CancelBooking_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label reservationNumLabel;
        private System.Windows.Forms.Label reservationIDinputLabel;
        private System.Windows.Forms.Button prevPageButton;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.TextBox textBoxForReservationID;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button doneButton;
    }
}