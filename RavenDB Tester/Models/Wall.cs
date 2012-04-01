using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RavenDB_Tester.Models
{
    public class Wall
    {
        public List<WallEntry> Entries { get; set; }
    }
}