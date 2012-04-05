using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace RavenDB_Tester.Models
{
    public class UserInfo
    {
        public int Id { get; set; }

        [DisplayName("User Name")]
        public string UserName { get; set; }
    }
}