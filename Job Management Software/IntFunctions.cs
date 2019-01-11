using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml.Linq;
using JMSFunctions;
using System.ComponentModel;
using System.Drawing;
using JMS.Variables;

namespace JMS
{
    internal class Functions
    {
        /// <summary>
        /// Initializes the variables needed for the program to function.
        /// </summary>
        public static void InitializeVariables()
        {
            Public.DevMode = AppSettings.Default.DevMode;
            Public.WorkDirectory = AppSettings.Default.WorkDirectory;
            Public.Indexes = new List<string> { };

            Debug.WriteLine(Public.WorkDirectory + " | " + AppSettings.Default.WorkDirectory);

            var paths = PublicFunctions.GrabDirectories(Public.WorkDirectory, "index.txt");
            List<List<Job>> allJobs = new List<List<Job>> { };
            foreach (string index in paths)
            {
                Debug.WriteLine("Index path: " + index);
                string yearFolder = PublicFunctions.GrabDirectoryName(index);
                if (!Public.Indexes.Contains(yearFolder))
                {
                    Debug.WriteLine("Adding " + yearFolder);
                    Public.Indexes.Add(yearFolder);
                }
                List<Job> jobYears = new List<Job> { };
                List<string> indexItems = File.ReadAllLines(index).ToList();
                indexItems.Sort();
                foreach (string iItem in indexItems)
                {
                    Debug.WriteLine("job path: " + iItem);
                    Job job = PublicFunctions.XML.CompileJob(iItem.Split(';')[1]);
                    jobYears.Add(job);
                    job.Dispose();
                }
                jobYears.OrderBy(n => n.Name).ToList();
                allJobs.Add(jobYears);
            }
            Public.AllJobs = allJobs;
        }
    }
}
