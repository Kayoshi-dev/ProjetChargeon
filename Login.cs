/* 
 * Date de création : 11/03/2019
 * Dernière modification : 19/04/2019
 * Équipe : Nathouuuu
 * Rôle : Affichage et traitement du formulaire de connexion
 * Développeurs : Maxime
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, System.EventArgs e)
        {
            Close();
        }

		private void Connect(object sender, EventArgs e)
		{
			DBConnect Connect = new DBConnect();
			DataSet DataAccount = Connect.CheckLogin(tb_login.Text, tb_mdp.Text);

			//Si le Count renvoie 0, on affiche une erreur
			if (DataAccount.Tables[0].Rows.Count == 0)
			{
				MessageBox.Show("Login ou mot de passe incorrect.");
			}
			//Sinon on parcours
			else
			{
				var ListeID = new UserDAO();
				ListeID.GetId(tb_login.Text);

				if (DataAccount.Tables[0].Rows[0].ItemArray[1].ToString() == "False")
				{
					Hide();
					var LoggedCustomer = new Logged_Customer();
					LoggedCustomer.ShowDialog();
					Close();
				}
				//Si Admin
				else
				{
					Hide();
					var LoggedAdmin = new Logged_Admin();
					LoggedAdmin.ShowDialog();
					Close();
				}
			}
		}

		private void BackForm(object sender, EventArgs e)
		{
			Hide();
			var Accueil = new Accueil();
			Accueil.ShowDialog();
			Close();
		}
	}
}
