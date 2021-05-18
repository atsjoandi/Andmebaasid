using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class LoanList
    {
        public Guid Id { get; set; }
        public Company Company { get; set; }
        public Employee Employee { get; set; }
        public ICollection<LoanItem> LoanItem { get; set; }
        public string Item { get; set; }
        public DateTime? LoanStart { get; set; }
        public DateTime? DueDate { get; set; }
        public int Interest { get; set; }
        public string Comments { get; set; }
    }
}
