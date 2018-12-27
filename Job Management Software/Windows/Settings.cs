using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JMS
{
    public partial class Settings : Form
    {
        string workDir;
        string userName;

        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            TxtWorkDir.Text = JMSFunctions.AppSettings.Default.WorkDir;
            workDir = JMSFunctions.AppSettings.Default.WorkDir;
            TxtUserName.Text = JMSFunctions.AppSettings.Default.UserName;
            userName = JMSFunctions.AppSettings.Default.UserName;
        }

        private void TxtWorkDir_TextChanged(object sender, EventArgs e)
        {
            if (TxtWorkDir.Text.Equals(workDir))
            {
                CmdSave.Enabled = false;
            } else
            {
                CmdSave.Enabled = true;
            }
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            JMSFunctions.AppSettings.Default.WorkDir = TxtWorkDir.Text;
            JMSFunctions.AppSettings.Default.UserName = TxtUserName.Text;
            workDir = TxtWorkDir.Text;
            userName = TxtUserName.Text;

            CmdSave.Enabled = false;
        }

        private void CmdWorkDirBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FB = new FolderBrowserDialog();
            if (Directory.Exists(TxtWorkDir.Text)) {
                FB.SelectedPath = TxtWorkDir.Text;
            } else
            {
                FB.SelectedPath = workDir;
            }
            FB.ShowDialog();
            TxtWorkDir.Text = FB.SelectedPath;
            if (TxtWorkDir.Text.Equals(workDir))
            {
                CmdSave.Enabled = false;
            }
            else
            {
                CmdSave.Enabled = true;
            }
            FB.Dispose();
        }

        private void TxtUserName_TextChanged(object sender, EventArgs e)
        {
            if (TxtUserName.Text.Equals(workDir))
            {
                CmdSave.Enabled = false;
            }
            else
            {
                CmdSave.Enabled = true;
            }
        }
    }
}
