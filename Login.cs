/* 
 * Date de création : 11/03/2019
 * Dernière modification : 24/03/2019
 * Équipe : Nathouuuu
 * Rôle : Affichage du formulaire de connexion
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
using System.Data.SqlClient;

namespace ProjetChargeon
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            DBConnect Connect = new DBConnect();
            Connect.OpenConnection();
        }

        private void PictureBox1_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void b_valider_Click(object sender, EventArgs e)
        {

        }
    }
}
