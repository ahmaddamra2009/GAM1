using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GAM1.Models;
namespace GAM1.Controllers
{
    public class EmployeesController : Controller
    {
        List<Employee> empList = new List<Employee>()
        {
            new Employee{Id=1,Name="Rami",City="Amman"},
            new Employee{Id=2,Name="Sami",City="Irbid"},
            new Employee{Id=3,Name="Hiba",City="Amman"}
        };
        // Ado.net
        // Connected Dis
        // App  EntityFramework(LINQ) = Dataset   Db
        // Ahmad Damra
        
        public ActionResult AllEmployees()
        {
            // Global Variable Session["Age"]
            ViewBag.fullName= "Ahmad Damra";
            ViewBag.City = "Jordan, Amman";
            return View();
        }

        public ActionResult Vision()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View(empList.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
      
    }
}