using EBC.BuscaInsumo.Mvc.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EBC.BuscaInsumo.Mvc.Services {
	public class ProductService {

		public static List<ProductModel> GetProductsFromSearch(string terms) {
			return Data.DataProductModel.GetProductFromSearch(terms);
		}

	}
}