/* 
 * Date de création : 28/04/2019
 * Dernière modification : 18/05/2019
 * Équipe : Nathouuuu
 * Rôle : Fichier de class contenant différentes méthodes concernant les demandes d'assistance
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
	class AssistanceDAO
	{
		private MySqlConnection connection;
		
		public AssistanceDAO() 
		{
			DBConnect ConnectObject = new DBConnect();
			connection = ConnectObject.GetConnection();
		}
		public bool AddAssistance(int idBorne, int idTypeAss, string titre) 
		{
			bool validate = false;

			try 
			{
				string query = "INSERT INTO assistance (Assist_NoBorne, Assist_NoTypeAssist, Assist_Titre, Assist_Etat) VALUES (@idBorne, @idTypeAss, @titre, 0)";
				MySqlCommand req = new MySqlCommand(query, connection);

				req.Parameters.Clear();
				req.Parameters.Add(new MySqlParameter("@idBorne", idBorne));
				req.Parameters.Add(new MySqlParameter("@idTypeAss", idTypeAss));
				req.Parameters.Add(new MySqlParameter("@titre", titre));

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

		public int CountAssistance() 
		{
			string query = "SELECT COUNT(*) FROM assistance WHERE Assist_Etat = 0";
			MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

			DataSet CountAssistance = new DataSet();

			adapter.Fill(CountAssistance);
			adapter.Dispose();

			int Count = Convert.ToInt32(CountAssistance.Tables[0].Rows[0].ItemArray[0]);
			return Count;
		}

		public DataSet selectTypesAssistances() 
		{
			string query = "SELECT * FROM typeassist";
			MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

			DataSet ListTypesAssistance = new DataSet();

			adapter.Fill(ListTypesAssistance);
			adapter.Dispose();

			return ListTypesAssistance;
		}

		public DataSet selectPendingAssistances()
		{
			string query = "SELECT * FROM assistance WHERE Assist_Etat = 0";

			MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

			DataSet ListPendingAssistance = new DataSet();

			adapter.Fill(ListPendingAssistance);
			adapter.Dispose();

			return ListPendingAssistance;
		}

		public DataSet selectInfosPendingAssistances(int idDemande)
		{
			string query = "SELECT Assist_Id, Assist_NoBorne, Assist_NoTypeAssist, Assist_Titre, Assist_Etat, Borne_Ref, TypeAssist_Ref " +
						   "FROM assistance, bornes, typeassist " +
						   "WHERE Assist_NoBorne = Borne_Id " +
						   "AND Assist_NoTypeAssist = TypeAssist_Id	" +
						   "AND Assist_Id = @idDemande " +
						   "AND Assist_Etat = 0";

			MySqlCommand req = new MySqlCommand(query, connection);

			req.Parameters.Clear();
			req.Parameters.Add(new MySqlParameter("@idDemande", idDemande));

			MySqlDataAdapter adapter = new MySqlDataAdapter();

			DataSet ListPendingAssistance = new DataSet();

			adapter.SelectCommand = req;
			adapter.Fill(ListPendingAssistance);
			adapter.Dispose();

			return ListPendingAssistance;
		}

		public DataSet selectInProgressAssistances()
		{
			string query = "SELECT Assist_Id, Assist_Titre FROM assistance WHERE Assist_Etat = 1";
			MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

			DataSet ListInProgressAssistance = new DataSet();

			adapter.Fill(ListInProgressAssistance);
			adapter.Dispose();

			return ListInProgressAssistance;
		}

        public DataSet selectInfosInProgressAssistances(int idDemande)
        {
            string query = "SELECT Assist_Titre, Borne_Ref, TypeAssist_Ref, Tech_Nom " +
                           "FROM assistance, bornes, typeassist, technicien " +
                           "WHERE Assist_NoBorne = Borne_Id " +
                           "AND Tech_Id = Assist_NoTech " +
                           "AND Assist_NoTypeAssist = TypeAssist_Id	" +
                           "AND Assist_Id = @idDemande " +
                           "AND Assist_Etat = 1";

            MySqlCommand req = new MySqlCommand(query, connection);

            req.Parameters.Clear();
            req.Parameters.Add(new MySqlParameter("@idDemande", idDemande));

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            DataSet ListInfosInProgressAssistance = new DataSet();

            adapter.SelectCommand = req;
            adapter.Fill(ListInfosInProgressAssistance);
            adapter.Dispose();

            return ListInfosInProgressAssistance;
        }

        public DataSet selectCompletedAssistances()
		{
			string query = "SELECT * FROM assistance WHERE Assist_Etat = 2";
			MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

			DataSet ListCompletedAssistance = new DataSet();

			adapter.Fill(ListCompletedAssistance);
			adapter.Dispose();

			return ListCompletedAssistance;
		}

        public DataSet selectInfosCompletedAssistances(int idDemande)
        {
            string query = "SELECT Assist_Titre, Borne_Ref, TypeAssist_Ref, Tech_Nom " +
                           "FROM assistance, bornes, typeassist, technicien " +
                           "WHERE Assist_NoBorne = Borne_Id " +
                           "AND Tech_Id = Assist_NoTech " +
                           "AND Assist_NoTypeAssist = TypeAssist_Id	" +
                           "AND Assist_Id = @idDemande " +
                           "AND Assist_Etat = 2";

            MySqlCommand req = new MySqlCommand(query, connection);

            req.Parameters.Clear();
            req.Parameters.Add(new MySqlParameter("@idDemande", idDemande));

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            DataSet ListInfosCompletedAssistance = new DataSet();

            adapter.SelectCommand = req;
            adapter.Fill(ListInfosCompletedAssistance);
            adapter.Dispose();

            return ListInfosCompletedAssistance;
        }

        public void SetAssistanceToInProgress(int idDemande, int idTechnicien)
        {
            string query = "UPDATE assistance SET Assist_NoTech = @idTechnicien, Assist_Etat = 1 WHERE Assist_Id = @idDemande";
            MySqlCommand req = new MySqlCommand(query, connection);

            req.Parameters.Clear();
            req.Parameters.Add(new MySqlParameter("@idDemande", idDemande));
            req.Parameters.Add(new MySqlParameter("@idTechnicien", idTechnicien));

            connection.Open();

            req.ExecuteNonQuery();

            connection.Close();
        }

        public void SetAssistanceToDone(int idDemande)
        {
            string query = "UPDATE assistance SET Assist_Etat = 2 WHERE Assist_Id = @idDemande";

            MySqlCommand req = new MySqlCommand(query, connection);

            req.Parameters.Clear();
            req.Parameters.Add(new MySqlParameter("@idDemande", idDemande));

            connection.Open();

            req.ExecuteNonQuery();

            connection.Close();
        }
	}
}
