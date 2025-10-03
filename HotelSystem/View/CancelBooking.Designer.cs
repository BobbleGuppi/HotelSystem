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
            this.button1 = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ConfirmButton);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(27, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 465);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(90, 361);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 67);
            this.button1.TabIndex = 13;
            this.button1.Text = "Previous page";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ConfirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConfirmButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmButton.Location = new System.Drawing.Point(617, 361);
            this.ConfirmButton.Margin = new System.Windows.Forms.Padding(4);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(133, 67);
            this.ConfirmButton.TabIndex = 12;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(289, 213);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(302, 35);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 225);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Reservation ID:\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Eras Demi ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 55);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 200, 0);
            this.label1.Size = new System.Drawing.Size(914, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Provide the reservation number and details:";
            // 
            // CancelBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(942, 534);
            this.Controls.Add(this.panel1);
            this.Name = "CancelBooking";
            this.Text = "CancelBooking";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ConfirmButton;
    }
}