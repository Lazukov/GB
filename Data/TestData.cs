using Domain.Entities;
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


        public static IEnumerable<Section> GetSections()
        {
            return new List<Section>()
            {
                 new Section(){Id=1, Name="Для спорта", Order =1},
                  new Section(){Id=2, Name="Nike для спорта", Order =2, ParentId=1},
                  new Section(){Id=3, Name="Puma для спорта", Order =3, ParentId=1},
                 new Section(){Id=4, Name="Для отдыха", Order =4},
                  new Section(){Id=5, Name="Nike для отдыха", Order =5, ParentId=4},
                  new Section(){Id=6, Name="Puma ", Order =6, ParentId=4},
            };
        }

        public static IEnumerable<Brand> GetBrands()
        {
            return new List<Brand>()
            {
                new Brand(){Id=1, Order=1, Name="Gucci"},
                new Brand(){Id=1, Order=1, Name="Adiddas"},
                new Brand(){Id=1, Order=1, Name="Nike"}
            };
        }
    }
}
