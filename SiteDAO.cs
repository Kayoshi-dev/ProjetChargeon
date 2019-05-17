using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetChargeon
{
    class SiteDAO
    {
        private MySqlConnection connection;

        public SiteDAO()
        {
            var ConnectObject = new DBConnect();
            this.connection = ConnectObject.GetConnection(); //On récupère la valeur de Connection grâce à la méthode GetConnection.
        }

        // Cette méthode permet d'obtenir l'ID et les noms des Sites dans la ComboBox
        public DataSet SelectSites()
        {
            string query = "SELECT Site_Id, Site_Nom FROM site";

            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            DataSet listeSites = new DataSet();

            adapter.Fill(listeSites);

            adapter.Dispose();

            return listeSites;
        }
    }

}
