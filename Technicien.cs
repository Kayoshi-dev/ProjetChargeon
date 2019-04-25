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
    public partial class Technicien : Form
    {
        /* Code lors de l'initialisation de la Page */

        public Technicien()
        {
            InitializeComponent();

            // Affiche dans la ComboBox la liste des Techniciens enregistrés dans la BDD
            CrudBornes selectTechnicien = new CrudBornes();
            DataSet listeTechniciens = selectTechnicien.SelectTechniciens();

            // Affiche le Nom du Technicien dans la ComboBox
            cb_Technicien.DisplayMember = "Tech_Nom";

            // ID du Technicien Sélectionné
            cb_Technicien.ValueMember = "Tech_Id";

            cb_Technicien.DataSource = listeTechniciens.Tables["Technicien"];
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
    }
}
