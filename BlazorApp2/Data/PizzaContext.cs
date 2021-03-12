using BlazorApp2.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Data
{
    public class PizzaContext : IdentityDbContext
    {

        public PizzaContext(
         DbContextOptions options) : base(options)
        {
        }

        public DbSet<Pizza> Pizzas { get; set; }


    }

}
