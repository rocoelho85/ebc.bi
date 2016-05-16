using EBC.BuscaInsumo.Mvc.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EBC.BuscaInsumo.Mvc.ViewModels {
	public class SearchViewModel {
		public IEnumerable<ProductModel> model { get; set; }
		public string terms { get; set; }
	}
}