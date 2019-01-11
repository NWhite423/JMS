using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using JMS.UC;
using JMSFunctions;
using JMS.Variables;
using MDG_UC;
using JobCreationTool;

namespace JMS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Resizes the controls in panel1 to look good.
        /// </summary>
        private void ResizeControls()
        {
            int formwidth = SCMain.Panel1.Width;
            int edgeBuffer = 3;
            int centerBuffer = 2;
            int itemWidth = (formwidth - edgeBuffer - edgeBuffer - centerBuffer) / 2;
            CmbYear.Width = itemWidth;
            CmbMonth.Width = itemWidth;

            CmbMonth.Location = new Point(edgeBuffer + itemWidth + centerBuffer - 1, CmbMonth.Location.Y);
        }

        //Updated 12-22-18
        private void MainForm_Load(object sender, EventArgs e)
        {
            ResizeControls();
            Functions.InitializeVariables();
            if (Public.AllJobs.Count == 0)
            {
                return;
            }

            List<Job> lastJobList = Public.AllJobs[Public.AllJobs.Count - 1];
            int yPos = 1;
            foreach (Job job in lastJobList)
            {
                JobListItem jobLI = new JobListItem()
                {
                    Address = job.Address.Replace(";", ", "),
                    JobName = job.Name,
                    Width = PnlJobs.Width - 2,
                    Location = new Point(1, yPos),
                    Job = job,
                    Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top
                };
                PnlJobs.Controls.Add(jobLI);
                yPos += 1 + jobLI.Height;
            }
        }
        
        //Updated 12-22-18
        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        //Updated 12-22-18
        private void CmdFilter_Click(object sender, EventArgs e)
        {
            
        }
        
        private void TestEMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            return;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void CustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*CustomerManager cm = new CustomerManager();
            DialogResult result = cm.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                XML.SaveCustomers(cm.Customers, Variables.WorkDirectory + @"\JMS\customers.xml");
                Variables.Customers = XML.CompileCustomers(Variables.WorkDirectory + @"\JMS\customers.xml").OrderBy(o => o.Name).ToList();
            }*/
        }

        private void SCMain_Panel1_SizeChanged(object sender, EventArgs e)
        {
            ResizeControls();
        }
    }
}
