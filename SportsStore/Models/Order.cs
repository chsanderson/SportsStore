using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace SportsStore.Models
{
    //This allows carts to become orders

    public class Order
    {
        [BindNever] //these prevent the user from supplying these values via a HTTPRequest
        public int OrderID { get; set; }
        [BindNever] //these prevent the user from supplying these values via a HTTPRequest
        public ICollection<CartLine> Lines { get; set; }

        [BindNever]//this is for enhancing for the administrator view
        public bool Shipped { get; set; }

        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Please enter the first address line")]
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }

        [Required(ErrorMessage = "Please enter a city name")]
        public string City { get; set; }

        //[Required(ErrorMessage = "Please enter a state name")]
        public string State { get; set; }
        
        public string Zip { get; set; }

        [Required(ErrorMessage = "Please enter a country name")]
        public string Country { get; set; }
        
        public bool GiftWrap { get; set; }
    }
}
