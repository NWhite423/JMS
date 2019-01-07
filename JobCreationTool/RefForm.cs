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

namespace JobCreationTool
{
    public partial class RefForm : Form
    {
        public RefForm()
        {
            InitializeComponent();
        }
        

        public Customer Value { get; internal set; }

        private void RefForm_Load(object sender, EventArgs e)
        {
            Variables.RefForm = this;
            Value = new Customer();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void CmdSearch_Click(object sender, EventArgs e)
        {
            CustomerLookup lookup = new CustomerLookup();

            if (lookup.ShowDialog().Equals(DialogResult.OK))
            {
                Value = lookup.Value;
                TxtCompany.Text = Value.Name;
                TxtName.Text = Value.Employees[0].Name;
                TxtAddressLine1.Text = Value.Address.Split(';')[0];
                TxtAddressLine2.Text = Value.Address.Split(';')[1];
                TxtPhone.Text = Value.Employees[0].PhoneNumber;
                TxtEmail.Text = Value.Employees[0].Email;
            }
        }
    }
}
