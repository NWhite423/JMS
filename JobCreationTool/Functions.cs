using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using JMSFunctions;

namespace JobCreationTool
{
    class Functions
    {
        public static void PopulateTree(TreeView tree, List<Customer> customers)
        {
            if (tree.Nodes.Count > 0)
            {
                tree.Nodes.Clear();
            }
            foreach (Customer customer in customers)
            {
                TreeNode node = tree.Nodes.Add(customer.Name);
                int index = tree.Nodes.IndexOf(node);
                foreach (POC poc in customer.Employees)
                {
                    tree.Nodes[index].Nodes.Add(poc.Name);
                }
            }
        }

        //Updated 12-22-18
        public static void CreateJobNumber(LandingForm form)
        {
            bool numberFinished = false;
            string workDir = Variables.WorkDir;

            while (!numberFinished)
            {
                string year = DateTime.Now.Year.ToString("0000");
                string month = DateTime.Now.Month.ToString("00");

                if (!Directory.Exists(workDir + year))
                {
                    var input = MessageBox.Show("A directory for " + year + " does not exist. Create one now?\n\nProposed folder location:\n  " + workDir + year, "Create new year directory", MessageBoxButtons.YesNo);
                    if (input.Equals(DialogResult.Yes))
                    {
                        Directory.CreateDirectory(workDir + year);
                        var file = File.CreateText(workDir + @"\" + year + @"\index.txt");
                        file.Close();
                        File.SetAttributes(workDir + @"\" + year + @"\index.txt", File.GetAttributes(workDir + @"\" + year + @"\index.txt") | FileAttributes.Hidden);
                    }
                    else
                    {
                        MessageBox.Show("ERROR:\nCannot create job. Missing current year folder.\nClosing...", "ERROR");
                        return;
                    }
                };

                workDir = workDir + year;
                Variables.Year = year;

                if (!Directory.Exists(workDir + @"\" + month + "-" + year))
                {
                    var input = MessageBox.Show("A directory for " + month + " does not exist. Create one now?\n\nProposed folder location:\n  " + workDir + @"\" + month + "-" + year, "Create new year directory", MessageBoxButtons.YesNo);
                    if (input.Equals(DialogResult.Yes))
                    {
                        Directory.CreateDirectory(workDir + @"\" + month + "-" + year);
                    }
                    else
                    {
                        MessageBox.Show("ERROR:\nCannot create job. Missing current month folder.\nClosing...", "ERROR");
                        return;
                    }
                };

                workDir = workDir + @"\" + month + "-" + year;
                Variables.CurPath = workDir;
                int jobNumber = 1;

                string[] directories = Directory.GetDirectories(workDir);
                for (int i = 0; i < directories.Count(); i++)
                {
                    Debug.WriteLine("Checking " + directories[i] + "for job number");
                    if (directories[i].Contains(month + "-" + year + @"\" + month + "-"))
                    {
                        Debug.WriteLine("Job number found. increasing current job number.");
                        jobNumber++;
                    }
                    else
                    {
                        if (directories[i - 1].Contains(month + "-" + jobNumber.ToString("000")))
                        {
                            Debug.WriteLine("Job number found. increasing current job number.");
                            jobNumber++;
                        }
                        else
                        {
                            Debug.WriteLine("Job number not found.");
                        }
                    }
                }
                Variables.JobNumber = month + "-" + jobNumber.ToString("000");
                form.JobNumber = month + "-" + jobNumber.ToString("000");
                form.Path = workDir;
                form.LblJobNumber.Text = year + "-" + month + "-" + jobNumber.ToString("000");
                numberFinished = true;
            }
            return;
        }
        
        //Updated 12-22-18
        public static bool CreateJob(LandingForm form)
        {
            //Grab all form information
            string name = form.TxtJobName.Text;
            string addressLine1 = form.TxtAddressLine1.Text;
            string addressLine2 = form.TxtAddressLine2.Text;
            List<string> tasks = JMS.Functions.GetCheckedItems(form.CBTasks);
            List<string> subfolders = JMS.Functions.GetCheckedItems(form.CBList);
            List<Customer> customers = form.Customers;
            List<string> employees = JMS.Functions.GetCheckedItems(form.CBEmployees);

            //Check for empty items
            if (name.Equals(""))
            {
                MessageBox.Show("No job name was entered.", "ERROR");
                form.TxtJobName.Focus();
                return false;
            }

            if (addressLine1.Equals("") || addressLine2.Equals(""))
            {
                MessageBox.Show("The address is not filled out (both lines are needed)", "ERROR");
                if (addressLine1.Equals(""))
                {
                    form.TxtAddressLine1.Focus();
                    return false;
                }
                if (addressLine2.Equals(""))
                {
                    form.TxtAddressLine2.Focus();
                    return false;
                }
            }

            if (tasks.Count == 0)
            {
                MessageBox.Show("There are no tasks selected.", "ERROR");
                return false;
            }

            if (customers.Count == 0)
            {
                MessageBox.Show("At laese one Point of Contact needs to be present.", "ERROR");
                return false;
            }

            if (employees.Count == 0)
            {
                MessageBox.Show("Please select an employee.", "ERROR");
                return false;
            }

            //Do the heavy lifting
            Job job = new Job { };
            while (name.First().Equals(' '))
            {
                name = name.Remove(0, 1);
            }

            if (form.CbUseJobNumber.Checked)
            {
                job.Name = form.JobNumber + " " + name;
            }
            else
            {
                job.Name = name;
            }

            job.Path = Variables.CurPath + @"\" + job.Name;
            job.Address = addressLine1 + ";" + addressLine2;
            job.Tasks = tasks;
            job.Folders = subfolders;
            job.Contacts = form.Customers;
            job.Price = form.TxtPrice.Text;
            job.DueDate = form.DateTimeDue.Value.Date;
            job.DateCreated = DateTime.Now.ToShortDateString();
            job.DateEdited = DateTime.Now.ToShortDateString();
            job.TimeCreated = DateTime.Now.ToString("HH:mm:ss");
            job.TimeEdited = DateTime.Now.ToString("HH:mm:ss");
            job.CreatedBy = JMSFunctions.AppSettings.Default.UserName;
            job.EditedBy = JMSFunctions.AppSettings.Default.UserName;
            job.Status = "Created";
            job.Employees = new List<Employee> { };

            foreach (string employee in employees)
            {
                Debug.WriteLine(employee);
                string employeename = employee.Split('(')[0].TrimEnd(' ');
                foreach (Employee employeeItem in JMS.Variables.Employees)
                {
                    if (employeeItem.Name.Equals(employeename))
                    {
                        job.Employees.Add(employeeItem);
                        Debug.WriteLine("Employee found");
                    }
                }
            }

            job.Notes = new List<Note> { };

            string verify = String.Format("Please Verify this information\n" +
                "\n" +
                "Job Name: {0}\n" +
                "Job Address: {1}\n" +
                "Job folder: {2}\n" +
                "Tasks: {3}\n" +
                "Sub-folders: {4}\n" +
                "Employees: {5}\n" +
                "\n" +
                "Is this information correct?",
                job.Name, job.Address, job.Path, JMS.Functions.ConvertListToString(job.Tasks), JMS.Functions.ConvertListToString(job.Folders), JMS.Functions.ConvertListToString(employees));
            DialogResult result = MessageBox.Show(verify, "Verify Information", MessageBoxButtons.YesNo);
            if (result.Equals(DialogResult.Yes))
            {
                CreateFolder(job, form);
                return true;
            }
            MessageBox.Show("Folder creation aborted.");
            return false;
        }

        //Updated 12-22-18
        public static void CreateFolder(Job job, LandingForm form)
        {
            //If there is a folder that matches another job, exit to avoid conflict.
            if (Directory.Exists(job.Path))
            {
                MessageBox.Show("A folder with the specified name already exists. Please enter a different name.", "ERROR");
                return;
            }
            Directory.CreateDirectory(job.Path);
            foreach (string sub in job.Folders)
            {
                Directory.CreateDirectory(job.Path + @"\" + sub);
            }

            if (JMS.Variables.AllIndexes.Contains(Variables.Year.ToString()))
            {
                List<Job> jobList = new List<Job> { job };
                JMS.Variables.AllJobs.Add(jobList);
            } else
            {
                JMS.Variables.AllJobs[JMS.Variables.AllJobs.Count - 1].Add(job);
            }

            XML.WriteXMLFile(job, job.Path + @"\jobdata.xml");

            string logItems = job.Name + ";" + job.Path + @"\jobdata.xml;" + Environment.NewLine;
            File.AppendAllText(JMSFunctions.AppSettings.Default.WorkDir + @"\" + Variables.Year + @"\index.txt", logItems);
            CreateJobNumber(form);
            form.TxtAddressLine1.Text = "";
            form.TxtAddressLine2.Text = "";
            form.TxtJobName.Text = "";
            form.Customers.Clear();
            form.TxtJobName.Focus();

            

            form.DialogResult = DialogResult.OK;
        }
    }
}
