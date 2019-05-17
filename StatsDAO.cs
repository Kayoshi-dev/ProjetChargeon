/*
 * Date de création : 26/03/2019
 * Dernière modification : 27/04/2019
 * Équipe : Nathouuuu
 * Rôle : Fichier de classe contenant toute les méthodes permettant des actions sur les statistiques
 * Développeur : Nathan
*/

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetChargeon
{
	class StatsDAO
	{
		private MySqlConnection connection;

		public StatsDAO()
		{
			var ConnectObject = new DBConnect();
			this.connection = ConnectObject.GetConnection(); //On récupère la valeur de Connection grâce à la méthode GetConnection.
		}

		public DataSet SelectDetailsStats(string idSelected)
		{
			string query = "SELECT Stats_Titre, Stats_Date, Stats_PuisAbs, Stats_Duree FROM Stats, Bornes WHERE Borne_Id = Stats_NoBorne AND Stats_Id = @id";

			MySqlCommand req = new MySqlCommand(query, connection);

			req.Parameters.Clear();
			req.Parameters.Add(new MySqlParameter("@id", idSelected));

			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataSet listeDetailsStats = new DataSet();

			adapter.SelectCommand = req;
			adapter.Fill(listeDetailsStats);

			adapter.Dispose();
			req.Dispose();

			return listeDetailsStats;
		}
	}
}
