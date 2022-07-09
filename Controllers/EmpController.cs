using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebEmpApp.Models;

namespace WebEmpApp.Controllers
{
    public class EmpController : Controller
    {
        public IActionResult Index()
        {
            List<Emp> lstEmployees = new List<Emp>
            {
                new Emp{EId=1,EName="Raji",EDesing="Programmer",EDOJ=System.DateTime.Parse("12/06/2022")},
                new Emp{EId=1,EName="Lakshmi",EDesing="Manager",EDOJ=System.DateTime.Parse("09/06/2020")},
                new Emp{EId=1,EName="Roopan",EDesing="Manager",EDOJ=System.DateTime.Parse("12/08/2018")},
                new Emp{EId=1,EName="Suba",EDesing="Programmer",EDOJ=System.DateTime.Parse("06/06/2021")},

            };
            return View(lstEmployees);
        }
    }
}
