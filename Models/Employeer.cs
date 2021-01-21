using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebGB.Models
{
    public class Employeer
    {
        public int ID { get; set; }
        public string Surname { get; set; }

        public string Name { get; set; }

        public DateTime  Date { get; set; }

        public string Description { get; set; }
    }
}
