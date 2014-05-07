using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KmrApiTestServ.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int Content { get; set; }
    }
}