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
        BornesDAO selectBornes = new BornesDAO(); // Connexion à la BDD pour la liste des bornes


        public Stats()
        {
            InitializeComponent();

            DataSet listeBornes = selectBornes.SelectBornes();
            cb_Bornes.DisplayMember = "Borne_Ref"; // La ComboBox affiche la référence
            cb_Bornes.ValueMember = "Borne_Id"; // Mais vaut l'ID correspondant
            cb_Bornes.DataSource = listeBornes.Tables["Borne"];
        }


        /* Evènement sur les images */

        // Au Clic, on kill le process et on ferme la page
		private void CloseProgram(object sender, EventArgs e)
		{
			Close();
		}

        // Au Clic, on retourne à la page Logged_Admin
        private void Return(object sender, EventArgs e)
        {
            Hide();
            var Logged_Admin = new Logged_Admin();
            Logged_Admin.ShowDialog();
            Close();
        }


        /* Méthodes pour les Statistiques */

        private void ComboIndexChange(object sender, EventArgs e)
        {
            string idSelected = cb_Bornes.SelectedValue.ToString(); // idSelected vaut l'ID du champ de la ComboBox

            StatsDAO selectDetailsStats = new StatsDAO();
            DataSet listDetailsStats = selectDetailsStats.SelectDetailsStats(idSelected);

            // Affichage des données dans chaque label

            // Condition pour Vérifier l'éxistence de la donnée Titre
            if (listDetailsStats.Tables[0].Rows[0].ItemArray[0].ToString() != null)
            {
                l_Titre.Text = listDetailsStats.Tables[0].Rows[0].ItemArray[0].ToString(); // Affiche le titre de la Stat
            }
            else
            {
                l_Titre.Text = "Vide";
            }

            // Condition pour Vérifier l'éxistence de la donnée Date
            if (listDetailsStats.Tables[0].Rows[0].ItemArray[1].ToString() != null)
            {
                l_Date.Text = listDetailsStats.Tables[0].Rows[0].ItemArray[1].ToString(); // Affiche la date de la Stat
            }
            else
            {
                l_Date.Text = "Vide";
            }

            // Condition pour Vérifier l'éxistence de la donnée Puissance Absorbée
            if (listDetailsStats.Tables[0].Rows[0].ItemArray[2].ToString() != null)
            {
                l_PuisAbs.Text = listDetailsStats.Tables[0].Rows[0].ItemArray[2].ToString(); // Affiche la Puissance Absorbée de la borne
            }
            else
            {
                l_PuisAbs.Text = "Vide";
            }

            // Condition pour Vérifier l'éxistence de la donnée Durée
            if (listDetailsStats.Tables[0].Rows[0].ItemArray[3].ToString() != null)
            {
                l_Duree.Text = listDetailsStats.Tables[0].Rows[0].ItemArray[3].ToString(); // Affiche la Durée de Chargement de la borne
            }
            else
            {
                l_Duree.Text = "Vide";
            }

			// Code pour le graphique
			ch_Graphe.Series["Bornes"].XValueMember = "Stats_Duree";
			ch_Graphe.Series["Bornes"].YValueMembers = "Stats_PuisAbs";
			ch_Graphe.DataSource = listDetailsStats;
			ch_Graphe.DataBind();
        }
    }
}
