
namespace Assignment_10
{
    partial class InsertFlightForm
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
            this.flightIdTextBox = new System.Windows.Forms.TextBox();
            this.airlineCompanyTextBox = new System.Windows.Forms.TextBox();
            this.originTextBox = new System.Windows.Forms.TextBox();
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.addFlightButton = new System.Windows.Forms.Button();
            this.flightIdLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.originLabel = new System.Windows.Forms.Label();
            this.airlineCompanyLabel = new System.Windows.Forms.Label();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flightIdTextBox
            // 
            this.flightIdTextBox.Location = new System.Drawing.Point(328, 48);
            this.flightIdTextBox.Name = "flightIdTextBox";
            this.flightIdTextBox.Size = new System.Drawing.Size(278, 29);
            this.flightIdTextBox.TabIndex = 0;
            // 
            // airlineCompanyTextBox
            // 
            this.airlineCompanyTextBox.Location = new System.Drawing.Point(328, 114);
            this.airlineCompanyTextBox.Name = "airlineCompanyTextBox";
            this.airlineCompanyTextBox.Size = new System.Drawing.Size(278, 29);
            this.airlineCompanyTextBox.TabIndex = 1;
            // 
            // originTextBox
            // 
            this.originTextBox.Location = new System.Drawing.Point(328, 180);
            this.originTextBox.Name = "originTextBox";
            this.originTextBox.Size = new System.Drawing.Size(278, 29);
            this.originTextBox.TabIndex = 2;
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.Location = new System.Drawing.Point(328, 252);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.Size = new System.Drawing.Size(278, 29);
            this.destinationTextBox.TabIndex = 3;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(328, 322);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(278, 29);
            this.dateTextBox.TabIndex = 4;
            // 
            // addFlightButton
            // 
            this.addFlightButton.Location = new System.Drawing.Point(328, 391);
            this.addFlightButton.Name = "addFlightButton";
            this.addFlightButton.Size = new System.Drawing.Size(155, 47);
            this.addFlightButton.TabIndex = 5;
            this.addFlightButton.Text = "Add flight";
            this.addFlightButton.UseVisualStyleBackColor = true;
            this.addFlightButton.Click += new System.EventHandler(this.AddFlightButton_Click);
            // 
            // flightIdLabel
            // 
            this.flightIdLabel.AutoSize = true;
            this.flightIdLabel.Location = new System.Drawing.Point(124, 52);
            this.flightIdLabel.Name = "flightIdLabel";
            this.flightIdLabel.Size = new System.Drawing.Size(80, 25);
            this.flightIdLabel.TabIndex = 6;
            this.flightIdLabel.Text = "Flight Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 7;
            // 
            // originLabel
            // 
            this.originLabel.AutoSize = true;
            this.originLabel.Location = new System.Drawing.Point(124, 184);
            this.originLabel.Name = "originLabel";
            this.originLabel.Size = new System.Drawing.Size(64, 25);
            this.originLabel.TabIndex = 8;
            this.originLabel.Text = "Origin";
            // 
            // airlineCompanyLabel
            // 
            this.airlineCompanyLabel.AutoSize = true;
            this.airlineCompanyLabel.Location = new System.Drawing.Point(124, 118);
            this.airlineCompanyLabel.Name = "airlineCompanyLabel";
            this.airlineCompanyLabel.Size = new System.Drawing.Size(156, 25);
            this.airlineCompanyLabel.TabIndex = 9;
            this.airlineCompanyLabel.Text = "Airline Company";
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Location = new System.Drawing.Point(124, 256);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(109, 25);
            this.destinationLabel.TabIndex = 10;
            this.destinationLabel.Text = "Destination";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(124, 326);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(53, 25);
            this.dateLabel.TabIndex = 11;
            this.dateLabel.Text = "Date";
            // 
            // InsertFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 517);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.destinationLabel);
            this.Controls.Add(this.airlineCompanyLabel);
            this.Controls.Add(this.originLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flightIdLabel);
            this.Controls.Add(this.addFlightButton);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.destinationTextBox);
            this.Controls.Add(this.originTextBox);
            this.Controls.Add(this.airlineCompanyTextBox);
            this.Controls.Add(this.flightIdTextBox);
            this.Name = "InsertFlightForm";
            this.Text = "Insert Flight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox flightIdTextBox;
        private System.Windows.Forms.TextBox airlineCompanyTextBox;
        private System.Windows.Forms.TextBox originTextBox;
        private System.Windows.Forms.TextBox destinationTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Button addFlightButton;
        private System.Windows.Forms.Label flightIdLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label originLabel;
        private System.Windows.Forms.Label airlineCompanyLabel;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.Label dateLabel;
    }
}