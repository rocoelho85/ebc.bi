
using EBC.BuscaInsumo.Mvc.Areas.DoMyRecipe.Domain.Data;
using EBC.BuscaInsumo.Mvc.Areas.DoMyRecipe.Domain.Objects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace EBC.BuscaInsumo.Mvc.Areas.DoMyRecipe.Domain.Collections {
	public class StyleCollection {

		public List<Style> GetAllStyles() {
			List<Style> styles = new List<Style>();

			using (DoMyRecipeDataContextContainer context = new DoMyRecipeDataContextContainer()) {

				context.dmr_beerstyle.ToList().ForEach((beer_style) => {

					Style item = new Style();

					item.Name = beer_style.name;
					item.Category = beer_style.name;

					item.MaxABV = beer_style.max_abv;
					item.MaxCarb = beer_style.max_carb;
					item.MaxColor = beer_style.max_color;
					item.MaxFG = beer_style.max_fg;
					item.MaxIBU = beer_style.max_ibu;
					item.MaxOG = beer_style.max_og;

					item.MinABV = beer_style.min_abv;
					item.MinCarb = beer_style.min_carb;
					item.MinColor = beer_style.min_color;
					item.MinFG = beer_style.min_fg;
					item.MinIBU = beer_style.min_ibu;
					item.MinOG = beer_style.min_og;

					styles.Add(item);

				});

			}
			return styles;

		}


		private void ExtractAllStyles() {
			StylesRoot styles = null;
			XmlSerializer serializer = new XmlSerializer(typeof(StylesRoot));

			using (Stream xmlStyleFile = new FileStream(@"C:\xml\styles.xml", FileMode.Open)) {

				using (XmlReader xmlReader = XmlReader.Create(xmlStyleFile)) {

					styles = (StylesRoot)serializer.Deserialize(xmlReader);
				}

			}

			foreach (Style item in styles.Styles) {

				using (DoMyRecipeDataContextContainer context = new DoMyRecipeDataContextContainer()) {

					dmr_beerstyle beer_style = new dmr_beerstyle();

					beer_style.name = item.Name;
					beer_style.name = item.Category;

					beer_style.max_abv = item.MaxABV;
					beer_style.max_carb = item.MaxCarb;
					beer_style.max_color = item.MaxColor;
					beer_style.max_fg = item.MaxFG;
					beer_style.max_ibu = item.MaxIBU;
					beer_style.max_og = item.MaxOG;

					beer_style.min_abv = item.MinABV;
					beer_style.min_carb = item.MinCarb;
					beer_style.min_color = item.MinColor;
					beer_style.min_fg = item.MinFG;
					beer_style.min_ibu = item.MinIBU;
					beer_style.min_og = item.MinOG;


					context.dmr_beerstyle.Add(beer_style);

					context.SaveChanges();
				}
			}


		}

	}
}