using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Mvc;
using mvcproject.BLL.Contracts;
using mvcproject.DBContext.DatabaseContext;
using mvcproject.Model.EntityModel;

namespace mvcproject.Controllers
{
    public class EmpController : Controller
    {

        private readonly IEmployeeManager _iEmployeeManager;

        public EmpController(IEmployeeManager iEmployeeManager)
        {
            _iEmployeeManager = iEmployeeManager;
        }

        //[System.Web.Http.Route("Emp/AddEmp/")]
        //[System.Web.Http.HttpPost]
        public JsonResult AddEmp(Employee emp)
        {
            string cr = string.Empty;
            
            try
            {


               _iEmployeeManager.Add(emp);
                cr = "Inserted";
                //   cr.httpStatusCode = res ? HttpStatusCode.OK : HttpStatusCode.BadRequest;

            }
            catch (Exception ex)
            {
                cr = "Failed";
            }
            return Json(cr, JsonRequestBehavior.AllowGet);
        }


        public JsonResult Get_data()

        {
           var res= _iEmployeeManager.GetAll().ToList();

           

            return Json(res, JsonRequestBehavior.AllowGet);

        }




        public JsonResult Update_record(Employee emp)

        {

            string res = string.Empty;

            try

            {

                _iEmployeeManager.Update(emp);

                res = "Updated";

            }

            catch (Exception)

            {

                res = "failed";

            }

            return Json(res, JsonRequestBehavior.AllowGet);



        }



        public JsonResult Get_databyid(int id)

        {

           var res= _iEmployeeManager.GetById(id);

            return Json(res, JsonRequestBehavior.AllowGet);

        }

        // Delete record

        public JsonResult Delete_record(int id)

        {

            string res = string.Empty;

            try

            {

                Employee employee = _iEmployeeManager.GetById(id);
                _iEmployeeManager.Remove(employee);

                res = "data deleted";

            }

            catch (Exception)

            {

                res = "failed";

            }

            return Json(res, JsonRequestBehavior.AllowGet);



        }




        //[System.Web.Http.Route("Emp/AddEmp/")]
        //[System.Web.Http.HttpGet]
        //public IHttpActionResult Index()
        //{
        //    CommonResponse cr = new CommonResponse();
        //    try
        //    {


        //        var res = _iEmployeeManager.GetAll().ToList();
        //        cr.httpStatusCode = res ? HttpStatusCode.OK : HttpStatusCode.BadRequest;

        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //    return Json(cr);



        //}

    }
}