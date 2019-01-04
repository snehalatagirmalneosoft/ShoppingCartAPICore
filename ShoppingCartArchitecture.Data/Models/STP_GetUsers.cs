using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ShoppingCart.Data.Models
{
   public class STP_GetUsers
    {
        public int UserId { get; set; }
        public int UserDetailId { get; set; }
        public int? RoleId { get; set; }
        public string EmailId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RoleName { get; set; }
        public string CreatedBy { get; set; }
        //public DateTime? ModifiedOn { get; set; }       
        //public int? ModifiedBy { get; set; }
        public bool? IsActive { get; set; }
    }
}
