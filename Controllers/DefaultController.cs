using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebGB.Models;

namespace WebGB.Controllers
{
    public class DefaultController : Controller
    {
        public readonly List<Employeer> AllEmployees = new List<Employeer>() 
        { 
            new Employeer() { ID=1, Surname="Иванов", Name="Иван", Date=DateTime.Parse("10.01.1985"), Description="Описание Иванов"} , 
            new Employeer() { ID =2, Surname = "Петров",Name="Егор",  Date=DateTime.Parse("10.01.1984"), Description="Описание Петров"}
        };
        public IActionResult Index()
        {
            return View("Default");
        }

        //Default/ Employeer
        public IActionResult Employeers()
        {
            return View(AllEmployees);
        }

        //Default/DispEmployer
        public IActionResult DispEmployer(int id)
        {
            return View(AllEmployees.Where(x=>x.ID==id).FirstOrDefault());
        }
    }
}