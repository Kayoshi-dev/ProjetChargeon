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
	public partial class StatutBornes : Form
	{
		CrudBornes selectBornes = new CrudBornes();
		public StatutBornes()
		{
			InitializeComponent();
			DataSet listeBornes = selectBornes.SelectBornes();
			cb_bornes.DisplayMember = "Borne_Ref";
			cb_bornes.ValueMember = "Borne_Id";
			cb_bornes.DataSource = listeBornes.Tables["Borne"];
		}

		private void CloseProgram(object sender, EventArgs e)
		{
			Close();
		}

		private void ComboIndexChange(object sender, EventArgs e)
		{
			DataSet listeBornes = selectBornes.SelectBornes();

			string idSelected = cb_bornes.SelectedValue.ToString();

			CrudBornes selectDetailsBornes = new CrudBornes();
			DataSet listeDetailsBornes = selectDetailsBornes.SelectDetailsBornes(Convert.ToInt32(listeBornes.Tables[0].Rows[0].ItemArray[0]), idSelected);

			l_id.Text = listeDetailsBornes.Tables[0].Rows[0].ItemArray[0].ToString();
			l_desc.Text = listeDetailsBornes.Tables[0].Rows[0].ItemArray[7].ToString();
		}
	}
}
