using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TARge20.Core.Domain;

namespace TARge20.Data
{
    public class TARge20DbContext : DbContext
    {

        public TARge20DbContext(DbContextOptions<TARge20DbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.
        public DbSet<Employee> Employee { get; set; }
        public DbSet<AccessPermit> AccessPermit { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<CompanyOffice> CompanyOffice { get; set; }
        public DbSet<EmployeeChild> EmployeeChild { get; set; }
        public DbSet<HealthCheck> HealthCheck { get; set; }
        public DbSet<LoanItem> LoanItem { get; set; }
        public DbSet<LoanList> LoanList { get; set; }
        public DbSet<SickLeaves> SickLeaves { get; set; }
        public DbSet<Vacations> Vacations { get; set; }
        public DbSet<WorkTitle> WorkTitle { get; set; }
    }
}
