using System;
using System.Collections.Generic;

namespace Models
{
    public class Order
    {
        public List<Dish> Dishes { get; set; }
        public int GeneralCookingTime  { get; set; }

        public Order()
        {
            Dishes = new List<Dish>();
        }
    }
}
