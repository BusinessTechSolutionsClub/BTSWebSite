using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessTechSolutionsWebSite.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Cell { get; set; }
        public string Description { get; set; }
    }
}