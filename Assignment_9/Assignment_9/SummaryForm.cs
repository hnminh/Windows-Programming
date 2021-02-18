using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_9
{
    public partial class SummaryForm : Form
    {
        public SummaryForm()
        {
            InitializeComponent();
        }

        public void AddText(string information)
        {
            summaryRichTextBox.Text += information;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.summaryRichTextBox.SelectAll();
            this.summaryRichTextBox.SelectionFont = new Font(summaryRichTextBox.SelectionFont.FontFamily, 12.0f);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.summaryRichTextBox.SelectAll();
            this.summaryRichTextBox.SelectionFont = new Font(summaryRichTextBox.SelectionFont.FontFamily, 14.0f);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.summaryRichTextBox.SelectAll();
            this.summaryRichTextBox.SelectionFont = new Font(summaryRichTextBox.SelectionFont.FontFamily, 16.0f);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.summaryRichTextBox.SelectAll();
            this.summaryRichTextBox.SelectionFont = new Font(summaryRichTextBox.SelectionFont.FontFamily, 18.0f);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            this.summaryRichTextBox.SelectAll();
            this.summaryRichTextBox.SelectionFont = new Font(summaryRichTextBox.SelectionFont.FontFamily, 20.0f);
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    summaryRichTextBox.ForeColor = colorDialog.Color;
                }
            }
        }
    }
}
