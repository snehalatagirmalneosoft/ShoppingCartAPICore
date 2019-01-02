using System;
using System.Collections.Generic;

namespace ShoppingCartArchitecture.Data.Models
{
    public partial class Exception
    {
        public int ExceptionId { get; set; }
        public string ExceptionType { get; set; }
        public string ExceptionDetails { get; set; }
        public string ExceptionFileName { get; set; }
        public string Method { get; set; }
        public DateTime? ExceptionDateTime { get; set; }
        public bool? ExceptionStatus { get; set; }
    }
}
