using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mvcproject.DAL.Contracts;
using mvcproject.Model.EntityModel;

namespace mvcproject.DAL.Repository
{
   public class EmployeeRepository:Repository<Employee>,IEmployeeRepository
    {
    }
}
