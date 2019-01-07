using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JMSFunctions;

namespace JMS
{
    public static class Variables
    {
        public static bool JobTransition;

        public static string UserName;
        public static bool DevMode;
        
        public static string WorkDir;
        public static string CurrentDir;

        public static List<Employee> Employees;
        public static List<Customer> Customers;

        public static List<List<Job>> AllJobs;
        public static List<string> AllIndexes;
        
        public static List<string[]> dataset;

        public static List<Job> Jobs;
        public static List<POC> POCs;

        public static Job Job;
        public static ListBox JobList;
    }
}
