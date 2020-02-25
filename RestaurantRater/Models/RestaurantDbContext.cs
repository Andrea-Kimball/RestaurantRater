using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestaurantRater.Models
{
    //using entity framework we have inherited everything we need from Db Context
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext() : base("DefaultConnection")
        {

        }

        public DbSet<Restaurant> Restauranst { get; set; }

    }
}