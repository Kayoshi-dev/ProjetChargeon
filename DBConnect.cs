/* 
 * Date de création : 11/03/2019
 * Dernière modification : 24/03/2019
 * Équipe : Nathouuuu
 * Rôle : Connexion à la base de donnée
 */

using System;
using System.Collections.Generic;
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

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                MessageBox.Show("Ok");
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
                    MessageBox.Show("User ou mot de passe incorect");
                }
				else { // Sinon on affiche un message général
					MessageBox.Show("Une erreur inconnue est survenue");	
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

        public int CheckLogin(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM connexion WHERE username = @username AND password = @password";
            int Count = -1;

            if(OpenConnection() == true) {
                MySqlCommand req = new MySqlCommand(query, connection);

                req.Parameters.Clear();
                req.Parameters.AddWithValue("@username", username);
                req.Parameters.AddWithValue("@password", password);
                Count = int.Parse(req.ExecuteScalar()+"");
                
                CloseConnection();

				return Count;
            }
            else 
            {
				MessageBox.Show("Connexion fermée");
                return Count;
            }
        }      
    }
}
