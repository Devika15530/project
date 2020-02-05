using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dmart.Models
{
    public class SellerContext: DbContext
    {

        public SellerContext(DbContextOptions<SellerContext> options) : base(options)
        {

        }

        public DbSet<Seller> SellerAccounts { get; set; }

    }
}
