using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BusinessTechSolutionsWebSite.Models
{
    public class ClubOfficer
    {
        [ForeignKey("Member")]

        public int Id { get; set; } //Primary
        public virtual Member Member { get; set; } //Foreign
        public string officerPosition { get; set; }
        public DateTime beginDate { get; set; }
        public DateTime endDate { get; set; }
    }
}