using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Company
    {
        public Guid Id { get; set; }
        public ICollection<CompanyOffice> CompanyOffice { get; set; }
        public ICollection<LoanList> LoanList { get; set; }
        public string Register { get; set; }
        public string Name { get; set; }
        public string BrandName { get; set; }
        public string Address { get; set; }
        public int PhoneNR { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string Comments { get; set; }
    }
}
