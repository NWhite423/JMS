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
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using JMSFunctions;

namespace JobCreationTool
{
    public partial class LandingForm : Form
    {
        public LandingForm()
        {
            InitializeComponent();
            Variables.LandingForm = this;
        }

        public List<Customer> Customers { get; internal set; }
        public string JobNumber { get; set; }
        public string Path { get; set; }

        //Updated 12-22-18
        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                if (Properties.Settings.Default.WorkDir.Equals(""))
                {
                    Application.Exit();
                }

                Customers = new List<Customer> { };
                Variables.WorkDir = Properties.Settings.Default.WorkDir;
                Variables.SubDir = Properties.Settings.Default.SubDir.Cast<string>().ToList();
                Functions.CreateJobNumber(this);
                var employeesList = JMS.Variables.Employees;

                foreach (string subDir in Variables.SubDir)
                {
                    int index = CBList.Items.Add(subDir);
                    CBList.SetItemChecked(index, true);
                }

                foreach (Employee employee in employeesList)
                {
                    if (employee.Status.Equals("Active"))
                    {
                        string str = employee.Name + " (" + employee.Role + ")";
                        CBEmployees.Items.Add(str);
                    }
                }

                DateTimeDue.Value = DateTime.Now.Add(TimeSpan.FromDays(31));
            }
            catch (Exception ex)
            {
                JMS.Functions.ProduceErrorReport(ex);
            }
        }

        //Updated 12-22-18
        private void CmdCheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < CBList.Items.Count; i++)
            {
                CBList.SetItemChecked(i, true);
            }
        }

        //Updated 12-22-18
        private void CmdUncheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < CBList.Items.Count; i++)
            {
                CBList.SetItemChecked(i, false);
            }
        }

        //Updated 12-22-18
        private void CmdCreate_Click(object sender, EventArgs e)
        {
            Functions.CreateJob(this);
            TxtJobName.Focus();
        }

        //Updated 12-22-18
        private void CmdAdd_Click(object sender, EventArgs e)
        {
            string text = Interaction.InputBox("Please enter the sub-folder name:", "Enter sub-folder");
            if (text.Equals(""))
            {
                return;
            }
            if (Variables.SubDir.Contains(text))
            {
                MessageBox.Show("The sub-directory already exists. You must use unique sud-directories.", "ERROR");
                return;
            }
            Properties.Settings.Default.SubDir.Add(text);
            Properties.Settings.Default.Save();
            Variables.SubDir.Add(text);
            CBList.Items.Clear();
            foreach (string subDir in Variables.SubDir)
            {
                int index = CBList.Items.Add(subDir);
                CBList.SetItemChecked(index, true);
            }
        }
        
        //Updated 12-22-18
        private void Button1_Click(object sender, EventArgs e)
        {
            int index = CBList.SelectedIndex;
            string name = CBList.GetItemText(CBList.Items[index]);
            DialogResult result = MessageBox.Show("Are you sure you want to remove " + name + " from the sub-directory list?\n\nWARNING: This will permanently delete the item from the list.", "Confirmation", MessageBoxButtons.YesNo);
            if (result.Equals(DialogResult.Yes))
            {
                CBList.Items.RemoveAt(0);
                Properties.Settings.Default.SubDir.Remove(name);
                Properties.Settings.Default.Save();
                Variables.SubDir.Remove(name);
                CBList.Items.Clear();
                foreach (string subDir in Variables.SubDir)
                {
                    index = CBList.Items.Add(subDir);
                    CBList.SetItemChecked(index, true);
                }
            }
        }

        //Updated 12-22-18
        private void CBList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBList.SelectedIndex >= 0)
            {
                cmdRemove.Enabled = true;
            } else
            {
                cmdRemove.Enabled = false;
            }
        }

        //Updated 12-22-18
        private void CmdAddRep_Click(object sender, EventArgs e)
        {
            //Open the reference page
            RefForm references = new RefForm();
            DialogResult result = references.ShowDialog();

            //if the dialog succecssfully completed.
            if (result.Equals(DialogResult.OK))
            {
                Customer customer = references.Value;
                string name = customer.Name;
                int listIndex = -1;
                foreach (Customer entry in Customers)
                {
                    if (entry.Name == name)
                    {
                        listIndex = Customers.IndexOf(entry);
                        break;
                    }
                }
                if (listIndex.Equals(-1))
                {
                    Customers.Add(customer);
                    Functions.PopulateTree(TVContacts, Customers);
                    return;
                }
                //The dialog only returns a single customer and single poc, so we can set a hard index limit
                Customers[listIndex].Employees.Add(customer.Employees[0]);
                Functions.PopulateTree(TVContacts, Customers);
            }
        }

        //Updated 12-22-18
        private void LandingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.DialogResult.Equals(DialogResult.OK))
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
