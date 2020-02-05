using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dmart.Models;

namespace Dmart.Models
{
    public class SubCategoryContext:DbContext
    {

        public SubCategoryContext(DbContextOptions<SubCategoryContext> options) : base(options)
        {

        }

        public DbSet<Subcategories> subcatdata { get; set; }

        public DbSet<Dmart.Models.Buyer> Buyer { get; set; }

    }

    
}
