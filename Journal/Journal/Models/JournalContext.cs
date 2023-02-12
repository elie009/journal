using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Journal.Models
{
    public class JournalContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public JournalContext() : base("name=JournalContext")
        {
        }

        public System.Data.Entity.DbSet<Journal.Models.JournalItem> JournalItems { get; set; }
        public System.Data.Entity.DbSet<Journal.Models.JournalDetails> JournalDetails { get; set; }
    }
}
