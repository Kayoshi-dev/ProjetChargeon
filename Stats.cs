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
        CrudBornes selectBornes = new CrudBornes(); // Connexion à la BDD pour la liste des bornes


        public Stats()
        {
            InitializeComponent();

            DataSet listeBornes = selectBornes.SelectBornes();
            cb_Bornes.DisplayMember = "Borne_Ref"; // La ComboBox affiche la référence
            cb_Bornes.ValueMember = "Borne_Id"; // Mais vaut l'ID correspondant
            cb_Bornes.DataSource = listeBornes.Tables["Borne"];
        }

		private void CloseProgram(object sender, EventArgs e)
		{
			Close();
		}

		private void PictureBox4_Click(object sender, EventArgs e)
		{
			Hide();
			var Logged_Admin = new Logged_Admin();
			Logged_Admin.ShowDialog();
			Close();
		}

        private void ComboIndexChange(object sender, EventArgs e)
        {
            string idSelected = cb_Bornes.SelectedValue.ToString(); // idSelected vaut l'ID du champ de la ComboBox

            CrudBornes selectDetailsStats = new CrudBornes();
            DataSet listeDetailsStats = selectDetailsStats.SelectDetailsStats(idSelected);

            // Affichage des données dans chaque label

            // Condition pour Vérifier l'éxistence de la donnée Titre
            if (listeDetailsStats.Tables[0].Rows[0].ItemArray[0].ToString() != null)
            {
                l_Titre.Text = listeDetailsStats.Tables[0].Rows[0].ItemArray[0].ToString(); // Affiche le titre de la Stat
            }
            else
            {
                l_Titre.Text = "Vide";
            }

            // Condition pour Vérifier l'éxistence de la donnée Date
            if (listeDetailsStats.Tables[0].Rows[0].ItemArray[1].ToString() != null)
            {
                l_Date.Text = listeDetailsStats.Tables[0].Rows[0].ItemArray[1].ToString(); // Affiche la date de la Stat
            }
            else
            {
                l_Date.Text = "Vide";
            }

            // Condition pour Vérifier l'éxistence de la donnée Puissance Absorbée
            if (listeDetailsStats.Tables[0].Rows[0].ItemArray[2].ToString() != null)
            {
                l_PuisAbs.Text = listeDetailsStats.Tables[0].Rows[0].ItemArray[2].ToString(); // Affiche la Puissance Absorbée de la borne
            }
            else
            {
                l_PuisAbs.Text = "Vide";
            }

            // Condition pour Vérifier l'éxistence de la donnée Durée
            if (listeDetailsStats.Tables[0].Rows[0].ItemArray[3].ToString() != null)
            {
                l_Duree.Text = listeDetailsStats.Tables[0].Rows[0].ItemArray[3].ToString(); // Affiche la Durée de Chargement de la borne
            }
            else
            {
                l_Duree.Text = "Vide";
            }

			// Code pour le graphique

			ch_Graphe.Series["Bornes"].XValueMember = "Stats_Duree";
			ch_Graphe.Series["Bornes"].YValueMembers = "Stats_PuisAbs";
			ch_Graphe.DataSource = listeDetailsStats;
			ch_Graphe.DataBind();
        }
    }
}
