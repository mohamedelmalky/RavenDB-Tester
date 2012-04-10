using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RavenDB.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}