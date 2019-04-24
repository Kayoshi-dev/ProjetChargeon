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
    public partial class ClientCRUD : Form
    {
        public ClientCRUD()
        {
            InitializeComponent();

            /* Au démarrage de l'initialisation, les TextBox & le bouton sont bloqués */

            // On bloque la TextBox Nom & On change le BackGroundColor
            tb_Nom_MAJ.Enabled = false;
            tb_Nom_MAJ.BackColor = Color.Gray;

            // On bloque la TextBox Adresse & On change le BackGroundColor
            tb_Adresse_MAJ.Enabled = false;
            tb_Adresse_MAJ.BackColor = Color.Gray;

            // On bloque la TextBox Code Postal & On change le BackGroundColor
            tb_CP_MAJ.Enabled = false;
            tb_CP_MAJ.BackColor = Color.Gray;

            // On bloque la TextBox Ville & On change le BackGroundColor
            tb_Ville_MAJ.Enabled = false;
            tb_Ville_MAJ.BackColor = Color.Gray;

            // On bloque la ComboBox Nom & On change le BakcGroundColor
            cb_Nom.Enabled = false;
            cb_Nom.BackColor = Color.Gray;

            // Pour la Zone "Supprimer un Client", on bloque le Bouton Enregistrer & On change le BackGroundColor
            bt_Supprimer.Enabled = false;
            bt_Supprimer.BackColor = Color.Gray;


            /* Afficher à l'initialisation la liste des Clients */

            CrudBornes selectClients = new CrudBornes();
            DataSet listeClients = selectClients.SelectClients();

            // Affiche le Client dans la ComboBox
            cb_Nom.DisplayMember = "Cli_Nom";

            // ID du Client Sélectionné
            cb_Nom.ValueMember = "Cli_Id";

            cb_Nom.DataSource = listeClients.Tables["Client"];

        }

        // Au Clic sur l'image, on ferme l'application
        private void Close(object sender, EventArgs e)
        {
            Close();
        }

        // Au Clic sur l'image, on retourne à la page précédente
        private void Return(object sender, EventArgs e)
        {
            Hide();
            var Data = new Gestion_Donnees();
            Data.ShowDialog();
            Close();
        }

        private void NomIsCheck(object sender, EventArgs e)
        {
            // CheckBox Nom
            CheckState stateNom = chb_Nom_MAJ.CheckState;

            // Evènement si CheckBox est Check ou pas
            switch (stateNom)
            {
                // Si Check : on rend la TextBox Nom saisisable & On remet le BackGroundColor initial
                case CheckState.Checked:
                    {
                        tb_Nom_MAJ.Enabled = true;
                        tb_Nom_MAJ.BackColor = Color.White;
                        break;
                    }
                // Sinon on remet à l'état initial
                case CheckState.Indeterminate:
                case CheckState.Unchecked:
                    {
                        tb_Nom_MAJ.Enabled = false;
                        tb_Nom_MAJ.BackColor = Color.Gray;
                        break;
                    }
            }
        }

        private void AdresseIsCheck(object sender, EventArgs e)
        {
            // CheckBox Adresse
            CheckState stateAdresse = chb_Adresse.CheckState;

            // Evènement si CheckBox est Check ou pas
            switch (stateAdresse)
            {
                // Si Check : on rend la TextBox Adresse saisisable & On remet le BackGroundColor initial
                case CheckState.Checked:
                    {
                        tb_Adresse_MAJ.Enabled = true;
                        tb_Adresse_MAJ.BackColor = Color.White;
                        break;
                    }
                // Sinon on remet à l'état initial
                case CheckState.Indeterminate:
                case CheckState.Unchecked:
                    {
                        tb_Adresse_MAJ.Enabled = false;
                        tb_Adresse_MAJ.BackColor = Color.Gray;
                        break;
                    }
            }
        }

        private void CPIsCheck(object sender, EventArgs e)
        {
            // CheckBox Code Postal (CP)
            CheckState stateCP = chb_CP.CheckState;

            // Evènement si CheckBox est Check ou pas
            switch (stateCP)
            {
                // Si Check : on rend la TextBox CP saisisable & On remet le BackGroundColor initial
                case CheckState.Checked:
                    {
                        tb_CP_MAJ.Enabled = true;
                        tb_CP_MAJ.BackColor = Color.White;
                        break;
                    }
                // Sinon on remet à l'état initial
                case CheckState.Indeterminate:
                case CheckState.Unchecked:
                    {
                        tb_CP_MAJ.Enabled = false;
                        tb_CP_MAJ.BackColor = Color.Gray;
                        break;
                    }
            }
        }

        private void VilleIsCheck(object sender, EventArgs e)
        {
            // CheckBox Ville
            CheckState stateVille = chb_Ville.CheckState;

            // Evènement si CheckBox est Check ou pas
            switch (stateVille)
            {
                // Si Check : on rend la TextBox Ville saisisable & On remet le BackGroundColor initial
                case CheckState.Checked:
                    {
                        tb_Ville_MAJ.Enabled = true;
                        tb_Ville_MAJ.BackColor = Color.White;
                        break;
                    }
                // Sinon on remet à l'état initial
                case CheckState.Indeterminate:
                case CheckState.Unchecked:
                    {
                        tb_Ville_MAJ.Enabled = false;
                        tb_Ville_MAJ.BackColor = Color.Gray;
                        break;
                    }
            }
        }

        private void NomIsCheck_2(object sender, EventArgs e)
        {
            // ComboBox Nom
            CheckState stateNom = chb_Nom_Supprimer.CheckState;

            // Evènement si CheckBox est Check ou pas
            switch (stateNom)
            {
                // Si Check : on rend la ComboBox Nom saisisable et le Bouton Enregistrer cliquable & On remet le BackGroundColor initial
                case CheckState.Checked:
                    {
                        cb_Nom.Enabled = true;
                        cb_Nom.BackColor = Color.White;
                        bt_Supprimer.Enabled = true;
                        bt_Supprimer.BackColor = Color.White;
                        break;
                    }
                // Sinon on remet tout à l'état initial
                case CheckState.Indeterminate:
                case CheckState.Unchecked:
                    {
                        cb_Nom.Enabled = false;
                        cb_Nom.BackColor = Color.Gray;
                        bt_Supprimer.Enabled = false;
                        bt_Supprimer.BackColor = Color.Gray;
                        break;
                    }
            }
        }

        private void Supprimer_Client(object sender, EventArgs e)
        {
            // On récupère l'ID de la ComboBox
            string idSelected = cb_Nom.SelectedValue.ToString();

            CrudBornes deleteClient = new CrudBornes();
            bool deleteClientBool = deleteClient.DeleteClient(idSelected);

            if (deleteClientBool == true)
            {
                MessageBox.Show("Requête exécutée, client supprimé !");
            }
            else
            {
                MessageBox.Show("Erreur : Requête non exécutée !");
            }
        }
    }
}
