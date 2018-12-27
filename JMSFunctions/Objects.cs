using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMSFunctions
{
    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public List<POC> Employees { get; set; }
    }

    public class Note
    {
        public string Timestamp { get; set; }
        public string Author { get; set; }
        public string Value { get; set; }
    }

    public class POC
    {
        public string Name { get; set; }
        public string Company { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }

    public class Employee
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Status { get; set; }
    }

    public class Job : ICloneable
    {
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Path { get; set; }
        public string Status { get; set; }
        public string Price { get; set; }
        public string DateCreated { get; set; }
        public string DateEdited { get; set; }
        public string TimeCreated { get; set; }
        public string TimeEdited { get; set; }
        public string CreatedBy { get; set; }
        public string EditedBy { get; set; }
        public DateTime DueDate { get; set; }
        public List<string> Folders { get; set; }
        public List<string> Tasks { get; set; }
        public List<Note> Notes { get; set; }
        public List<Customer> Contacts { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
