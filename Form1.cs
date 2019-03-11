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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(53, 70, 100);
            p_titre.BackColor = Color.FromArgb(33, 43, 61);
            btn_localisation.BackColor = Color.FromArgb(33, 43, 61);
            btn_connect.BackColor = Color.FromArgb(33, 43, 61);
        }
    }
}
