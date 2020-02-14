using mvcproject.Model.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcproject.DAL.Contracts
{
   public interface IEmployeeRepository:IRepository<Employee>
    {
    }
}
