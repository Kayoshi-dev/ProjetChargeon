using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetChargeon
{
    public partial class Facture : Form
    {
        FactureDAO DataFacturation = new FactureDAO();

        public Facture()
        {
            InitializeComponent();

            // Récupération de l'ID de l'utilisateur
            ClientDAO IdList = new ClientDAO();
            int idCustomer = IdList.GetId();

            DataSet ListeMyFacture = DataFacturation.selectMyFacture(idCustomer);

            // Affiche le Client dans la ComboBox
            cb_Facture.DisplayMember = "Fact_Titre";
            cb_Facture.ValueMember = "Fact_Id";
            cb_Facture.DataSource = ListeMyFacture.Tables[0];
        }

        private void Click_Sauvegarde(object sender, EventArgs e)
        {
            using(SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
            {
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4);
                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();
                        doc.Add(new iTextSharp.text.Paragraph(rtb_data.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        doc.Close();
                    }
                }
            }
        }

        private void SelectedFactureIndexChange(object sender, EventArgs e)
        {
            int idFacture = Convert.ToInt32(cb_Facture.SelectedValue); // idFacture vaut l'ID du champ de la ComboBox

            DataSet ListeInfosMyFacture = DataFacturation.selectInfosMyFacture(idFacture);

            l_deb.Text = ListeInfosMyFacture.Tables[0].Rows[0].ItemArray[4].ToString();
            l_fin.Text = ListeInfosMyFacture.Tables[0].Rows[0].ItemArray[5].ToString();

            rtb_data.Text = "Facture du : " + ListeInfosMyFacture.Tables[0].Rows[0].ItemArray[4].ToString() + Environment.NewLine +
                "au : " + ListeInfosMyFacture.Tables[0].Rows[0].ItemArray[5].ToString() + Environment.NewLine +
                "Montant à régler : " + ListeInfosMyFacture.Tables[0].Rows[0].ItemArray[3].ToString() + "€" ;
        }

        private void CloseProgram(object sender, EventArgs e)
        {
            Close();
        }

        private void BackForm(object sender, EventArgs e)
        {
            Hide();
            var LoggedCustomer = new Logged_Customer();
            LoggedCustomer.ShowDialog();
            Close();
        }
    }
}
