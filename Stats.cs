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
    public partial class Stats : Form
    {
        CrudBornes selectBornes = new CrudBornes(); // Connexion à la BDD

        public Stats()
        {
            InitializeComponent();
            DataSet listeBornes = selectBornes.SelectBornes();
            cb_Bornes.DisplayMember = "Borne_Ref"; // La ComboBox affiche la référence
            cb_Bornes.ValueMember = "Borne_Id"; // Mais vaut l'ID correspondant
            cb_Bornes.DataSource = listeBornes.Tables["Borne"];
        }

		private void CloseProgram(object sender, EventArgs e)
		{
			Close();
		}

		private void PictureBox4_Click(object sender, EventArgs e)
		{
			Hide();
			var Logged_Admin = new Logged_Admin();
			Logged_Admin.ShowDialog();
			Close();
		}
	}
}
