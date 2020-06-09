using System;
using System.Collections.Generic;
using System.Configuration;
using Models;

namespace DAL
{
    public static class Kitchen
    {
        public static List<Dish> Dishes { get; private set; }
        public static List<Cook> Cooks { get; private set; }
        public static List<Order> Orders { get; private set; }
        static Kitchen()
        { 
            var a = ConfigurationManager.AppSettings.Get("DishConnection");
            var b = ConfigurationManager.AppSettings.Get("CookConnection");
            Serialization<List<Dish>> serDish = new Serialization<List<Dish>>(a, null);
            Serialization<List<Cook>> serCook = new Serialization<List<Cook>>(b, null);

            Cooks = serCook.Deserialize();
            Dishes = serDish.Deserialize();

            //Dishes = new List<Dish>();
            //Cooks =  new List<Cook>();
            //Orders = new List<Order>();

            //Cook cook1 = new Cook
            //{
            //    Name = "John Doe",
            //    Specialization = "meat-master",
            //    TimeToBecomeFree = 0
            //};

            //Cook cook2 = new Cook
            //{
            //    Name = "George Floyd",
            //    Specialization = "sushi-master",
            //    TimeToBecomeFree = 0
            //};

            //Cooks.Add(cook1);
            //Cooks.Add(cook2);

            //Dish dish1 = new Dish
            //{
            //    CookingTime = 15,
            //    Name = "Sushi California",
            //    Specialization = "sushi-master"
            //};

            //Dish dish2 = new Dish
            //{
            //    CookingTime = 20,
            //    Name = "Sushi Philadelphia",
            //    Specialization = "sushi-master"
            //};

            //Dish dish3 = new Dish
            //{
            //    CookingTime = 30,
            //    Name = "Steak",
            //    Specialization = "meat-master"
            //};

            //Dish dish4 = new Dish
            //{
            //    CookingTime = 25,
            //    Name = "Sausages",
            //    Specialization = "meat-master"
            //};

            //Dishes.Add(dish1);
            //Dishes.Add(dish2);
            //Dishes.Add(dish3);
            //Dishes.Add(dish4);
            //Serialization<List<Dish>> serDish = new Serialization<List<Dish>>(@"", Dishes);
            //Serialization<List<Cook>> serCook = new Serialization<List<Cook>>(@"", Cooks);

            //serDish.Serialize();
            //serCook.Serialize();
        }
    }
}