using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RavenDB_Tester.Models
{
    public class WallEntry
    {
        public int Id { get; set; }
        public string Entry { get; set; }
        public int UserId { get; set; }
    }
}