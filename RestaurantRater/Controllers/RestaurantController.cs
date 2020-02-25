using RestaurantRater.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace RestaurantRater.Controllers
{
    //Db set is a snapshot of the database
    public class RestaurantController : ApiController
    {
        //create a field so that we can make changes to the database without messing up the actual database
        private readonly RestaurantDbContext _context = new RestaurantDbContext();
        //return status codes
        //POST
        public async Task<IHttpActionResult> PostRestaurant(Restaurant restaurant)
        {   //ModelState is a property from API controller
            if (ModelState.IsValid && restaurant != null)
            {
                _context.Restaurants.Add(restaurant);
                //apply changes to database
                await _context.SaveChangesAsync();
                return Ok();
            }           //ModelState will pass back all the errors
            return BadRequest(ModelState);
        }

        //GET ALL
        public async Task<IHttpActionResult> GetAll()
        {
            List<Restaurant> allRestaurants = await _context.Restaurants.ToListAsync();
            return Ok(allRestaurants);
        }

        //GET BY ID
        public async Task<IHttpActionResult> GetById(int Id)
        {
            Restaurant restaurant = await _context.Restaurants.FindAsync(Id);
            if(restaurant == null)
            {
                return NotFound();
            }
            return Ok(restaurant);
        }

        //PUT (update)

        //DELETE BY ID
    }
}
