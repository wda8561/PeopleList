using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PeopleList.Models
{
    public class PeopleContext: DbContext
    {
        public DbSet<People> People { get; set; }
    }
}