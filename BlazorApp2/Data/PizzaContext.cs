using BlazorApp2.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Data
{
    public class PizzaContext : DbContext
    {

        public PizzaContext(
         DbContextOptions options) : base(options)
        {
        }

        public DbSet<Pizza> Pizzas { get; set; }


    }

}
