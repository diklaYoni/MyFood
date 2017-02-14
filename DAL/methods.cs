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

        /// <summary>
        /// Add new user to the system
        /// </summary>
        /// <param name="strEmail"> user email </param>
        /// <param name="strPassword"> user password </param>
        /// <param name="strName"> user name </param>
        /// <param name="strGender"> user gender </param>
        /// <returns> return if the user added or not </returns>
        public bool AddUser(string strEmail, string strPassword, string strName, string strGender)
        {
            bool bIsAdded = false;

            if ((strEmail != String.Empty) && (strPassword != String.Empty) && (strName != String.Empty) && (strGender != String.Empty))
            {
                User usrUser = new User();
                usrUser.EMAIL = strEmail;
                usrUser.Password = strPassword;
                usrUser.Name = strName;

                ////////  why gender is bool???
                //usrUser.Gender = strGender;

                mfeEntity.User.Add(usrUser);
                bIsAdded = true;
            }

            return bIsAdded;
        }
    }
}
