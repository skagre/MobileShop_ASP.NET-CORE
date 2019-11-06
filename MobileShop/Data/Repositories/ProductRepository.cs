﻿using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using MobileShop.Data.Interfaces;
using MobileShop.Data.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _appDbContext;
        public ProductRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Product> Products => _appDbContext.Products.Include(c => c.Category);

        public IEnumerable<Product> PreferredProducts => _appDbContext.Products.Where(p => p.Product_IsPreferred).Include(c => c.Category);

        //public Product GetProductById(int productId) => _appDbContext.Products.FirstOrDefault(p => p.Product_Id == productId);
        public Product GetProductById(int id)
        {
            return _appDbContext.Products.Find(id);
        }
        public IEnumerable<Product> GetAllProducts() => _appDbContext.Products;

        public Product Add(Product product, IFormFile photo)
        {
            AddPhoto(product, photo);

            _appDbContext.Products.Add(product);
            _appDbContext.SaveChanges();
            return product;
        }

        public Product Edit(Product product, int id, IFormFile photo)
        {
            Product p = _appDbContext.Products.Find(id);
            if (p != null)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", p.Product_ImageThumbnail);

                p.Product_Name = product.Product_Name;
                p.Product_Price = product.Product_Price;
                p.Product_ShortDescription = product.Product_ShortDescription;
                p.Product_LongDescription = product.Product_LongDescription;
                p.Product_InStock = product.Product_InStock;
                p.Product_IsPreferred = product.Product_IsPreferred;

                AddPhoto(product, photo);
                p.Product_ImageThumbnail = product.Product_ImageThumbnail;

                //p.Product_ImageThumbnail = "avatar.png";

                p.Product_OperatingSystem = product.Product_OperatingSystem;
                p.Product_Chipset = product.Product_Chipset;
                p.Product_CPUSpeed = product.Product_CPUSpeed;
                p.Product_GPU = product.Product_GPU;
                p.Product_ScreenResolution = product.Product_ScreenResolution;
                p.Product_ScreenWidth = product.Product_ScreenWidth;
                p.Product_RAM = product.Product_RAM;
                p.Product_ROM = product.Product_ROM;
                p.Product_SDCardSupport = product.Product_SDCardSupport;
                p.Product_SDCard = product.Product_SDCard;
                p.Product_FrontCamera = product.Product_FrontCamera;
                p.Product_RearCamera = product.Product_RearCamera;

                _appDbContext.SaveChanges();

                if (File.Exists(path))
                {
                    File.Delete(path);
                }
            }
            return p;
        }

        public Product Delete(int id)
        {
            Product p = _appDbContext.Products.Find(id);
            if (p != null)
            {
                _appDbContext.Products.Remove(p);
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", p.Product_ImageThumbnail);
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                _appDbContext.SaveChanges();
            }
            return p;
        }

        public void AddPhoto(Product product, IFormFile photo)
        {
            Random rand = new Random();
            string random = DateTime.Now.ToString("dd-MM-yyyy-HHmmss") + rand.Next(1, 10);
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", random + photo.FileName);
            var stream = new FileStream(path, FileMode.Create);
            photo.CopyToAsync(stream);
            product.Product_ImageThumbnail = random + photo.FileName;
            stream.Close();
        }
    }
}