using System.Web.Mvc;

namespace EBC.BuscaInsumo.Mvc.Areas.DoMyRecipe {
	public class DoMyRecipeAreaRegistration : AreaRegistration {
		public override string AreaName {
			get {
				return "DoMyRecipe";
			}
		}

		public override void RegisterArea(AreaRegistrationContext context) {
			context.MapRoute(
				"DoMyRecipe_default",
				"DoMyRecipe/{controller}/{action}/{id}",
				new { controller = "Home", action = "Index", id = UrlParameter.Optional },
				namespaces: new string[] { "EBC.BuscaInsumo.Mvc.Areas.DoMyRecipe.Controllers" }
			);
		}
	}
}
