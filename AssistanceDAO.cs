using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
		public bool AddAssistance(int idBorne, string Message) 
		{
			bool validate = false;

			try 
			{
				string query = "INSERT INTO assistance (Assist_NoBorne, Assist_Message, Assist_Etat) VALUES (@idBorne, @message, 0)";
				MySqlCommand req = new MySqlCommand(query, connection);

				req.Parameters.Clear();
				req.Parameters.Add(new MySqlParameter("@idBorne", idBorne));
				req.Parameters.Add(new MySqlParameter("@message", Message));

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
	}
}
