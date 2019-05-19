/* 
* Date de création : 17/04/2019
* Dernière modification : 23/04/2019
* Équipe : Nathouuuu
* Rôle : Cette classe comporte différentes méthodes concernant les factures des clients
* Développeur : Maxime
*/

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
    public partial class FactureCRUD : Form
    {
        public FactureCRUD()
        {
            InitializeComponent();

            // Initialisation de la combo box contenant les clients
            ClientDAO DataUser = new ClientDAO();
            DataSet ListCustomer = DataUser.SelectClients();

            // Affiche le Client dans la ComboBox
            cb_Client.DisplayMember = "Cli_Nom";
            cb_Client.ValueMember = "Cli_Id";
            cb_Client.DataSource = ListCustomer.Tables[0];

            int idCustomer = Convert.ToInt32(cb_Client.SelectedValue);
            BornesDAO DataBorne = new BornesDAO();
            DataSet ListBornesCustomer = DataBorne.SelectBornesCustomer(idCustomer);

            cb_Borne.DisplayMember = "Borne_Ref";
            cb_Borne.ValueMember = "Borne_Id";
            cb_Borne.DataSource = ListBornesCustomer.Tables[0];
        }

        private void SelectedClientIndexChange(object sender, EventArgs e)
        {
            int idCustomer = Convert.ToInt32(cb_Client.SelectedValue);
            BornesDAO DataBorne = new BornesDAO();
            DataSet ListBornesCustomer = DataBorne.SelectBornesCustomer(idCustomer);

            cb_Borne.DisplayMember = "Borne_Ref";
            cb_Borne.ValueMember = "Borne_Id";
            cb_Borne.DataSource = ListBornesCustomer.Tables[0];

            btn_Creer.Enabled = true;
            l_statut.Text = null;
        }

        private void btn_CreateFacture(object sender, EventArgs e)
        {
            int idCustomer = Convert.ToInt32(cb_Client.SelectedValue);
            int idBorne = Convert.ToInt32(cb_Borne.SelectedValue);

            // On converti pour correspondre au format de la base de donnée
            string dateDebut = dtp_Debut.Value.Date.ToString("yyyy-MM-dd");
            string dateFin = dtp_Fin.Value.Date.ToString("yyyy-MM-dd");

            FactureDAO DataFacturation = new FactureDAO();
            bool validate = DataFacturation.addNewFacture(tb_Titre.Text, Convert.ToInt32(tb_Montant.Text), dateDebut, dateFin, idCustomer, idBorne);

            if(validate == true)
            {
                btn_Creer.Enabled = false;
                l_statut.Text = "Facture crée!";
            }

            else
            {
                l_statut.Text = "Une erreur est survenue";
            }
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }

        private void Return(object sender, EventArgs e)
        {
            Hide();
            var Data = new Gestion_Donnees();
            Data.ShowDialog();
            Close();
        }
    }
}
