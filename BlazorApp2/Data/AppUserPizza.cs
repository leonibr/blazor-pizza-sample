using BlazorApp2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Data
{
    public class AppUserPizza
    {
        public int AppUserPizzaId { get; set; }
        public string AppUserId { get; set; }
        public int PizzaId { get; set; }

        public virtual Pizza Pizza { get; set; }
        public virtual AppUser Usuario { get; set; }

        public DateTime DataCompra { get; set; }
    }
}
