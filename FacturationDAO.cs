/* 
 * Date de création : 19/05/2019
 * Dernière modification : 19/05/2019
 * Équipe : Nathouuuu
 * Rôle : Fichier contenant différentes méthodes pour intéragir sur les factures d'un client :)
 * Développeur : Maxime
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
    class FacturationDAO
    {
        private MySqlConnection connection;

        public FacturationDAO()
        {
            DBConnect ConnectObject = new DBConnect();
            connection = ConnectObject.GetConnection();
        }

        // Récupère le titre et l'ID d'une facture en fonction du client
        public DataSet selectMyFacture(int idCustomer)
        {
            string query = "SELECT Fact_Id, Fact_Titre FROM facture WHERE Fact_IdClient = @idCustomer";

            MySqlCommand req = new MySqlCommand(query, connection);

            req.Parameters.Clear();
            req.Parameters.Add(new MySqlParameter("@idCustomer", idCustomer));

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            DataSet ListMyFacture = new DataSet();

            adapter.SelectCommand = req;
            adapter.Fill(ListMyFacture);
            adapter.Dispose();

            return ListMyFacture;
        }

        // Récupère toute les infos d'une facture
        public DataSet selectInfosMyFacture(int idFacture)
        {
            string query = "SELECT * FROM facture WHERE Fact_Id = @idFacture";

            MySqlCommand req = new MySqlCommand(query, connection);

            req.Parameters.Clear();
            req.Parameters.Add(new MySqlParameter("@idFacture", idFacture));

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            DataSet ListInfosMyFacture = new DataSet();

            adapter.SelectCommand = req;
            adapter.Fill(ListInfosMyFacture);
            adapter.Dispose();

            return ListInfosMyFacture;
        }

        public bool addNewFacture(int idCustomer, int idBorne)
        {
            bool validate = false;

            try
            {
                string query = "";
                return validate;
            }
            catch (Exception e)
            {
                return validate;
            }
        }
    }
}
