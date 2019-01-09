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
using System.IO;

namespace MDG_UC
{
    public partial class EMailManager : UserControl
    {
        private Microsoft.Office.Interop.Outlook.Application OL;
        private DataTable table;

        public EMailManager()
        {
            InitializeComponent();
            OL = new Microsoft.Office.Interop.Outlook.Application();
            table = new DataTable();
            table.Columns.Add("Subject", typeof(string));
            table.Columns.Add("Sender", typeof(string));
            table.Columns.Add("Date", typeof(DateTime));
            table.Columns.Add("Path", typeof(string));
            DataGridEmails.DataSource = table;
            DataGridEmails.Columns[3].Visible = false;
        }

        private void Panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void Panel1_DragDrop(object sender, DragEventArgs e)
        {
            for (int i = 1; i <= OL.ActiveExplorer().Selection.Count; i++)
            {
                Object temp = OL.ActiveExplorer().Selection[i];

                if (temp is Microsoft.Office.Interop.Outlook.MailItem)
                {
                    Microsoft.Office.Interop.Outlook.MailItem mailitem = (temp as Microsoft.Office.Interop.Outlook.MailItem);
                    string subject;
                    if (mailitem.Subject == null)
                    {
                        subject = "email " + DateTime.Now.ToString("MM-dd-yyyy HH-mm-ss");
                    } else
                    {
                        subject = mailitem.Subject.Replace(":", "");
                    }
                    mailitem.SaveAs(@"P:\test\" + subject + ".msg", Microsoft.Office.Interop.Outlook.OlSaveAsType.olMSG);
                    UpdateEmailList();
                }
            }
        }

        private void EMailManager_Load(object sender, EventArgs e)
        {
            UpdateEmailList();
        }

        private void UpdateEmailList()
        {
            string path = @"P:\test\";
            List<string> items = Directory.GetFiles(path).ToList();
            foreach (string msg in items)
            {
                OutlookStorage.Message outlookMsg = new OutlookStorage.Message(msg);
                string subject;
                if (outlookMsg.Subject == null)
                {
                    subject = "(no subject)";
                } else
                {
                    subject = outlookMsg.Subject;
                }
                table.Rows.Add(new object[] { subject, outlookMsg.From, File.GetCreationTime(msg).ToShortDateString(), msg });
                outlookMsg.Dispose();
            }
            DataGridEmails.ClearSelection();
        }

        private void DataGridEmails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = DataGridEmails.SelectedRows[0].Index;
            string emailPath = DataGridEmails[3, row].Value.ToString();
            Process.Start(emailPath);
        }

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                InitialDirectory = @"P:\",
                Filter = "E-Mail Message|*.msg",
                Multiselect = false
            };
            DialogResult result = dialog.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                string file = dialog.FileName;
                Debug.WriteLine(file);
            }
        }

        private void CmdRemove_Click(object sender, EventArgs e)
        {
            if (DataGridEmails.SelectedCells == null)
            {
                return;
            }
            int row = DataGridEmails.SelectedRows[0].Index;
            File.Delete(DataGridEmails[3, DataGridEmails.SelectedRows[0].Index].Value.ToString());
            table.Rows.RemoveAt(row);
        }

        private void DataGridEmails_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridEmails.SelectedRows == null)
            {
                CmdRemove.Visible = false;
                DataGridEmails.ClearSelection();
                return;
            }
            CmdRemove.Visible = true;
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (TxtSearch.Text == "" || TxtSearch.Text == "@" || TxtSearch.Text == "#")
            {
                table.DefaultView.RowFilter = "";
                return;
            }
            if (TxtSearch.Text[0] == '@')
            {
                Debug.WriteLine(TxtSearch.Text.TrimStart('@'));
                table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "Subject", TxtSearch.Text.TrimStart('@'));
            } else
            {
                if (TxtSearch.Text[0] == '#')
                {
                    Debug.WriteLine(TxtSearch.Text.TrimStart('#'));
                    table.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') LIKE '%{1}%'", "Date", TxtSearch.Text.TrimStart('#'));
                }
                else
                {

                    table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "Sender", TxtSearch.Text);
                }
            }
        }

        private void TxtSearch_Enter(object sender, EventArgs e)
        {
            TxtSearch.SelectAll();
        }

        private void TxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)13))
            {
                DataGridEmails.Focus();
                DataGridEmails.Select();
            }
        }
    }
}
