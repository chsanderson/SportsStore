using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SportsStore.Models;

namespace SportsStore.Models.ViewModels
{
    public class CartIndexViewModel
    {
        //this is the start of the creation of the cart index display
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}
