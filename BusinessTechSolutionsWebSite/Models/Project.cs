using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessTechSolutionsWebSite.Models
{
    public class Project
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string ProjectLeader { get; set; }
        public string ProjectName { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
        public string StatusNote { get; set; }
        public string Description { get; set; }
        
        public virtual Customer customer { get; set; }
    }
}