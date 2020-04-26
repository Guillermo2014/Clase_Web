using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Domain.Models;
using WebApplication1.Domain.Services;

namespace WebApplication1.Services
{
    public class CategoryServices : ICategoryService
    {
        public CategoryServices()
        {

        }
        public Task<IEnumerable<Category>> ListAsync()
        {
            throw new NotImplementedException();
        }
    }
}
