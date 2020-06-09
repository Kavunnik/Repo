using System;
using System.Collections.Generic;
using DAL;
using Models;

namespace BLL
{
    public class MakeOrder
    {

        public int Make(List<Dish> dishes)
        {
            Order order = new Order();
            order.Dishes = dishes;
            int finalResult = 0;
            foreach (var dish in dishes)
            {
                foreach (var cook in Kitchen.Cooks)
                {
                    if (dish.Specialization == cook.Specialization)
                    {
                        cook.TimeToBecomeFree += dish.CookingTime;
                        break;
                    }
                }
            }



            foreach (var cook in Kitchen.Cooks)
            {
                if (finalResult < cook.TimeToBecomeFree)
                {
                    finalResult = cook.TimeToBecomeFree;
                }
            }

            order.GeneralCookingTime = finalResult;
            return finalResult;
        }
    }
}