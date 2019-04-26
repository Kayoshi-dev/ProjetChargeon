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

            // Affiche dans la ComboBox la liste des Techniciens enregistrés dans la BDD
            TechnicienDAO selectTechnicien = new TechnicienDAO();
            DataSet listeTechniciens = selectTechnicien.SelectTechniciens();

            // Affiche le Nom du Technicien dans les ComboBox
            cb_Nom_Modif.DisplayMember = "Tech_Nom";
            //cb_Nom_Supprimer.DisplayMember = "Tech_Nom";

            // ID du Technicien Sélectionné
            cb_Nom_Modif.ValueMember = "Tech_Id";
            //cb_Nom_Supprimer.ValueMember = "Tech_Id";

            cb_Nom_Modif.DataSource = listeTechniciens.Tables["Technicien"];
            //cb_Nom_Supprimer.DataSource = listeTechniciens.Tables["Technicien"];
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

        // Au Clic, Ajoute un technicien dans la BDD
        private void AddTechnicien(object sender, EventArgs e)
        {
            /*bool test = DataUser.InsertCustomer(tb_Nom_Ajout.Text, tb_Adresse_Ajout.Text, tb_CP_Ajout.Text, tb_Ville_Ajout.Text);

            if (test == true)
            {
                tb_Nom_Ajout.Text = "";
                tb_Adresse_Ajout.Text = "";
                tb_CP_Ajout.Text = "";
                tb_Ville_Ajout.Text = "";
            }

            DataSet ListCustomer = DataUser.SelectClients();
            cb_Nom.DataSource = ListCustomer.Tables[0];*/
        }

        // Au Clic, Modifie les données du technicien sélectionné
        private void UpdateTechnicien(object sender, EventArgs e)
        {

        }

        // Après avoir choisi le technicien dans la ComoBox, affiche ces données
        private void DataTechnicienChanged(object sender, EventArgs e)
        {

        }
    }
}
