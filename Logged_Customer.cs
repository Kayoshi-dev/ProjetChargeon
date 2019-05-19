/* 
 * Date de création : 11/03/2019
 * Dernière modification : 11/03/2019
 * Équipe : Nathouuuu
 * Rôle : Page d'Accueil (Client)
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
    public partial class Logged_Customer : Form
    {
        public Logged_Customer()
        {
            InitializeComponent();
        }

		private void CloseProgram(object sender, EventArgs e)
		{
			Close();
		}

		private void Btn_factures_Click(object sender, EventArgs e)
		{
			Hide();
			var Facturation = new Facture();
			Facturation.ShowDialog();
			Close();
		}

		private void Btn_bornes_Click(object sender, EventArgs e)
		{
			Hide();
			var MesBornes = new MesBornes();
			MesBornes.ShowDialog();
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
