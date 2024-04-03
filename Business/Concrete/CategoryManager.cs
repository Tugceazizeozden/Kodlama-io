using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        public IList<ICategoryService> GetList()
        {
            throw new NotImplementedException();
        }
    }
}

