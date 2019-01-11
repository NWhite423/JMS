using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JMS;
using JMSFunctions;
using System.Diagnostics;

namespace MDG_UC
{
    public partial class JobListItem : UserControl
    {
        public JobListItem()
        {
            InitializeComponent();
        }

        [Description("The job object assigned to the control.")]
        public Job Job { get; set; }

        [Description("The name of the job (folder name)."),Category("Data")]
        public string JobName
        {
            get
            {
                return LblName.Text;
            }
            set
            {
                LblName.Text = value;
            }
        }

        [Description("The street address of the job"), Category("Data")]
        public string Address
        {
            get
            {
                return LblAddress.Text;
            }
            set
            {
                LblAddress.Text = value;
            }
        }

        private void CmdOpen_Click(object sender, EventArgs e)
        {
            Process.Start(Job.Path);
        }
    }
}
