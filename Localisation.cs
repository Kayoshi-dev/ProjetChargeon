/* 
 * Date de création : 11/03/2019
 * Dernière modification : 11/03/2019
 * Équipe : Nathouuuu
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
    public partial class Localisation : Form
    {
        public Localisation()
        {
            InitializeComponent();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            Hide();
            var Login = new Login();
            Login.ShowDialog();
            Close();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
