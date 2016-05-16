using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace EBC.BuscaInsumo.Mvc.Services.Data {
	public static class DataCommand {

		private static void Initialize() {
			connectionString = ConfigurationManager.ConnectionStrings["BuscaInsumo"].ToString();
		}
		private static string connectionString = string.Empty;

		public static void ExecuteSelect(string query, Action<MySqlDataReader> loadAction) {
			Initialize();

			MySqlConnection connection = null;
			try {

				connection = new MySqlConnection(connectionString);

				connection.Open();

				MySqlCommand command = connection.CreateCommand();
				command.CommandText = query;

				MySqlDataReader reader = command.ExecuteReader();
				while (reader.Read()) {
					loadAction(reader);
				}
			} catch (Exception) {

				throw;
			} finally {
				connection.Close();
			}
		}

		public static void Execute(string query) {
			Initialize();
			MySqlConnection connection
					= new MySqlConnection(connectionString);

			try {

				connection.Open();

				MySql.Data.MySqlClient.MySqlCommand command = connection.CreateCommand();

				command.CommandText = query;
				command.ExecuteNonQuery();

			} catch (Exception) {

				throw;
			} finally {
				connection.Close();
			}
		}

	}
}