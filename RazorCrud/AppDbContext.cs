using System;
using Microsoft.EntityFrameworkCore;
namespace RazorCrud
{
    public class AppDbContext : DbContext

    {
        public AppDbContext(DbContextOptions options) 
            : base(options)
            {

            }

        //create a list of customers
        public DbSet<Customer> Customers { get; set; }

    }
}