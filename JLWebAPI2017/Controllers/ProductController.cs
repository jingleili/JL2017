using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Antlr.Runtime.Tree;

namespace JLWebAPI2017.Controllers
{

    public class Product
    {
        public int  Id { get; set; }
        public string Name{ get; set; }
        public double Price { get; set; }
    }
    public class ProductController : ApiController
    {

        private IEnumerable<Product> _products;
        public ProductController()
        {
            _products=new List<Product>(){new Product(){Id =1,Name = "Apple",Price = 2.11},new Product(){Id = 2,Name = "Banana",Price = 3.33}};

        }


        public IEnumerable<Product> Get()
        {
            return _products;

        }

        public Product Get(int id)
        {
            return _products.FirstOrDefault(x => x.Id == id);
        }
        /// <summary>
        /// http://localhost:52354/api/Product
        /// request body {"Id":"3","Name":"PineApple","Price":"3.33"}
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public IList<Product> Post(Product product)
        {
            var temProduct = _products.ToList();
            temProduct.Add(product);
            return temProduct.ToList();
        }
        /// <summary>
        /// http://localhost:52354/api/Product?id=2
        /// request body apple1
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public IEnumerable<Product> Put(int id, [FromBody] string name)
        {
            var temProduct = _products.ToList().FirstOrDefault(x=>x.Id==id);
            temProduct.Name = name;
            return _products;
        }


    }
}
