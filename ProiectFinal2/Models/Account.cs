using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProiectFinal2.Models
{
    public class Account
    {
        public int id { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }


        public virtual ICollection<ApplicationUser> Users { get; set; }
    }
}