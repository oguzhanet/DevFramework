﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Northwind.Entities.Concrete;

namespace DevFramework.Northwind.Business.ServiceContracts.Wcf
{
    public interface IProductDetailService
    {
        [OperationContract]
        List<Product> GetAll();
    }
}
