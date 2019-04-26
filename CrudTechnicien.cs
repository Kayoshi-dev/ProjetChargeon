﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetChargeon
{
    class CrudTechnicien
    {
        private MySqlConnection connection;

        public CrudTechnicien()
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

        /* Début de SQL pour Technicien et son Habilitation */

        /*string query = "SELECT Tech_Id, Tech_Nom, Tech_Prenom, TypeHab_Ref, Tech_Dispo FROM technicien, habilitation, typehab " +
                "WHERE Tech_Id = @id " +
                "AND Tech_NoHab = Hab_Id " +
                "AND Hab_NoTypeHab = TypeHab_Id";*/
    }
}
