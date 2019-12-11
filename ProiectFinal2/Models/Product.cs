using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProiectDAW.Models
{
    public class Product
    {
        public int productId { get; set; }  
        public int categoryId { get; set; }
        public int ratingId { get; set; }
        public int businessId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int stock { get; set; }
        public string photo { get; set; }
    }
    public class ProductDBContext : DbContext
    {
        public ProductDBContext() : base("DefaultConnection") { }
        public DbSet<Product> Products { get; set; }
    }

}