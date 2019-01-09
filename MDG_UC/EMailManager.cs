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

        public EMailManager()
        {
            InitializeComponent();
            OL = new Microsoft.Office.Interop.Outlook.Application();
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
                    string subject = mailitem.Subject.Replace(":", "");
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
            if (DataGridEmails.Rows.Count > 0)
            {
                DataGridEmails.Rows.Clear();
            }
            string path = @"P:\test\";
            List<string> items = Directory.GetFiles(path).ToList();
            foreach (string msg in items)
            {
                OutlookStorage.Message outlookMsg = new OutlookStorage.Message(msg);
                DataGridEmails.Rows.Add(outlookMsg.Subject, outlookMsg.From, File.GetCreationTime(msg).Date, msg);
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
    }
}
