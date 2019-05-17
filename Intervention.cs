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

		public Intervention()
		{
			InitializeComponent();

			DataSet listePendingAssistance = dataAssistance.selectPendingAssistances();
			cb_titreAssAtt.DisplayMember = "Assist_Titre"; // La ComboBox affiche le titre de la demande
			cb_titreAssAtt.ValueMember = "Assist_Id"; // Mais vaut l'ID correspondant
			cb_titreAssAtt.DataSource = listePendingAssistance.Tables[0]; // Affiche la seule table contenu dans le DataSource
			//cb_titreAssAtt.SelectedItem = null;
		}

		private void IndexChangePendingAssist(object sender, EventArgs e)
		{
			int idSelectedAssist = Convert.ToInt32(cb_titreAssAtt.SelectedValue); // idSelected vaut l'ID du champ de la ComboBox

			DataSet listePendingAssistance = dataAssistance.selectInfosPendingAssistances(idSelectedAssist);

			l_numBorneAtt.Text = listePendingAssistance.Tables[0].Rows[0].ItemArray[5].ToString();
			l_typeAssAtt.Text = listePendingAssistance.Tables[0].Rows[0].ItemArray[6].ToString();
		}

		private void CloseProgram(object sender, EventArgs e)
		{
			Close();
		}
	}
}
