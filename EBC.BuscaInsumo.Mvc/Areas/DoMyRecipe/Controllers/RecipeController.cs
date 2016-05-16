using EBC.BuscaInsumo.Mvc.Areas.DoMyRecipe.Domain;
using EBC.BuscaInsumo.Mvc.Areas.DoMyRecipe.Domain.Collections;
using EBC.BuscaInsumo.Mvc.Areas.DoMyRecipe.Domain.Objects;
using EBC.BuscaInsumo.Mvc.Areas.DoMyRecipe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace EBC.BuscaInsumo.Mvc.Areas.DoMyRecipe.Controllers {
	public class RecipeController : Controller {
		//
		// GET: /DoMyRecipe/Recipe/

		public ActionResult Index() {
			RecipeViewModel viewModel = new RecipeViewModel() {
				Styles = DoMyRecipeApi.GetAllStyles(),
				Grains = DoMyRecipeApi.GetAllGrains()
			};

			return View(viewModel);
		}


		public JsonResult GetSelectedStyle(int id) {

			Style style = DoMyRecipeApi.GetAllStyles().Find(obj => obj.Id.Equals(id));

			return Json(style, JsonRequestBehavior.AllowGet);
		}

		public JsonResult SearchGrain(string name) {
			return Json(DoMyRecipeApi.SearchGrains(name), JsonRequestBehavior.AllowGet);
		}
	}
}
