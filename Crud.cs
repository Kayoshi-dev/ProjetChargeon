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
    public partial class Crud : Form
    {
        public Crud()
        {
            InitializeComponent();
        }

		private void PictureBox2_Click(object sender, EventArgs e)
		{
			Hide();
			var LoggedAdmin = new Gestion_Donnees();
			LoggedAdmin.ShowDialog();
			Close();
		}

		private void CloseProgram(object sender, EventArgs e)
		{
			Close();
		}
	}
}
