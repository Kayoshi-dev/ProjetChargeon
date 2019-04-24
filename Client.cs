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

            CrudBornes selectClients = new CrudBornes();
            DataSet listeClients = selectClients.SelectClients();

            // Affiche le Client dans la ComboBox
            cb_Client.DisplayMember = "Cli_Nom";

            // ID du Client Sélectionné
            cb_Client.ValueMember = "Cli_Id";

            cb_Client.DataSource = listeClients.Tables["Client"];
        }

        private void CloseProgram(object sender, EventArgs e)
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

            CrudBornes selectDetailsClient = new CrudBornes();
            DataSet listeDetailsClient = selectDetailsClient.SelectDetailsClient(idSelected);

            
            /* Affichage des données dans chaque label */

            // Condition pour Vérifier l'éxistence de la donnée ID
            if (listeDetailsClient.Tables[0].Rows[0].ItemArray[0].ToString() != null)
            {
                // Affiche l'ID du client sélectionné
                l_ID.Text = listeDetailsClient.Tables[0].Rows[0].ItemArray[0].ToString();
            }
            else
            {
                l_ID.Text = "Vide";
            }

            // Condition pour Vérifier l'éxistence de la donnée Nom
            if (listeDetailsClient.Tables[0].Rows[0].ItemArray[1].ToString() != null)
            {
                // Affiche le Nom du client sélectionné
                l_Nom.Text = listeDetailsClient.Tables[0].Rows[0].ItemArray[1].ToString();
            }
            else
            {
                l_Nom.Text = "Vide";
            }

            // Condition pour Vérifier l'éxistence de la donnée Adresse
            if (listeDetailsClient.Tables[0].Rows[0].ItemArray[2].ToString() != null)
            {
                // Affiche l'Adresse du client sélectionné
                l_Adresse.Text = listeDetailsClient.Tables[0].Rows[0].ItemArray[2].ToString();
            }
            else
            {
                l_Adresse.Text = "Vide";
            }

            // Condition pour Vérifier l'éxistence de la donnée Code Postal
            if (listeDetailsClient.Tables[0].Rows[0].ItemArray[3].ToString() != null)
            {
                // Affiche le Code Postal du client sélectionné
                l_CP.Text = listeDetailsClient.Tables[0].Rows[0].ItemArray[3].ToString();
            }
            else
            {
                l_CP.Text = "Vide";
            }

            // Condition pour Vérifier l'éxistence de la donnée Ville
            if (listeDetailsClient.Tables[0].Rows[0].ItemArray[4].ToString() != null)
            {
                // Affiche la Ville du client sélectionné
                l_Ville.Text = listeDetailsClient.Tables[0].Rows[0].ItemArray[4].ToString();
            }
            else
            {
                l_Ville.Text = "Vide";
            }
        }
    }
}
