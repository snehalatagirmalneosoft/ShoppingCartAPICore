using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Data.Models
{
   public class STP_GetUserDetails
    {
        public int UserId { get; set; }
        public int UserDetailId { get; set; }
        public int? RoleId { get; set; }
        public string EmailId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RoleName { get; set; }
        public string PermanentAddress { get; set; }
        public string AlternateAddress { get; set; }
        public string MobileNumber { get; set; }
        public string City { get; set; }
        public string CreatedBy { get; set; }
        //public DateTime? ModifiedOn { get; set; }       
        //public int? ModifiedBy { get; set; }
        public bool? IsActive { get; set; }
    }
}
