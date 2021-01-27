using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebGB.Infrastructure.Interfaces;
using WebGB.Models;
using WebGB;
using WebGB.Data;

namespace WebGB.Infrastructure.Services
{


    public class InMemoryEmployeesData : IEmployeesService
    {
        private readonly List<Employeer> _Employees;


        public  InMemoryEmployeesData()
        {
            _Employees = TestData.AllEmployees;
        }

        public void Add(Employeer empl)
        {
            _Employees.Add(empl);
        }

        public bool Delete(int id)
        {
            return _Employees.Remove(Get(id));
        }

        public IEnumerable<Employeer> Get()
        {
            return _Employees;
        }

        public Employeer Get(int id)
        {
            return _Employees.FirstOrDefault(x => x.ID == id);
        }

        public void Update(Employeer empl)
        {
            var emp = Get(empl.ID);
            if(emp!=null)
            {
                emp.Name = empl.Name;
                emp.Surname = empl.Surname;
                emp.Description = empl.Description;
                emp.Date = empl.Date;
            }
        }
    }
}
