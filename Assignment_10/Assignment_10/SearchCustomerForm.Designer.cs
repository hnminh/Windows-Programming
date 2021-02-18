
namespace Assignment_10
{
    partial class SearchCustomerForm
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
            this.customerIdLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchCustomerButton = new System.Windows.Forms.Button();
            this.customersDataGridView = new System.Windows.Forms.DataGridView();
            this.customerIdTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerIdLabel
            // 
            this.customerIdLabel.AutoSize = true;
            this.customerIdLabel.Location = new System.Drawing.Point(346, 66);
            this.customerIdLabel.Name = "customerIdLabel";
            this.customerIdLabel.Size = new System.Drawing.Size(118, 25);
            this.customerIdLabel.TabIndex = 1;
            this.customerIdLabel.Text = "Customer Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(532, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 2;
            // 
            // searchCustomerButton
            // 
            this.searchCustomerButton.Location = new System.Drawing.Point(505, 134);
            this.searchCustomerButton.Name = "searchCustomerButton";
            this.searchCustomerButton.Size = new System.Drawing.Size(144, 43);
            this.searchCustomerButton.TabIndex = 3;
            this.searchCustomerButton.Text = "Search";
            this.searchCustomerButton.UseVisualStyleBackColor = true;
            this.searchCustomerButton.Click += new System.EventHandler(this.SearchCustomerButton_Click);
            // 
            // customersDataGridView
            // 
            this.customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataGridView.Location = new System.Drawing.Point(13, 199);
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.RowHeadersWidth = 72;
            this.customersDataGridView.RowTemplate.Height = 31;
            this.customersDataGridView.Size = new System.Drawing.Size(1015, 504);
            this.customersDataGridView.TabIndex = 5;
            // 
            // customerIdTextBox
            // 
            this.customerIdTextBox.Location = new System.Drawing.Point(505, 66);
            this.customerIdTextBox.Name = "customerIdTextBox";
            this.customerIdTextBox.Size = new System.Drawing.Size(266, 29);
            this.customerIdTextBox.TabIndex = 6;
            // 
            // SearchCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 715);
            this.Controls.Add(this.customerIdTextBox);
            this.Controls.Add(this.customersDataGridView);
            this.Controls.Add(this.searchCustomerButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerIdLabel);
            this.Name = "SearchCustomerForm";
            this.Text = "Search Customer";
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label customerIdLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchCustomerButton;
        private System.Windows.Forms.DataGridView customersDataGridView;
        private System.Windows.Forms.TextBox customerIdTextBox;
    }
}