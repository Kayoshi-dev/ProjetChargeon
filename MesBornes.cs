using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetChargeon
{
	public partial class MesBornes : Form
	{
		public MesBornes()
		{
			InitializeComponent();

			UserDAO IdList = new UserDAO();
			int idAccount = IdList.idAccount;
			MessageBox.Show(idAccount.ToString());

			CrudBornes selectBornes = new CrudBornes();
			DataSet listeBornes = selectBornes.SelectBornesClient(idAccount);
			cb_bornesClient.DisplayMember = "Borne_Ref"; // La ComboBox affiche la référence
			cb_bornesClient.ValueMember = "Borne_Id"; // Mais vaut l'ID correspondant
			cb_bornesClient.DataSource = listeBornes.Tables["Borne"];
		}

		private void CloseProgram(object sender, EventArgs e)
		{
			Close();
		}

		private void BackForm(object sender, EventArgs e)
		{
			Hide();
			var Logged_Customer = new Logged_Customer();
			Logged_Customer.ShowDialog();
			Close();
		}
	}
}
