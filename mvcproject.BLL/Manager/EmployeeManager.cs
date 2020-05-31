using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mvcproject.BLL.Contracts;
using mvcproject.DAL.Contracts;
using mvcproject.Model.EntityModel;

namespace mvcproject.BLL.Manager
{
  public  class EmployeeManager:Manager<Employee>,IEmployeeManager
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeManager(IEmployeeRepository repository) : base(repository)
        {
            _employeeRepository = repository;

        }

        public ICollection<EmpReport> AllEmp()
        {
            return _employeeRepository.AllEmp();
        }
    }
}
