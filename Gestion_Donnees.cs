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

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Return_Click(object sender, EventArgs e)
        {
            Hide();
            var accueilAdmin = new Logged_Admin();
            accueilAdmin.ShowDialog();
            Close();
        }

        private void onClickToCustomers(object sender, EventArgs e)
        {
            Hide();
            var Client = new Client();
            Client.ShowDialog();
            Close();
        }
    }
}
