using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JMSFunctions
{
    public partial class ErrorReport : Form
    {
        public ErrorReport()
        {
            InitializeComponent();
        }

        public string Report { get; set; }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel sending this report?", "Confirmation", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
            {
                MessageBox.Show("Error report not sent.");
                this.Close();
            }
        }

        private void CmdSendErrorReport_Click(object sender, EventArgs e)
        {
            Report = TxtDescription.Text;
            this.Close();
        }
    }
}
