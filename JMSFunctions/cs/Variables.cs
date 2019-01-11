using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JMSFunctions;

namespace JMS.Variables
{
    public static class Public
    {
        /// <summary>
        /// Determines if program is in Development mode.
        /// </summary>
        public static bool DevMode;

        /// <summary>
        /// The default work directory where the program grabs all their shared files.
        /// </summary>
        public static string WorkDirectory;

        /// <summary>
        /// The list of all YearJobs
        /// </summary>
        public static List<List<Job>> AllJobs;

        /// <summary>
        /// The list of all jobs in the selected year
        /// </summary>
        public static List<Job> YearJobs;

        /// <summary>
        /// The list of all the customers.
        /// </summary>
        public static List<Customer> Customers;

        /// <summary>
        /// The list of all employees.
        /// </summary>
        public static List<Employee> Employees;

        /// <summary>
        /// The login information of the current user (minus password)
        /// </summary>
        public static LoginInformation LoginInformation;

        /// <summary>
        /// The list of all years in string format
        /// </summary>
        public static List<string> Indexes;
    }
}
