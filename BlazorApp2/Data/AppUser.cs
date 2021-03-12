using BlazorApp2.Model;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Data
{
    public class AppUser : IdentityUser
    {
        public virtual ICollection<Pizza> MinhasPizzas { get; set; }
    }
}
