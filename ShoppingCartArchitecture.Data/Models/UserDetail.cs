using System;
using System.Collections.Generic;

namespace ShoppingCartArchitecture.Data.Models
{
    public partial class UserDetail
    {
        public int UserDetailId { get; set; }
        public int? UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PermanentAddress { get; set; }
        public string AlternateAddress { get; set; }
        public string MobileNumber { get; set; }
        public string City { get; set; }

        public UserMaster User { get; set; }
    }
}
