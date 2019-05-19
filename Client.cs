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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();

			ClientDAO DataUser = new ClientDAO();
			DataSet ListCustomer = DataUser.SelectClients();

			// Affiche le Client dans la ComboBox
			cb_Client.DisplayMember = "Cli_Nom";
			cb_Client.ValueMember = "Cli_Id";
			cb_Client.DataSource = ListCustomer.Tables[0];
		}

        private void Close(object sender, EventArgs e)
        {
            Close();
        }

        private void BackForm(object sender, EventArgs e)
        {
            Hide();
            var Data = new Gestion_Donnees();
            Data.ShowDialog();
            Close();
        }

        private void cb_Client_SelectedIndexChanged(object sender, EventArgs e)
        {
            // On récupère l'ID de la ComboBox
            string idSelected = cb_Client.SelectedValue.ToString();

			ClientDAO DataUser = new ClientDAO();
			DataSet ListCustomerDetails = DataUser.SelectDetailsClient(idSelected);

			/* Affichage des données dans chaque label */

			// Condition pour Vérifier l'éxistence de la donnée ID
			if (ListCustomerDetails.Tables[0].Rows[0].ItemArray[0].ToString() != null)
            {
                // Affiche l'ID du client sélectionné
                l_ID.Text = ListCustomerDetails.Tables[0].Rows[0].ItemArray[0].ToString();
            }
            else
            {
                l_ID.Text = "Vide";
            }

            // Condition pour Vérifier l'éxistence de la donnée Nom
            if (ListCustomerDetails.Tables[0].Rows[0].ItemArray[3].ToString() != null)
            {
                // Affiche le Nom du client sélectionné
                l_Nom.Text = ListCustomerDetails.Tables[0].Rows[0].ItemArray[3].ToString();
            }
            else
            {
                l_Nom.Text = "Vide";
            }

            // Condition pour Vérifier l'éxistence de la donnée Adresse
            if (ListCustomerDetails.Tables[0].Rows[0].ItemArray[4].ToString() != null)
            {
                // Affiche l'Adresse du client sélectionné
                l_Adresse.Text = ListCustomerDetails.Tables[0].Rows[0].ItemArray[4].ToString();
            }
            else
            {
                l_Adresse.Text = "Vide";
            }

            // Condition pour Vérifier l'éxistence de la donnée Code Postal
            if (ListCustomerDetails.Tables[0].Rows[0].ItemArray[5].ToString() != null)
            {
                // Affiche le Code Postal du client sélectionné
                l_CP.Text = ListCustomerDetails.Tables[0].Rows[0].ItemArray[5].ToString();
            }
            else
            {
                l_CP.Text = "Vide";
            }

            // Condition pour Vérifier l'éxistence de la donnée Ville
            if (ListCustomerDetails.Tables[0].Rows[0].ItemArray[6].ToString() != null)
            {
                // Affiche la Ville du client sélectionné
                l_Ville.Text = ListCustomerDetails.Tables[0].Rows[0].ItemArray[6].ToString();
            }
            else
            {
                l_Ville.Text = "Vide";
            }
        }
    }
}
