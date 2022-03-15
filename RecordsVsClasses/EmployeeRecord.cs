using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsVsClasses
{
    public record EmployeeRecord (string FirstName, string LastName, string Job) : PersonRecord(FirstName, LastName);
}
