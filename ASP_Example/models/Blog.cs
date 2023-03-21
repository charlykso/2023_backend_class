using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Example.models
{
    public class Blog
    {
        public int id { get; set; }
        public string? title { get; set; }
        public string? text { get; set; }
        public DateTime created_at { get; set; }
        public DateTime update_at { get; set; }
    }
}