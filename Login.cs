/* 
 * Date de création : 11/03/2019
 * Dernière modification : 16/04/2019
 * Équipe : Nathouuuu
 * Rôle : Affichage et traitement du formulaire de connexion
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
        }

        private void PictureBox1_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void b_valider_Click(object sender, EventArgs e)
        {
			DBConnect Connect = new DBConnect();
			DataSet DataAccount = Connect.CheckLogin(tb_login.Text, tb_mdp.Text);

			//On parcours
			for (int i = 0; i <= DataAccount.Tables[0].Rows.Count - 1; i++)
			{
				//DataAccount.Tables[0].Rows[i].ItemArray[0].ToString() corresponds au Count(*)
				if (DataAccount.Tables[0].Rows[i].ItemArray[0].ToString() == "1") 
				{
					

					//DataAccount.Tables[0].Rows[i].ItemArray[1].ToString() corresponds au statut du compte (cad Admin ou non)
					//Si non Admin
					if (DataAccount.Tables[0].Rows[i].ItemArray[1].ToString() == "False") {
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
				else
				{
					
				}
			}
			
			MessageBox.Show("Mauvais identifiant ou mot de passe.");
		}
    }
}
