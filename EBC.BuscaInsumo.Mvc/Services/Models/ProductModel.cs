using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EBC.BuscaInsumo.Mvc.Services.Models {
	public class ProductModel {

		public int id { get; set; }

		public string link { get; set; }

		public string name { get; set; }

		public string description { get; set; }
		
		public double price { get; set; }

		public string image { get; set; }

		public DateTime extracted_date { get; set; }

		public string logo_image { get; set; }
	}
}