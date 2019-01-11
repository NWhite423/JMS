using JMSFunctions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JMS.Variables;

namespace JMS
{
    public partial class SearchWindow : Form
    {
        public SearchWindow()
        {
            InitializeComponent();
        }

        public List<Job> FilteredJobs { get; set; }
        private List<Employee> Employees { get; set; }
        private List<List<Job>> Jobs { get; set; }

        private void SearchWindow_Load(object sender, EventArgs e)
        {
            DateTimeFrom.Value = DateTime.Now;
            DateTimeTo.Value = DateTime.Now;
            DateTimeDue.Value = DateTime.Now;

            Employees = Public.Employees;
            Jobs = Public.AllJobs;

            foreach (Employee employee in Public.Employees)
            {
                CBWorkers.Items.Add(employee.Name);
            }
        }

        private void CmdExecute_Click(object sender, EventArgs e)
        {
            /*int directory = IntVariables.MainForm.CmbDirectories.SelectedIndex;

            int filtersApplied = 0;
            List<Job> consideredJobs = new List<Job> { };
            IEnumerable<Job> resultstream = Jobs[directory];
            
            List<Job> namesearch = new List<Job> { };
            List<Job> addressSerch = new List<Job> { };
            List<Job> dateSearch = new List<Job> { };
            List<Job> dueDateSerch = new List<Job> { };
            List<Job> customerSerch = new List<Job> { };
            List<Job> employeeSerch = new List<Job> { };
            List<Job> statusSearch = new List<Job> { };

            if (TxtName.Text.Count() > 0)
            {
                filtersApplied++;
                if (CBExactMatch.Checked)
                {
                    namesearch = resultstream.Where(job => job.Name.Equals(TxtName.Text)).ToList();
                } else
                {
                    namesearch = resultstream.Where(job => job.Name.Contains(TxtName.Text)).ToList();
                }
            }

            if (TxtAddress.Text.Count() > 0)
            {
                filtersApplied++;
                if (CBExactMatch.Checked)
                {
                    addressSerch = resultstream.Where(job => job.Address.Replace(";", ", ").Equals(TxtName.Text)).ToList();
                }
                else
                {
                    addressSerch = resultstream.Where(job => job.Address.Replace(";", ", ").Contains(TxtName.Text)).ToList();
                }
            }

            if (CBDateRange.Checked)
            {
                filtersApplied++;
                DateTime beginDate = DateTimeFrom.Value.Date;
                DateTime endDate = DateTimeTo.Value.Date;

                dateSearch = resultstream.Where(job => DateTime.Parse(job.DateCreated) <= endDate && DateTime.Parse(job.DateCreated) >= beginDate).ToList();
            }

            if (CBDateDue.Checked)
            {
                filtersApplied++;
                DateTime limit = DateTimeDue.Value.Date;

                dueDateSerch = resultstream.Where(job => job.DueDate <= limit && (job.Status != "COMPLETE" || job.Status != "CANCELLED")).ToList();
            }

            if (TxtCustomer.Text.Count() > 2)
            {
                filtersApplied++;
                if (TxtCustomer.Text[0] == '@')
                {
                    customerSerch = resultstream.Where(
                        job => job.Contacts.Any(
                            c => c.Name.Contains(TxtCustomer.Text.TrimStart())
                        )
                    ).ToList();
                }
                else
                {
                    customerSerch = resultstream.Where(
                        job => job.Contacts.Any(
                            c => c.Employees.Any(
                                m => m.Name.Contains(TxtCustomer.Text)
                            )
                        )
                    ).ToList();
                }
            }

            if (CBWorkers.SelectedItem != null)
            {
                filtersApplied++;
                employeeSerch = resultstream.Where(j => j.Employees.Any(m => m.Name == CBWorkers.GetItemText(CBWorkers.SelectedItem))).ToList();
            }

            if (CBStatusSelector.SelectedItem != null)
            {
                filtersApplied++;
                statusSearch = resultstream.Where(j => j.Status == CBStatusSelector.GetItemText(CBStatusSelector.SelectedItem)).ToList();
            }

            if (filtersApplied.Equals(0))
            {
                MessageBox.Show("You must select at least one filter to search", "ERROR");
                return;
            }

            IntVariables.MainForm.TxtSearchResults.Text = filtersApplied.ToString() + " applied";
            
            if (RBMatchAny.Checked)
            {
                Debug.WriteLine(namesearch.Count + "|" + addressSerch.Count + "|" + dateSearch.Count + "|" + dueDateSerch.Count + "|" + customerSerch.Count + "|" + employeeSerch.Count + "|" + statusSearch.Count);
                var combined = namesearch.Union(addressSerch).ToList();
                combined = combined.Union(dateSearch).ToList();
                combined = combined.Union(dueDateSerch).ToList();
                combined = combined.Union(customerSerch).ToList();
                combined = combined.Union(employeeSerch).ToList();
                combined = combined.Union(statusSearch).ToList();
                FilteredJobs = combined.ToList();
                Debug.WriteLine("Job count: " + FilteredJobs.Count);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();*/
        }
    }
}
