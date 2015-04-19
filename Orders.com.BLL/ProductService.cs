﻿using Facile;
using Orders.com.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.com.BLL
{
    public class ProductService : BusinessServiceBase<Product, int>
    {
        public ProductService(IServiceDataProxy<Product, int> dataProxy) : base(dataProxy)
        {
        }
    }
}
