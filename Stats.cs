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
    public partial class Stats : Form
    {
        public Stats()
        {
            InitializeComponent();
        }

		private void CloseProgram(object sender, EventArgs e)
		{
			Close();
		}

		private void PictureBox4_Click(object sender, EventArgs e)
		{
			Hide();
			var Logged_Admin = new Logged_Admin();
			Logged_Admin.ShowDialog();
			Close();
		}
	}
}
