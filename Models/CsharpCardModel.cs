using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace flashCardBackend.Models
{
    public class CsharpCardModel
    {
        public int Id { get; set; }
        public string? CsharpQuestion { get; set; }
        public string? CsharpAnswer { get; set; }
        public string? CodeAnswer { get; set; }
        public CsharpCardModel(){}
    }
}