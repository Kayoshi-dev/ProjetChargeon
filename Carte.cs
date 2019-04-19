/* 
 * Date de création : 11/03/2019
 * Dernière modification : 25/03/2019
 * Équipe : Nathouuuu
 * Rôle : Affichage de la carte
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
    public partial class Carte : Form
    {
        public Carte()
        {
            InitializeComponent();
        }

        private void CloseProgram(object sender, EventArgs e)
        {
            Close();
        }

		private void PictureBox2_Click(object sender, EventArgs e)
		{
			Hide();
			var Accueil = new Accueil();
			Accueil.ShowDialog();
			Close();
		}
	}
}
