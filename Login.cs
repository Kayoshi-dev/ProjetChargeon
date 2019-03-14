using System.Drawing;
using System.Windows.Forms;

/* 
 * Date de création : 11/03/2019
 * Dernière modification : 11/03/2019
 * Équipe : Nathouuuu
 */

namespace ProjetChargeon
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            //Définit les couleurs pour l'arrière plan et des boutons
            BackColor = Color.FromArgb(33, 43, 61); // Background global de l'appli
            p_form.BackColor = Color.FromArgb(53, 70, 99); //Panel 
            p_form1.BackColor = Color.FromArgb(53, 70, 99); // Panel 
        }

        private void PictureBox1_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
