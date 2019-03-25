/* 
 * Date de création : 11/03/2019
 * Dernière modification : 18/03/2019
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
        private void btn_connect_Click(object sender, EventArgs e)
        {
            Hide();
            var Login = new Login();
            Login.ShowDialog();
            Close();
        }

        // Au Click sur l'image, fermer la page et kill le process
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
