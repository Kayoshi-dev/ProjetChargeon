/*
 * Date de création : 23/04/2019
 * Dernière modification : 27/04/2019
 * Équipe : Nathouuuu
 * Rôle : Fichier de classe contenant toute les méthodes permettant des actions sur l'utilisateur
 * Développeur : Maxime, Nathan
 * Design : Nathan
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
    public partial class ClientCRUD : Form
    {
		UserDAO DataUser = new UserDAO();

		public ClientCRUD()
        {
            InitializeComponent();

            /* Afficher à l'initialisation la liste des Clients */

            DataSet ListCustomer = DataUser.SelectClients();

            // Affiche le Client dans la ComboBox
            cb_Nom.DisplayMember = "Cli_Nom";
            cb_Nom.ValueMember = "Cli_Id";
            cb_Nom.DataSource = ListCustomer.Tables[0];
        }

		private void NameIndexChange(object sender, EventArgs e)
		{
			string idSelected = cb_Nom.SelectedValue.ToString(); // idSelected vaut l'ID du champ de la ComboBox

			DataSet dataCustomerDetails = DataUser.SelectDetailsClient(idSelected);

			l_nom.Text = dataCustomerDetails.Tables[0].Rows[0].ItemArray[3].ToString();
			tb_nom.Text = dataCustomerDetails.Tables[0].Rows[0].ItemArray[3].ToString();
			tb_adresse.Text = dataCustomerDetails.Tables[0].Rows[0].ItemArray[4].ToString();
			tb_cp.Text = dataCustomerDetails.Tables[0].Rows[0].ItemArray[5].ToString();
			tb_ville.Text = dataCustomerDetails.Tables[0].Rows[0].ItemArray[6].ToString();
		}

		private void UpdateClick(object sender, EventArgs e)
		{
			string idSelected = cb_Nom.SelectedValue.ToString(); // idSelected vaut l'ID du champ de la ComboBox

			bool test = DataUser.UpdateCustomer(idSelected, tb_nom.Text, tb_adresse.Text, tb_cp.Text, tb_ville.Text);
			if (test == true)
			{
				l_test.ForeColor = Color.FromArgb(46, 204, 113); // Vert
				l_test.Text = "Modification effectuée";

				//On recharge la base de donnée pour prendre en compte la mise à jour
				DataSet ListCustomer = DataUser.SelectClients();
				cb_Nom.DataSource = ListCustomer.Tables[0];
			}
			else 
			{ 
				l_test.ForeColor = Color.FromArgb(231, 76, 60); // Rouge
				l_test.Text = "Echec lors de la modification";
			}
		}

		private void DeleteClick(object sender, EventArgs e)
		{
			string idSelected = cb_Nom.SelectedValue.ToString(); // idSelected vaut l'ID du champ de la ComboBox

			bool test = DataUser.DeleteCustomer(idSelected);
			if(test == true) 
			{
				l_test.ForeColor = Color.FromArgb(46, 204, 113); // Vert
				l_test.Text = "Suppression effectuée";

				//On recharge la base de donnée pour prendre en compte la mise à jour
				DataSet ListCustomer = DataUser.SelectClients();
				cb_Nom.DataSource = ListCustomer.Tables[0];
			}
			else 
			{
				l_test.ForeColor = Color.FromArgb(231, 76, 60); // Rouge
				l_test.Text = "Echec lors de la suppression";
			}
		}

		private void AddClick(object sender, EventArgs e)
		{
			bool test = DataUser.InsertCustomer(tb_Nom_Ajout.Text, tb_Adresse_Ajout.Text, tb_CP_Ajout.Text, tb_Ville_Ajout.Text);

			if (test == true)
			{
				//Après Modification des infos on reset la valeur des champs.
				tb_Nom_Ajout.Text = "";
				tb_Adresse_Ajout.Text = "";
				tb_CP_Ajout.Text = "";
				tb_Ville_Ajout.Text = "";

				if (test == true)
				{
					l_test.ForeColor = Color.FromArgb(46, 204, 113); // Vert
					l_test.Text = "Ajout effectuée";

					//On recharge la base de donnée pour prendre en compte la mise à jour
					DataSet ListCustomer = DataUser.SelectClients();
					cb_Nom.DataSource = ListCustomer.Tables[0];
				}
				else
				{
					l_test.ForeColor = Color.FromArgb(231, 76, 60); // Rouge
					l_test.Text = "Echec lors de l'insertion";
				}
			}
		}

		// Au Clic sur l'image, on ferme l'application
		private void Close(object sender, EventArgs e)
		{
			Close();
		}

		// Au Clic sur l'image, on retourne à la page précédente
		private void Return(object sender, EventArgs e)
		{
			Hide();
			var Data = new Gestion_Donnees();
			Data.ShowDialog();
			Close();
		}
	}
}
