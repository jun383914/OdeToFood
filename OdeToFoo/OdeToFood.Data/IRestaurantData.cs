using OdeToFood.core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantByName(string name);
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Pizza", Location = "Washington", Cuisine = CuisineType.Italian },
                new Restaurant { Id = 2, Name = "Buritto", Location = "New York", Cuisine = CuisineType.Mexico },
                new Restaurant { Id = 3, Name = "Curry", Location = "Los Angeles", Cuisine = CuisineType.Indian },
            };
        }

        public IEnumerable<Restaurant> GetRestaurantByName(string name=null)
        {
            return from r in restaurants
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Name
                   select r;
        }
    }
}
