using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetChargeon
{
	class CrudBornes
	{
		private MySqlConnection connection;

		public CrudBornes() 
		{
			var ConnectObject = new DBConnect();
			this.connection = ConnectObject.GetConnection();
		}

		public DataSet SelectBornes()
		{
			string query = "SELECT * FROM bornes";

			MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
			DataSet listeBornes = new DataSet();
			da.Fill(listeBornes, "Borne");
			return listeBornes;
		}
	}
}
