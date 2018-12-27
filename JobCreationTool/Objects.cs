using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobCreationTool
{
    class Objects
    {
        public class POC
        {
            public string Name { get; set; }
            public string Company { get; set; }
            public string PhoneNumber { get; set; }
            public string[] Address { get; set; }
            public string Email { get; set; }
        }

        public class Job
        {
            public string Name { get; set; }
            public string Address { get; set; }
            public string JobNumber { get; set; }
            public string Path { get; set; }
            public string Price { get; set; }
            public List<string> Tasks { get; set; }
            public List<string> Folders { get; set; }
            public List<POC> Contacts { get; set; }
        }
    }
}
