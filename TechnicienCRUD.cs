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
        public class Item
        {
            public string Name;
            public int Value;

            public Item(string name, int value)
            {
                Name = name;
                Value = value;
            }

            public override string ToString()
            {
                return Name;
            }
        }

        TechnicienDAO DataTechnicien = new TechnicienDAO();

        /* Code lors de l'initialisation de la Page */

        public TechnicienCRUD()
        {
            InitializeComponent();
            InitializeComboBoxNomUpdate();
            InitializeComboBoxNomDelete();
            InitializeComboBoxDispoAdd();
            InitializeComboBoxDispoUpdate();
        }

        private void InitializeComboBoxDispoAdd()
        {
            cb_Dispo_Ajout.Items.Add(new Item("Oui", 1));
            cb_Dispo_Ajout.Items.Add(new Item("Non", 0));
        }

        private void InitializeComboBoxDispoUpdate()
        {
            cb_Dispo_Modif.Items.Add(new Item("Oui", 1));
            cb_Dispo_Modif.Items.Add(new Item("Non", 0));
        }

        private void InitializeComboBoxNomUpdate()
        {
            // Affiche dans la ComboBox Update la liste des Techniciens enregistrés dans la BDD
            TechnicienDAO selectTechnicien = new TechnicienDAO();
            DataSet listeTechniciens = selectTechnicien.SelectTechniciens();

            // Affiche le Nom du Technicien dans la ComboBox
            cb_Nom_Modif.DisplayMember = "Tech_Nom";

            // ID du Technicien Sélectionné
            cb_Nom_Modif.ValueMember = "Tech_Id";

            cb_Nom_Modif.DataSource = listeTechniciens.Tables["Technicien"];
        }

        private void InitializeComboBoxNomDelete()
        {
            // Affiche dans la ComboBox Delete la liste des Techniciens enregistrés dans la BDD
            TechnicienDAO selectTechnicien = new TechnicienDAO();
            DataSet listeTechniciens = selectTechnicien.SelectTechniciens();

            // Affiche le Nom du Technicien dans la ComboBox
            cb_Nom_Supprimer.DisplayMember = "Tech_Nom";

            // ID du Technicien Sélectionné
            cb_Nom_Supprimer.ValueMember = "Tech_Id";

            cb_Nom_Supprimer.DataSource = listeTechniciens.Tables["Technicien"];
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

        // ComboBox Update : Affiche les données du technicien sélectionné
        private void DataSelected(object sender, EventArgs e)
        {
            // On récupère l'ID de la ComboBox
            string idSelected = cb_Nom_Modif.SelectedValue.ToString();

            TechnicienDAO selectDetailsTechniciens = new TechnicienDAO();
            DataSet listeDetailsTechniciens = selectDetailsTechniciens.SelectDetailsTechnicien(idSelected);

            // Condition pour Vérifier l'éxistence de la donnée Nom
            if (listeDetailsTechniciens.Tables[0].Rows[0].ItemArray[1].ToString() != null)
            {
                // Affiche le prénom du client sélectionné
                tb_Nom_Modif.Text = listeDetailsTechniciens.Tables[0].Rows[0].ItemArray[1].ToString();
            }
            else
            {
                tb_Nom_Modif.Text = "";
            }

            // Condition pour Vérifier l'éxistence de la donnée Prénom
            if (listeDetailsTechniciens.Tables[0].Rows[0].ItemArray[2].ToString() != null)
            {
                // Affiche le prénom du client sélectionné
                tb_Prenom_Modif.Text = listeDetailsTechniciens.Tables[0].Rows[0].ItemArray[2].ToString();
            }
            else
            {
                tb_Prenom_Modif.Text = "";
            }
        }

        // Au Clic, on ajoute un technicien dans la BDD
        private void AddTechnicien(object sender, EventArgs e)
        {
            //bool test = DataTechnicien.InsertTechnicien(tb_Nom_Ajout.Text, tb_Prenom_Ajout.Text, Convert.ToInt32(cb_Dispo_Ajout.SelectedValue));
            bool test = DataTechnicien.InsertTechnicien(tb_Nom_Ajout.Text, tb_Prenom_Ajout.Text, (cb_Dispo_Ajout.SelectedItem as Item).Value);
            if (test == true)
            {
                tb_Nom_Ajout.Text = "";
                tb_Prenom_Ajout.Text = "";
                cb_Dispo_Ajout.Text = "";
            }

            MessageBox.Show("Technicien Ajouté");

            DataSet ListTechnicien = DataTechnicien.SelectTechniciens();
			cb_Nom_Modif.DataSource = ListTechnicien.Tables[0];
            cb_Nom_Supprimer.DataSource = ListTechnicien.Tables[0];
        }

        // Au Clic, on peut modifier les données enregistrées dans la BDD en fonction du technicien sélectionné
        private void UpdateTechnicien(object sender, EventArgs e)
        {
            string idSelected = cb_Nom_Modif.SelectedValue.ToString();

            bool test = DataTechnicien.UpdateTechnicien(idSelected, tb_Nom_Modif.Text, tb_Prenom_Modif.Text, (cb_Dispo_Modif.SelectedItem as Item).Value);

            if (test == true)
            {
                tb_Nom_Modif.Text = "";
                tb_Prenom_Modif.Text = "";
                cb_Dispo_Modif.Text = "";
            }

            MessageBox.Show("Technicien Modifié");

            DataSet ListTechnicien = DataTechnicien.SelectTechniciens();
			cb_Nom_Modif.DataSource = ListTechnicien.Tables[0];
            cb_Nom_Supprimer.DataSource = ListTechnicien.Tables[0];
        }

        // Au Clic, on supprime le technicien sélectionné de la BDD
        private void DeleteTechnicien(object sender, EventArgs e)
        {
            string idSelected = cb_Nom_Supprimer.SelectedValue.ToString();

            bool test = DataTechnicien.DeleteTechnicien(idSelected);

            DataSet ListTechnicien = DataTechnicien.SelectTechniciens();
            cb_Nom_Supprimer.DataSource = ListTechnicien.Tables[0];
            cb_Nom_Modif.DataSource = ListTechnicien.Tables[0];

            MessageBox.Show("Technicien Supprimé");
        }
    }
}
