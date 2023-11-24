using EmployeesWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EmployeesWebApplication.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Retrieving student details by Id number.
        /// </summary>
        /// <param name="Id"> this is unique Id Number of a student</param>
        /// <returns> returns data in Json Format</returns>
        public JsonResult GetEmployeeDetails(int? Id)
        {
            EmployeeRepo repoObj = new EmployeeRepo();
            IEnumerable<Employee>? empObj = repoObj.GetEmployeeById(Id);
            return Json(empObj);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}