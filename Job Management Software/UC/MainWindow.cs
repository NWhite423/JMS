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
using System.Threading;

namespace JMS.UC
{
    public partial class MainWindow : UserControl
    {         
        public MainWindow()
        {
            InitializeComponent();
        }

        public Job CurrentJob { get; set; }
        public static Thread UpdateThread { get; set; }

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
            /*Thread thread = new Thread(new ThreadStart(UpdateJobInfo));
            UpdateThread = thread;
            UpdateThread.IsBackground = true;
            UpdateThread.Start();*/
        }

        private void UpdateJobInfo(object sender, EventArgs e)
        {               
            Debug.WriteLine("Re-compiling current job");
            XML.RecompileJob(
                CurrentJob.Path,
                Variables.JobIndex[0],
                Variables.JobIndex[1]
            );
            IntFunctions.OpenFileInfo(this, Variables.AllJobs[Variables.JobIndex[0]][Variables.JobIndex[1]]);
        }

        //Updated 12-22-18
        private void CmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntVariables.JobEditing = true;
            if (Variables.JobTransition)
            {
                return;
            }
            Variables.Job.Status = CmbStatus.GetItemText(CmbStatus.SelectedItem);
            string message = String.Format("Job status set to {0}", CmbStatus.GetItemText(CmbStatus.SelectedItem));
            //MessageBox.Show(message, timestamp);
            XML.AddNoteToJob(Variables.Job, message);
            
            IntFunctions.OpenFileInfo(this, Variables.Job);
            IntVariables.JobEditing = false;
        }

        //Updated 12-22-18
        private void CmdAddComment_Click(object sender, EventArgs e)
        {
            IntVariables.JobEditing = true;
            //MessageBox.Show(message, timestamp);
            XML.AddNoteToJob(Variables.Job, TxtnoteEditor.Text);
            TxtnoteEditor.Text = string.Empty;
            IntFunctions.OpenFileInfo(this, Variables.Job);
            IntVariables.JobEditing = false;
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
            /*if (MessageBox.Show("Are you sure you wish to remove this job from JMS?\n\nThe folder will be moved to a backup location and you will not be able to reference this job through JMS", "Are you sure?", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
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
            }*/
        }

        //Updated 12-22-18
        private void CmdSave_Click(object sender, EventArgs e)
        {
            IntVariables.JobEditing = true;
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
            if (LBRepresentatives.SelectedNode == null)
            {
                CmdRemoveRep.Enabled = false;
                return;
            }
            CmdRemoveRep.Enabled = true;
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

        private void CmdAddTask_Click(object sender, EventArgs e)
        {
            IntVariables.JobEditing = true;
            CheckListDialog dialog = new CheckListDialog
            {
                Text = "Select Jobs"
            };
            CheckedListBox box = dialog.checkedListBox1;
            foreach (string task in Variables.Tasks)
            {
                int index = box.Items.Add(task);
                if (Variables.Job.Tasks.Contains(task))
                {
                    box.SetItemChecked(index, true);
                }
            }

            DialogResult result = dialog.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                var itemCollection = box.CheckedItems;
                if (itemCollection.Count == 0)
                {
                    MessageBox.Show("Cannot proceed\nNo tasks were selected for the job", "ERROR");
                    return;
                }
                List<string> tasks = new List<string> { };
                foreach (var item in itemCollection)
                {
                    tasks.Add(box.GetItemText(item));
                }
                Variables.Job.Tasks = tasks;

                XML.AddNoteToJob(Variables.Job, "Changed job tasks");
                IntFunctions.OpenFileInfo(this, Variables.Job);
            }
            dialog.Dispose();
            IntVariables.JobEditing = false;
        }

        private void CmdModifyEmployees_Click(object sender, EventArgs e)
        {
            IntVariables.JobEditing = true;
            CheckListDialog dialog = new CheckListDialog
            {
                Text = "Select Employees"
            };
            CheckedListBox box = dialog.checkedListBox1;
            foreach (Employee employee in Variables.Employees)
            {
                if (employee.Status != "Retired")
                {
                    int index = box.Items.Add(employee.Name + " (" + employee.Role + ")");
                    if (Variables.Job.Employees.Contains(employee))
                    {
                        box.SetItemChecked(index, true);
                    }
                }
            }

            DialogResult result = dialog.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                var itemCollection = box.CheckedItems;
                if (itemCollection.Count == 0)
                {
                    MessageBox.Show("Cannot proceed\nNo employees were selected for the job", "ERROR");
                    return;
                }
                List<Employee> newList = new List<Employee> { };
                foreach (var item in itemCollection)
                {
                    string name = box.GetItemText(item).Split('(')[0].TrimEnd();
                    Debug.WriteLine(name);
                    newList.Add(Variables.Employees.First(n => n.Name.Equals(name)));
                }
                Variables.Job.Employees = newList;

                XML.AddNoteToJob(Variables.Job, "Changed assigned employees");
                IntFunctions.OpenFileInfo(this, Variables.Job);
            }
            dialog.Dispose();
            IntVariables.JobEditing = false;
        }

        private void CmdAddRep_Click(object sender, EventArgs e)
        {
            IntVariables.JobEditing = true;
            CustomerSelector selector = new CustomerSelector()
            {
                Text = "Select Customer / Contact"
            };
            TreeView tree = selector.TVCustomers;
            foreach (Customer customer in Variables.Customers)
            {
                TreeNode node = tree.Nodes.Add(customer.Name);
                foreach (POC poc in customer.Employees)
                {
                    tree.Nodes[node.Index].Nodes.Add(poc.Name);
                }
            }
            DialogResult result = selector.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                //An entire company is selected.
                if (tree.SelectedNode.Parent == null)
                {
                    Customer selected = Variables.Customers.First(n => n.Name == tree.SelectedNode.Text);
                    if (Variables.Job.Contacts.Contains(selected))
                    {
                        MessageBox.Show("Unable to add company\nThe company is already in the contacts. Select a Point of Reference in the company", "ERROR");
                        IntVariables.JobEditing = false;
                        return;
                    }
                    Variables.Job.Contacts.Add(selected);
                    XML.AddNoteToJob(Variables.Job, "Added " + selected.Name + " to the list of contacts");
                    IntFunctions.OpenFileInfo(this, Variables.Job);
                    IntVariables.JobEditing = false;
                    return;
                }
                Customer selectedCustomer = Variables.Customers.First(n => n.Name == tree.SelectedNode.Parent.Text);
                POC selectedPOC = selectedCustomer.Employees.First(n => n.Name == tree.SelectedNode.Text);
                //The customer exists, but the employee doesn't
                if (Variables.Job.Contacts.Find(n => n.Name == selectedCustomer.Name) != null)
                {
                    var customerItem = Variables.Job.Contacts.First(n => n.Name == selectedCustomer.Name);
                    List<POC> pocs = customerItem.Employees;
                    if (pocs.Contains(selectedPOC))
                    {
                        MessageBox.Show("Point of Contact is already a selected contact", "ERROR");
                        IntVariables.JobEditing = false;
                        return;
                    }
                    pocs.Add(selectedPOC);
                    Variables.Job.Contacts[Variables.Job.Contacts.FindIndex(n => n.Name == selectedCustomer.Name)].Employees = pocs;
                    XML.AddNoteToJob(Variables.Job, "Added " + selectedPOC.Name + " to " + selectedCustomer.Name);
                    IntFunctions.OpenFileInfo(this, Variables.Job);
                    IntVariables.JobEditing = false;
                    return;
                } else
                {

                    Customer customer = selectedCustomer;
                    customer.Employees.Clear();
                    List<POC> pocs = new List<POC> { };
                    pocs.Add(selectedPOC);
                    customer.Employees = pocs;
                    Variables.Job.Contacts.Add(customer);
                    XML.AddNoteToJob(Variables.Job, "Added " + selectedPOC.Name + " to " + selectedCustomer.Name + ", a new company");
                    IntFunctions.OpenFileInfo(this, Variables.Job);
                    IntVariables.JobEditing = false;
                    return;
                }
                
            }
        }

        private void CmdRemoveRep_Click(object sender, EventArgs e)
        {
            IntVariables.JobEditing = true;
            if (LBRepresentatives.SelectedNode.Parent == null)
            {
                Variables.Job.Contacts.Remove(Variables.Job.Contacts.First(n => n.Name == LBRepresentatives.SelectedNode.Text.Split('(')[0].TrimEnd()));
                XML.AddNoteToJob(Variables.Job, "Removed " + LBRepresentatives.SelectedNode.Text + " as a customer.");
                IntFunctions.OpenFileInfo(this, Variables.Job);
                IntVariables.JobEditing = false;
                return;
            }
            Customer customer = Variables.Job.Contacts.First(n => n.Name == LBRepresentatives.SelectedNode.Parent.Text.Split('(')[0].TrimEnd());
            customer.Employees.Remove(customer.Employees.First(n => n.Name == LBRepresentatives.SelectedNode.Text));
            XML.AddNoteToJob(Variables.Job, "Removed " + LBRepresentatives.SelectedNode.Text + " as a Point of Contact from " + customer.Name + ".");
            IntFunctions.OpenFileInfo(this, Variables.Job);

            IntVariables.JobEditing = false;
        }

        private void CmdEmailCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TxtEmail.Text);
            MessageBox.Show("E-Mail copied to clipboard");
        }
    }
}
