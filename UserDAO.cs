/* 
 * Date de création : 18/03/2019
 * Dernière modification : 27/04/2019
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

		// Cette méthode permet d'ajouter un Client
		public bool InsertCustomer(string nomClient, string adresseClient, string cpClient, string villeClient)
		{
			bool validate = false;

			try 
			{
				string query = "INSERT INTO client (Cli_Nom, Cli_Adre, Cli_CP, Cli_Ville) VALUES (@nom, @adresse, @cp, @ville)";

				MySqlCommand req = new MySqlCommand(query, connection);

				//Bind Value des paramètres.
				req.Parameters.Clear();
				req.Parameters.Add(new MySqlParameter("@nom", nomClient));
				req.Parameters.Add(new MySqlParameter("@adresse", adresseClient));
				req.Parameters.Add(new MySqlParameter("@cp", cpClient));
				req.Parameters.Add(new MySqlParameter("@ville", villeClient));

				connection.Open();

				req.ExecuteNonQuery();

				connection.Close();

				validate = true;

				return validate;
			}
			catch(MySqlException e) 
			{
				return validate;
			}
		}

		// Méthode de mise à jour d'un client
		public bool UpdateCustomer(string idCustomer, string nom, string adresse, string cp, string ville)
		{
			bool validate = false;

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

				validate = true;
				return validate;
			} 
			catch (MySqlException e) 
			{
				return validate;
			}
		}

		// Méthode de suppression d'un compte client
		public bool DeleteCustomer(string idSelected)
		{
			bool validate = false;
			
			try
			{
				string query = "DELETE FROM client WHERE Cli_Id = @id";

				MySqlCommand req = new MySqlCommand(query, connection);

				req.Parameters.Clear();
				req.Parameters.Add(new MySqlParameter("@id", idSelected));

				connection.Open();

				req.ExecuteNonQuery(); 

				connection.Close();

				validate = true;

				return validate;
			}
			catch(MySqlException e) 
			{
				return validate;
			}
		}
	}
}
