/* 
 * Date de création : 11/03/2019
 * Dernière modification : 18/04/2019
 * Équipe : Nathouuuu
 * Rôle : Connexion à la base de donnée
 * Développeurs : Maxime, Kevin
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
    class DBConnect
    {
        private MySqlConnection connection;
        private string host;
        private string database;
        private string user;
        private string password;

		public DBConnect() //Constructeur
        {
            Initialize();
        }

        private void Initialize()
        {
            host = "localhost";
            database = "chargeon";
            user = "root";
            password = "";
            string infosDB = "SERVER=" + host + ";" + "DATABASE=" + database + ";"
                             + "UID=" + user + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(infosDB);
        }

		//Cette méthode permet de récuperer l'objet Connection afin de pouvoir l'utiliser dans d'autres classes.
		public MySqlConnection GetConnection() 
		{
			return connection;
		}

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                //MessageBox.Show("Connexion ouverte!");
                return true;
            }
            catch(MySqlException ex)
            {
                if(ex.Number == 0) // Si le message d'erreur est 0
                {
                    MessageBox.Show("Erreur de connexion au serveur.");
                }
                else if (ex.Number == 1045) // Si le message d'erreur est 1045
                {
                    MessageBox.Show("User ou Password pour la BDD incorect.");
                }
				else { // Sinon on affiche un message général
					MessageBox.Show("Impossible de se connecter à la base de donnée.");	
				} 
				// et on ferme l'application
				Environment.Exit(0);
				
				// On retourne quand même false car Csharp exige une valeur de retour
				return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

		// A bouger.
        public DataSet CheckLogin(string username, string password)
        {
            string query = "SELECT ChkAdmin.CntUser, Co_Admin FROM connexion, (SELECT COUNT(*) AS CntUser FROM connexion) AS ChkAdmin WHERE Co_Login = @username AND Co_Mdp = @password GROUP BY ChkAdmin.CntUser, Co_Admin";

			if (OpenConnection() == true) {
                MySqlCommand req = new MySqlCommand(query, connection);

                req.Parameters.Clear();
                req.Parameters.AddWithValue("@username", username);
                req.Parameters.AddWithValue("@password", password);

				MySqlDataAdapter adapter = new MySqlDataAdapter();
				DataSet DataAccount = new DataSet();

				//On remplie le DataSet avec notre objet "req"
				adapter.SelectCommand = req;
				adapter.Fill(DataAccount);

				//On libère les ressources
				adapter.Dispose();
				req.Dispose();
				CloseConnection();

				return DataAccount;
			}
            else 
            {
				MessageBox.Show("Connexion fermée");
				DataSet DataAccount = new DataSet();
				return DataAccount = null;
            }
        }      
    }
}
