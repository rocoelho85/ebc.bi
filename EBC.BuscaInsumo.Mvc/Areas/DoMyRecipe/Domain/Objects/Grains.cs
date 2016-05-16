using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace EBC.BuscaInsumo.Mvc.Areas.DoMyRecipe.Domain.Objects {


	[XmlRoot("Grains")]
	public class GrainsRoot {

		[XmlElement("Grain")]
		public List<Grain> Grains { get; set; }

	}

	[Serializable]
	public class Grain {

		[XmlIgnore]
		public int Id {
			get;
			set;
		}


		[XmlElement(ElementName = "_MOD_")]
		public string Mod { get; set; }

		[XmlElement(ElementName = "F_G_NAME")]
		public string Name { get; set; }

		[XmlElement(ElementName = "F_G_ORIGIN")]
		public string Origin { get; set; }

		[XmlElement("F_G_TYPE")]
		public int Type { get; set; }

		[XmlElement("F_G_COLOR")]
		public decimal Color { get; set; }

		[XmlElement("F_G_YIELD")]
		public decimal Yield { get; set; }

		[XmlElement("F_G_LATE_EXTRACT")]
		public decimal LateExtract { get; set; }

		[XmlElement("F_G_PERCENT")]
		public decimal Percent { get; set; }
	
		[XmlElement("F_G_NOT_FERMENTABLE")]
		public int NotFermentable { get; set; }

		[XmlElement("F_G_COARSE_FINE_DIFF")]
		public decimal CoarseFineDiff { get; set; }

		[XmlElement("F_G_MOISTURE")]
		public decimal Moisture { get; set; }

		[XmlElement("F_G_DIASTATIC_POWER")]
		public decimal DiastaticPower { get; set; }

		[XmlElement("F_G_PROTEIN")]
		public decimal Protein { get; set; }

		[XmlElement("F_G_IBU_GAL_PER_LB")]
		public decimal IbuGALPerLB { get; set; }

		[XmlElement("F_G_ADD_AFTER_BOIL")]
		public decimal AddAfterBoil { get; set; }

		[XmlElement("F_G_RECOMMEND_MASH")]
		public decimal RecommendMash { get; set; }

		[XmlElement("F_G_MAX_IN_BATCH")]
		public decimal MaxInBatch { get; set; }

		[XmlElement("F_G_NOTES")]
		public string Notes { get; set; }

		[XmlElement("F_G_BOIL_TIME")]
		public decimal BoilTime { get; set; }

		[XmlElement("F_G_CONVERT_GRAIN")]
		public string ConvertGrain { get; set; }
	}
}