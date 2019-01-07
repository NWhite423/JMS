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

        public void Initscript()
        {
            string pathMaster = Variables.WorkDir;
            List<string> directories = Functions.GrabDirectories(pathMaster, "index.txt");
            Variables.AllIndexes = directories;
            List<List<Job>> allJobs = new List<List<Job>> { };
            for (int i = 0; i < directories.Count; i++)
            {
                string dir = pathMaster + @"\" + directories[i];
                Debug.WriteLine("Directory: " + dir);
                List<Job> jobs = new List<Job> { };
                List<string> jobindex = File.ReadAllLines(dir + @"\index.txt").ToList();
                int size = jobindex.Count;
                Progress.Maximum = size;
                for (int j = 0; j < size; j++)
                {
                    string[] jobInfo = jobindex[j].Split(';');
                    Debug.WriteLine("Job: " + jobInfo[0]);
                    Job job = new Job();
                    Progress.Value = j + 1;

                    //Grab information
                    job = XML.CompileJob(jobInfo[1]);
                    Debug.WriteLine("compiled " + job.Name);
                    jobs.Add(job);
                }
                allJobs.Add(jobs);
            }
            Variables.AllJobs = allJobs;
            Variables.LastCompile = DateTime.Now;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void LoadingScreen_Shown(object sender, EventArgs e)
        {
            Initscript();
        }
    }
}
