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

        // Au lancement de la page
        /*
        private void InitializeComponent
        {

        }
        */

        // Au Clic sur le bouton, accéder à la page Statistiques
        private void onClickToStats(object sender, EventArgs e)
        {
            Hide();
            var Stats = new Stats();
            Stats.ShowDialog();
            Close();
        }

        // Au Clic sur le bouton, accéder à la page Mes Factures
        private void onClickToFactures(object sender, EventArgs e)
        {

        }

        // Au Clic sur le bouton, accéder à la page Mes Bornes
        private void onClickToBornes(object sender, EventArgs e)
        {

        }
    }
}
