﻿/* 
 * Date de création : 20/04/2019
 * Dernière modification : 30/04/2019
 * Équipe : Nathouuuu
 * Rôle : Fichier de class contenant différentes méthodes concernant les données "Technicien"
 * Développeur : Nathan
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
    class TechnicienDAO
    {
        private MySqlConnection connection;

        public TechnicienDAO()
        {
            var ConnectObject = new DBConnect();
            this.connection = ConnectObject.GetConnection(); //On récupère la valeur de Connection grâce à la méthode GetConnection.
        }

        // Cette méthode permet d'obtenir l'ID et les noms des techniciens dans la ComboBox
        public DataSet SelectTechniciens()
        {
            string query = "SELECT Tech_Id, Tech_Nom FROM technicien";

            MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
            DataSet listeTechniciens = new DataSet();
            da.Fill(listeTechniciens, "Technicien");
            return listeTechniciens;
        }

        // Cette méthode permet d'obtenir les données du Technicien sélectionné et de les afficher
        public DataSet SelectDetailsTechnicien(string idSelected)
        {
            string query = "SELECT Tech_Id, Tech_Nom, Tech_Prenom, Tech_Dispo FROM technicien WHERE Tech_Id = @id";
            //string query = "SELECT Tech_Id, Tech_Nom, Tech_Prenom, Tech_Dispo, Hab_DateDeb, Hab_DateFin FROM technicien, habilitation WHERE Tech_Id = @id AND Tech_NoHab = Hab_Id";

            MySqlCommand req = new MySqlCommand(query, connection);

            req.Parameters.Clear();
            req.Parameters.Add(new MySqlParameter("@id", idSelected));

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet listeDetailsTechniciens = new DataSet();

            adapter.SelectCommand = req;
            adapter.Fill(listeDetailsTechniciens);

            adapter.Dispose();
            req.Dispose();

            return listeDetailsTechniciens;
        }

        // Cette méthode permet d'ajouter un technicien dans la BDD
        public bool InsertTechnicien(string nomTechnicien, string prenomTechnicien, int dispoTechnicien)
        {
            string query = "INSERT INTO technicien (Tech_Nom, Tech_Prenom, Tech_Dispo) VALUES (@nom, @prenom, @dispo)";
            bool validate = false;

            MySqlCommand req = new MySqlCommand(query, connection);

            req.Parameters.Clear();
            req.Parameters.Add(new MySqlParameter("@nom", nomTechnicien));
            req.Parameters.Add(new MySqlParameter("@prenom", prenomTechnicien));
            req.Parameters.Add(new MySqlParameter("@dispo", dispoTechnicien));

            connection.Open();

            req.ExecuteNonQuery();

            connection.Close();

            validate = true;

            return validate;
        }

        // Cette méthode permet de mettre à jour un technicien dans la BDD
        public bool UpdateTechnicien(string idSelected, string nom, string prenom, int dispo)
        {
            bool validate = false;

            string query = "UPDATE technicien SET Tech_Nom = @nom, Tech_Prenom = @prenom, Tech_Dispo = @dispo WHERE Tech_Id = @idTechnicien";

            MySqlCommand req = new MySqlCommand(query, connection);

            req.Parameters.Clear();
            req.Parameters.Add(new MySqlParameter("@idTechnicien", idSelected));
            req.Parameters.Add(new MySqlParameter("@nom", nom));
            req.Parameters.Add(new MySqlParameter("@prenom", prenom));
            req.Parameters.Add(new MySqlParameter("@dispo", dispo));

            connection.Open();

            req.ExecuteNonQuery();

            connection.Close();

            validate = true;

            return validate;
        }

        // Cette méthode permet de supprimer un technicien dans la BDD
        public bool DeleteTechnicien(string idSelected)
        {
            string query = "DELETE FROM technicien WHERE Tech_Id = @id";
            bool validate = false;

            MySqlCommand req = new MySqlCommand(query, connection);

            req.Parameters.Clear();
            req.Parameters.Add(new MySqlParameter("@id", idSelected));

            connection.Open();

            req.ExecuteNonQuery();

            connection.Close();

            validate = true;

            return validate;
        }
    }
}
