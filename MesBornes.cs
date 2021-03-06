﻿/*
 * Date de création : 19/04/2019
 * Dernière modification : 19/05/2019
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

            // Récupération de l'ID de l'utilisateur
			ClientDAO IdList = new ClientDAO();
			int idAccount = IdList.GetId();

			// Initialisation de la ComboBox affichant les différentes bornes
			BornesDAO selectBornes = new BornesDAO();
			DataSet listeBornes = selectBornes.SelectBornesCustomer(idAccount);
			cb_mesBornes.DisplayMember = "Borne_Ref"; // La ComboBox affiche la référence
			cb_mesBornes.ValueMember = "Borne_Id"; // Mais vaut l'ID correspondant
			cb_mesBornes.DataSource = listeBornes.Tables[0]; // Affiche la seule table contenu dans le DataSource

			// Initialisation de la ComboBox pour les différents types de problèmes
			AssistanceDAO selectTypesAssistances = new AssistanceDAO();
			DataSet listTypesAssistances = selectTypesAssistances.selectTypesAssistances();
			cb_typepb.DisplayMember = "TypeAssist_Ref";
			cb_typepb.ValueMember = "TypeAssist_Id";
			cb_typepb.DataSource = listTypesAssistances.Tables[0];
		}

		private void Cb_bornesClient_SelectedIndexChanged(object sender, EventArgs e)
		{
			string idSelected = cb_mesBornes.SelectedValue.ToString(); // idSelected vaut l'ID du champ de la ComboBox

			BornesDAO dataBornes = new BornesDAO();
			DataSet DetailsMesBornes = dataBornes.SelectDetailsBornes(idSelected);

			l_ns.Text = DetailsMesBornes.Tables[0].Rows[0].ItemArray[5].ToString();

			// Selon le type de borne on affiche :
			if (DetailsMesBornes.Tables[0].Rows[0].ItemArray[6].ToString() == "0") 
			{
				l_type.Text = "Intérieur";
			}
			else 
			{
				l_type.Text = "Exterieur";
			}

			// Selon l'état de la borne on affiche une image avec un cercle de couleur différente
			if (DetailsMesBornes.Tables[0].Rows[0].ItemArray[7].ToString() == "True")
			{
				l_etat.Text = "ON";
				p_etat.Image = ProjetChargeon.Properties.Resources.circle_green; //Chargement de l'image circle green
			}
			else
			{
				l_etat.Text = "OFF";
				p_etat.Image = ProjetChargeon.Properties.Resources.circle_red; //Chargement de l'image circle red
			}

			l_puis.Text = DetailsMesBornes.Tables[0].Rows[0].ItemArray[8].ToString() + " kWh";

			DataSet selectCity = dataBornes.SelectCityForBornes(idSelected);
			l_ville.Text = selectCity.Tables[0].Rows[0].ItemArray[0].ToString();
		}

		// Ajoute une demande d'assistance lors du clic
		private void needHelp(object sender, EventArgs e)
		{
			int idSelectedBornes = Convert.ToInt32(cb_mesBornes.SelectedValue); // idSelected vaut l'ID du champ de la ComboBox
			int idSelectedTypeAssist = Convert.ToInt32(cb_typepb.SelectedValue);

			AssistanceDAO AskForHelp = new AssistanceDAO();
			// On vérifie que le texte ne vaut pas le placeholder
			if(tb_intitule.Text != "Intitulé de votre problème" && tb_intitule.Text != null) 
			{
				// On ajoute la demande d'assistance
				bool validate = AskForHelp.AddAssistance(idSelectedBornes, idSelectedTypeAssist, tb_intitule.Text);

				// Si notre validation est vraie alors
				if (validate == true) 
				{
					tb_intitule.Text = ""; // On vide la TextBox
					l_valid.ForeColor = l_valid.ForeColor = Color.FromArgb(46, 204, 113); // Message en Vert
					l_valid.Text = "Ok"; // On affiche ok
				}
				else 
				{
					l_valid.ForeColor = Color.FromArgb(231, 76, 60); // Message en Rouge
					l_valid.Text = "Fail"; // On affiche fail
				}
			}
			// Si le message entré vaut la placeholder
			else 
			{
				MessageBox.Show("Entrez un message différent");
			}
		}

		// Méthode pour placeholder
		private void messageHelpClick(object sender, MouseEventArgs e)
		{
			if (tb_intitule.Text == "Intitulé de votre problème") {
				tb_intitule.Text = "";
			}
		}

		private void BackForm(object sender, EventArgs e)
		{
			Hide();
			var LoggedCustomer = new Logged_Customer();
			LoggedCustomer.ShowDialog();
			Close();
		}

		private void CloseProgram(object sender, EventArgs e)
		{
			Close();
		}
	}
}
