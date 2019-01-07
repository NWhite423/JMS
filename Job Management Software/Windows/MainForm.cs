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
using JobCreationTool;

namespace JMS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        //Updated 12-22-18
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Determine if a drive has been selected
            if (JMSFunctions.AppSettings.Default.WorkDir.Equals(""))
            {
                //If no, it is assumed first run. Do all this.
                MessageBox.Show("First Run Setup. Please select a directory.");
                FolderBrowserDialog folder = new FolderBrowserDialog();
                folder.ShowDialog();
                if (folder.SelectedPath.Equals(""))
                {
                    MessageBox.Show("No path was selected. Exiting.", "ERROR");
                    Application.Exit();
                    return;
                }
                JMSFunctions.AppSettings.Default.WorkDir = folder.SelectedPath;
                JMSFunctions.AppSettings.Default.Save();
            }

            //Determine if a name is setup for the local account
            if (JMSFunctions.AppSettings.Default.UserName.Equals(""))
            {
                string response = StringEntry.ShowDialog("Please enter your name.", "Enter your Name");
                if (response.Equals(""))
                {
                    MessageBox.Show("An invalid name was entered. Exiting.", "ERROR");
                    Application.Exit();
                    return;
                }
                JMSFunctions.AppSettings.Default.UserName = response;
                JMSFunctions.AppSettings.Default.Save();
            }
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fvi.FileVersion;
            MessageBox.Show("This software is in development and is likely to change. Anything you see may be modified, added to, or removed.\n\nCurrent Version: " + version, "Beta Build");

            // define what 'MainForm' is and initialize misc variables
            IntVariables.MainForm = this;
            IntFunctions.InitializeVariables();
            
            //Begin loading screen
            LoadingScreen screen = new LoadingScreen();

            if (!screen.ShowDialog().Equals(DialogResult.OK))
            {
                MessageBox.Show("There was an error compiling the jobs. Good luck fixing this shit.", "ERROR");
                return;
            }

            //Populate year filter with all years avaiable.
            foreach (string year in Variables.AllIndexes)
            {
                CmbDirectories.Items.Add(year);
            }

            //If there is items in the list, select the latest one
            if (CmbDirectories.Items.Count > 0)
            {
                CmbDirectories.SelectedIndex = CmbDirectories.Items.Count - 1;
                CBMonth.SelectedIndex = 0;
                IntFunctions.PopulateJobList(CmbDirectories.SelectedIndex, CBMonth.SelectedIndex);
                TxtSearchResults.Text = string.Empty;
            }
            


            //Show window
            this.WindowState = FormWindowState.Normal;
        }

        //Updated 12-22-18
        private void CmbDirectories_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBMonth.SelectedIndex = 0;
            IntFunctions.PopulateJobList(CmbDirectories.SelectedIndex, CBMonth.SelectedIndex);
        }

        //Updated 12-22-18
        private void JobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LandingForm form = new LandingForm();
            DialogResult result = form.ShowDialog();

            //Job form closed
            if (result.Equals(DialogResult.OK))
            {
                //Grab job indexes
                List<string> yearDirectories = Functions.GrabDirectories(Variables.WorkDir, "index.txt");

                //If the new list is different than the old list, then a new year was added. We need to add the year to the cmbDirectory list.
                if (Variables.AllIndexes != yearDirectories)
                {
                    List<Job> jobs = new List<Job> { };
                    List<string> jobindex = File.ReadAllLines(Variables.WorkDir + @"\" + yearDirectories[yearDirectories.Count - 1] + @"\index.txt").ToList();
                    int size = jobindex.Count;
                    for (int j = 0; j < size; j++)
                    {
                        string[] jobInfo = jobindex[j].Split(';');
                        Debug.WriteLine("Job: " + jobInfo[0]);
                        Job job = new Job();

                        //Grab information
                        job = XML.CompileJob(jobInfo[1]);
                        Debug.WriteLine("compiled " + job.Name);
                        jobs.Add(job);
                    }
                    Variables.AllJobs.Add(jobs);


                    if (CmbDirectories.Items.Count > 0)
                    {
                        CmbDirectories.Items.Clear();
                    }
                    foreach (string list in yearDirectories)
                    {
                        CmbDirectories.Items.Add(list);
                        CmbDirectories.SelectedIndex = CmbDirectories.Items.Count - 1;
                        IntFunctions.PopulateJobList(CmbDirectories.SelectedIndex, CBMonth.SelectedIndex);
                    }
                } else
                {
                    LBJobs.Refresh();
                    //Variables.Jobs.Add(Variables.CurrentJobs[Variables.CurrentJobs.Count-1]);
                }
            }
        }

        //Updated 12-22-18
        private void LBJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Do not execute if the MainForm is not the focused form
            if (Form.ActiveForm != this) {
                return;
            }

            //Extra bullshit to make this not retarded.
            if (LBJobs.Items.Count-1 < LBJobs.SelectedIndex || (LBJobs.SelectedIndex) < 0)
            {
                return;
            }
            Debug.WriteLine("Job index: " + LBJobs.SelectedIndex);
            Variables.JobTransition = true;
            string searchItem = LBJobs.GetItemText(LBJobs.SelectedItem);
            Job job = Variables.Jobs.First(n => n.Name == searchItem);
            
            MainWindow window = new MainWindow();

            if (MainPanel.Controls.Count > 0)
            {
                if (MainPanel.Controls[0] is MainWindow)
                {
                    window = (MainWindow)MainPanel.Controls[0];
                    IntFunctions.OpenFileInfo(window, job);
                    Variables.JobTransition = false;
                    return;
                }
            } else
            {
                MainPanel.Controls.Add(window);
                window.Dock = DockStyle.Fill;
                IntFunctions.OpenFileInfo(window, job);
                Variables.JobTransition = false;
                return;
            }
            Variables.JobTransition = false;
        }

        //Updated 12-22-18
        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }
        
        //Updated 12-22-18
        private void SalesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //Updated 12-22-18
        private void CmdFilter_Click(object sender, EventArgs e)
        {
            SearchWindow window = new SearchWindow();
            DialogResult result = window.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                Functions.PopulateJobList(window.FilteredJobs);
                Variables.Jobs = window.FilteredJobs;
                Variables.FilteredList = true;
            }
        }

        //Updated 12-22-18
        private void CmdSearchClear_Click(object sender, EventArgs e)
        {
            TxtSearchResults.Text = "";
            CBMonth.SelectedIndex = 0;
            Variables.FilteredList = false;
            IntFunctions.PopulateJobList(CmbDirectories.SelectedIndex, CBMonth.SelectedIndex);
        }

        //Updated 12-22-18
        private void DeadlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelFunctions.CreateExcelFile();
        }

        //Updated 12-22-18
        private void CBMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntFunctions.PopulateJobList(CmbDirectories.SelectedIndex, CBMonth.SelectedIndex);
        }

        private void TestEMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*var st = new StackTrace();
            var sf = st.GetFrame(0);
            var currentMethod = sf.GetMethod();
            NotImplementedException exception = new NotImplementedException
            {
                Source = currentMethod.ToString()
            };
            Functions.ProduceErrorReport(exception);*/
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void CustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerManager cm = new CustomerManager();
            DialogResult result = cm.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                XML.SaveCustomers(cm.Customers, Variables.WorkDir + @"\JMS\customers.xml");
                Variables.Customers = XML.CompileCustomers(Variables.WorkDir + @"\JMS\customers.xml").OrderBy(o => o.Name).ToList();
            }
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            LBJobs.Size = new Size(LBJobs.Width, this.Height - 167);
        }

        private void RefreshJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XML.RecompileJobs();
            IntFunctions.PopulateJobList(CmbDirectories.SelectedIndex, CBMonth.SelectedIndex);
        }
    }
}
