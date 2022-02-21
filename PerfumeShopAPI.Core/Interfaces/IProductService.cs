﻿using PerfumeShopAPI.Core.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfumeShopAPI.Core.Interfaces
{
    public interface IProductService
    {
        void AddProductt(ProductDTO category);
        IEnumerable<ProductDTO> GetAllProducts();
        ProductDTO GetProductById(int id);
        void EditProduct(ProductDTO category);
        void DeleteProductById(int id);
    }
}
