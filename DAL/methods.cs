using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    class methods
    {
        // variables
        MyFoodEntities mfeEntity = new MyFoodEntities();

        public List<Recipe> GetAllRecipes()
        {
            return mfeEntity.Recipe.ToList();
        }


        public Recipe GetRecipeByID(int nId)
        {
            Recipe recRecipe = mfeEntity.Recipe.Find(nId);
            return recRecipe;
        }
    }
}
