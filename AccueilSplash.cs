/* 
 * Date de création : 11/03/2019
 * Dernière modification : 18/05/2019
 * Équipe : Nathouuuu
 * Développeur : Maxime
 * Rôle : Cette page sert uniquement lors du lancement, c'est un clone de Accueil qui s'execute uniquement après le Splash Screen
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetChargeon
{
    public partial class AccueilSplash : Form
    {
        // Execute un thread pendant 5 secondes
        public AccueilSplash()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }

        public void StartForm()
        {
            Application.Run(new SplashScreen());
        }

        // Au Clic sur le bouton, accéder à la page Login
        private void OpenLogin(object sender, EventArgs e)
        {
            Hide();
            var Login = new Login();
            Login.ShowDialog();
            Close();
        }

        private void OpenStatut(object sender, EventArgs e)
        {
            Hide();
            var StatutBornes = new StatutBornes();
            StatutBornes.ShowDialog();
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
    }
}
