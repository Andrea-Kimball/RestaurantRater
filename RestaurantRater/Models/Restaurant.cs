using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantRater.Models
{
    public class Restaurant
    {
        //Primary key is the first item in the list unless otherwise defined
        //look up other annotations
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Style { get; set; }
        [Required]
        [Range(0d, 5d)]
        public string Name { get; set; }
        [Required]
        public double Rating { get; set; }
        [Required]
        [Range(1,5)]
        public int DollaSigns { get; set; }
    }
}