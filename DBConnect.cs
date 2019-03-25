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
                if(ex.Number == 0) //
                {
                    MessageBox.Show("Erreur de connexion au serveur.");
                }
                else if (ex.Number == 1045)
                {
                    MessageBox.Show("User ou mot de passe incorect");
                }
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

        public bool VerifLogin(string user, string password)
        {
            string query = "SELECT * FROM connexion WHERE Col_Login= '" + user + "' AND Col_Mdp '" + password + "'";
            MySqlCommand req = new MySqlCommand(query, connection);


        }

        
    }
}
