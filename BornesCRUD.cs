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
    public partial class BornesCRUD : Form
    {
        /* Nouvelle Classe pour les ComboBox du CRUD */

        // Avec cette classe, on peut ajouter des nouveaux items dans des ComboBox, avec une valeur et un libelle
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


        BornesDAO DataBorne = new BornesDAO();
        UserDAO DataUser = new UserDAO();
        SiteDAO DataSite = new SiteDAO();


        /* Code lors de l'initialisation de la Page */

        public BornesCRUD()
        {
            InitializeComponent();

            // A l'initialisation de la page : Afficher la liste des Sites dans la ComboBox (INSERT)
            InitializeAjoutComboBoxSite();

            // A l'initialisation de la page : Afficher la liste des Clients dans la ComboBox (INSERT)
            InitializeAjoutComboBoxClient();

            // A l'initialisation de la page : Afficher les options pour la ComboBox Type (INSERT)
            InitializeAjoutComboBoxType();

            // A l'initialisation de la page : Afficher les options pour la ComboBox Etat (INSERT)
            InitializeAjoutComboBoxEtat();

            // A l'initialisation de la page : Afficher les options pour la ComboBox Priorite (INSERT)
            InitializeAjoutComboBoxPriorite();

            // A l'initialisation de la page : Afficher la liste des Sites dans la ComboBox (UPDATE)
            InitializeModifComboBoxSite();

            // A l'initialisation de la page : Afficher la liste des Clients dans la ComboBox (UPDATE)
            InitializeModifComboBoxClient();

            // A l'initialisation de la page : Afficher les options pour la ComboBox Type (UPDATE)
            InitializeModifComboBoxType();

            // A l'initialisation de la page : Afficher les options pour la ComboBox Etat (UPDATE)
            InitializeModifComboBoxEtat();

            // A l'initialisation de la page : Afficher les options pour la ComboBox Priorite (UPDATE)
            InitializeModifComboBoxPriorite();

            // A l'initialisation de la page : Afficher la liste des Bornes dans la ComboBox (UPDATE)
            InitializeComboBoxBorneUpdate();

            // A l'initialisation de la page : Afficher la liste des Bornes dans la ComboBox (DELETE)
            InitializeComboBoxBorneDelete();
        }

        // Fonction pour afficher des données dans la ComboBox cb_Client_Ajout
        private void InitializeAjoutComboBoxClient()
        {
            // Affiche dans la ComboBox Update la liste des Clients enregistrés dans la BDD
            DataSet ListClient = DataUser.SelectClients();

            // Affiche le Client dans la ComboBox
            cb_Client_Ajout.DisplayMember = "Cli_Nom";
            cb_Client_Ajout.ValueMember = "Cli_Id";
            cb_Client_Ajout.DataSource = ListClient.Tables[0];

        }

        // Fonction pour afficher des données dans la ComboBox cb_Site_Ajout
        private void InitializeAjoutComboBoxSite()
        {
            // Affiche dans la ComboBox Update la liste des Sites enregistrés dans la BDD
            DataSet ListSite = DataSite.SelectSites();

            // Affiche le Site dans la ComboBox
            cb_Site_Ajout.DisplayMember = "Site_Nom";
            cb_Site_Ajout.ValueMember = "Site_Id";
            cb_Site_Ajout.DataSource = ListSite.Tables[0];
        }

        // Fonction pour afficher des données dans la ComboBox cb_Etat_Type
        private void InitializeAjoutComboBoxType()
        {
            cb_Type_Ajout.Items.Add(new Item("Intérieur", 1));
            cb_Type_Ajout.Items.Add(new Item("Extérieur", 0));
        }

        // Fonction pour afficher des données dans la ComboBox cb_Etat_Ajout
        private void InitializeAjoutComboBoxEtat()
        {
            cb_Etat_Ajout.Items.Add(new Item("ON", 1));
            cb_Etat_Ajout.Items.Add(new Item("OFF", 0));
        }

        // Fonction pour afficher des données dans la ComboBox cb_Prio_Ajout
        private void InitializeAjoutComboBoxPriorite()
        {
            cb_Prio_Ajout.Items.Add(new Item("Elevée", 1));
            cb_Prio_Ajout.Items.Add(new Item("Normale", 0));
        }

        // Fonction pour afficher des données dans la ComboBox cb_Site_Modif
        private void InitializeModifComboBoxClient()
        {
            // Affiche dans la ComboBox Update la liste des Clients enregistrés dans la BDD
            DataSet ListClient = DataUser.SelectClients();

            // Affiche le Client dans la ComboBox
            cb_Client_Modif.DisplayMember = "Cli_Nom";
            cb_Client_Modif.ValueMember = "Cli_Id";
            cb_Client_Modif.DataSource = ListClient.Tables[0];

        }

        // Fonction pour afficher des données dans la ComboBox cb_Site_Modif
        private void InitializeModifComboBoxSite()
        {
            // Affiche dans la ComboBox Update la liste des Sites enregistrés dans la BDD
            DataSet ListSite = DataSite.SelectSites();

            // Affiche le Site dans la ComboBox
            cb_Site_Modif.DisplayMember = "Site_Nom";
            cb_Site_Modif.ValueMember = "Site_Id";
            cb_Site_Modif.DataSource = ListSite.Tables[0];
        }

        // Fonction pour afficher des données dans la ComboBox cb_Etat_Type
        private void InitializeModifComboBoxType()
        {
            cb_Type_Modif.Items.Add(new Item("Intérieur", 1));
            cb_Type_Modif.Items.Add(new Item("Extérieur", 0));
        }

        // Fonction pour afficher des données dans la ComboBox cb_Etat_Etat
        private void InitializeModifComboBoxEtat()
        {
            cb_Etat_Modif.Items.Add(new Item("ON", 1));
            cb_Etat_Modif.Items.Add(new Item("OFF", 0));
        }

        // Fonction pour afficher des données dans la ComboBox cb_Type_Modif
        private void InitializeModifComboBoxPriorite()
        {
            cb_Prio_Modif.Items.Add(new Item("Elevée", 1));
            cb_Prio_Modif.Items.Add(new Item("Normale", 0));
        }

        private void InitializeComboBoxBorneUpdate()
        {
            // Affiche dans la ComboBox Update la liste des Bornes enregistrés dans la BDD
            BornesDAO selectBorne = new BornesDAO();
            DataSet listeBornes = selectBorne.SelectBornes();

            // Affiche le Nom du Technicien dans la ComboBox
            cb_Borne_Modif.DisplayMember = "Borne_Ref";

            // ID du Technicien Sélectionné
            cb_Borne_Modif.ValueMember = "Borne_Id";

            cb_Borne_Modif.DataSource = listeBornes.Tables[0];
        }

        private void InitializeComboBoxBorneDelete()
        {
            // Affiche dans la ComboBox Delete la liste des Bornes enregistrés dans la BDD
            BornesDAO selectBorne = new BornesDAO();
            DataSet listeBornes = selectBorne.SelectBornes();

            // Affiche le Nom du Technicien dans la ComboBox
            cb_Borne_Supprimer.DisplayMember = "Borne_Ref";

            // ID du Technicien Sélectionné
            cb_Borne_Supprimer.ValueMember = "Borne_Id";

            cb_Borne_Supprimer.DataSource = listeBornes.Tables[0];
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


        /* On affiche les Données dans la ComboBox cb_Borne_Modif en fonction de la Borne Sélectionnée */

        private void DataBorneSelected(object sender, EventArgs e)
        {
            // On récupère l'ID de la ComboBox
            string idSelected = cb_Borne_Modif.SelectedValue.ToString();

            BornesDAO selectDetailsBorne = new BornesDAO();
            DataSet listeDetailsBornes = selectDetailsBorne.SelectDetailsBornesForCRUD(idSelected);

            // Condition pour Vérifier l'éxistence de la donnée Nom du Site
            if (listeDetailsBornes.Tables[0].Rows[0].ItemArray[0].ToString() != null)
            {
                // Affiche le nom du Site de la Borne sélectionnée
                cb_Site_Modif.Text = listeDetailsBornes.Tables[0].Rows[0].ItemArray[0].ToString();
            }
            else
            {
                cb_Site_Modif.Text = "";
            }

            // Condition pour Vérifier l'éxistence de la donnée Nom du Client
            if (listeDetailsBornes.Tables[0].Rows[0].ItemArray[1].ToString() != null)
            {
                // Affiche le nom du Client de la Borne sélectionnée
                cb_Client_Modif.Text = listeDetailsBornes.Tables[0].Rows[0].ItemArray[1].ToString();
            }
            else
            {
                cb_Client_Modif.Text = "";
            }

            // Condition pour Vérifier l'éxistence de la donnée Référence
            if (listeDetailsBornes.Tables[0].Rows[0].ItemArray[3].ToString() != null)
            {
                // Affiche la Référence de la Borne sélectionnée
                tb_Ref_Modif.Text = listeDetailsBornes.Tables[0].Rows[0].ItemArray[3].ToString();
            }
            else
            {
                tb_Ref_Modif.Text = "";
            }

            // Condition pour Vérifier l'éxistence de la donnée Numéro de Série
            if (listeDetailsBornes.Tables[0].Rows[0].ItemArray[4].ToString() != null)
            {
                // Affiche le Numéro de Série de la Borne sélectionnée
                tb_NS_Modif.Text = listeDetailsBornes.Tables[0].Rows[0].ItemArray[4].ToString();
            }
            else
            {
                tb_NS_Modif.Text = "";
            }

            // Condition pour Vérifier l'éxistence de la donnée Description
            if (listeDetailsBornes.Tables[0].Rows[0].ItemArray[5].ToString() != null)
            {
                // Affiche la Description de la Borne sélectionnée
                tb_Description_Modif.Text = listeDetailsBornes.Tables[0].Rows[0].ItemArray[5].ToString();
            }
            else
            {
                tb_Description_Modif.Text = "";
            }

            // Condition pour Vérifier l'éxistence de la donnée Type
            if (listeDetailsBornes.Tables[0].Rows[0].ItemArray[6].ToString() == "True")
            {
                // Affiche le Type de la Borne sélectionnée
                cb_Type_Modif.Text = "Intérieur";
            }
            else if (listeDetailsBornes.Tables[0].Rows[0].ItemArray[6].ToString() == "False")
            {
                cb_Type_Modif.Text = "Extérieur";
            }
            else
            {
                cb_Type_Modif.Text = "X"; // X pour Erreur
            }

            // Condition pour Vérifier l'éxistence de la donnée Etat
            if (listeDetailsBornes.Tables[0].Rows[0].ItemArray[7].ToString() == "True")
            {
                // Affiche l'Etat de la Borne sélectionnée
                cb_Etat_Modif.Text = "ON";
            }
            else if(listeDetailsBornes.Tables[0].Rows[0].ItemArray[7].ToString() == "False")
            {
                cb_Etat_Modif.Text = "OFF";
            }
            else
            {
                cb_Etat_Modif.Text = "X"; // X pour Erreur
            }

            // Condition pour Vérifier l'éxistence de la donnée Puissance
            if (listeDetailsBornes.Tables[0].Rows[0].ItemArray[8].ToString() != null)
            {
                // Affiche la Puissance de la Borne sélectionnée
                tb_Puissance_Modif.Text = listeDetailsBornes.Tables[0].Rows[0].ItemArray[8].ToString();
            }
            else
            {
                tb_Puissance_Modif.Text = "";
            }

            // Condition pour Vérifier l'éxistence de la donnée Priorité
            if (listeDetailsBornes.Tables[0].Rows[0].ItemArray[9].ToString() == "1")
            {
                // Affiche la Priorité de la Borne sélectionnée
                cb_Prio_Modif.Text = "Elevée";
            }
            else if(listeDetailsBornes.Tables[0].Rows[0].ItemArray[9].ToString() == "0")
            {
                cb_Prio_Modif.Text = "Normale";
            }
            else
            {
                cb_Prio_Modif.Text = "X"; // X pour Erreur
            }
        }


        /* Evènements au Clic sur les Boutons */

        // Au Clic, on ajoute une borne dans la BDD
        private void AddBorne(object sender, EventArgs e)
        {
            bool test = DataBorne.InsertBorne(Convert.ToInt32(cb_Site_Ajout.SelectedValue), Convert.ToInt32(cb_Client_Ajout.SelectedValue), tb_Ref_Ajout.Text, tb_NS_Ajout.Text, tb_Description_Ajout.Text, (cb_Type_Ajout.SelectedItem as Item).Value, (cb_Etat_Ajout.SelectedItem as Item).Value, tb_Puissance_Ajout.Text, (cb_Prio_Ajout.SelectedItem as Item).Value);
            if (test == true)
            {
                tb_Ref_Ajout.Text = "";
                tb_NS_Ajout.Text = "";
                tb_Description_Ajout.Text = "";
                cb_Type_Ajout.Text = "";
                cb_Etat_Ajout.Text = "";
                tb_Puissance_Ajout.Text = "";
                cb_Prio_Ajout.Text = "";
            }

            MessageBox.Show("Borne Ajoutée");

            // Met à Jour les ComboBox Update et Delete
            DataSet ListeBorne = DataBorne.SelectBornes();
            cb_Borne_Modif.DataSource = ListeBorne.Tables[0];
            cb_Borne_Supprimer.DataSource = ListeBorne.Tables[0];
        }

        // Au Clic, on met à jour une borne dans la BDD
        private void UpdateBorne(object sender, EventArgs e)
        {
            string idSelected = cb_Borne_Modif.SelectedValue.ToString();

            bool test = DataBorne.UpdateBorne(Convert.ToInt32(cb_Site_Modif.SelectedValue), Convert.ToInt32(cb_Client_Modif.SelectedValue), tb_Ref_Modif.Text, tb_Description_Modif.Text, tb_NS_Modif.Text, (cb_Type_Modif.SelectedItem as Item).Value, (cb_Etat_Modif.SelectedItem as Item).Value, tb_Puissance_Modif.Text, (cb_Prio_Modif.SelectedItem as Item).Value, idSelected);
            if (test == true)
            {
                cb_Borne_Modif.Text = "";
                cb_Site_Modif.Text = "";
                cb_Client_Modif.Text = "";
                tb_Ref_Modif.Text = "";
                tb_NS_Modif.Text = "";
                tb_Description_Modif.Text = "";
                cb_Type_Modif.Text = "";
                cb_Etat_Modif.Text = "";
                tb_Puissance_Modif.Text = "";
                cb_Prio_Modif.Text = "";
            }

            MessageBox.Show("Borne Mise à Jour");

            // Met à Jour les ComboBox Update et Delete
            DataSet ListeBorne = DataBorne.SelectBornes();
            cb_Borne_Modif.DataSource = ListeBorne.Tables[0];
            cb_Borne_Supprimer.DataSource = ListeBorne.Tables[0];
        }

        // Au Clic, on supprime une borne de la BDD
        private void DeleteBorne(object sender, EventArgs e)
        {
            string idSelected = cb_Borne_Supprimer.SelectedValue.ToString();

            bool test = DataBorne.DeleteBorne(idSelected);

            MessageBox.Show("Borne Supprimée");

            // Met à Jour les ComboBox Update et Delete
            DataSet ListeBornes = DataBorne.SelectBornes();
            cb_Borne_Supprimer.DataSource = ListeBornes.Tables[0];
            cb_Borne_Modif.DataSource = ListeBornes.Tables[0];
        }
    }
}
