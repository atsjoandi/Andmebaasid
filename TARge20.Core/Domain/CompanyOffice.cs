using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class CompanyOffice
    {
        public Guid Id { get; set; }
        public ICollection<Employee> Employee { get; set; }
        public Company Company { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public int PhoneNR { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Comments { get; set; }
    }
}
