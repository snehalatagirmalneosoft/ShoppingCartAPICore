using System;
using System.Collections.Generic;

namespace ShoppingCartArchitecture.Data.Models
{
    public partial class UserMaster
    {
        public UserMaster()
        {
            Cart = new HashSet<Cart>();
            UserDetail = new HashSet<UserDetail>();
        }

        public int UserId { get; set; }
        public int? RoleId { get; set; }
        public string EmailId { get; set; }
        public string UserPassWord { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsActive { get; set; }

        public UserRole Role { get; set; }
        public ICollection<Cart> Cart { get; set; }
        public ICollection<UserDetail> UserDetail { get; set; }
    }
}
