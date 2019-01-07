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
    public partial class StringEntry : Form
    {
        public string TextEntry { get; set; }

        public StringEntry()
        {
            InitializeComponent();
        }

        public static string ShowDialog(string description)
        {
            StringEntry entry = new StringEntry();
            entry.LblDescription.Text = description;
            entry.TopMost = true;
            entry.TxtEntry.Focus();
            if (entry.ShowDialog().Equals(DialogResult.OK))
            {
                return entry.TextEntry;
            }
            return null;
        }

        public static string ShowDialog(string description, string title)
        {
            StringEntry entry = new StringEntry();
            entry.LblDescription.Text = description;
            entry.Text = title;
            entry.TopMost = true;
            entry.TxtEntry.Focus();
            if (entry.ShowDialog().Equals(DialogResult.OK))
            {
                return entry.TextEntry;
            }
            return null;
        }

        private void CmdOK_Click(object sender, EventArgs e)
        {
            TextEntry = TxtEntry.Text;
            this.Close();
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StringEntry_Load(object sender, EventArgs e)
        {

        }
    }
}
