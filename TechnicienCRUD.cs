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
    public partial class TechnicienCRUD : Form
    {
        /* Code lors de l'initialisation de la Page */

        public TechnicienCRUD()
        {
            InitializeComponent();
        }

        /* Liens de Redirection */

        // Au Clic, on retourne vers la page Gestion_Donnees
        private void Return(object sender, EventArgs e)
        {
            Hide();
            var Data = new Gestion_Donnees();
            Data.ShowDialog();
            Close();
        }

        // Au Clic, on kill le process et on ferme la page
        private void Close(object sender, EventArgs e)
        {
            Close();
        }
    }
}
