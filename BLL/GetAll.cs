using System.Collections.Generic;
using DAL;
using Models;

namespace BLL
{
    public class GetAll
    {
        public List<Dish> Dishes => Kitchen.Dishes;
    }
}