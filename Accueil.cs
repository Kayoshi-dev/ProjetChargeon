/* 
 * Date de création : 11/03/2019
 * Dernière modification : 27/03/2019
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
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        // Au Clic sur le bouton, accéder à la page Login
        private void OpenLogin(object sender, EventArgs e)
        {
            Hide();
            var Login = new Login();
            Login.ShowDialog();
            Close();
        }
        
        private void OpenCarte(object sender, EventArgs e)
        {
            Hide();
            var Localisation = new Carte();
            Localisation.ShowDialog();
            Close();
        }

        // Au Click sur l'image, fermer la page et kill le process
        private void CloseProgram(object sender, EventArgs e)
        {
            Close();
        }

		private void OpenStatut(object sender, EventArgs e)
		{
			Hide();
			var StatutBornes = new StatutBornes();
			StatutBornes.ShowDialog();
			Close();
		}
	}
}
