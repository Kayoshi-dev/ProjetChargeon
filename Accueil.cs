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
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();

            //Définit les couleurs pour l'arrière plan et des boutons
            BackColor = Color.FromArgb(33, 43, 61); // Background global de l'appli
            p_titre.BackColor = Color.FromArgb(53, 70, 100); //Panel titre en haut
            btn_localisation.BackColor = Color.FromArgb(53, 70, 100);
            btn_connect.BackColor = Color.FromArgb(53, 70, 100);
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            Hide();
            var Login = new Login();
            Login.ShowDialog();
            Close();
        }
    }
}
