using BE;
using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace MyFood.Server
{
    [RoutePrefix("api/recipes")]
    public class RecipeController : ApiController
    {
        [ResponseType(typeof(Recipe))]
        [HttpGet]
        [Route("")]
        public IEnumerable<Recipe> getAllRecipes()
        {
            RecipeBL recipeBl = new RecipeBL();
            return recipeBl.getRecipes();
        }

    }
}
