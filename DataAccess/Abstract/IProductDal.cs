﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //DAL = Data Access Layer
    public interface IProductDal:IEntityRepository<Product>
    {
        
    }
}
