using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class EmployeeChild
    {
        public Guid Id { get; set; }
        public Employee Employee { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
