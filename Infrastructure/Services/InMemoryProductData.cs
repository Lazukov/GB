using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using WebGB.Data;
using WebGB.Infrastructure.Interfaces;

namespace WebGB.Infrastructure.Services
{
    public class InMemoryProductData : IProductData
    {

        public IEnumerable<Section> GetSections()
        {
            return TestData.GetSections();
        }

        public IEnumerable<Brand> GetBrands()
        {
            return TestData.GetBrands();
        }

    }
}
