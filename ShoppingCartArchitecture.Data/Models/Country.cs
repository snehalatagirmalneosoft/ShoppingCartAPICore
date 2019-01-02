using System;
using System.Collections.Generic;

namespace ShoppingCartArchitecture.Data.Models
{
    public partial class Country
    {
        public Country()
        {
            State = new HashSet<State>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public ICollection<State> State { get; set; }
    }
}
