﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public  interface ICategoryDal
    {
        List<Category> GetAll();



    }
}

namespace DataAccess
{
    public class Category
    {
    }
}