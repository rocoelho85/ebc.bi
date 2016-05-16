using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace EBC.BuscaInsumo.Mvc.Areas.DoMyRecipe.Domain.Objects {


	[XmlRoot("Styles")]
	public class StylesRoot {

		[XmlElement("Style")]
		public List<Style> Styles { get; set; }

	}

	[Serializable]
	public class Style {

		[XmlIgnore]
		public int Id {
			get;
			set;
		}


		[XmlElement(ElementName = "_MOD_")]
		public string Mod { get; set; }

		[XmlElement(ElementName = "F_S_NAME")]
		public string Name { get; set; }

		[XmlElement(ElementName = "F_S_CATEGORY")]
		public string Category { get; set; }

		[XmlElement(ElementName = "F_S_MIN_OG")]
		public decimal MinOG { get; set; }

		[XmlElement(ElementName = "F_S_MAX_OG")]
		public decimal MaxOG { get; set; }

		[XmlElement(ElementName = "F_S_MIN_FG")]
		public decimal MinFG { get; set; }

		[XmlElement(ElementName = "F_S_MAX_FG")]
		public decimal MaxFG { get; set; }


		[XmlElement(ElementName = "F_S_MIN_IBU")]
		public decimal MinIBU { get; set; }

		[XmlElement(ElementName = "F_S_MAX_IBU")]
		public decimal MaxIBU { get; set; }


		[XmlElement(ElementName = "F_S_MIN_CARB")]
		public decimal MinCarb { get; set; }

		[XmlElement(ElementName = "F_S_MAX_CARB")]
		public decimal MaxCarb { get; set; }


		[XmlElement(ElementName = "F_S_MIN_COLOR")]
		public decimal MinColor { get; set; }

		[XmlElement(ElementName = "F_S_MAX_COLOR")]
		public decimal MaxColor { get; set; }

		[XmlElement(ElementName = "F_S_MIN_ABV")]
		public decimal MinABV { get; set; }

		[XmlElement(ElementName = "F_S_MAX_ABV")]
		public decimal MaxABV { get; set; }

	}
}