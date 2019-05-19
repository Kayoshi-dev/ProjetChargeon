/* 
 * Date de création : 31/04/2019
 * Dernière modification : 17/05/2019
 * Équipe : Nathouuuu
 * Rôle : Affichage et traitement des interventions
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
	public partial class Assistance : Form
	{
		AssistanceDAO dataAssistance = new AssistanceDAO();
        TechnicienDAO dataTechnicien = new TechnicienDAO();

		public Assistance()
		{
			InitializeComponent();

            // Initialisation de la combo box des demandes d'interventions en attente.
			DataSet listePendingAssistance = dataAssistance.selectPendingAssistances();
			cb_titreAssAtt.DisplayMember = "Assist_Titre"; // La ComboBox affiche le titre de la demande
			cb_titreAssAtt.ValueMember = "Assist_Id"; // Mais vaut l'ID correspondant
			cb_titreAssAtt.DataSource = listePendingAssistance.Tables[0]; // Affiche la seule table contenu dans le DataSource

            // Initialisation de la combo box des demandes d'interventions en cours.
            DataSet listeInProgressAssistance = dataAssistance.selectInProgressAssistances();
            cb_titreAssCur.DisplayMember = "Assist_Titre"; // La ComboBox affiche le titre de la demande
            cb_titreAssCur.ValueMember = "Assist_Id"; // Mais vaut l'ID correspondant
            cb_titreAssCur.DataSource = listeInProgressAssistance.Tables[0]; // Affiche la seule table contenu dans le DataSource

            // Initialisation de la combo box des demandes d'interventions finies.
            DataSet listeCompletedAssistance = dataAssistance.selectCompletedAssistances();
            cb_titreAssDone.DisplayMember = "Assist_Titre"; // La ComboBox affiche le titre de la demande
            cb_titreAssDone.ValueMember = "Assist_Id"; // Mais vaut l'ID correspondant
            cb_titreAssDone.DataSource = listeCompletedAssistance.Tables[0]; // Affiche la seule table contenu dans le DataSource

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

        private void IndexChangeInProgressAssist(object sender, EventArgs e)
        {
            int idSelectedAssist = Convert.ToInt32(cb_titreAssCur.SelectedValue);

            DataSet listeInProgressAssist = dataAssistance.selectInfosInProgressAssistances(idSelectedAssist);

            if(listeInProgressAssist != null)
            {
                l_numBorneCur.Text = listeInProgressAssist.Tables[0].Rows[0].ItemArray[1].ToString();
                l_typeAssCur.Text = listeInProgressAssist.Tables[0].Rows[0].ItemArray[2].ToString();
                l_technicienCur.Text = listeInProgressAssist.Tables[0].Rows[0].ItemArray[3].ToString();
            } else
            {
                l_numBorneCur.Text = null;
                l_typeAssCur.Text = null;
                l_technicienCur.Text = null;
            }
        }

        private void IndexChangeCompletedAssist(object sender, EventArgs e)
        {
            int idSelectedAssist = Convert.ToInt32(cb_titreAssDone.SelectedValue);

            DataSet listeCompletedAssist = dataAssistance.selectInfosCompletedAssistances(idSelectedAssist);

            l_numBorneDone.Text = listeCompletedAssist.Tables[0].Rows[0].ItemArray[1].ToString();
            l_typeAssDone.Text = listeCompletedAssist.Tables[0].Rows[0].ItemArray[2].ToString();
            l_technicienDone.Text = listeCompletedAssist.Tables[0].Rows[0].ItemArray[3].ToString();
        }

        private void btn_Assignation(object sender, EventArgs e)
        {
            int idSelectedAssist = Convert.ToInt32(cb_titreAssAtt.SelectedValue);
            int idSelectedTechnicien = Convert.ToInt32(cb_Technicien.SelectedValue);

            dataAssistance.SetAssistanceToInProgress(idSelectedAssist, idSelectedTechnicien);

            DataSet listePendingAssistances = dataAssistance.selectPendingAssistances();
            cb_titreAssAtt.DataSource = listePendingAssistances.Tables[0]; // Affiche la seule table contenu dans le DataSource

            DataSet listeInProgressAssistances = dataAssistance.selectInProgressAssistances();
            cb_titreAssCur.DataSource = listeInProgressAssistances.Tables[0];

            //cb_titreAssAtt.DisplayMember = null;
            //cb_titreAssAtt.ValueMember = null;
            //cb_Technicien.DisplayMember = null;
            //cb_Technicien.ValueMember = null;
            l_numBorneAtt.Text = null;
            l_typeAssAtt.Text = null;
        }

        private void btn_Terminer(object sender, EventArgs e)
        {
            int idSelectedAssist = Convert.ToInt32(cb_titreAssCur.SelectedValue);

            dataAssistance.SetAssistanceToDone(idSelectedAssist);

            DataSet listeInProgressAssistances = dataAssistance.selectInProgressAssistances();
            cb_titreAssCur.DataSource = listeInProgressAssistances.Tables[0];

            DataSet listeCompletedAssistances = dataAssistance.selectCompletedAssistances();
            cb_titreAssDone.DataSource = listeCompletedAssistances.Tables[0];
        }

        private void CloseProgram(object sender, EventArgs e)
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
