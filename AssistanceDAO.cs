﻿/* 
 * Date de création : 28/04/2019
 * Dernière modification : 28/04/2019
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
	}
}
