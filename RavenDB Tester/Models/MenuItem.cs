using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RavenDB.Models
{
    public class MenuItem
    {
        public string DisplayName { get; set; }
        public string Area { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
    }
}