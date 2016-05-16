using EBC.BuscaInsumo.Mvc.Areas.DoMyRecipe.Domain.Data;
using EBC.BuscaInsumo.Mvc.Areas.DoMyRecipe.Domain.Objects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace EBC.BuscaInsumo.Mvc.Areas.DoMyRecipe.Domain.Collections {
	public class GrainCollection {


		public List<Grain> SearchGrains(string name) {

			List<Grain> grains = new List<Grain>();

			if (string.IsNullOrEmpty(name))
				return grains;

			using (DoMyRecipeDataContextContainer context = new DoMyRecipeDataContextContainer()) {

				foreach (var item in context.dmr_beergrain.ToList().FindAll(obj => obj.name.ToLower().Contains(name.ToLower()))) {

					grains.Add(CreateGrainObject(item));

				}
			}

			return grains;

		}

		public List<Grain> GetAllGrains() {
			List<Grain> grains = new List<Grain>();

			using (DoMyRecipeDataContextContainer context = new DoMyRecipeDataContextContainer()) {
				context.dmr_beergrain.ToList().ForEach((item) => {
					Grain grain = CreateGrainObject(item);

					grains.Add(grain);
				});
			}
			return grains;
		}

		private static Grain CreateGrainObject(dmr_beergrain item) {
			Grain grain = new Grain();

			grain.Id = item.id;
			grain.Name = item.name;
			grain.Origin = item.origin;
			grain.AddAfterBoil = item.add_after_boil;
			grain.BoilTime = item.boil_time;
			grain.CoarseFineDiff = item.coarse_fine_diff;
			grain.Color = item.color;
			grain.ConvertGrain = item.convert_grain;
			grain.DiastaticPower = item.diastatic_power;
			grain.IbuGALPerLB = item.ibu_gal_per_lb;
			grain.LateExtract = item.late_extract;
			grain.MaxInBatch = item.max_in_batch;
			grain.Moisture = item.moisture;
			grain.NotFermentable = item.not_fermentable;
			grain.Notes = item.notes;
			grain.Percent = item.percent;
			grain.Protein = item.protein;
			grain.RecommendMash = item.recommend_mash;
			grain.Type = item.type;
			grain.Yield = item.yield;
			return grain;
		}

		private void ExtractGrains() {
			GrainsRoot styles = null;
			XmlSerializer serializer = new XmlSerializer(typeof(GrainsRoot));

			using (Stream xmlStyleFile = new FileStream(@"C:\xml\grains.xml", FileMode.Open)) {

				using (XmlReader xmlReader = XmlReader.Create(xmlStyleFile)) {

					styles = (GrainsRoot)serializer.Deserialize(xmlReader);
				}

			}

			foreach (Grain item in styles.Grains) {

				using (DoMyRecipeDataContextContainer context = new DoMyRecipeDataContextContainer()) {

					dmr_beergrain beer_grain = new dmr_beergrain();

					beer_grain.name = item.Name;

					beer_grain.origin = item.Origin;
					beer_grain.add_after_boil = item.AddAfterBoil;
					beer_grain.boil_time = item.BoilTime;
					beer_grain.coarse_fine_diff = item.CoarseFineDiff;
					beer_grain.color = item.Color;
					beer_grain.convert_grain = item.ConvertGrain;
					beer_grain.diastatic_power = item.DiastaticPower;
					beer_grain.ibu_gal_per_lb = item.IbuGALPerLB;
					beer_grain.late_extract = item.LateExtract;
					beer_grain.max_in_batch = item.MaxInBatch;
					beer_grain.moisture = item.Moisture;
					beer_grain.not_fermentable = item.NotFermentable;
					beer_grain.notes = item.Notes;
					beer_grain.percent = item.Percent;
					beer_grain.protein = item.Protein;
					beer_grain.recommend_mash = item.RecommendMash;
					beer_grain.type = item.Type;
					beer_grain.yield = item.Yield;

					context.dmr_beergrain.Add(beer_grain);

					context.SaveChanges();
				}
			}


		}
	}
}