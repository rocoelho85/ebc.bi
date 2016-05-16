using EBC.BuscaInsumo.Mvc.Areas.DoMyRecipe.Domain.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EBC.BuscaInsumo.Mvc.Areas.DoMyRecipe.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /DoMyRecipe/Home/

        public ActionResult Index()
        {
            return View();
        }

		public ActionResult New() {

			IList<Style> styles = DoMyRecipe.Domain.DoMyRecipeApi.GetAllStyles();

			return View(styles);
		}
    }
}
