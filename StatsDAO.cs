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
			string query = "SELECT Stats_Titre, Stats_Date, Stats_PuisAbs, Stats_Duree FROM Stats, Bornes WHERE Stats_Id = Borne_NoStat AND Borne_NoStat = @id";

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
