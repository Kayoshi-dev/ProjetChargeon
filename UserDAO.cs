/* 
 * Date de création : 20/04/2019
 * Dernière modification : 20/04/2019
 * Équipe : Nathouuuu
 * Rôle : Fichier de class contenant différentes méthodes concernant l'utilisateur
 * Développeurs : Maxime, Nathan
 */

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetChargeon
{
    class UserDAO
    {
		private MySqlConnection connection;
		public static int idAccount;

		public UserDAO() 
		{
			var ConnectObject = new DBConnect();
			this.connection = ConnectObject.GetConnection(); //On récupère la valeur de Connection grâce à la méthode GetConnection.
		}

		public void RetrieveCustomerId(string username) 
		{
			string query = "SELECT Cli_Id FROM connexion, client WHERE Co_Login = @username AND Co_Id = Cli_NoCo";
			MySqlCommand req = new MySqlCommand(query, connection);

			req.Parameters.Clear();
			req.Parameters.AddWithValue("@username", username);

			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataSet DataId = new DataSet();

			adapter.SelectCommand = req;
			adapter.Fill(DataId); 
			
			adapter.Dispose();
			req.Dispose();

			int id = Convert.ToInt32(DataId.Tables[0].Rows[0].ItemArray[0]);
			idAccount = id;
		}

		public int GetId() 
		{
			return idAccount;
		}

		// Cette méthode permet d'obtenir l'ID et les noms des clients dans la ComboBox
		public DataSet SelectClients()
		{
			string query = "SELECT Cli_Id, Cli_Nom FROM client";

			MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
			DataSet listeClients = new DataSet();

			adapter.Fill(listeClients);

			adapter.Dispose();

			return listeClients;
		}

		// Cette méthode permet d'obtenir les données des Clients en fonction du client sélectionné
		public DataSet SelectDetailsClient(string idSelected)
		{
			string query = "SELECT * FROM client WHERE Cli_Id = @id";

			MySqlCommand req = new MySqlCommand(query, connection);

			req.Parameters.Clear();
			req.Parameters.Add(new MySqlParameter("@id", idSelected));

			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataSet listeDetailsClient = new DataSet();

			adapter.SelectCommand = req;
			adapter.Fill(listeDetailsClient);

			adapter.Dispose();
			req.Dispose();

			return listeDetailsClient;
		}


		/* Méthodes pour le CRUD Client */

		// Cette méthode permet d'ajouter un Client
		public bool InsertClient(string nomClient, string adresseClient, int cpClient, string villeClient)
		{
			string query = "INSERT INTO client (Cli_Nom, Cli_Adre, Cli_CP, Cli_Ville) VALUES ('@nom', '@adresse', @cp, '@ville')";
			bool validate = false;

			MySqlCommand req = new MySqlCommand(query, connection);

			req.Parameters.Clear();
			req.Parameters.Add(new MySqlParameter("@nom", nomClient));
			req.Parameters.Add(new MySqlParameter("@adresse", adresseClient));
			req.Parameters.Add(new MySqlParameter("@cp", cpClient));
			req.Parameters.Add(new MySqlParameter("@ville", villeClient));
			req.ExecuteNonQuery(); // Si je met cette ligne, cela fait l'erreur suivante : "System.InvalidOperationException : 'Connection must be valid and open.'"

			validate = true;

			return validate;
		}

		public bool UpdateCustomer(string idCustomer, string nom, string adresse, string cp, string ville)
		{
			bool test;
			try {
				string query = "UPDATE client SET Cli_Nom = @nom, Cli_Adre = @adresse, Cli_CP = @cp, Cli_Ville = @ville WHERE Cli_Id = @idCustomer";

				MySqlCommand req = new MySqlCommand(query, connection);

				req.Parameters.Clear();
				req.Parameters.Add(new MySqlParameter("@idCustomer", idCustomer));
				req.Parameters.Add(new MySqlParameter("@nom", nom));
				req.Parameters.Add(new MySqlParameter("@adresse", adresse));
				req.Parameters.Add(new MySqlParameter("@cp", cp));
				req.Parameters.Add(new MySqlParameter("@ville", ville));

				connection.Open();

				req.ExecuteNonQuery();

				connection.Close();

				test = true;
				return test;
			} 
			catch (MySqlException e) 
			{
				test = false;
				return test;
			}
			
		}

		// A Réfléchir : Pour la requête SQL Update, une méthode pour chaque champ de texte ou un méthode pour l'ensemble des champs

		// Cette méthode permet de supprimer un Client
		public bool DeleteClient(string idSelected)
		{
			string query = "DELETE FROM client WHERE Cli_Id = @id";
			bool validate = false;

			MySqlCommand req = new MySqlCommand(query, connection);

			req.Parameters.Clear();
			req.Parameters.Add(new MySqlParameter("@id", idSelected));
			req.ExecuteNonQuery(); // Si je met cette ligne, cela fait l'erreur suivante : "System.InvalidOperationException : 'Connection must be valid and open.'"

			validate = true;

			return validate;
		}

	}
}
