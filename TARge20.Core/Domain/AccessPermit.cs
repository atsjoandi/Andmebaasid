using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class AccessPermit
    {
        public Guid Id { get; set; }
        public ICollection<Employee> Employee { get; set; }
        public WorkTitle WorkTitle { get; set; }
        public int Level { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Comments { get; set; }
    }
}
