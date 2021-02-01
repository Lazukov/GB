using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebGB.Models
{
    public class SectionViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public  SectionViewModel Parent { get; set; }
        
        public List<SectionViewModel> ChildSections { get; set; }

        public int Order { get; set; }
    }
}
