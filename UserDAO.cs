/* 
 * Date de création : 20/04/2019
 * Dernière modification : 20/04/2019
 * Équipe : Nathouuuu
 * Rôle : Fichier de class contenant différentes méthodes concernant l'utilisateur
 * Développeurs : Maxime
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
    }
}
