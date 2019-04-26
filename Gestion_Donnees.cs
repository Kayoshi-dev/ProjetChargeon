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


        /* Evènement sur les images */

        // Au Clic sur l'image, on kill le process et on ferme la page
        private void Close(object sender, EventArgs e)
        {
            Close();
        }

        // Au Clic sur l'image, on revient à la page de Connexion
        private void Return(object sender, EventArgs e)
        {
            Hide();
            var Logged_Admin = new Logged_Admin();
            Logged_Admin.ShowDialog();
            Close();
        }


        /* Liens de Redirection */

        // Au Click sur le Bouton, redirection vers Gestion des Bornes
        private void onClickToBorne(object sender, EventArgs e)
        {

        }

        // Au Clic, redirection vers Gestion des Techniciens
        private void onClickToTechnicien(object sender, EventArgs e)
        {
            Hide();
            var Technicien = new Technicien();
            Technicien.ShowDialog();
            Close();
        }

        // Au Clic, redirection vers le CRUD Technicien
        private void onClickToCRUDTechnicien(object sender, EventArgs e)
        {
            Hide();
            var CRUD_Technicien = new TechnicienCRUD();
            CRUD_Technicien.ShowDialog();
            Close();
        }
    }
}
