/* 
* Date de création : 17/04/2019
* Dernière modification : 23/04/2019
* Équipe : Nathouuuu
* Rôle : Affichage des informations concernant toute les bornes 
* Développeur : Maxime
*/

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
			cb_bornes.DisplayMember = "Borne_Ref"; // La ComboBox affiche la référence
			cb_bornes.ValueMember = "Borne_Id"; // Mais vaut l'ID correspondant
			cb_bornes.DataSource = listeBornes.Tables["Borne"];
		}

		private void CloseProgram(object sender, EventArgs e)
		{
			Close();
		}

		private void ComboIndexChange(object sender, EventArgs e)
		{
			string idSelected = cb_bornes.SelectedValue.ToString(); // idSelected vaut l'ID du champ de la ComboBox

			CrudBornes selectDetailsBornes = new CrudBornes();
			DataSet listeDetailsBornes = selectDetailsBornes.SelectDetailsBornes(idSelected);

			l_id.Text = listeDetailsBornes.Tables[0].Rows[0].ItemArray[0].ToString(); // Affiche l'ID

			// Affiche la zone
			DataSet listeCity = selectDetailsBornes.SelectCityForBornes(idSelected);
			l_zone.Text = listeCity.Tables[0].Rows[0].ItemArray[0].ToString(); 

			l_desc.Text = listeDetailsBornes.Tables[0].Rows[0].ItemArray[4].ToString(); // Affiche la description
			l_ns.Text = listeDetailsBornes.Tables[0].Rows[0].ItemArray[5].ToString(); // Affiche le Numéro de série
			if(listeDetailsBornes.Tables[0].Rows[0].ItemArray[6].ToString() == "False") 
			{
				l_type.Text = "Intérieur";
			}
			else 
			{
				l_type.Text = "Extérieur";
			}
			if (listeDetailsBornes.Tables[0].Rows[0].ItemArray[7].ToString() == "True") // Cette condition change la couleur du texte selon l'état de la borne
			{
				l_etat.Text = "ON";
				l_etat.ForeColor = Color.FromArgb(46, 204, 113); // Vert
			} 
			else 
			{
				l_etat.Text = "OFF";
				l_etat.ForeColor = Color.FromArgb(231, 76, 60); // Rouge
			}
			l_power.Text = listeDetailsBornes.Tables[0].Rows[0].ItemArray[8].ToString() + " kWh";
		}

		private void BackForm(object sender, EventArgs e)
		{
			Hide();
			var Accueil = new Accueil();
			Accueil.ShowDialog();
			Close();
		}
	}
}
