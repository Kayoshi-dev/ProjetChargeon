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
    public partial class Bornes : Form
    {
        public Bornes()
        {
            InitializeComponent();
            InitializeComboBoxBorne();
        }

        private void InitializeComboBoxBorne()
        {
            CrudBornes DataBorne = new CrudBornes();
            DataSet ListBornes = DataBorne.SelectBornes();

            // Affiche les Bornes dans la ComboBox
            cb_Borne.DisplayMember = "Borne_Ref";
            cb_Borne.ValueMember = "Borne_Id";
            cb_Borne.DataSource = ListBornes.Tables[0];
        }

        // Au Clic, on kill le process et on ferme la page
        private void Close(object sender, EventArgs e)
        {
            Close();
        }

        // Au Clic, on retourne à la page Gestion des Données
        private void Return(object sender, EventArgs e)
        {
            Hide();
            var Data = new Gestion_Donnees();
            Data.ShowDialog();
            Close();
        }

        private void DataBorne(object sender, EventArgs e)
        {
            // On récupère l'ID de la ComboBox
            string idSelected = cb_Borne.SelectedValue.ToString();

            CrudBornes DataBorne = new CrudBornes();
            DataSet ListMoreDetailsBornes = DataBorne.SelectMoreDetailsBornes(idSelected);

            
            /* Affichage des données dans chaque label */

            // Condition pour Vérifier l'éxistence de la donnée ID
            if (ListMoreDetailsBornes.Tables[0].Rows[0].ItemArray[0].ToString() != null)
            {
                // Affiche l'ID de la Borne sélectionné
                l_ID.Text = ListMoreDetailsBornes.Tables[0].Rows[0].ItemArray[0].ToString();
            }
            else
            {
                l_ID.Text = "Vide";
            }

            // Condition pour Vérifier l'éxistence de la donnée Description
            if (ListMoreDetailsBornes.Tables[0].Rows[0].ItemArray[1].ToString() != null)
            {
                // Affiche la Description de la Borne sélectionnée
                l_Description.Text = ListMoreDetailsBornes.Tables[0].Rows[0].ItemArray[1].ToString();
            }
            else
            {
                l_Description.Text = "Vide";
            }

            // Condition pour Vérifier l'éxistence de la donnée Numéro de Série
            if (ListMoreDetailsBornes.Tables[0].Rows[0].ItemArray[2].ToString() != null)
            {
                // Affiche le Numéro de Série de la Borne sélectionné
                l_NS.Text = ListMoreDetailsBornes.Tables[0].Rows[0].ItemArray[2].ToString();
            }
            else
            {
                l_NS.Text = "Vide";
            }

            // Condition pour Vérifier l'éxistence de la donnée Type
            if (ListMoreDetailsBornes.Tables[0].Rows[0].ItemArray[3].ToString() == "True")
            {
                // Affiche le Type de la Borne sélectionné
                l_Type.Text = "Intérieur";
            }
            else
            {
                l_Type.Text = "Extérieur";
            }

            // Condition pour Vérifier l'éxistence de la donnée Disponible
            if (ListMoreDetailsBornes.Tables[0].Rows[0].ItemArray[4].ToString() == "True")
            {
                // Si Disponibilité == TRUE : Affiche "OUI" dans le label et change la couleur du cercle en vert
                l_Dispo.Text = "ON";
                p_Dispo.Image = ProjetChargeon.Properties.Resources.circle_green;
            }
            else
            {
                // Sinon si Dispinibilité == FALSE : Affiche "NON" dans le label et change la couleur du cercle en rouge
                l_Dispo.Text = "OFF";
                p_Dispo.Image = ProjetChargeon.Properties.Resources.circle_red;
            }

            // Condition pour Vérifier l'éxistence de la donnée Puissance
            if (ListMoreDetailsBornes.Tables[0].Rows[0].ItemArray[5].ToString() != null)
            {
                // Affiche la Puissance de la Borne sélectionnée
                l_Puissance.Text = ListMoreDetailsBornes.Tables[0].Rows[0].ItemArray[5].ToString();
            }
            else
            {
                l_Puissance.Text = "Vide";
            }

            // Condition pour Vérifier l'éxistence de la donnée Priorité
            if (ListMoreDetailsBornes.Tables[0].Rows[0].ItemArray[6].ToString() == "True")
            {
                // Affiche la Priorité de la Borne sélectionnée
                l_Priorite.Text = "Elevée";
            }
            else
            {
                l_Priorite.Text = "Normale";
            }

            // Condition pour Vérifier l'éxistence de la donnée Nom du Site
            if (ListMoreDetailsBornes.Tables[0].Rows[0].ItemArray[7].ToString() != null)
            {
                // Affiche le Nom du Site où est installé la Borne
                l_Site.Text = ListMoreDetailsBornes.Tables[0].Rows[0].ItemArray[7].ToString();
            }
            else
            {
                l_Site.Text = "Vide";
            }
        }
    }
}
