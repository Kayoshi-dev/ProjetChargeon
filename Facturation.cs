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
    public partial class Facturation : Form
    {
        public Facturation()
        {
            InitializeComponent();
        }

		private void BackForm(object sender, EventArgs e)
		{
			Hide();
			var Logged_Customer = new Logged_Customer();
			Logged_Customer.ShowDialog();
			Close();
		}
	}
}
