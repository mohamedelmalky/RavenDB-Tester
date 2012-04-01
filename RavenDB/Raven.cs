using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Raven.Client.Document;
using System.Configuration;

namespace RavenDB
{
    public static class Raven
    {
        static DocumentStore _ds = null;

        public static DocumentStore ds 
        { 
            get
            {
                if (_ds == null)
                {
                    _ds = new DocumentStore() { Url = ConfigurationManager.ConnectionStrings["RavenDB"].ConnectionString };
                    _ds.Initialize();
                }
                return _ds;
            }
            private set { _ds = value; }
        }
    }
}
