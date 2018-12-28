using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using JMS.UC;
using JMSFunctions;
using JobCreationTool;
using System.DirectoryServices;
using System.Net;

namespace JMS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private delegate void CloseDelegate();

        static public void StartLoading()
        {
            // Make sure it is only launched once.
            Thread thread = new Thread(new ThreadStart(LoadVariables));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        static private void LoadVariables()
        {
            string pathMaster = Variables.WorkDir;
            List<string> directories = Functions.GrabDirectories(pathMaster, "index.txt");
            Variables.AllIndexes = directories;
            List<List<Job>> allJobs = new List<List<Job>> { };
            for (int i = 0; i < directories.Count; i++)
            {
                Thread.Sleep(10);
                string dir = pathMaster + @"\" + directories[i];
                Debug.WriteLine("Directory: " + dir);
                string header = String.Format("Phase {0} of {1}: {2}", i + 1, directories.Count, Functions.GrabDirectoryName(dir));
                List<Job> jobs = new List<Job> { };
                List<string> jobindex = File.ReadAllLines(dir + @"\index.txt").ToList();
                int size = jobindex.Count;
                for (int j = 0; j < size; j++)
                {
                    Thread.Sleep(10);
                    string[] jobInfo = jobindex[j].Split(';');
                    Debug.WriteLine("Job: " + jobInfo[0]);
                    Job job = new Job();

                    //Grab information
                    job = XML.CompileJob(jobInfo[1]);
                    Debug.WriteLine("compiled " + job.Name);
                    jobs.Add(job);
                }
                allJobs.Add(jobs);
            }
            Variables.AllJobs = allJobs;
            IntVariables.LoadingDone = true;
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
                }
                JMSFunctions.AppSettings.Default.WorkDir = folder.SelectedPath;
                JMSFunctions.AppSettings.Default.Save();
            }

            //Determine if a name is setup for the local account
            if (JMSFunctions.AppSettings.Default.UserName.Equals(""))
            {
                string response = Microsoft.VisualBasic.Interaction.InputBox("Please enter your name. This name will appear on the logs and other documentation.", "Enter your name");
                if (response.Equals(""))
                {
                    MessageBox.Show("An invalid name was entered. Exiting.", "ERROR");
                    Application.Exit();
                }
                JMSFunctions.AppSettings.Default.UserName = response;
                JMSFunctions.AppSettings.Default.Save();
            }

            MessageBox.Show("This software is in development and is likely to change. Anything you see may be modified, added to, or removed.\n\nCurrent Version: " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString(), "Beta Build");

            // define what 'MainForm' is and initialize misc variables
            IntVariables.MainForm = this;
            IntFunctions.InitializeVariables();

            LoadingScreen screen = new LoadingScreen();
            screen.Show();
            screen.BringToFront();

            //Begin loading screen
            StartLoading();

            while (!IntVariables.LoadingDone)
            {
                Thread.Sleep(25);
            }

            screen.Close();

            string strHostName = string.Empty;
            strHostName = Dns.GetHostName();

            IPHostEntry ipEntry = Dns.GetHostByName(strHostName);
            IPAddress[] iparrAddr = ipEntry.AddressList;

            if (iparrAddr.Length > 0)
            {
                for (int intLoop = 0; intLoop < iparrAddr.Length; intLoop++)
                    Debug.WriteLine(iparrAddr[intLoop].ToString());
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
            Job job = null;
            foreach (Job jobsearch in Variables.Jobs)
            {
                if (jobsearch.Name.Equals(searchItem))
                {
                    job = jobsearch;
                }
            }

            if (job.Equals(null))
            {
                MessageBox.Show("No job was found by that name.", "ERROR");
                return;
            }

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
            }
        }

        //Updated 12-22-18
        private void CmdSearchClear_Click(object sender, EventArgs e)
        {
            IntFunctions.PopulateJobList(CmbDirectories.SelectedIndex, CBMonth.SelectedIndex);
            TxtSearchResults.Text = string.Empty;
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
            var st = new StackTrace();
            var sf = st.GetFrame(0);
            var currentMethod = sf.GetMethod();
            NotImplementedException exception = new NotImplementedException
            {
                Source = currentMethod.ToString()
            };
            Functions.ProduceErrorReport(exception);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            LBJobs.Size = new Size(LBJobs.Width, this.Height - 167);
        }
    }
}
