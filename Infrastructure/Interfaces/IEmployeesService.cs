using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebGB.Models;

namespace WebGB.Infrastructure.Interfaces
{
    public interface IEmployeesService
    {
        IEnumerable<Employeer> Get();

        Employeer Get(int id);

        void Update(Employeer empl);

        bool Delete(int id);

        void Add(Employeer empl);
    }
}
