using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Alblog.Models
{
    public class Blogpost
    {
        public string Id { get; set; }
        public string Author { get; set; }
        public string Date { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string PostContent { get; set; }
        public override string ToString() => JsonSerializer.Serialize<Blogpost>(this);
    }
}
