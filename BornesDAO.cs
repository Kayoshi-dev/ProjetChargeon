/* 
* Date de création : 17/04/2019
* Dernière modification : 23/04/2019
* Équipe : Nathouuuu
* Rôle : Cette classe comporte différentes méthodes permettant d'obtenir des informations sur différentes bornes
* Développeurs : Nathan, Maxime
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetChargeon
{
	class BornesDAO
	{
		private MySqlConnection connection;

		public BornesDAO() 
		{
			var ConnectObject = new DBConnect();
			this.connection = ConnectObject.GetConnection(); //On récupère la valeur de Connection grâce à la méthode GetConnection.
		}

		/* Il est surement possible de tout *
		 * grouper en une seule méthode *
		 * il faut y réfléchir */

        //Cette méthode permet d'obtenir l'ID et la Ref pour remplir la ComboBox
		public DataSet SelectBornes()
		{
			string query = "SELECT Borne_Id, Borne_Ref FROM bornes";

			MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
			DataSet listeBornes = new DataSet();

			da.Fill(listeBornes, "Borne");

			return listeBornes;
		}

		//Cette méthode récupère quant à elle les autres champs de la base de données, tout en s'adaptant à l'ID selectionné
		public DataSet SelectDetailsBornes(string idSelected)
		{
			string query = "SELECT * FROM bornes WHERE Borne_Id = @id";

			MySqlCommand req = new MySqlCommand(query, connection);

			req.Parameters.Clear();
			req.Parameters.Add(new MySqlParameter("@id", idSelected));

			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataSet listeDetailsBornes = new DataSet();

			adapter.SelectCommand = req;
			adapter.Fill(listeDetailsBornes);

			adapter.Dispose();
			req.Dispose();

			return listeDetailsBornes;
		}

        // Cette méthode récupère les données pour la page Gestion des Bornes
        public DataSet SelectMoreDetailsBornes(string idSelected)
        {
            string query = "SELECT Borne_Id, Borne_Desc, Borne_NS, Borne_Type, Borne_Etat, Borne_Puis, Borne_Prio, Site_Nom, Cli_Nom FROM bornes, site, client WHERE Site_NoZone = Borne_NoSite AND Cli_Id = Borne_NoCli AND Borne_Id = @id";

            MySqlCommand req = new MySqlCommand(query, connection);

            req.Parameters.Clear();
            req.Parameters.Add(new MySqlParameter("@id", idSelected));

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet listeMoreDetailsBornes = new DataSet();

            adapter.SelectCommand = req;
            adapter.Fill(listeMoreDetailsBornes);

            adapter.Dispose();
            req.Dispose();

            return listeMoreDetailsBornes;
        }

        public DataSet SelectCityForBornes(string idSelected) 
		{
			string query = "SELECT Site_Ville FROM site, bornes WHERE Borne_NoSite = Site_Id AND Borne_Id = @idSelected";

			MySqlCommand req = new MySqlCommand(query, connection);

			req.Parameters.Clear();
			req.Parameters.Add(new MySqlParameter("@idSelected", idSelected));

			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataSet cityForBorne = new DataSet();

			adapter.SelectCommand = req;
			adapter.Fill(cityForBorne);

			adapter.Dispose();
			req.Dispose();

			return cityForBorne;
		}

		public DataSet SelectBornesCustomer(int idAccount)
		{
			string query = "SELECT * FROM bornes WHERE Borne_NoCli = @idAccount";

			MySqlCommand req = new MySqlCommand(query, connection);

			req.Parameters.Clear();
			req.Parameters.Add(new MySqlParameter("@idAccount", idAccount));

			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataSet listeBornesClient = new DataSet();

			adapter.SelectCommand = req;
			adapter.Fill(listeBornesClient);

			adapter.Dispose();
			req.Dispose();

			return listeBornesClient;
		}

        // Cette méthode récupère les données pour la page CRUD Borne (Modifier une Borne)
        public DataSet SelectDetailsBornesForCRUD(string idSelected)
        {
            string query = "SELECT Site_Nom, Cli_Nom, Borne_Id, Borne_Ref, Borne_NS, Borne_Desc, Borne_Type, Borne_Etat, Borne_Puis, Borne_Prio FROM site, client, bornes WHERE Borne_NoSite = Site_Id AND Borne_NoCli = Cli_Id AND Borne_Id = @id";

            MySqlCommand req = new MySqlCommand(query, connection);

            req.Parameters.Clear();
            req.Parameters.Add(new MySqlParameter("@id", idSelected));

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet listeDetailsBornesForCRUD = new DataSet();

            adapter.SelectCommand = req;
            adapter.Fill(listeDetailsBornesForCRUD);

            adapter.Dispose();
            req.Dispose();

            return listeDetailsBornesForCRUD;
        }

        // Cette méthode permet d'ajouter une nouvelle Borne à la BDD
        public bool InsertBorne(int noSite, int noClient, string refBorne, string descBorne, string nsBorne, int typeBorne, int etatBorne, string puisBorne, int prioBorne)
        {
            string query = "INSERT INTO bornes (Borne_NoSite, Borne_NoCli, Borne_Ref, Borne_Desc, Borne_NS, Borne_Type, Borne_Etat, Borne_Puis, Borne_Prio) VALUES (@site, @client, @ref, @desc, @ns, @type, @etat, @puis, @prio)";
            bool validate = false;

            MySqlCommand req = new MySqlCommand(query, connection);

            req.Parameters.Clear();
            req.Parameters.Add(new MySqlParameter("@site", noSite));
            req.Parameters.Add(new MySqlParameter("@client", noClient));
            req.Parameters.Add(new MySqlParameter("@ref", refBorne));
            req.Parameters.Add(new MySqlParameter("@desc", descBorne));
            req.Parameters.Add(new MySqlParameter("@ns", nsBorne));
            req.Parameters.Add(new MySqlParameter("@type", typeBorne));
            req.Parameters.Add(new MySqlParameter("@etat", etatBorne));
            req.Parameters.Add(new MySqlParameter("@puis", puisBorne));
            req.Parameters.Add(new MySqlParameter("@prio", prioBorne));

            connection.Open();

            req.ExecuteNonQuery();

            connection.Close();

            validate = true;

            return validate;
        }

        // Cette méthode permet de mettre à jour une Borne sélectionnée
        public bool UpdateBorne(int noSite, int noClient, string refBorne, string descBorne, string nsBorne, int typeBorne, int etatBorne, string puisBorne, int prioBorne, string idBorne)
        {
            string query = "Update bornes SET Borne_NoSite = @site, Borne_NoCli = @client, Borne_Ref = @ref, Borne_Desc = @desc, Borne_NS = @ns, Borne_Type = @type, Borne_Etat = @etat, Borne_Puis = @puis, Borne_Prio = @prio WHERE Borne_Id = @id";
            bool validate = false;

            MySqlCommand req = new MySqlCommand(query, connection);

            req.Parameters.Clear();
            req.Parameters.Add(new MySqlParameter("@site", noSite));
            req.Parameters.Add(new MySqlParameter("@client", noClient));
            req.Parameters.Add(new MySqlParameter("@ref", refBorne));
            req.Parameters.Add(new MySqlParameter("@desc", descBorne));
            req.Parameters.Add(new MySqlParameter("@ns", nsBorne));
            req.Parameters.Add(new MySqlParameter("@type", typeBorne));
            req.Parameters.Add(new MySqlParameter("@etat", etatBorne));
            req.Parameters.Add(new MySqlParameter("@puis", puisBorne));
            req.Parameters.Add(new MySqlParameter("@prio", prioBorne));
            req.Parameters.Add(new MySqlParameter("@id", idBorne));

            connection.Open();

            req.ExecuteNonQuery();

            connection.Close();

            validate = true;

            return validate;
        }

        // Cette méthode permet de supprimer une borne dans la BDD
        public bool DeleteBorne(string idSelected)
        {
            bool validate = false;

            string query = "DELETE FROM assistance WHERE Assist_NoBorne = @id";
            string query2 = "DELETE FROM stats WHERE Stats_NoBorne = @id";
            string query3 = "DELETE FROM facture WHERE Fact_IdBorne = @id";
            string query4 = "DELETE FROM bornes WHERE Borne_Id = @id";
            

            MySqlCommand req = new MySqlCommand(query, connection);
            MySqlCommand req2 = new MySqlCommand(query2, connection);
            MySqlCommand req3 = new MySqlCommand(query3, connection);
            MySqlCommand req4 = new MySqlCommand(query4, connection);

            req.Parameters.Clear();
            req.Parameters.Add(new MySqlParameter("@id", idSelected));

            req2.Parameters.Clear();
            req2.Parameters.Add(new MySqlParameter("@id", idSelected));

            req3.Parameters.Clear();
            req3.Parameters.Add(new MySqlParameter("@id", idSelected));

            req4.Parameters.Clear();
            req4.Parameters.Add(new MySqlParameter("@id", idSelected));

            connection.Open();

            req.ExecuteNonQuery();
            req2.ExecuteNonQuery();
            req3.ExecuteNonQuery();
            req4.ExecuteNonQuery();

            connection.Close();

            validate = true;

            return validate;
        }

        // Cette méthode permet d'obtenir les données des Statistiques en fonction d'une borne sélectionnée
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