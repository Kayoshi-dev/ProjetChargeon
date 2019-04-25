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
    public partial class Gestion_Donnees : Form
    {
        public Gestion_Donnees()
        {
            InitializeComponent();
        }

        // Au Clic sur l'image, fermer la page et kill le process
        private void Close(object sender, EventArgs e)
        {
            Close();
        }

        // Au Clic sur l'image, on revient à la page de Connexion
        private void Return(object sender, EventArgs e)
        {
            Hide();
            var Accueil = new Accueil();
            Accueil.ShowDialog();
            Close();
        }
    }
}
