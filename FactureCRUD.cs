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
            UserDAO DataUser = new UserDAO();
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
        }
    }
}
