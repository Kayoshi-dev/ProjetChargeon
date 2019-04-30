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

        // Au Clic, on kill le process et on ferme la page
        private void Close(object sender, EventArgs e)
        {
            Close();
        }

        // Au Clic, on retourne à la page d'Accueil de l'Administrateur
        private void Return(object sender, EventArgs e)
        {
            Hide();
            var accueilAdmin = new Logged_Admin();
            accueilAdmin.ShowDialog();
            Close();
        }


        // Au Clic, redirection vers la page Gestion des Clients
        private void onClickToClient(object sender, EventArgs e)
        {
            Hide();
            var Client = new Client();
            Client.ShowDialog();
            Close();
        }

        // Au Clic, redirection vers le CRUD des Clients
        private void onClickToClientCRUD(object sender, EventArgs e)
        {
            Hide();
            var ClientCRUD = new ClientCRUD();
            ClientCRUD.ShowDialog();
            Close();
        }


        // Au Clic, redirection vers la page Gestion des Bornes
        private void onClickToBorne(object sender, EventArgs e)
        {
            Hide();
            var Borne = new Bornes();
            Borne.ShowDialog();
            Close();
        }

        // Au Clic, redirection vers le CRUD des Bornes
        private void onClickToCRUDBorne(object sender, EventArgs e)
        {
            Hide();
            var BorneCRUD = new BornesCRUD();
            BorneCRUD.ShowDialog();
            Close();
        }

        
        // Au Clic, redirection vers la page Gestion des Techniciens
        private void onClickToTechnicien(object sender, EventArgs e)
        {
            Hide();
            var Technicien = new Technicien();
            Technicien.ShowDialog();
            Close();
        }

        // Au Clic, redirection vers le CRUD des Techniciens
        private void onClickToCRUDTechnicien(object sender, EventArgs e)
        {
            Hide();
            var TechnicienCRUD = new TechnicienCRUD();
            TechnicienCRUD.ShowDialog();
            Close();
        }


        // Au Clic, redirection vers la page Gestion des Interventions
        private void onClickToIntervention(object sender, EventArgs e)
        {
            Hide();
            var Intervention = new Intervention();
            Intervention.ShowDialog();
            Close();
        }
    }
}
