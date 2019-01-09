using JMSFunctions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JMS
{
    public partial class CustomerManager : Form
    {
        public CustomerManager()
        {
            InitializeComponent();
        }

        public List<Customer> Customers { get; set; }
        private bool UpdatingEntry { get; set; }
        private bool UpdatesPending { get; set; }
        private int ParentIndex { get; set; }
        private int ChildIndex { get; set; }

        private void CustomerManager_Load(object sender, EventArgs e)
        {
            foreach (Customer customer in Variables.Customers)
            {
                TreeNode node = TVCustomers.Nodes.Add(customer.Name);
                string details = String.Format("Name: {0}\n" +
                    "Address: {1}\n" +
                    "Phone: {2}", customer.Name, customer.Address.Replace(";", ", "), customer.Phone);
                node.ToolTipText = details;
                foreach (POC poc in customer.Employees)
                {
                    TreeNode subNode = TVCustomers.Nodes[node.Index].Nodes.Add(poc.Name);
                    string subdetails = String.Format("Name: {0}\n" +
                        "Address: {1}\n" +
                        "Phone: {2}\n" +
                        "Email: {3}", poc.Name, poc.Address.Replace(";", ", "), poc.PhoneNumber, poc.Email);
                    subNode.ToolTipText = subdetails;
                }
            }

            UpdatesPending = false;
            Customers = Variables.Customers;
            ChildIndex = -1;
            ParentIndex = -1;
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            if (UpdatesPending)
            {
                DialogResult result = MessageBox.Show("You have updates pending, do you want to save the changes?", "Save Changes", MessageBoxButtons.YesNo);
                if (result.Equals(DialogResult.Yes))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                } else
                {
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void TVCustomers_DoubleClick(object sender, EventArgs e)
        {
            //No node was selected
            if (TVCustomers.SelectedNode == null)
            {
                return;
            }
            //Customer Selected
            if (TVCustomers.SelectedNode.Parent == null)
            {
                ParentIndex = TVCustomers.SelectedNode.Index;
                ChildIndex = -1;
                PopulateEditor(Customers.First(c => c.Name == TVCustomers.SelectedNode.Text));
                return;
            }
            ParentIndex = TVCustomers.SelectedNode.Parent.Index;
            ChildIndex = TVCustomers.SelectedNode.Index;
            var customer = Customers.First(c => c.Name == TVCustomers.Nodes[ParentIndex].Text);
            var poc = customer.Employees.First(w => w.Name == TVCustomers.Nodes[ParentIndex].Nodes[ChildIndex].Text);
            PopulateEditor(poc);
        }

        private void PopulateEditor(Customer customer)
        {
            TxtName.Text = string.Empty;
            TxtAddress1.Text = string.Empty;
            TxtAddress2.Text = string.Empty;
            TxtPhone.Text = string.Empty;
            TxtEmail.Text = string.Empty;

            TxtName.Text = customer.Name;
            if (customer.Address.Split(';').Count() > 0)
            {
                if (customer.Address.Split(';').Count() > 1)
                {
                    TxtAddress1.Text = customer.Address.Split(';')[0];
                    TxtAddress2.Text = customer.Address.Split(';')[1];
                } else
                {
                    TxtAddress1.Text = customer.Address.Split(';')[0];
                }
            }
            TxtPhone.Text = customer.Phone;
            TxtEmail.Enabled = false;
            CmdCreateCompany.Text = "Disgard";
            CmdCreatePOI.Text = "Apply";
            UpdatingEntry = true;
            CmdSave.Enabled = false;
            CmdCancel.Enabled = false;
        }

        private void PopulateEditor(POC poc)
        {
            TxtName.Text = string.Empty;
            TxtAddress1.Text = string.Empty;
            TxtAddress2.Text = string.Empty;
            TxtPhone.Text = string.Empty;
            TxtEmail.Text = string.Empty;

            TxtName.Text = poc.Name;
            if (poc.Address.Split(';').Count() > 0)
            {
                if (poc.Address.Split(';').Count() > 1)
                {
                    TxtAddress1.Text = poc.Address.Split(';')[0];
                    TxtAddress2.Text = poc.Address.Split(';')[1];
                }
                else
                {
                    TxtAddress1.Text = poc.Address.Split(';')[0];
                }
            }
            TxtPhone.Text = poc.PhoneNumber;
            TxtEmail.Text = poc.Email;
            CmdCreateCompany.Text = "Disgard";
            CmdCreatePOI.Text = "Apply";
            UpdatingEntry = true;
            CmdSave.Enabled = false;
            CmdCancel.Enabled = false;
        }

        private void CmdCreatePOI_Click(object sender, EventArgs e)
        {
            if (UpdatingEntry)
            {
                if (ChildIndex == -1)
                {
                    Customer newInfo = Customers.First(c => c.Name == TVCustomers.Nodes[ParentIndex].Text);
                    newInfo.Name = TxtName.Text;
                    newInfo.Phone = TxtPhone.Text;
                    newInfo.Address = TxtAddress1.Text + ";" + TxtAddress2.Text;
                    Customers[ParentIndex] = newInfo;
                } else
                {
                    Customer newInfo = Customers.First(c => c.Name == TVCustomers.Nodes[ParentIndex].Text);
                    POC poc = newInfo.Employees.First(m => m.Name == TVCustomers.Nodes[ParentIndex].Nodes[ChildIndex].Text);
                    poc.Name = TxtName.Text;
                    poc.PhoneNumber = TxtPhone.Text;
                    poc.Email = TxtEmail.Text;
                    poc.Address = TxtAddress1.Text + ";" + TxtAddress2.Text;
                    Customers[ParentIndex] = newInfo;
                }

                TVCustomers.Nodes.Clear();
                foreach (Customer customer in Customers)
                {
                    TreeNode node = TVCustomers.Nodes.Add(customer.Name);
                    string details = String.Format("Name: {0}\n" +
                        "Address: {1}\n" +
                        "Phone: {2}", customer.Name, customer.Address.Replace(";", ", "), customer.Phone);
                    node.ToolTipText = details;
                    foreach (POC poc in customer.Employees)
                    {
                        TreeNode subNode = TVCustomers.Nodes[node.Index].Nodes.Add(poc.Name);
                        string subdetails = String.Format("Name: {0}\n" +
                            "Address: {1}\n" +
                            "Phone: {2}\n" +
                            "Email: {3}", poc.Name, poc.Address.Replace(";", ", "), poc.PhoneNumber, poc.Email);
                        subNode.ToolTipText = subdetails;
                    }
                }

                CmdCreateCompany.Text = "Create as Company";
                CmdCreatePOI.Text = "Create as POI";
                CmdSave.Enabled = true;
                CmdCancel.Enabled = true;
                TxtEmail.Enabled = true;
                UpdatingEntry = false;
                ChildIndex = -1;
                ParentIndex = -1;
                TxtName.Text = string.Empty;
                TxtAddress1.Text = string.Empty;
                TxtAddress2.Text = string.Empty;
                TxtPhone.Text = string.Empty;
                TxtEmail.Text = string.Empty;
                UpdatesPending = true;
                return;
            }

            if (TVCustomers.SelectedNode == null)
            {
                MessageBox.Show("Please select a company to add the Point of Contact", "Error");
                return;
            }

            int Index;
            if (TVCustomers.SelectedNode.Parent == null)
            {
                Index = TVCustomers.SelectedNode.Index;
            } else
            {
                Index = TVCustomers.SelectedNode.Parent.Index;
            }

            Customer customerParent = Customers[Index];
            string name = TxtName.Text;
            string address = TxtAddress1.Text + ";" + TxtAddress2.Text;
            string phone = TxtPhone.Text;
            string email = TxtEmail.Text;
            if (name.Equals(string.Empty))
            {
                MessageBox.Show("You must give the person a name.", "Error");
                TxtName.Focus();
                return;
            }
            if (address.Equals(";"))
            {
                address = customerParent.Address;
            }
            if (phone.Equals(string.Empty))
            {
                MessageBox.Show("You must give the company a number.", "Error");
                TxtPhone.Focus();
                return;
            }
            if (email.Equals(string.Empty))
            {
                MessageBox.Show("You must give the company a number.", "Error");
                TxtPhone.Focus();
                return;
            }

            if (customerParent.Employees.Where(n => n.Name == name).Count() > 0)
            {
                MessageBox.Show("You cannot add a person by the same name as another person under the company. Please enter a different name.", "Error");
                return;
            }

            POC pocItem = new POC() {
                Name = name,
                Address = address,
                PhoneNumber = phone,
                Email = email,
                Company = customerParent.Name
            };
            customerParent.Employees.Add(pocItem);
            Customers[Index] = customerParent;
            Customers = Customers.OrderBy(o => o.Name).ToList();
            TVCustomers.Nodes.Clear();
            foreach (Customer customerItem in Customers)
            {
                TreeNode node = TVCustomers.Nodes.Add(customerItem.Name);
                string details = String.Format("Name: {0}\n" +
                    "Address: {1}\n" +
                    "Phone: {2}", customerItem.Name, customerItem.Address.Replace(";", ", "), customerItem.Phone);
                node.ToolTipText = details;
                foreach (POC poc in customerItem.Employees)
                {
                    TreeNode subNode = TVCustomers.Nodes[node.Index].Nodes.Add(poc.Name);
                    string subdetails = String.Format("Name: {0}\n" +
                        "Address: {1}\n" +
                        "Phone: {2}\n" +
                        "Email: {3}", poc.Name, poc.Address.Replace(";", ", "), poc.PhoneNumber, poc.Email);
                    subNode.ToolTipText = subdetails;
                }
            }
            TxtEmail.Enabled = true;
            TxtName.Text = string.Empty;
            TxtAddress1.Text = string.Empty;
            TxtAddress2.Text = string.Empty;
            TxtPhone.Text = string.Empty;
            TxtEmail.Text = string.Empty;
            UpdatesPending = true;
        }

        private void CmdCreateCompany_Click(object sender, EventArgs e)
        {
            if (UpdatingEntry)
            {
                CmdCreateCompany.Text = "Create as Company";
                CmdCreatePOI.Text = "Create as POI";
                UpdatingEntry = false;
                ChildIndex = -1;
                ParentIndex = -1;
                TxtName.Text = string.Empty;
                TxtAddress1.Text = string.Empty;
                TxtAddress2.Text = string.Empty;
                TxtPhone.Text = string.Empty;
                TxtEmail.Text = string.Empty;
                CmdSave.Enabled = true;
                CmdCancel.Enabled = true;
                TxtEmail.Enabled = true;
                return;
            }

            string name = TxtName.Text;
            string address = TxtAddress1.Text + ";" + TxtAddress2.Text;
            string phone = TxtPhone.Text;
            if (name.Equals(string.Empty))
            {
                MessageBox.Show("You must give the company a name.", "Error");
                TxtName.Focus();
                return;
            }
            if (address.Equals(";"))
            {
                MessageBox.Show("You must give the company an address.", "Error");
                TxtAddress1.Focus();
                return;
            }
            if (phone.Equals(string.Empty))
            {
                MessageBox.Show("You must give the company a number.", "Error");
                TxtPhone.Focus();
                return;
            }
            Customer customer = new Customer()
            {
                Name = name,
                Address = address,
                Phone = phone,
                Employees = new List<POC> { }
            };
            Customers.Add(customer);
            Customers = Customers.OrderBy(o => o.Name).ToList();
            TVCustomers.Nodes.Clear();
            foreach (Customer customerItem in Customers)
            {
                TreeNode node = TVCustomers.Nodes.Add(customerItem.Name);
                string details = String.Format("Name: {0}\n" +
                    "Address: {1}\n" +
                    "Phone: {2}", customerItem.Name, customerItem.Address.Replace(";", ", "), customerItem.Phone);
                node.ToolTipText = details;
                foreach (POC poc in customerItem.Employees)
                {
                    TreeNode subNode = TVCustomers.Nodes[node.Index].Nodes.Add(poc.Name);
                    string subdetails = String.Format("Name: {0}\n" +
                        "Address: {1}\n" +
                        "Phone: {2}\n" +
                        "Email: {3}", poc.Name, poc.Address.Replace(";", ", "), poc.PhoneNumber, poc.Email);
                    subNode.ToolTipText = subdetails;
                }
            }
            TxtEmail.Enabled = true;
            TxtName.Text = string.Empty;
            TxtAddress1.Text = string.Empty;
            TxtAddress2.Text = string.Empty;
            TxtPhone.Text = string.Empty;
            TxtEmail.Text = string.Empty;
            UpdatesPending = true;
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            if (TVCustomers.SelectedNode == null)
            {
                return;
            }
            if (TVCustomers.SelectedNode.Parent != null)
            {
                Customers[TVCustomers.SelectedNode.Parent.Index].Employees.RemoveAt(TVCustomers.SelectedNode.Index);
                TVCustomers.Nodes.Clear();
                foreach (Customer customerItem in Customers)
                {
                    TreeNode node = TVCustomers.Nodes.Add(customerItem.Name);
                    string details = String.Format("Name: {0}\n" +
                        "Address: {1}\n" +
                        "Phone: {2}", customerItem.Name, customerItem.Address.Replace(";", ", "), customerItem.Phone);
                    node.ToolTipText = details;
                    foreach (POC poc in customerItem.Employees)
                    {
                        TreeNode subNode = TVCustomers.Nodes[node.Index].Nodes.Add(poc.Name);
                        string subdetails = String.Format("Name: {0}\n" +
                            "Address: {1}\n" +
                            "Phone: {2}\n" +
                            "Email: {3}", poc.Name, poc.Address.Replace(";", ", "), poc.PhoneNumber, poc.Email);
                        subNode.ToolTipText = subdetails;
                    }
                }
                return;
            }
            Customers.RemoveAt(TVCustomers.SelectedNode.Index);
            TVCustomers.Nodes.Clear();
            foreach (Customer customerItem in Customers)
            {
                TreeNode node = TVCustomers.Nodes.Add(customerItem.Name);
                string details = String.Format("Name: {0}\n" +
                    "Address: {1}\n" +
                    "Phone: {2}", customerItem.Name, customerItem.Address.Replace(";", ", "), customerItem.Phone);
                node.ToolTipText = details;
                foreach (POC poc in customerItem.Employees)
                {
                    TreeNode subNode = TVCustomers.Nodes[node.Index].Nodes.Add(poc.Name);
                    string subdetails = String.Format("Name: {0}\n" +
                        "Address: {1}\n" +
                        "Phone: {2}\n" +
                        "Email: {3}", poc.Name, poc.Address.Replace(";", ", "), poc.PhoneNumber, poc.Email);
                    subNode.ToolTipText = subdetails;
                }
            }
            return;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //No text in the text box
            string contents = TxtSearch.Text;
            if (contents.Count() == 0)
            {
                Customers = Variables.Customers;
                return;
            }
            //If the string only contains the company identifier, then ignore it.
            if (contents.Count() == 1)
            {
                if (contents[0] == '@')
                {
                    Customers = Variables.Customers;
                    return;
                }
            }
        }
    }
}
