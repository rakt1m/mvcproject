using mvcproject.BLL.Contracts;
using mvcproject.BLL.Manager;
using mvcproject.DAL.Contracts;
using mvcproject.DAL.Repository;
using System.Web.Mvc;

using Unity;
using Unity.Mvc5;

namespace mvcproject
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            container.RegisterType<IEmployeeManager, EmployeeManager>();
            container.RegisterType<IEmployeeRepository, EmployeeRepository>();

           
        }
    }
}