
namespace Assignment_8_2
{
    partial class MainForm
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
            this.flightIdBox = new System.Windows.Forms.TextBox();
            this.originBox = new System.Windows.Forms.TextBox();
            this.destinationBox = new System.Windows.Forms.TextBox();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.flightIdLabel = new System.Windows.Forms.Label();
            this.originLabel = new System.Windows.Forms.Label();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flightIdBox
            // 
            this.flightIdBox.Location = new System.Drawing.Point(292, 63);
            this.flightIdBox.Name = "flightIdBox";
            this.flightIdBox.Size = new System.Drawing.Size(248, 29);
            this.flightIdBox.TabIndex = 0;
            // 
            // originBox
            // 
            this.originBox.Location = new System.Drawing.Point(292, 120);
            this.originBox.Name = "originBox";
            this.originBox.Size = new System.Drawing.Size(248, 29);
            this.originBox.TabIndex = 1;
            // 
            // destinationBox
            // 
            this.destinationBox.Location = new System.Drawing.Point(292, 182);
            this.destinationBox.Name = "destinationBox";
            this.destinationBox.Size = new System.Drawing.Size(248, 29);
            this.destinationBox.TabIndex = 2;
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(292, 244);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(248, 29);
            this.dateBox.TabIndex = 3;
            // 
            // flightIdLabel
            // 
            this.flightIdLabel.AutoSize = true;
            this.flightIdLabel.Location = new System.Drawing.Point(86, 67);
            this.flightIdLabel.Name = "flightIdLabel";
            this.flightIdLabel.Size = new System.Drawing.Size(83, 25);
            this.flightIdLabel.TabIndex = 4;
            this.flightIdLabel.Text = "Flight ID";
            // 
            // originLabel
            // 
            this.originLabel.AutoSize = true;
            this.originLabel.Location = new System.Drawing.Point(86, 124);
            this.originLabel.Name = "originLabel";
            this.originLabel.Size = new System.Drawing.Size(64, 25);
            this.originLabel.TabIndex = 5;
            this.originLabel.Text = "Origin";
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Location = new System.Drawing.Point(86, 186);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(109, 25);
            this.destinationLabel.TabIndex = 6;
            this.destinationLabel.Text = "Destination";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(86, 248);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(53, 25);
            this.dateLabel.TabIndex = 7;
            this.dateLabel.Text = "Date";
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(292, 304);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(248, 29);
            this.timeBox.TabIndex = 8;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(91, 304);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(56, 25);
            this.timeLabel.TabIndex = 9;
            this.timeLabel.Text = "Time";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(292, 358);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(159, 46);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Clicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.destinationLabel);
            this.Controls.Add(this.originLabel);
            this.Controls.Add(this.flightIdLabel);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.destinationBox);
            this.Controls.Add(this.originBox);
            this.Controls.Add(this.flightIdBox);
            this.Name = "MainForm";
            this.Text = "Assignment 8_2";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox flightIdBox;
        private System.Windows.Forms.TextBox originBox;
        private System.Windows.Forms.TextBox destinationBox;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.Label flightIdLabel;
        private System.Windows.Forms.Label originLabel;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button submitButton;
    }
}

