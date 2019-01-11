using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JMS;
using JMS.Variables;
using JMSFunctions;

namespace JMSFunctions
{
    public partial class CustomerLookup : Form
    {
        internal List<Customer> customerList = Public.Customers;

        public Customer Value { get; internal set; }

        public CustomerLookup()
        {
            InitializeComponent();
        }

        private void CustomerLookup_Load(object sender, EventArgs e)
        {
            Value = new Customer();
            TVCustomers.BeginUpdate();
            foreach (Customer customer in customerList)
            {
                var node = TVCustomers.Nodes.Add(customer.Name);
                TVCustomers.SelectedNode = node;
                foreach (POC poc in customer.Employees)
                {
                    TVCustomers.SelectedNode.Nodes.Add(poc.Name);
                }
            }
            TVCustomers.SelectedNode = null;
            TVCustomers.EndUpdate();
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void CmdSelect_Click(object sender, EventArgs e)
        {
            int customerIndex = TVCustomers.SelectedNode.Parent.Index;
            int contactIndex = TVCustomers.SelectedNode.Index;

            Customer customer = customerList[customerIndex];
            POC poc = customer.Employees[contactIndex];

            Value.Name = customer.Name;
            Value.Address = customer.Address;
            Value.Phone = customer.Phone;
            Value.Employees = new List<POC>() { poc };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void TVCustomers_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (TVCustomers.SelectedNode.Parent == null)
            {
                CmdSelect.Enabled = false;
            } else
            {
                CmdSelect.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerManager cm = new CustomerManager();
            DialogResult result = cm.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                PublicFunctions.XML.SaveCustomers(cm.Customers, Public.WorkDirectory + @"\JMS\customers.xml");
                Public.Customers = PublicFunctions.XML.CompileCustomers(Public.WorkDirectory + @"\JMS\customers.xml").OrderBy(o => o.Name).ToList();
                customerList = cm.Customers;
                TVCustomers.BeginUpdate();
                TVCustomers.Nodes.Clear();
                foreach (Customer customer in cm.Customers)
                {
                    var node = TVCustomers.Nodes.Add(customer.Name);
                    TVCustomers.SelectedNode = node;
                    foreach (POC poc in customer.Employees)
                    {
                        TVCustomers.SelectedNode.Nodes.Add(poc.Name);
                    }
                }
                TVCustomers.SelectedNode = null;
                TVCustomers.EndUpdate();
            }
        }
    }
}
