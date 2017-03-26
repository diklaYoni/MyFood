using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class RecipeBL
    {

        public List<Recipe> getRecipes()
        {
            RecipeDAL recipeDal = new RecipeDAL();
            return recipeDal.GetAllRecipes();

        }
    }
}
