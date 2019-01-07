using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using System.Diagnostics;
using System.Threading;
using JMSFunctions;

namespace JMS
{
    public partial class LoadingScreen : Form
    {   
        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("Loading form loaded");
            Thread.Sleep(100);
            BringToFront();
        }
    }
}
