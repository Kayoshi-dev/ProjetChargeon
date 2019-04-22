﻿/* 
 * Date de création : 17/04/2019
 * Dernière modification : 19/04/2019
 * Équipe : Nathouuuu
 * Rôle : Cette classe comporte différentes méthodes permettant d'obtenir des informations sur différentes bornes
 */

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetChargeon
{
	class CrudBornes
	{
		private MySqlConnection connection;

		public CrudBornes() 
		{
			var ConnectObject = new DBConnect();
			this.connection = ConnectObject.GetConnection(); //On récupère la valeur de Connection grâce à la méthode GetConnection.
		}

		/* Il est surement possible de tout *
		 * grouper en une seule méthode *
		 * il faut y réfléchir */

		//Cette méthode permet d'obtenir l'ID et la Ref pour remplir la ComboBox
		public DataSet SelectBornes()
		{
			string query = "SELECT Borne_Id, Borne_Ref FROM bornes";

			MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
			DataSet listeBornes = new DataSet();
			da.Fill(listeBornes, "Borne");
			return listeBornes;
		}

		//Cette méthode récupère quant à elle les autres champs de la base de données, tout en s'adaptant à l'ID selectionné
		public DataSet SelectDetailsBornes(string idSelected)
		{
			string query = "SELECT * FROM bornes WHERE Borne_Id = @id";

			MySqlCommand req = new MySqlCommand(query, connection);

			req.Parameters.Clear();
			req.Parameters.Add(new MySqlParameter("@id", idSelected));

			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataSet listeDetailsBornes = new DataSet();

			adapter.SelectCommand = req;
			adapter.Fill(listeDetailsBornes);

			adapter.Dispose();
			req.Dispose();

			return listeDetailsBornes;
		}

		public DataSet SelectCityForBornes(string idSelected) 
		{
			string query = "SELECT Site_Ville FROM site, bornes WHERE Borne_NoSite = Site_Id AND Borne_Id = @idSelected";

			MySqlCommand req = new MySqlCommand(query, connection);

			req.Parameters.Clear();
			req.Parameters.Add(new MySqlParameter("@idSelected", idSelected));

			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataSet cityForBorne = new DataSet();

			adapter.SelectCommand = req;
			adapter.Fill(cityForBorne);

			adapter.Dispose();
			req.Dispose();

			return cityForBorne;
		}

		public DataSet SelectBornesCustomer(int idAccount)
		{
			string query = "SELECT * FROM bornes WHERE Borne_NoCli = @idAccount";

			MySqlCommand req = new MySqlCommand(query, connection);

			req.Parameters.Clear();
			req.Parameters.Add(new MySqlParameter("@idAccount", idAccount));

			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataSet listeBornesClient = new DataSet();

			adapter.SelectCommand = req;
			adapter.Fill(listeBornesClient);

			adapter.Dispose();
			req.Dispose();

			return listeBornesClient;
		}
	}
}
