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
		public StatutBornes()
		{
			InitializeComponent();
			CrudBornes selectBornes = new CrudBornes();
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
			
		}
	}
}
