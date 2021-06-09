using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _012.Models
{
    public class Transfer
    {
        public decimal cardFrom { get; set; }
        public decimal cardTo { get; set; }
        public decimal amt { get; set; }
        public DateTime date { get; set; }
    }
}
