using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebGB.Models;

namespace WebGB.Data
{
   static  public class TestData
    {
        public static readonly  List<Employeer> AllEmployees = new List<Employeer>()
        {
            new Employeer() { ID=1, Surname="Иванов", Name="Иван", Date=DateTime.Parse("10.01.1985"), Description="Описание Иванов"} ,
            new Employeer() { ID =2, Surname = "Петров",Name="Егор",  Date=DateTime.Parse("10.01.1984"), Description="Описание Петров"}
        };

        public static List<Employeer> GetEmployers()
        {

            return AllEmployees;
        }
    }
}
