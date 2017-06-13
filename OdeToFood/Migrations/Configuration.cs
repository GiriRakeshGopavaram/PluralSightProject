namespace OdeToFood.Migrations
{
    using OdeToFood.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OdeToFood.Models.OdeToFoodDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(OdeToFood.Models.OdeToFoodDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Restaurants.AddOrUpdate(
              p => p.Name,
              new Restaurant { Name = "KFC", City = "Baltimore", Country = "USA" },

              new Restaurant
              {
                  Name = "McDonald's",
                  City = "Baltimore",
                  Country = "USA",
                  Reviews = new List<RestaurantReview> 
                  { 
                      new RestaurantReview{Rating=9,Body="Great Food, Good Service", ReviewerName="Rakesh Gopavaram"}
                  }
              });
        }
    }
}
