using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace flashCardBackend.Models
{
    public class HtmlCardModel
    {
        public int Id { get; set; }
        public string? HtmlQuestion { get; set; }
        public string? HtmlAnswer { get; set; }
        public string? CodeAnswer { get; set; }
        public HtmlCardModel(){}
    }
}