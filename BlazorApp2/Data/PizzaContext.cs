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


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("public");

            builder.Entity<AppUser>()
                    .HasMany(c => c.MinhasPizzas)
                    .WithOne(c => c.Usuario)
                    .HasForeignKey(c => c.AppUserId);

            builder.Entity<Pizza>()
                .HasMany(c => c.Usuarios)
                .WithOne(c => c.Pizza)
                .HasForeignKey(c => c.PizzaId);

            // builder.Entity<AppUserPizza>();

            base.OnModelCreating(builder);
        }

        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<AppUser> Usuarios { get; set; }


    }

}
