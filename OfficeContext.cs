using EmployeePRO.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmployeePRO
{
    public class OfficeContext : DbContext
    {
        public OfficeContext() : base("dbconn")
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}