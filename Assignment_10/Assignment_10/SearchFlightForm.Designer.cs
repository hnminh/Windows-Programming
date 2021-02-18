
namespace Assignment_10
{
    partial class SearchFlightForm
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
            this.flightIdLabel = new System.Windows.Forms.Label();
            this.searchFlightButton = new System.Windows.Forms.Button();
            this.flightIdTextBox = new System.Windows.Forms.TextBox();
            this.flightsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.flightsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // flightIdLabel
            // 
            this.flightIdLabel.AutoSize = true;
            this.flightIdLabel.Location = new System.Drawing.Point(320, 77);
            this.flightIdLabel.Name = "flightIdLabel";
            this.flightIdLabel.Size = new System.Drawing.Size(80, 25);
            this.flightIdLabel.TabIndex = 1;
            this.flightIdLabel.Text = "Flight Id";
            // 
            // searchFlightButton
            // 
            this.searchFlightButton.Location = new System.Drawing.Point(450, 155);
            this.searchFlightButton.Name = "searchFlightButton";
            this.searchFlightButton.Size = new System.Drawing.Size(149, 42);
            this.searchFlightButton.TabIndex = 2;
            this.searchFlightButton.Text = "Search";
            this.searchFlightButton.UseVisualStyleBackColor = true;
            this.searchFlightButton.Click += new System.EventHandler(this.SearchFlightButton_Click);
            // 
            // flightIdTextBox
            // 
            this.flightIdTextBox.Location = new System.Drawing.Point(450, 77);
            this.flightIdTextBox.Name = "flightIdTextBox";
            this.flightIdTextBox.Size = new System.Drawing.Size(267, 29);
            this.flightIdTextBox.TabIndex = 4;
            // 
            // flightsDataGridView
            // 
            this.flightsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flightsDataGridView.Location = new System.Drawing.Point(13, 223);
            this.flightsDataGridView.Name = "flightsDataGridView";
            this.flightsDataGridView.RowHeadersWidth = 72;
            this.flightsDataGridView.RowTemplate.Height = 31;
            this.flightsDataGridView.Size = new System.Drawing.Size(934, 413);
            this.flightsDataGridView.TabIndex = 5;
            // 
            // SearchFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 648);
            this.Controls.Add(this.flightsDataGridView);
            this.Controls.Add(this.flightIdTextBox);
            this.Controls.Add(this.searchFlightButton);
            this.Controls.Add(this.flightIdLabel);
            this.Name = "SearchFlightForm";
            this.Text = "SearchFlightForm";
            ((System.ComponentModel.ISupportInitialize)(this.flightsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label flightIdLabel;
        private System.Windows.Forms.Button searchFlightButton;
        private System.Windows.Forms.TextBox flightIdTextBox;
        private System.Windows.Forms.DataGridView flightsDataGridView;
    }
}