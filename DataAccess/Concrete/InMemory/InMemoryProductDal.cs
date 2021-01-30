using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> { 
            
            new Product(){CategoryId=1,ProductId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15},
            new Product(){CategoryId=2,ProductId=2,ProductName="Kulaklık",UnitPrice=500,UnitsInStock=3},
            new Product(){CategoryId=2,ProductId=3,ProductName="Klavye",UnitPrice=1500,UnitsInStock=2},
            new Product(){CategoryId=2,ProductId=4,ProductName="Telefon",UnitPrice=150,UnitsInStock=65},
            new Product(){CategoryId=2,ProductId=5,ProductName="Mouse",UnitPrice=85,UnitsInStock=1}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);       
        }

        public void Delete(Product product)
        {
            Product productToDelete =  productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);


            _products.Remove(productToDelete);

        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
