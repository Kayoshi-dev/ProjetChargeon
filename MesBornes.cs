/*
 * Date de création : 19/04/2019
 * Dernière modification : 27/04/2019
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
	public partial class MesBornes : Form
	{
		public MesBornes()
		{
			InitializeComponent();

			UserDAO IdList = new UserDAO();
			int idAccount = IdList.GetId();

			CrudBornes selectBornes = new CrudBornes();
			DataSet listeBornes = selectBornes.SelectBornesCustomer(idAccount);
			cb_mesBornes.DisplayMember = "Borne_Ref"; // La ComboBox affiche la référence
			cb_mesBornes.ValueMember = "Borne_Id"; // Mais vaut l'ID correspondant
			cb_mesBornes.DataSource = listeBornes.Tables[0]; // Affiche la seul table contenu dans le DataSource
		}

		private void Cb_bornesClient_SelectedIndexChanged(object sender, EventArgs e)
		{
			string idSelected = cb_mesBornes.SelectedValue.ToString(); // idSelected vaut l'ID du champ de la ComboBox

			CrudBornes dataBornes = new CrudBornes();
			DataSet DetailsMesBornes = dataBornes.SelectDetailsBornes(idSelected);

			l_ns.Text = DetailsMesBornes.Tables[0].Rows[0].ItemArray[7].ToString();

			// Selon le type de borne on affiche :
			if (DetailsMesBornes.Tables[0].Rows[0].ItemArray[8].ToString() == "0") 
			{
				l_type.Text = "Intérieur";
			}
			else 
			{
				l_type.Text = "Exterieur";
			}

			// Selon l'état de la borne on affiche une image avec un cercle de couleur différente
			if (DetailsMesBornes.Tables[0].Rows[0].ItemArray[9].ToString() == "True")
			{
				l_etat.Text = "ON";
				p_etat.Image = ProjetChargeon.Properties.Resources.circle_green; //Chargement de l'image circle green
			}
			else
			{
				l_etat.Text = "OFF";
				p_etat.Image = ProjetChargeon.Properties.Resources.circle_red; //Chargement de l'image circle red
			}

			l_puis.Text = DetailsMesBornes.Tables[0].Rows[0].ItemArray[10].ToString() + " kWh";

			DataSet selectCity = dataBornes.SelectCityForBornes(idSelected);
			l_ville.Text = selectCity.Tables[0].Rows[0].ItemArray[0].ToString();
		}

		private void needHelp(object sender, EventArgs e)
		{
			
		}

		private void messageHelpClick(object sender, MouseEventArgs e)
		{
			if (tb_message.Text == "Décrivez votre problème") {
				tb_message.Text = "";
			}
		}

		private void BackForm(object sender, EventArgs e)
		{
			Hide();
			var Data = new Gestion_Donnees();
			Data.ShowDialog();
			Close();
		}

		private void CloseProgram(object sender, EventArgs e)
		{
			Close();
		}
	}
}
