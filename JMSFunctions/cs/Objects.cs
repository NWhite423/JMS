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

    public class Job: IDisposable
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

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~Job() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion


    }

    public class LoginInformation
    {
        /// <summary>
        /// The username for the account
        /// </summary>
        public string UserName;

        /// <summary>
        /// The Name to be displayed on the front end.
        /// </summary>
        public string DisplayName;

        /// <summary>
        /// The local computer name that the user is using.
        /// </summary>
        public string ComputerName
        {
            get { return Environment.MachineName; }
        }

        /// <summary>
        /// The username logged into the computer.
        /// </summary>
        public string ComputerUserName
        {
            get { return System.Security.Principal.WindowsIdentity.GetCurrent().Name; }
        }

        /// <summary>
        /// The current admin level
        /// 1 - User
        /// 2 - Manager
        /// 3 - Owner
        /// </summary>
        public int AdminLevel;
    }
}
