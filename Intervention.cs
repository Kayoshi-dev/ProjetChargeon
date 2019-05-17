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
	public partial class Intervention : Form
	{
		AssistanceDAO dataAssistance = new AssistanceDAO();
        TechnicienDAO dataTechnicien = new TechnicienDAO();

		public Intervention()
		{
			InitializeComponent();

            // Initialisation de la combo box des demandes d'interventions en attente
			DataSet listePendingAssistance = dataAssistance.selectPendingAssistances();
			cb_titreAssAtt.DisplayMember = "Assist_Titre"; // La ComboBox affiche le titre de la demande
			cb_titreAssAtt.ValueMember = "Assist_Id"; // Mais vaut l'ID correspondant
			cb_titreAssAtt.DataSource = listePendingAssistance.Tables[0]; // Affiche la seule table contenu dans le DataSource
            //cb_titreAssAtt.SelectedItem = null;

            // Initialisation de la combo box des demandes d'interventions en cours.
            DataSet listeCurrentAssistance = dataAssistance.selectInProgressAssistances();
            cb_titreAssCur.DisplayMember = "Assist_Titre";
            cb_titreAssCur.ValueMember = "Assist_Id";
            cb_titreAssCur.DataSource = listeCurrentAssistance.Tables[0];

            // Initialisation du technicien
            DataSet ListeTechnicien = dataTechnicien.SelectTechniciens();
            cb_Technicien.DisplayMember = "Tech_Nom";
            cb_Technicien.ValueMember = "Tech_Id";
            cb_Technicien.DataSource = ListeTechnicien.Tables[0];
		}

		private void IndexChangePendingAssist(object sender, EventArgs e)
		{
			int idSelectedAssist = Convert.ToInt32(cb_titreAssAtt.SelectedValue); // idSelected vaut l'ID du champ de la ComboBox

			DataSet listePendingAssistance = dataAssistance.selectInfosPendingAssistances(idSelectedAssist);

			l_numBorneAtt.Text = listePendingAssistance.Tables[0].Rows[0].ItemArray[5].ToString();
			l_typeAssAtt.Text = listePendingAssistance.Tables[0].Rows[0].ItemArray[6].ToString();
		}

        private void Cb_titreAssCur_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idSelectedAssist = Convert.ToInt32(cb_titreAssCur.SelectedValue);

            DataSet listeInProgressAssist = dataAssistance.selectInfosInProgressAssistances(idSelectedAssist);

            l_numBorneCur.Text = listeInProgressAssist.Tables[0].Rows[0].ItemArray[5].ToString();
            l_typeAssCur.Text = listeInProgressAssist.Tables[0].Rows[0].ItemArray[6].ToString();
            l_technicienCur.Text = listeInProgressAssist.Tables[0].Rows[0].ItemArray[7].ToString();
        }

        private void btn_Assignation(object sender, EventArgs e)
        {
            int idSelectedAssist = Convert.ToInt32(cb_titreAssAtt.SelectedValue);
            int idSelectedTechnicien = Convert.ToInt32(cb_Technicien.SelectedValue);

            dataAssistance.SetAssistanceToInProgress(idSelectedAssist, idSelectedTechnicien);

            DataSet listePendingAssistance = dataAssistance.selectPendingAssistances();
            cb_titreAssAtt.DataSource = listePendingAssistance.Tables[0]; // Affiche la seule table contenu dans le DataSource

            DataSet listeCurrentAssistance = dataAssistance.selectInProgressAssistances();
            cb_titreAssCur.DataSource = listeCurrentAssistance.Tables[0];

            cb_titreAssAtt.DisplayMember = null;
            cb_titreAssAtt.ValueMember = null;
            cb_Technicien.DisplayMember = null;
            cb_Technicien.ValueMember = null;
            l_numBorneAtt.Text = null;
            l_typeAssAtt.Text = null;
        }

        private void CloseProgram(object sender, EventArgs e)
		{
			Close();
		}

        private void Return(object sender, EventArgs e)
        {
            Hide();
            var accueilAdmin = new Logged_Admin();
            accueilAdmin.ShowDialog();
            Close();
        }
    }
}
