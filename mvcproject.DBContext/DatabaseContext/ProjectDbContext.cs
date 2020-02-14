using mvcproject.Model.EntityModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcproject.DBContext.DatabaseContext
{
   public class ProjectDbContext:DbContext
    {


        public DbSet<Employee> Employees { get; set; }
    }
}
