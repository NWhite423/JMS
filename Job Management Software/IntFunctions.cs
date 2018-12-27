using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml.Linq;
using JMSFunctions;
using System.ComponentModel;
using System.Drawing;

namespace JMS
{
    class IntFunctions
    {
        //Updated 12-22-18 - has catch
        public static void OpenFileInfo(UC.MainWindow window, Job job)
        {
            try
            {
                //If the listboxes have content, clear them.
                if (window.LBRepresentatives.Nodes.Count > 0)
                {
                    window.LBRepresentatives.BeginUpdate();
                    window.LBRepresentatives.Nodes.Clear();
                    window.LBRepresentatives.EndUpdate();
                }

                if (window.LBLog.Items.Count > 0)
                {
                    window.LBLog.Items.Clear();
                }

                if (window.LBTasks.Items.Count > 0)
                {
                    window.LBTasks.Items.Clear();
                }

                if (window.LBAssigned.Items.Count > 0)
                {
                    window.LBAssigned.Items.Clear();
                }

                //Set all the text windows to their value
                window.TxtName.Text = job.Name;
                window.TxtAddress.Text = job.Address.Replace(";", ", ");
                window.TxtFolderLocation.Text = job.Path;
                window.TxtDate.Text = job.DateCreated;
                window.TxtDateEdited.Text = job.DateEdited;
                window.TxtTime.Text = job.TimeCreated;
                window.TxtTimeEdited.Text = job.TimeEdited;
                window.TxtCreatedBy.Text = job.CreatedBy;
                window.TxtEditedBy.Text = job.EditedBy;
                window.TxtPrice.Text = job.Price;
                window.CmbStatus.SelectedIndex = window.CmbStatus.FindStringExact(job.Status);
                window.TxtRepName.Text = string.Empty;
                window.TxtRepCompany.Text = string.Empty;
                window.TxtRepAddress.Text = string.Empty;
                window.TxtPhone.Text = string.Empty;
                window.TxtEmail.Text = string.Empty;
                window.DateTimeDueDate.Value = job.DueDate;

                if (DateTime.Now.Date.AddDays(2) > job.DueDate)
                {
                    window.LblDateCompare.BackColor = Color.Red;
                }
                else
                if (DateTime.Now.Date.AddDays(8) > job.DueDate)
                {
                    window.LblDateCompare.BackColor = Color.Yellow;
                }
                else
                {
                    window.LblDateCompare.BackColor = Color.White;
                }

                string timeTillDue = null;

                if (DateTime.Now.Date > job.DueDate)
                {
                    timeTillDue = String.Format("{0} day(s) past due", (DateTime.Now.Date - job.DueDate).Days);
                }
                else
                {
                    timeTillDue = String.Format("{0} day(s) until due", (job.DueDate - DateTime.Now.Date).Days);
                }
                window.LblDateCompare.Text = timeTillDue;


                window.LBRepresentatives.BeginUpdate();
                foreach (Customer customer in job.Contacts)
                {
                    var node = window.LBRepresentatives.Nodes.Add(customer.Name + "(" + customer.Employees.Count + ")");
                    int index = window.LBRepresentatives.Nodes.IndexOf(node);
                    foreach (POC poc in customer.Employees)
                    {
                        window.LBRepresentatives.Nodes[index].Nodes.Add(poc.Name);
                    }
                }
                window.LBRepresentatives.EndUpdate();

                foreach (Note entry in job.Notes)
                {
                    string str = String.Format("[{0}] [{1}]: {2}", entry.Timestamp, entry.Author, entry.Value);
                    window.LBLog.Items.Add(str);
                }

                foreach (string task in job.Tasks)
                {
                    window.LBTasks.Items.Add(task);
                }

                foreach (Employee employee in job.Employees)
                {
                    window.LBAssigned.Items.Add(employee.Name);
                }

                Variables.Job = job;
            } catch (Exception ex)
            {
                Functions.ProduceErrorReport(ex);
            }
        }

        //Updated 12-22-18 - has catch
        public static List<string> GrabDirectories(string path, string file)
        {
            try
            {
                List<string> array = new List<string> { };

                foreach (string dir in Directory.GetDirectories(path))
                {
                    if (File.Exists(dir + @"\" + file))
                    {
                        string dirName = new DirectoryInfo(dir).Name;
                        array.Add(dirName);
                    }
                }
                return array;
            }
            catch (Exception ex)
            {
                Functions.ProduceErrorReport(ex);
            }
            return null;
        }

        //Updated 12-22-18 - has catch
        public static void InitializeVariables()
        {
            try
            {
                Variables.WorkDir = JMSFunctions.AppSettings.Default.WorkDir;
                Variables.UserName = JMSFunctions.AppSettings.Default.UserName;
                Variables.DevMode = JMSFunctions.AppSettings.Default.DevMode;

                IntVariables.JobEditing = false;

                Variables.Employees = XML.CompileEmployees(Variables.WorkDir + @"\JMS\employees.xml").OrderBy(o => o.Name).ToList();
                Variables.Customers = XML.CompileCustomers(Variables.WorkDir + @"\JMS\customers.xml").OrderBy(o => o.Name).ToList();

                Variables.Jobs = new List<Job> { };
                Variables.JobList = IntVariables.MainForm.LBJobs;
                Variables.AllJobs = new List<List<Job>> { };
                Variables.AllIndexes = new List<string> { };
                Variables.JobTransition = false;
            }
            catch (Exception ex)
            {
                Functions.ProduceErrorReport(ex);
            }
            
        }

        //Updated 12-22-18
        public static void PopulateJobList(int index, int monthIndex)
        {
            try
            {
                //No jobs were loaded, would throw an error.
                if (Variables.AllJobs.Count == 0)
                {
                    MessageBox.Show("No jobs were loaded. (incorrect job directory?)", "ERROR");
                    return;
                }

                //Grab the year's jobs and clear the current list
                List<Job> jobsAll = Variables.AllJobs[index];
                List<Job> filter = new List<Job> { };

                if (monthIndex != 0)
                {
                    foreach (Job job in jobsAll)
                    {
                        filter = jobsAll.Where(n => n.Name.Contains(monthIndex.ToString("00"))).ToList();
                    }
                }
                else
                {
                    filter = jobsAll;
                }

                Variables.Jobs = filter;
                Functions.PopulateJobList(Variables.Jobs);
                string[] path = { Variables.WorkDir, Variables.AllIndexes[index] };
                Variables.CurrentDir = Path.Combine(path);
            }
            catch (Exception ex)
            {
                Functions.ProduceErrorReport(ex);
            }
        }
    }
}
