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

		private void UpdateClick(object sender, EventArgs e)
		{
			string idSelected = cb_Nom.SelectedValue.ToString(); // idSelected vaut l'ID du champ de la ComboBox

			bool test = DataUser.UpdateCustomer(idSelected, tb_nom.Text, tb_adresse.Text, tb_cp.Text, tb_ville.Text);
			if(test == true)
			{
				l_test.Text = "ok";
			}
		}

		/*
        // Au Clic sur le bouton, permet d'ajouter un client dans la Base de Données
        private void Ajouter_Client(object sender, EventArgs e)
        {
            // Récupère les valeurs des TextBox, et on les ajoutent dans une variable
            // Pour l'instant, on met le TextBox CodePostal en String, on effectuera plus tard sa convertion en Int32
            string nomClient = tb_Nom_Ajout.Text.ToString();
            string adresseClient = tb_Adresse_Ajout.Text.ToString();
            string cpClientText = tb_CP_Ajout.Text.ToString();
            string villeClient = tb_Ville_Ajout.Text.ToString();

            CrudBornes insertClient = new CrudBornes();

            // On vérifie si tous les TextBox sont remplis
            if (nomClient == "" || adresseClient == "" || cpClientText == "" || villeClient == "")
            {
                // Si un d'entre eux n'est pas remplis, on affiche une erreur
                MessageBox.Show("Veuillez remplir toutes les cases du formulaire !");
            }
            // Ensuite on vérifie le nombre de caractère des TextBox afin d'éviter les attaques (Injection SQL ...)
            else if(nomClient.Length > 20 || adresseClient.Length > 70 || cpClientText.Length > 5 || villeClient.Length > 20)
            {
                MessageBox.Show("Veuillez réduire le nombre de caractère pour le formulaire !");
            }

            // Si tous est Ok, alors on peut traiter le TextBox CP, et exécuter la requête 
            else
            {
                // On convertit maintenant le TextBox Code Postal en Int32
                int cpClient = Convert.ToInt32(cpClientText);

                // On exécute notre requête SQL INSERT
                bool insertClientBool = insertClient.InsertClient(nomClient, adresseClient, cpClient, villeClient);

                
                if (insertClientBool == true)
                {
                    // Si requête exécutée, on affiche un message positif
                    MessageBox.Show("Requête exécutée, client ajouté !");
                }
                else
                {
                    // Sinon on affiche une erreur
                    MessageBox.Show("Erreur : Requête INSERT non exécutée !");
                }
            }
        }

        // Au Clic sur le bouton, permet de supprimer le client sélectionné dans la ComboBox
        private void Supprimer_Client(object sender, EventArgs e)
        {
            // On récupère l'ID de la ComboBox
            string idSelected = cb_Nom.SelectedValue.ToString();

            CrudBornes deleteClient = new CrudBornes();
            bool deleteClientBool = deleteClient.DeleteClient(idSelected);

            // Si requête exécutée, on affiche un message positif, sinon on affiche une erreur
            if (deleteClientBool == true)
            {
                MessageBox.Show("Requête exécutée, client supprimé !");
            }
            else
            {
                MessageBox.Show("Erreur : Requête DELETE non exécutée !");
            }
        }*/


	}
}
