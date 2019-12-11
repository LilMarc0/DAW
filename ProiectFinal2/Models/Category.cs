using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProiectDAW.Models
{
    public class Category
    {
        public int categoryId { set; get; }
        public string name { set; get; }
    }
    public class CategoryDBContext : DbContext
    {
        public  CategoryDBContext() : base("DefaultConnection") { }
        public DbSet<Category> Categories { get; set; }
    }

}