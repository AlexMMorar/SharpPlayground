using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsVsClasses
{
    public class EmployeeClass : PersonClass
    {
        public string Job { get; set; }

        public EmployeeClass(string firstName, string lastName, string job)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Job = job;
        }
    }
}
