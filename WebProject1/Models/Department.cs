using System.Collections.Generic;
using System.Linq;
using System;
using WebProject1.Models;


namespace WebProject1.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
       
        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }
        
                public void AddProducts(Product product)
        {
            Products.Add(product);
        }
    }
}
