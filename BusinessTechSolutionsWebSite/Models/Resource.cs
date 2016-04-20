using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessTechSolutionsWebSite.Models
{
    public class Resource
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int MemberId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public DateTime Date { get; set; }

        public virtual Category category { get; set; }
        public virtual Member member { get; set; }
    }
}