/* 
 * Date de création : 11/03/2019
 * Dernière modification : 11/03/2019
 * Équipe : Nathouuuu
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
    public partial class Logged_Admin : Form
    {
        public Logged_Admin()
        {
            InitializeComponent();

			AssistanceDAO DataAssist = new AssistanceDAO();
			int CountAssistance = DataAssist.CountAssistance();


			if(CountAssistance >= 1) 
			{
				//Si il existe des demandes d'assistances on génère ce label
				Label l_nbAss = new Label();
				l_nbAss.BackColor = Color.FromArgb(53, 70, 99);
				l_nbAss.ForeColor = Color.FromArgb(255, 255, 255);
				l_nbAss.Padding = new Padding(1, 0, 0, 0);
				l_nbAss.Location = new Point(656, 12);
				l_nbAss.AutoSize = false;
				l_nbAss.Size = new Size(36, 30);
				l_nbAss.Cursor = Cursors.Hand;
				l_nbAss.Image = Properties.Resources.red_notif;
				l_nbAss.TextAlign = ContentAlignment.MiddleCenter;
				l_nbAss.Text = CountAssistance.ToString();
				this.Controls.Add(l_nbAss);
				l_nbAss.BringToFront();

				l_nbAss.Click += (s, e) =>
				{
					Hide();
					var InterventionForm = new Intervention();
					InterventionForm.ShowDialog();
					Close();
				};
			}
        }


        /* Evènement sur les images */

        // Au Clic sur l'image, on kill le process et on ferme la page
        private void CloseProgram(object sender, EventArgs e)
        {
            Close();
        }

        // Au Clic sur l'image, retourne à la page de Connexion
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Hide();
            var Accueil = new Accueil();
            Accueil.ShowDialog();
            Close();
        }

        // Au Clic sur le bouton, accéder à la page Statistiques
        private void onClickToStats(object sender, EventArgs e)
        {
            Hide();
            var Stats = new Stats();
            Stats.ShowDialog();
            Close();
        }

        // Au Clic sur le bouton, accéder à la page Gestion des Données
        private void onClickToData(object sender, EventArgs e)
        {
            Hide();
            var Data = new Gestion_Donnees();
            Data.ShowDialog();
            Close();
        }
	}
}
