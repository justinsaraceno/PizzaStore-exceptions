using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStore.Models
{
    public class PizzaViewModel
    {
        public decimal PizzaCount { get; set; }
        public int SlicesPerPizza { get; set; }
        public int TotalSlices { get; set; }
    }
}