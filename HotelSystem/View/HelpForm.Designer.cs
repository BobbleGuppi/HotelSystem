namespace HotelSystem.View
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.helpList = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // helpList
            // 
            this.helpList.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.helpList.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpList.ForeColor = System.Drawing.SystemColors.Desktop;
            this.helpList.Location = new System.Drawing.Point(48, 49);
            this.helpList.Name = "helpList";
            this.helpList.ReadOnly = true;
            this.helpList.Size = new System.Drawing.Size(1205, 543);
            this.helpList.TabIndex = 0;
            this.helpList.Text = resources.GetString("helpList.Text");
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1300, 749);
            this.Controls.Add(this.helpList);
            this.Name = "Help";
            this.Text = "Help";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox helpList;
    }
}