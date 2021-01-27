using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebGB.Models;
using WebGB.Data;
using WebGB.Infrastructure.Services;
using WebGB.Infrastructure.Interfaces;
using WebGB.ViewModels;

namespace WebGB.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeesService _EmployeesData;//Только один раз можно записать 

        public EmployeesController(IEmployeesService empService)
        {
            _EmployeesData = empService;
        }
        public IActionResult Index()
        {
            return View(_EmployeesData.Get());
        }

        public IActionResult Details(int id)
        {
            return View(_EmployeesData.Get(id));
        }

        #region Edit
        public IActionResult Edit(int id)
        {
            //Физическая модель и модель представления должны быть разделены
            Employeer emp=  _EmployeesData.Get(id);
            return View(new EmployeerViewModel()
            {

                ID = emp.ID,
                Date=emp.Date,
                Description =emp.Description,
                Name=emp.Name,
                Surname=emp.Surname
                
            });
            ;
        }

        [HttpPost]
        public IActionResult Edit(EmployeerViewModel emp)
        {
            var em = _EmployeesData.Get(emp.ID);
            var emUpdate=(new Employeer()
            {

                ID = emp.ID,
                Date = emp.Date,
                Description = emp.Description,
                Name = emp.Name,
                Surname = emp.Surname

            });
            _EmployeesData.Update(emUpdate);
           return RedirectToAction("Index");
        }
        #endregion
    }
}