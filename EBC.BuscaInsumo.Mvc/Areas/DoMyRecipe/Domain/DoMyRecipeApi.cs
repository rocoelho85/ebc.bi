using EBC.BuscaInsumo.Mvc.Areas.DoMyRecipe.Domain.Collections;
using EBC.BuscaInsumo.Mvc.Areas.DoMyRecipe.Domain.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EBC.BuscaInsumo.Mvc.Areas.DoMyRecipe.Domain {
	public class DoMyRecipeApi {

		public static List<Style> GetAllStyles() {

			StyleCollection styleCollection = new StyleCollection();
			return styleCollection.GetAllStyles();

		}

		public static List<Grain> GetAllGrains() {
			GrainCollection grainCollection = new GrainCollection();
			return grainCollection.GetAllGrains();
		}

		public static List<Grain> SearchGrains(string name) {
			GrainCollection grainCollection = new GrainCollection();
			return grainCollection.SearchGrains(name);
		}
	}
}