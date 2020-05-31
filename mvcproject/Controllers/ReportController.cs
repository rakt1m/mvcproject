using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Reporting.WebForms;
using mvcproject.BLL.Contracts;

namespace mvcproject.Controllers
{
    public class ReportController : Controller
    {
        private readonly IEmployeeManager _iEmployeeManager;
        public ReportController(IEmployeeManager iEmployeeManager)
        {
            _iEmployeeManager = iEmployeeManager;
        }
        // GET: Report
        public FileResult EmpList()
        {

            ReportViewer rptViewer = new ReportViewer();

            var dt = _iEmployeeManager.AllEmp();
            rptViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/EMPlist.rdlc");
            rptViewer.LocalReport.EnableExternalImages = true;
            rptViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("UVResults", dt));
            rptViewer.LocalReport.Refresh();
            Warning[] warnings;
            string[] streamIds;
            string mimeType = string.Empty;
            string encoding = string.Empty;
            string extension = string.Empty;
            byte[] bytes = rptViewer.LocalReport.Render("PDF", null, out mimeType, out encoding, out extension, out streamIds, out warnings);
            return File(bytes, "application/pdf");
        }

    }
}