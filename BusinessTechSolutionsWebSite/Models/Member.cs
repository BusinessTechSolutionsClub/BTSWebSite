using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessTechSolutionsWebSite.Models
{
    public class Member
    {
        public int Id { get; set; }
        public virtual ApplicationUser ASPuser { get; set; }
        public string StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Major { get; set; }
        public bool Status { get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime GraduationDate { get; set; }
        public string Email { get; set; }
        public bool Memberhip { get; set; }
    }
}