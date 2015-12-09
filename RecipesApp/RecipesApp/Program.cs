using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (RecipesEntities context = new RecipesEntities())
            {
                /* Recipe recipe = new Recipe
                {
                    Name = "Chicken Salad"
                };*/
               // List<String> strings = new List<String>();
                //strings.Add("ASDF");
               // context.Recipes.Add(recipe);
                Recipe recipe = context.Recipes.FirstOrDefault(r => r.Name == "Chicken Salad");
                Console.WriteLine(recipe.Id);
                Console.Read();
                //context.SaveChanges();
                //adding an object to my recipes collection not adding a column to a database
            }

        }
    }
}
