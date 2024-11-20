//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
using System.Data.Entity;

namespace FlowerWeb.Models
{
    public class AppDbContext: DbContext
    {
        public DbSet <Flower> flowers { get; set; }
        public AppDbContext () : base("name=DefaultConnection")
        {

        }
    }
}