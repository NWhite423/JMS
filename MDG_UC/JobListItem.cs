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

namespace MDG_UC
{
    public partial class JobListItem : UserControl
    {
        public JobListItem()
        {
            InitializeComponent();
        }

        public static Job Job { get; set; }

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
    }
}
