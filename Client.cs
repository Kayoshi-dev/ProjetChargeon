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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();

            CrudBornes selectClients = new CrudBornes();
            DataSet listeClients = selectClients.SelectClients();

            cb_Client.DisplayMember = "Cli_Nom"; // La ComboBox affiche la référence
            cb_Client.ValueMember = "Cli_Id"; // Mais vaut l'ID correspondant
            cb_Client.DataSource = listeClients.Tables["Client"];
        }

        private void CloseProgram(object sender, EventArgs e)
        {
            Close();
        }

        private void BackForm(object sender, EventArgs e)
        {
            Hide();
            var Logged_Customer = new Logged_Customer();
            Logged_Customer.ShowDialog();
            Close();
        }

        private void cb_Client_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
