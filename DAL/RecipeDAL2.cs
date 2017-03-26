using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RecipeDAL2
    {
        public List<Recipe> GetAllRecipes()
        {
            using (MyFoodEntities mfeEntity = new MyFoodEntities())
            {
                return mfeEntity.Recipe.ToList();
            }
              
        }



    }
}
