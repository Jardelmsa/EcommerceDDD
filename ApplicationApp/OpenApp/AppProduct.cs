﻿using ApplicationApp.Interfaces;
using Domain.Interfaces.InterfaceProduct;
using Domain.Interfaces.InterfaceServices;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationApp.OpenApp
{
    public class AppProduct : InterfaceProductApp
    {
        IProduct _IProduct;
        IServiceProduct _IServiceProduct;
        public AppProduct(IProduct IProduct, IServiceProduct IServiceProduct)
        {
            _IProduct = IProduct;
            _IServiceProduct = IServiceProduct;
        }


       
        public async Task AddProduct(Produto produto)
        {
            await _IServiceProduct.AddProduct(produto);
        }
        public async Task UpdateProduct(Produto produto)
        {
            await _IServiceProduct.Update(produto);
        }
       

        public async Task Add(Produto objeto)
        {
            await _IProduct.Add(objeto);
        }

        public async Task Delete(Produto objeto)
        {
            await _IProduct.Delete(objeto);
        }

        public async Task<Produto> GetEntityById(int id)
        {
           return await _IProduct.GetEntityById(id);
        }

        public async Task<List<Produto>> List()
        {
            return await _IProduct.List();
        }

        public async Task Update(Produto produto)
        {
            await _IProduct.Update(produto);
        }

    }
}
