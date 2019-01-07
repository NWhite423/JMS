using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using System.Diagnostics;
using JMS;

namespace JMSFunctions
{
    public class XML
    {
        //Updated 12-22-18
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

        //Updated 12-22-18
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

        //Updated 12-22-18
        public static bool AddNoteToJob(Job job, string note, string author = null)
        {
            job.DateEdited = JMS.Functions.GrabCurrentTime(0);
            job.TimeEdited = JMS.Functions.GrabCurrentTime(1);
            if (author == null)
            {
                job.EditedBy = AppSettings.Default.UserName;
            } else
            {
                job.EditedBy = author;
            }

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

        //Updated 12-22-18
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

        //Updated 12-22-18
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
                    } else
                    {
                        if (employee.Element("Address").Value == ";")
                        {
                            poc.Address = customer.Address;
                        } else
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

        public static void RecompileJobs()
        {
            List<string> directories = Functions.GrabDirectories(Variables.WorkDir, "index.txt");
            for (int i = 0; i < directories.Count; i++)
            {
                DateTime lastEdit = File.GetLastWriteTime(Variables.WorkDir + @"\" + directories[i] + @"\index.txt");
                Debug.WriteLine(Variables.WorkDir + @"\" + directories + @"\index.txt" + " - " + lastEdit.ToLongDateString() + " " + lastEdit.ToLongTimeString());
                Debug.WriteLine(Variables.LastCompile.ToLongDateString() + " " + Variables.LastCompile.ToLongTimeString());
                if (lastEdit > Variables.LastCompile)
                {
                    Debug.WriteLine(string.Format("Recompile {0} ({1})", directories[i], i));
                    for (int j = 0; j < directories.Count; j++)
                    {
                        string dir = Variables.WorkDir + @"\" + directories[i];
                        Debug.WriteLine("Directory: " + dir);
                        List<Job> jobs = new List<Job> { };
                        List<string> jobindex = File.ReadAllLines(dir + @"\index.txt").ToList();
                        int size = jobindex.Count;
                        for (int k = 0; k < size; k++)
                        {
                            string[] jobInfo = jobindex[k].Split(';');
                            Debug.WriteLine("Job: " + jobInfo[0]);
                            Job job = new Job();

                            //Grab information
                            job = XML.CompileJob(jobInfo[1]);
                            Debug.WriteLine("compiled " + job.Name);
                            jobs.Add(job);
                        }
                        Variables.AllJobs[i] = jobs;
                    }
                }
            }
            Variables.LastCompile = DateTime.Now;
        }

        public static bool RecompileJob(string filepath, int year, int position)
        {
            Debug.WriteLine("Filepath: " + filepath + @"\jobdata.xml");
            if (!File.Exists(filepath + @"\jobdata.xml"))
            {
                return false;
            }
            Job job = CompileJob(filepath + @"\jobdata.xml");
            Debug.WriteLine("Produced job: " + job.Name);
            Debug.WriteLine("Existing job: " + Variables.AllJobs[year][position].Name);
            Variables.AllJobs[year][position] = job;
            Debug.WriteLine("Replacement job: " + Variables.AllJobs[year][position].Name);
            return true;
        }

        public static bool SaveEmployees(List<Employee> employees, string source)
        {
            return true;
        }

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
