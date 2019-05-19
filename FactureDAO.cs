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
using System.Windows.Forms;

namespace ProjetChargeon
{
    class FactureDAO
    {
        private MySqlConnection connection;

        public FactureDAO()
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

        public bool addNewFacture(string titre, int montant, string dateDebut, string dateFin, int idCustomer, int idBorne)
        {
            bool validate = false;

            try
            {
                string query = "INSERT INTO facture (Fact_Titre, Fact_Mont, Fact_DateDeb, Fact_DateFin, Fact_IdClient, Fact_IdBorne) " +
                               "VALUES (@titre, @montant, @dateDebut, @dateFin, @idCustomer, @idBorne)";

                MySqlCommand req = new MySqlCommand(query, connection);

                req.Parameters.Clear();
                req.Parameters.Add(new MySqlParameter("@titre", titre));
                req.Parameters.Add(new MySqlParameter("@montant", montant));
                req.Parameters.Add(new MySqlParameter("@dateDebut", dateDebut));
                req.Parameters.Add(new MySqlParameter("@dateFin", dateFin));
                req.Parameters.Add(new MySqlParameter("@idCustomer", idCustomer));
                req.Parameters.Add(new MySqlParameter("@idBorne", idBorne));

                connection.Open();

                req.ExecuteNonQuery();

                connection.Close();

                validate = true;

                return validate;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return validate;
            }
        }
    }
}
