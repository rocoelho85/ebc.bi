using EBC.BuscaInsumo.Mvc.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EBC.BuscaInsumo.Mvc.Services.Data {
	public class DataProductModel {

		public static List<ProductModel> GetProductFromSearch(string terms) {

			string query = string.Format("SELECT buscainsumo.Product.*, buscainsumo.Source.image_name FROM buscainsumo.Product INNER JOIN buscainsumo.Source ON Product.source_id = Source.id WHERE buscainsumo.Product.name LIKE '%{0}%' order by price asc", terms);
			List<ProductModel> products = new List<ProductModel>();

			DataCommand.ExecuteSelect(query, (reader) => {
				products.Add(new ProductModel() {
					id = reader.GetInt32("id"),
					name = reader.GetString("name"),
					description = reader.GetString("description"),
					price = reader.GetDouble("price"),
					link = reader.GetString("link"),
					image = reader.GetString("image"),
					logo_image = reader.GetString("image_name")
				});
			});

			return products;
		}

	}
}