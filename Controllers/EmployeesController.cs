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
            return emp!=null ? View(new EmployeerViewModel()
            {

                ID = emp.ID,
                Date=emp.Date,
                Description =emp.Description,
                Name=emp.Name,
                Surname=emp.Surname
                
            }): View(new EmployeerViewModel());
            ;
        }

        [HttpPost]
        public IActionResult Edit(EmployeerViewModel emp)
        {
            //ModelState.AddModelError("222", "");
            if (ModelState.IsValid)
            {
                var em = _EmployeesData.Get(emp.ID);
                if (em != null)
                {
                    var emUpdate = (new Employeer()
                    {

                        ID = emp.ID,
                        Date = emp.Date,
                        Description = emp.Description,
                        Name = emp.Name,
                        Surname = emp.Surname

                    });
                    _EmployeesData.Update(emUpdate);
                }
                else
                {
                    var emUpdate = (new Employeer()
                    {

                        ID = _EmployeesData.Get().Count() + 1,
                        Date = emp.Date,
                        Description = emp.Description,
                        Name = emp.Name,
                        Surname = emp.Surname

                    });
                    _EmployeesData.Add(emUpdate);
                }
                return RedirectToAction("Index");
            }
            return View();
        }
        #endregion

        #region Delete
        public IActionResult Delete(int id)
        {
            //Физическая модель и модель представления должны быть разделены
            Employeer emp = _EmployeesData.Get(id);
            return View(new EmployeerViewModel()
            {

                ID = emp.ID,
                Date = emp.Date,
                Description = emp.Description,
                Name = emp.Name,
                Surname = emp.Surname

            });
            ;
        }

        [HttpPost]
        public IActionResult Delete(EmployeerViewModel emp)
        {
            _EmployeesData.Delete(emp.ID);
            return RedirectToAction("Index");
        }
        #endregion

        #region Add
        public IActionResult Add(EmployeerViewModel empl)
        {
            return View("Edit",empl);
        }

        #endregion

    }
}