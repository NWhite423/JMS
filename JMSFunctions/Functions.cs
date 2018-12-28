using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using JMSFunctions;
using System.Net.Mail;

namespace JMS
{
    public class Functions
    {
        //Updated 12-22-18
        public static string GrabDirectoryName(string directory)
        {
            return new DirectoryInfo(directory).Name;
        }

        //Updated 12-22-18
        public static string GrabCurrentTime(int request = -1)
        {
            string output;
            switch (request)
            {
                case 0:
                    {
                        output = DateTime.Now.ToString("MM/dd/yyyy");
                        break;
                    }
                case 1:
                    {
                        output = DateTime.Now.ToString("HH:mm:ss");
                        break;
                    }
                default:
                    {
                        output = DateTime.Now.ToString("MM/dd/yyyy;HH:mm:ss");
                        break;
                    }
            }
            return output;
        }

        //Updated 12-22-18
        public static void OpenGoogleMaps(string address)
        {
            string url = "http://maps.google.com/maps?";

            url += "q=" + Uri.EscapeUriString(address) + "&t=m";

            Process.Start(url);
        }

        //Updated 12-22-18
        public static List<string> GrabDirectories(string path, string file)
        {
            List<string> array = new List<string> { };

            foreach (string dir in Directory.GetDirectories(path))
            {
                if (File.Exists(dir + @"\" + file))
                {
                    array.Add(GrabDirectoryName(dir));
                }
            }
            return array;
        }

        //Updated 12-22-18
        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        //Updated 12-22-18
        public static string ConvertListToString(List<string> list)
        {
            string text = "";
            foreach (string str in list)
            {
                text += str + ", ";
            }
            text = text.Remove(text.Length - 2);
            return text;
        }

        //Updated 12-22-18
        public static List<string> GetCheckedItems(CheckedListBox box)
        {
            List<string> array = new List<string> { };
            for (int i = 0; i < box.Items.Count; i++)
            {
                if (box.GetItemChecked(i))
                {
                    array.Add(box.GetItemText(box.Items[i]));
                }
            }
            return array;
        }

        //Updated 12-22-18
        public static bool ReplaceJob(Job oldJob, Job newJob)
        {
            if (oldJob.Name != newJob.Name)
            {
                Directory.Move(oldJob.Path, newJob.Path);
            };

            XML.WriteXMLFile(newJob, newJob.Path + @"\jobdata.xml");
            string lineToRemove = oldJob.Name + ";" + oldJob.Path + @"\jobdata.xml;";
            List<string> file = File.ReadAllLines(Variables.CurrentDir + @"\index.txt").ToList();
            file.Remove(lineToRemove);
            file.Add(newJob.Name + ";" + newJob.Path + @"\jobdata.xml;");
            File.WriteAllLines(Variables.CurrentDir + @"\temp.txt", file);
            File.Delete(Variables.CurrentDir + @"\index.txt");
            File.Move(Variables.CurrentDir + @"\temp.txt", Variables.CurrentDir + @"\index.txt");
            XML.AddNoteToJob(newJob, "Changed a portion of the job information");

            UpdateJobList(newJob, oldJob);
            return true;
        }

        public static void PopulateJobList(List<Job> jobs)
        {
            //No jobs were loaded, would throw an error.
            Variables.JobList.Items.Clear();
            foreach (Job jobI in jobs)
            {
                Variables.JobList.Items.Add(jobI.Name);
                Debug.WriteLine("adding job to list: " + jobI.Name);
            }
        }

        //Updated 12-22-18
        public static void UpdateJobList(Job job, Job replace)
        {
            if (!replace.Equals(null))
            {
                string oldName = replace.Name;
                var jobInList = Variables.Jobs.Find(j => j.Name.Equals(oldName));
                Variables.Jobs[Variables.Jobs.IndexOf(jobInList)] = job;
            }
            if (!Variables.Jobs.Contains(job))
            {
                Variables.Jobs.Add(job);
            }
            PopulateJobList(Variables.Jobs);
        }


        public static void ProduceErrorReport(Exception ex)
        {
            ErrorReport report = new ErrorReport();
            report.ShowDialog();
            string userReport = report.Report;
            string message = String.Format("User: {0}\r\n" +
                "User Message: {1}\r\n" +
                "Exception Message: {4}\r\n" +
                "Stack Trace:\r\n" +
                "{2}\r\n" +
                "Location: {3}\r\n" +
                "",
               JMSFunctions.AppSettings.Default.UserName,
               userReport,
               ex.StackTrace,
               ex.Source,
               ex.Message);

            if (!Directory.Exists("Error Reports"))
            {
                Directory.CreateDirectory("Error Reports");
            }
            string file = @"Error Reports\error " + DateTime.Now.ToString("MM-dd-yyyy HH-mm-ss") + ".txt";
            File.WriteAllText(file, ex.ToString());
            SendErrorReport("Error Report", message, file);
        }

        public static void SendErrorReport(string subject, string contents, string errorReport)
        {
            var fromAddress = new MailAddress("jmserrorreporting@gmail.com", "JMS Error Reporting");
            var toAddress = new MailAddress("jmserrors@gmail.com", "JMS Errors");
            const string fromPassword = "P1ay$4Gam3";
            MailMessage mail = new MailMessage(fromAddress, toAddress);
            SmtpClient client = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            mail.Subject = subject + " " + DateTime.Now.ToString("MM-dd-yyyy HH-mm-ss");
            mail.Body = contents;
            mail.Attachments.Add(new Attachment(errorReport));
            try
            {
                client.Send(mail);
                mail.Dispose();
                client.Dispose();
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not send error report");
                throw;
            }
        }
    }
}
