﻿using Microsoft.AspNetCore.Http;
using MobileShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Data.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
        IEnumerable<Product> PreferredProducts { get; }
        Product GetProductById(int productId);
        //IEnumerable<Product> GetAllProducts();
        Product Add(Product product, IFormFile photo);
        Product Edit(Product product, int id, IFormFile photo);
        Product Delete(int id);

        void AddPhoto(Product product, IFormFile photo);
    }
}