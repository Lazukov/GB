using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebGB.Models;
using WebGB.Data;

namespace WebGB.Controllers
{
    public class EmployeesController : Controller
    {
        private List<Employeer> _ListEmployees = new List<Employeer>();

        public EmployeesController()
        {
            _ListEmployees = Data.TestData.GetEmployers();
        }
        public IActionResult Index()
        {
            return View(_ListEmployees);
        }

        public IActionResult Details(int id)
        {
            return View(_ListEmployees.FirstOrDefault(x=>x.ID==id));
        }
    }
}