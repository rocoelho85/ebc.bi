using EBC.BuscaInsumo.Mvc.Services;
using EBC.BuscaInsumo.Mvc.Services.Models;
using EBC.BuscaInsumo.Mvc.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EBC.BuscaInsumo.Mvc.Controllers {
	public class HomeController : Controller {
		//
		// GET: /Home/

		public ActionResult Index() {
			return View();
		}

		[HttpPost]
		public ActionResult Search(string terms) {

			List<ProductModel> products = ProductService.GetProductsFromSearch(terms);

			SearchViewModel model = new SearchViewModel() { model = products, terms = terms };

			if (products.Count.Equals(0))
				return View("NoResults", model);

			return View(model);
		}

	}
}
