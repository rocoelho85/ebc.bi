using EBC.BuscaInsumo.Mvc.Areas.DoMyRecipe.Domain.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EBC.BuscaInsumo.Mvc.Areas.DoMyRecipe.Models {
	public class RecipeViewModel {


		public string SelectedStyle { get; set; }
		public List<Style> Styles { get; set; }

		public List<Grain> Grains { get; set; }

	}
}