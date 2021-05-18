using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class WorkTitle
    {
        public Guid Id { get; set; }
        public ICollection<Employee> Employee { get; set; }
        public ICollection<AccessPermit> AccessPermit { get; set; }
        public string TitleName { get; set; }
        public string Comments { get; set; }
    }
}
