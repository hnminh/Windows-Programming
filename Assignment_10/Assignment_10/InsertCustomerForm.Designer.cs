
namespace Assignment_10
{
    partial class InsertCustomerForm
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
            this.customerIdTextBox = new System.Windows.Forms.TextBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.flightIdTextBox = new System.Windows.Forms.TextBox();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.customerIdLabel = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.flightIdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customerIdTextBox
            // 
            this.customerIdTextBox.Location = new System.Drawing.Point(304, 70);
            this.customerIdTextBox.Name = "customerIdTextBox";
            this.customerIdTextBox.Size = new System.Drawing.Size(253, 29);
            this.customerIdTextBox.TabIndex = 0;
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(304, 142);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(253, 29);
            this.customerNameTextBox.TabIndex = 1;
            // 
            // flightIdTextBox
            // 
            this.flightIdTextBox.Location = new System.Drawing.Point(304, 211);
            this.flightIdTextBox.Name = "flightIdTextBox";
            this.flightIdTextBox.Size = new System.Drawing.Size(253, 29);
            this.flightIdTextBox.TabIndex = 2;
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.Location = new System.Drawing.Point(304, 282);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(162, 44);
            this.addCustomerButton.TabIndex = 3;
            this.addCustomerButton.Text = "Add customer";
            this.addCustomerButton.UseVisualStyleBackColor = true;
            this.addCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // customerIdLabel
            // 
            this.customerIdLabel.AutoSize = true;
            this.customerIdLabel.Location = new System.Drawing.Point(134, 74);
            this.customerIdLabel.Name = "customerIdLabel";
            this.customerIdLabel.Size = new System.Drawing.Size(118, 25);
            this.customerIdLabel.TabIndex = 4;
            this.customerIdLabel.Text = "Customer Id";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(134, 146);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(151, 25);
            this.customerNameLabel.TabIndex = 5;
            this.customerNameLabel.Text = "Customer name";
            // 
            // flightIdLabel
            // 
            this.flightIdLabel.AutoSize = true;
            this.flightIdLabel.Location = new System.Drawing.Point(134, 215);
            this.flightIdLabel.Name = "flightIdLabel";
            this.flightIdLabel.Size = new System.Drawing.Size(80, 25);
            this.flightIdLabel.TabIndex = 6;
            this.flightIdLabel.Text = "Flight Id";
            // 
            // InsertCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 406);
            this.Controls.Add(this.flightIdLabel);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.customerIdLabel);
            this.Controls.Add(this.addCustomerButton);
            this.Controls.Add(this.flightIdTextBox);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.customerIdTextBox);
            this.Name = "InsertCustomerForm";
            this.Text = "Insert Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customerIdTextBox;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox flightIdTextBox;
        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.Label customerIdLabel;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label flightIdLabel;
    }
}