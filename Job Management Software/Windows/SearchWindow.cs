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

namespace JMS
{
    public partial class SearchWindow : Form
    {
        public SearchWindow()
        {
            InitializeComponent();
        }

        public List<Job> FilteredJobs { get; set; }

        private void SearchWindow_Load(object sender, EventArgs e)
        {
            DateTimeFrom.Value = DateTime.Now;
            DateTimeTo.Value = DateTime.Now;
            DateTimeDue.Value = DateTime.Now;
            foreach (Employee employee in Variables.Employees)
            {
                CBWorkers.Items.Add(employee.Name);
            }
        }

        private void CmdExecute_Click(object sender, EventArgs e)
        {
            int directory = IntVariables.MainForm.CmbDirectories.SelectedIndex;
            List<Job> jobs = Variables.AllJobs[directory];

            int filtersApplied = 0;
            List<Job> consideredJobs = new List<Job> { };
            IEnumerable<Job> resultstream = jobs;

            

            List<Job> namesearch = new List<Job> { };
            List<Job> addressSerch = new List<Job> { };
            List<Job> dateSearch = new List<Job> { };
            List<Job> dueDateSerch = new List<Job> { };
            List<Job> customerSerch = new List<Job> { };
            List<Job> employeeSerch = new List<Job> { };

            if (CBName.Checked)
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

            if (CBAddress.Checked)
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

            /*if (CBCustomer.Checked)
            {
                filtersApplied++;
                if (CBExactMatch.Checked)
                {
                    customerSerch = resultstream.Where(job => job.Name.Equals(TxtName.Text)).ToList();
                }
                else
                {
                    customerSerch = resultstream.Where(job => job.Name.Contains(TxtName.Text)).ToList();
                }
            }*/

            if (CBWorkedOn.Checked)
            {
                filtersApplied++;
                string name = CBWorkers.GetItemText(CBWorkers.SelectedItem);

                employeeSerch = resultstream.Where(job => job.Employees.Any(person => person.Name == name)).ToList();
            }

            if (filtersApplied.Equals(0))
            {
                MessageBox.Show("You must select at least one filter to search", "ERROR");
                return;
            }

            IntVariables.MainForm.TxtSearchResults.Text = filtersApplied.ToString() + " applied";

            if (Variables.Jobs.Count > 0)
            {
                Variables.Jobs.Clear();
            }

            if (RBMatchAny.Checked)
            {
                Debug.WriteLine(namesearch.Count + "|" + addressSerch.Count + "|" + dateSearch.Count + "|" + dueDateSerch.Count + "|" + customerSerch.Count + "|" + employeeSerch.Count);
                var combined = namesearch.Union(addressSerch);
                combined = combined.Union(dateSearch);
                combined = combined.Union(dueDateSerch);
                combined = combined.Union(customerSerch);
                combined = combined.Union(employeeSerch);
                FilteredJobs = combined.ToList();
                Debug.WriteLine("Job count: " + FilteredJobs.Count);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
