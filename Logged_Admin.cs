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
        }

        // Au Clic sur l'image, fermer la page et kill le process
        private void Close(object sender, EventArgs e)
        {
            Close();
        }

        // Au Clic sur l'image, on revient à la page de Connexion
        private void Return(object sender, EventArgs e)
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
