using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Zarate.Models
{
    public class DataContext: DbContext
    {
        public DataContext(): base ("DefaultConnection")
        {
               
        }

        public System.Data.Entity.DbSet<Zarate.Models.Fairy> Fairies { get; set; }
    }
}