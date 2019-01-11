using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Net;
using JMSFunctions;
using JMS.Variables;
using System.Net.Mail;
using System.Xml.Linq;
using System.Linq;

namespace JMS
{
    public class PublicFunctions
    {
        /// <summary>
        /// Grabs the directory name of the folder provided
        /// </summary>
        /// <param name="directory">The full path to a specific folder</param>
        /// <returns>The name of the directory</returns>
        public static string GrabDirectoryName(string directory)
        {
            string name;
            if (File.Exists(directory))
            {
                FileInfo info = new FileInfo(directory);
                name = info.Directory.Name;
            } else
            {
                name = new DirectoryInfo(directory).Name;
            }
            return name;
        }

        /// <summary>
        /// Returns the current time and date as a string array formatted [date, time]
        /// </summary>
        /// <returns>["DATE", "TIME"]</returns>
        public static string[] GrabCurrentTime()
        {
            string[] output = DateTime.Now.ToString("MM/dd/yyyy;HH:mm:ss").Split(';');
            return output;
        }

        /// <summary>
        /// Opens the web browser to Google Maps to the string given.
        /// </summary>
        /// <param name="address">The string to go to.</param>
        public static void OpenGoogleMaps(string address)
        {
            string url = "http://maps.google.com/maps?";

            url += "q=" + Uri.EscapeUriString(address) + "&t=m";

            Process.Start(url);
        }

        /// <summary>
        /// Grabs a list of all the directories with the file inside it.
        /// </summary>
        /// <param name="path">The path to search.</param>
        /// <param name="file">The filename to search for.</param>
        /// <returns>A list of full paths where the file was found</returns>
        public static List<string> GrabDirectories(string path, string file)
        {
            List<string> array = new List<string> { };

            Debug.WriteLine(path + " / " + file);

            foreach (string dir in Directory.GetDirectories(path))
            {
                Debug.WriteLine("Searching for " + Path.Combine(dir, file));
                if (File.Exists(Path.Combine(dir, file)))
                {
                    array.Add(dir + @"\" + file);
                    Debug.WriteLine(dir + @"\" + file + " found");
                }
            }
            return array;
        }
        
        /// <summary>
        /// Converts a list of strings to a single string seperated by commas and spaces
        /// </summary>
        /// <param name="list">The list of strings to convert.</param>
        /// <returns>A single string ("obj a, obj b, obj n")</returns>
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

        /// <summary>
        /// Returns a list of string containing the texts of a CheckedBoxList
        /// </summary>
        /// <param name="box">The CheckedBoxList to grab strings from.</param>
        /// <returns>A list of string of the checked items</returns>
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
        
        /// <summary>
        /// Prepares the crash form due to error.
        /// </summary>
        /// <param name="ex">Thrown exception</param>
        public static void ProduceErrorReport(Exception ex)
        {
            ErrorReport report = new ErrorReport();
            DialogResult result = report.ShowDialog();
            if (result.Equals(DialogResult.Cancel))
            {
                return;
            }
            string userReport = report.Report;
            string message = String.Format("User: {0}\r\n" +
                "User Message: {1}\r\n" +
                "Exception Message: {4}\r\n" +
                "Stack Trace:\r\n" +
                "{2}\r\n" +
                "Location: {3}\r\n" +
                "",
               Public.LoginInformation.DisplayName,
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

        /// <summary>
        /// Sends the error report to the specified e-mail
        /// </summary>
        /// <param name="subject">The subject string</param>
        /// <param name="contents">The body of the e-mail</param>
        /// <param name="errorReport">Path to error report</param>
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
            catch (Exception)
            {
                #if DEBUG
                    throw;
                #else
                    MessageBox.Show("Could not send error report");
                #endif
            }
        }

        public class XML
        {
            public static void WriteXMLFile(Job job, string FilePath)
            {
                //Simple elements
                XElement element = new XElement("JobInfo",
                    new XElement("Name", job.Name),
                    new XElement("Address", job.Address),
                    new XElement("FilePath", job.Path),
                    new XElement("Status", job.Status),
                    new XElement("Price", job.Price),
                    new XElement("DateCreated", job.DateCreated),
                    new XElement("DateEdited", job.DateEdited),
                    new XElement("TimeCreated", job.TimeCreated),
                    new XElement("TimeEdited", job.TimeEdited),
                    new XElement("CreatedBy", job.CreatedBy),
                    new XElement("EditedBy", Environment.UserName),
                    new XElement("DueDate", job.DueDate.ToShortDateString())
                );

                //All contacts
                XElement customers = new XElement("Customers");
                foreach (Customer customer in job.Contacts)
                {
                    XElement XCustomer = new XElement("Customer",
                        new XElement("Name", customer.Name),
                        new XElement("Address", customer.Address),
                        new XElement("Phone", customer.Phone));

                    var XContacts = new XElement("Contacts");
                    foreach (POC poc in customer.Employees)
                    {
                        XElement XContact = new XElement("Contact",
                            new XElement("Name", poc.Name),
                            new XElement("Phone", poc.PhoneNumber),
                            new XElement("Email", poc.Email));
                        XContacts.Add(XContact);
                    }
                    XCustomer.Add(XContacts);
                    customers.Add(XCustomer);
                }
                element.Add(customers);

                //All notes
                XElement notes = new XElement("Notes");
                foreach (Note entry in job.Notes)
                {
                    XElement note = new XElement("Note",
                        new XElement("Timestamp", entry.Timestamp),
                        new XElement("Author", entry.Author),
                        new XElement("Value", entry.Value));
                    notes.Add(note);
                }
                element.Add(notes);

                //All employees
                XElement employees = new XElement("Employees");
                foreach (Employee employee in job.Employees)
                {
                    XElement note = new XElement("Employee",
                        new XElement("Name", employee.Name),
                        new XElement("Role", employee.Role),
                        new XElement("Email", employee.Email),
                        new XElement("Phone", employee.Phone));
                    employees.Add(note);
                }
                element.Add(employees);

                XElement tasks = new XElement("Tasks");
                foreach (string task in job.Tasks)
                {
                    XElement contact = new XElement("Task", task);
                    tasks.Add(contact);
                }
                element.Add(tasks);
                element.Save(FilePath);
            }

            /// <summary>
            /// Compiles the JobData.xml file for the specified job.
            /// </summary>
            /// <param name="jobFile">Path to jobdata.xml</param>
            /// <returns>Job object</returns>
            public static Job CompileJob(string jobFile)
            {
                Job job = new Job();

                XElement doc = XElement.Load(jobFile);

                job.Name = doc.Element("Name").Value;
                job.Address = doc.Element("Address").Value;
                job.Path = doc.Element("FilePath").Value;
                job.DateCreated = doc.Element("DateCreated").Value;
                job.DateEdited = doc.Element("DateEdited").Value;
                job.TimeCreated = doc.Element("TimeCreated").Value;
                job.TimeEdited = doc.Element("TimeEdited").Value;
                job.CreatedBy = doc.Element("CreatedBy").Value;
                job.EditedBy = doc.Element("EditedBy").Value;
                job.Price = doc.Element("Price").Value;
                job.Status = doc.Element("Status").Value;
                job.DueDate = DateTime.Parse(doc.Element("DueDate").Value);

                List<Customer> customers = new List<Customer> { };
                List<Note> entries = new List<Note> { };
                List<string> tasks = new List<string> { };
                List<Employee> employees = new List<Employee> { };

                foreach (XElement XCustomer in doc.Descendants("Customers").Elements())
                {
                    Debug.WriteLine(XCustomer.Element("Name").Value);
                    Customer customer = new Customer()
                    {
                        Name = XCustomer.Element("Name").Value,
                        Address = XCustomer.Element("Address").Value,
                        Phone = XCustomer.Element("Phone").Value,
                        Employees = new List<POC> { }
                    };
                    foreach (XElement XContact in XCustomer.Descendants("Contacts").Elements())
                    {
                        Debug.WriteLine(XContact.Element("Name").Value);
                        POC contact = new POC()
                        {
                            Name = XContact.Element("Name").Value,
                            PhoneNumber = XContact.Element("Phone").Value,
                            Email = XContact.Element("Email").Value,
                            Company = customer.Name,
                            Address = customer.Address
                        };
                        customer.Employees.Add(contact);
                    };
                    customers.Add(customer);
                }

                foreach (XElement element in doc.Descendants("Notes").Elements())
                {
                    Note entry = new Note()
                    {
                        Timestamp = element.Element("Timestamp").Value,
                        Author = element.Element("Author").Value,
                        Value = element.Element("Value").Value
                    };
                    entries.Add(entry);
                }

                foreach (XElement employee in doc.Descendants("Employees").Elements())
                {
                    Employee employeeItem = new Employee()
                    {
                        Name = employee.Element("Name").Value,
                        Role = employee.Element("Role").Value,
                        Email = employee.Element("Email").Value,
                        Phone = employee.Element("Phone").Value
                    };
                    employees.Add(employeeItem);
                }

                foreach (XElement element in doc.Descendants("Tasks").Elements())
                {
                    tasks.Add(element.Value);
                }

                job.Contacts = customers;
                job.Contacts.OrderBy(o => o.Name);
                job.Notes = entries;
                job.Tasks = tasks;
                job.Employees = employees;
                job.Employees.OrderBy(o => o.Name);
                return job;
            }

            /// <summary>
            /// Adds a note to the job
            /// </summary>
            /// <param name="job">Job object</param>
            /// <param name="note">Note to be added.</param>
            /// <returns>true if successful</returns>
            public static bool AddNoteToJob(Job job, string note)
            {
                var editTime = GrabCurrentTime();
                job.DateEdited = editTime[0];
                job.TimeEdited = editTime[1];
                job.EditedBy = Public.LoginInformation.DisplayName;

                Note noteItem = new Note()
                {
                    Timestamp = job.DateEdited + " " + job.TimeEdited,
                    Author = job.EditedBy,
                    Value = note
                };
                job.Notes.Add(noteItem);
                WriteXMLFile(job, job.Path + @"\jobdata.xml");
                return true;
            }

            /// <summary>
            /// Adds a note to the job
            /// </summary>
            /// <param name="job">Job object</param>
            /// <param name="note">Note to be added.</param>
            /// <param name="author">Name as person editing</param>
            /// <returns>true if successful</returns>
            public static bool AddNoteToJob(Job job, string note, string author)
            {
                var editTime = GrabCurrentTime();
                job.DateEdited = editTime[0];
                job.TimeEdited = editTime[1];
                job.EditedBy = author;

                Note noteItem = new Note()
                {
                    Timestamp = job.DateEdited + " " + job.TimeEdited,
                    Author = job.EditedBy,
                    Value = note
                };
                job.Notes.Add(noteItem);
                WriteXMLFile(job, job.Path + @"\jobdata.xml");
                return true;
            }

            /// <summary>
            /// Compiles employees
            /// </summary>
            /// <param name="source">File path to source</param>
            /// <returns>List of employees</returns>
            public static List<Employee> CompileEmployees(string source)
            {
                List<Employee> employees = new List<Employee> { };

                XDocument doc = XDocument.Load(source);
                var elements = doc.Descendants("Employees").Elements();

                foreach (XElement element in elements)
                {
                    Employee employee = new Employee()
                    {
                        Name = element.Element("Name").Value,
                        Role = element.Element("Role").Value,
                        Email = element.Element("Email").Value,
                        Phone = element.Element("Phone").Value,
                        Status = element.Element("Status").Value
                    };
                    employees.Add(employee);
                }

                return employees;
            }

            /// <summary>
            /// Compiles customers
            /// </summary>
            /// <param name="source">File path to source.</param>
            /// <returns>List of customers.</returns>
            public static List<Customer> CompileCustomers(string source)
            {
                List<Customer> customers = new List<Customer> { };

                XDocument doc = XDocument.Load(source);
                var elements = doc.Descendants("Customers").Elements();

                foreach (XElement element in elements)
                {
                    Customer customer = new Customer()
                    {
                        Name = element.Element("Name").Value,
                        Address = element.Element("Address").Value,
                        Phone = element.Element("Phone").Value,
                        Employees = new List<POC> { }
                    };

                    var employees = element.Descendants("Representatives").Elements();
                    foreach (XElement employee in employees)
                    {
                        POC poc = new POC()
                        {
                            Name = employee.Element("Name").Value,
                            PhoneNumber = employee.Element("Phone").Value,
                            Email = employee.Element("Email").Value,
                            Company = customer.Name
                        };
                        if (employee.Element("Address") == null)
                        {
                            poc.Address = customer.Address;
                        }
                        else
                        {
                            if (employee.Element("Address").Value == ";")
                            {
                                poc.Address = customer.Address;
                            }
                            else
                            {
                                poc.Address = employee.Element("Address").Value;
                            }
                        }
                        customer.Employees.Add(poc);
                    }
                    customers.Add(customer);
                }

                return customers;
            }

            /// <summary>
            /// Saves list of Employees to file
            /// </summary>
            /// <param name="employees">List of employees.</param>
            /// <param name="source">File to save to.</param>
            /// <returns></returns>
            public static bool SaveEmployees(List<Employee> employees, string source)
            {
                return true;
            }

            /// <summary>
            /// Saves list of Customers to file
            /// </summary>
            /// <param name="customers">List of customers.</param>
            /// <param name="source">File to save to.</param>
            /// <returns></returns>
            public static bool SaveCustomers(List<Customer> customers, string source)
            {
                if (customers.Count == 0)
                {
                    return false;
                }

                XElement master = new XElement("Customers");

                foreach (Customer customer in customers)
                {
                    XElement element = new XElement("Customer",
                        new XElement("Name", customer.Name),
                        new XElement("Address", customer.Address),
                        new XElement("Phone", customer.Phone)
                        );

                    XElement employees = new XElement("Representatives");
                    foreach (POC employee in customer.Employees)
                    {
                        XElement employeeXE = new XElement("Representative",
                        new XElement("Name", employee.Name),
                        new XElement("Address", employee.Address),
                        new XElement("Phone", employee.PhoneNumber),
                        new XElement("Email", employee.Email)
                        );
                        employees.Add(employeeXE);
                    }
                    element.Add(employees);
                    master.Add(element);
                }

                master.Save(source);

                return true;
            }
        }
    }
}
