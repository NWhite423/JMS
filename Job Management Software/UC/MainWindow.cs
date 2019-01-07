using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using JMSFunctions;
using System.IO;

namespace JMS.UC
{
    public partial class MainWindow : UserControl
    {         
        public MainWindow()
        {
            InitializeComponent();
        }

        //Updated 12-22-18
        private void CmdMaps_Click(object sender, EventArgs e)
        {
            Functions.OpenGoogleMaps(TxtAddress.Text);
        }

        //Updated 12-22-18
        private void CmdOpen_Click(object sender, EventArgs e)
        {
            Process.Start(TxtFolderLocation.Text);
        }

        //Updated 12-22-18
        private void CmdRepMaps_Click(object sender, EventArgs e)
        {
            Functions.OpenGoogleMaps(TxtRepAddress.Text);
        }

        //Updated 12-22-18
        private void TxtEmail_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(TxtEmail.Text);
        }

        //Updated 12-22-18
        private void MainWindow_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip
            {
                ShowAlways = true
            };


            toolTip.SetToolTip(TxtEmail, "Double-click to copy value to clipboard");
        }

        //Updated 12-22-18
        private void CmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Variables.JobTransition)
            {
                return;
            }
            Variables.Job.Status = CmbStatus.GetItemText(CmbStatus.SelectedItem);
            string message = String.Format("Job status set to {0}", CmbStatus.GetItemText(CmbStatus.SelectedItem));
            //MessageBox.Show(message, timestamp);
            XML.AddNoteToJob(Variables.Job, message);
            
            IntFunctions.OpenFileInfo(this, Variables.Job);
        }

        //Updated 12-22-18
        private void CmdAddComment_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(message, timestamp);
            XML.AddNoteToJob(Variables.Job, TxtnoteEditor.Text);
            TxtnoteEditor.Text = string.Empty;
            IntFunctions.OpenFileInfo(this, Variables.Job);
        }

        //Updated 12-22-18
        private void CmdEdit_Click(object sender, EventArgs e)
        {
            if (!IntVariables.JobEditing)
            {
                TxtName.Enabled = true;
                TxtAddress.Enabled = true;
                TxtAddress.Text = Variables.Job.Address;
                DateTimeDueDate.Enabled = true;
                TxtPrice.Enabled = true;
                CmdEdit.Text = "Cancel";
                CmdSave.Enabled = true;
                IntVariables.JobEditing = true;
                CmdRemove.Visible = true;
                CmdRemove.Enabled = true;
                return;
            }
            TxtName.Enabled = false;
            TxtAddress.Enabled = false;
            TxtAddress.Text = Variables.Job.Address.Replace(";", ", ");
            DateTimeDueDate.Enabled = false;
            TxtPrice.Enabled = false;
            CmdEdit.Text = "Edit";
            CmdSave.Enabled = false;
            IntVariables.JobEditing = false;
            CmdRemove.Visible = false;
            CmdRemove.Enabled = false;
            return;
        }

        //Updated 12-22-18
        private void CmdRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to remove this job from JMS?\n\nThe folder will be moved to a backup location and you will not be able to reference this job through JMS", "Are you sure?", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
            {
                Job job = Variables.Job;

                //If directory does not exist, create directory.
                if (!Directory.Exists(Variables.CurrentDir + @"\Removed")) {
                    Directory.CreateDirectory(Variables.CurrentDir + @"\Removed");
                }

                //If there is alrady a folder by that name, delete it and replace it.
                if (Directory.Exists(Variables.CurrentDir + @"\Removed\" + job.Name)) {
                    Directory.Delete(Variables.CurrentDir + @"\Removed\" + job.Name);
                }
                Directory.Move(job.Path, (Variables.CurrentDir + @"\Removed\" + job.Name));
                string lineToRemove = job.Name + ";" + job.Path + @"\jobdata.xml;";
                List<string> file = File.ReadAllLines(Variables.CurrentDir + @"\index.txt").ToList();
                file.Remove(lineToRemove);
                File.WriteAllLines(Variables.CurrentDir + @"\index.txt", file );
                Variables.Jobs.Remove(job);
                IntVariables.MainForm.LBJobs.Refresh();
            }
        }

        //Updated 12-22-18
        private void CmdSave_Click(object sender, EventArgs e)
        {
            Job newJob = (Job)Variables.Job.Clone();
            newJob.Name = TxtName.Text;
            newJob.Address = TxtAddress.Text;
            newJob.DueDate = DateTimeDueDate.Value;
            newJob.Price = TxtPrice.Text;
            newJob.Path = Variables.Job.Path.Replace(@"\" + Variables.Job.Name, @"\" + newJob.Name);
            if (Variables.Job == newJob)
            {
                MessageBox.Show("Nothing has changed.", "ERROR");
                TxtName.Enabled = false;
                TxtAddress.Enabled = false;
                DateTimeDueDate.Enabled = false;
                TxtPrice.Enabled = false;
                CmdEdit.Text = "Edit";
                CmdSave.Enabled = false;
                IntVariables.JobEditing = false;
                CmdRemove.Visible = false;
                CmdRemove.Enabled = false;
                return;
            }
            string[] editTime = Functions.GrabCurrentTime().Split(';');
            newJob.DateEdited = editTime[0];
            newJob.TimeEdited = editTime[1];
            newJob.EditedBy = Variables.UserName;
            if (Functions.ReplaceJob(Variables.Job, newJob))
            {
                Variables.Job = newJob;
                IntFunctions.OpenFileInfo(this, newJob);
                TxtName.Enabled = false;
                TxtAddress.Enabled = false;
                DateTimeDueDate.Enabled = false;
                TxtPrice.Enabled = false;
                CmdEdit.Text = "Edit";
                CmdSave.Enabled = false;
                IntVariables.JobEditing = false;
                CmdRemove.Visible = false;
                CmdRemove.Enabled = false;

            }
        }

        //Updated 12-22-18
        private void LBRepresentatives_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //if the selection is the company, not the contact, exit
            if (LBRepresentatives.SelectedNode.Parent == null)
            {
                return;
            }

            int nodeIndex = LBRepresentatives.SelectedNode.Index;
            int parentIndex = LBRepresentatives.SelectedNode.Parent.Index;

            POC poc = Variables.Job.Contacts[parentIndex].Employees[nodeIndex];
            TxtRepName.Text = poc.Name;
            TxtRepAddress.Text = poc.Address;
            TxtRepCompany.Text = poc.Company;
            TxtEmail.Text = poc.Email;
            TxtPhone.Text = poc.PhoneNumber;
        }
    }
}
