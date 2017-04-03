
using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RecipeDAL
    {
        public IEnumerable<Recipe> GetAllRecipes()
        {
            using (MyFoodEntities mfeEntity = new MyFoodEntities())
            {
                if (mfeEntity.Recipe.Count() > 0)
                {
                    return mfeEntity.Recipe.AsEnumerable<Recipe>();
                }
                else
                {
                    return new List<Recipe>().AsEnumerable <Recipe>();
                }
            }
        }


    }
}
