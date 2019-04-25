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
    public partial class Technicien : Form
    {
        /* Code lors de l'initialisation de la Page */

        public Technicien()
        {
            InitializeComponent();

            // Affiche dans la ComboBox la liste des Techniciens enregistrés dans la BDD
            CrudBornes selectTechnicien = new CrudBornes();
            DataSet listeTechniciens = selectTechnicien.SelectTechniciens();

            // Affiche le Nom du Technicien dans la ComboBox
            cb_Technicien.DisplayMember = "Tech_Nom";

            // ID du Technicien Sélectionné
            cb_Technicien.ValueMember = "Tech_Id";

            cb_Technicien.DataSource = listeTechniciens.Tables["Technicien"];
        }

        
        /* Liens de Redirection */
        
        // Au Clic, on retourne vers la page Gestion_Donnees
        private void Return(object sender, EventArgs e)
        {
            Hide();
            var Data = new Gestion_Donnees();
            Data.ShowDialog();
            Close();
        }

        // Au Clic, on kill le process et on ferme la page
        private void Close(object sender, EventArgs e)
        {
            Close();
        }


        /* Traitement des données Techniciens */

        // En fonction du Technicien sélectionné dans la ComboBox, affiche ces informations (ID, Nom, Prénom)
        private void cb_Technicien_SelectedIndexChanged(object sender, EventArgs e)
        {
            // On récupère l'ID de la ComboBox
            string idSelected = cb_Technicien.SelectedValue.ToString();

            CrudBornes selectDetailsTechniciens = new CrudBornes();
            DataSet listeDetailsTechniciens = selectDetailsTechniciens.SelectDetailsTechnicien(idSelected);

            /* Affichage des données dans chaque label */

            // Condition pour Vérifier l'éxistence de la donnée ID
            if (listeDetailsTechniciens.Tables[0].Rows[0].ItemArray[0].ToString() != null)
            {
                // Affiche l'ID du client sélectionné
                l_ID.Text = listeDetailsTechniciens.Tables[0].Rows[0].ItemArray[0].ToString();
            }
            else
            {
                l_ID.Text = "Vide";
            }

            // Condition pour Vérifier l'éxistence de la donnée Nom
            if (listeDetailsTechniciens.Tables[0].Rows[0].ItemArray[1].ToString() != null)
            {
                // Affiche le Nom du client sélectionné
                l_Nom.Text = listeDetailsTechniciens.Tables[0].Rows[0].ItemArray[1].ToString();
            }
            else
            {
                l_Nom.Text = "Vide";
            }

            // Condition pour Vérifier l'éxistence de la donnée Prénom
            if (listeDetailsTechniciens.Tables[0].Rows[0].ItemArray[2].ToString() != null)
            {
                // Affiche l'Adresse du client sélectionné
                l_Prenom.Text = listeDetailsTechniciens.Tables[0].Rows[0].ItemArray[2].ToString();
            }
            else
            {
                l_Prenom.Text = "Vide";
            }

            // Condition pour Vérifier l'éxistence de la donnée Disponible
            if (listeDetailsTechniciens.Tables[0].Rows[0].ItemArray[3].ToString() == "True")
            {
                // Si Disponibilité == TRUE : Affiche "OUI" dans le label et change la couleur du cercle en vert
                l_Dispo.Text = "OUI";
                p_Dispo.Image = ProjetChargeon.Properties.Resources.circle_green;
            }
            else if (listeDetailsTechniciens.Tables[0].Rows[0].ItemArray[3].ToString() == "False")
            {
                // Sinon si Dispinibilité == FALSE : Affiche "NON" dans le label et change la couleur du cercle en rouge
                l_Dispo.Text = "NON";
                p_Dispo.Image = ProjetChargeon.Properties.Resources.circle_red;
            }
            else
            {
                l_Dispo.Text = "X"; // X pour ERREUR
                p_Dispo.Image = ProjetChargeon.Properties.Resources.circle_red;
            }
        }
    }
}
