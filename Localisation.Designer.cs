namespace ProjetChargeon
{
    partial class Localisation
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Localisation));
			this.p_titre = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.wb_map = new System.Windows.Forms.WebBrowser();
			this.tb_villes = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cb_bornes = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.b_valider = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.p_titre.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// p_titre
			// 
			this.p_titre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
			this.p_titre.Controls.Add(this.pictureBox1);
			this.p_titre.Controls.Add(this.label1);
			resources.ApplyResources(this.p_titre, "p_titre");
			this.p_titre.Name = "p_titre";
			// 
			// pictureBox1
			// 
			resources.ApplyResources(this.pictureBox1, "pictureBox1");
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.ForeColor = System.Drawing.SystemColors.Window;
			this.label1.Name = "label1";
			// 
			// wb_map
			// 
			resources.ApplyResources(this.wb_map, "wb_map");
			this.wb_map.Name = "wb_map";
			this.wb_map.ScrollBarsEnabled = false;
			this.wb_map.Url = new System.Uri("https://www.google.com/maps/d/u/1/embed?mid=1V7pB1Nj9I5lG1zQgtwDQMqjzxh_Fgy2p", System.UriKind.Absolute);
			// 
			// tb_villes
			// 
			resources.ApplyResources(this.tb_villes, "tb_villes");
			this.tb_villes.Name = "tb_villes";
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Name = "label2";
			// 
			// cb_bornes
			// 
			resources.ApplyResources(this.cb_bornes, "cb_bornes");
			this.cb_bornes.FormattingEnabled = true;
			this.cb_bornes.Name = "cb_bornes";
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Name = "label3";
			// 
			// b_valider
			// 
			resources.ApplyResources(this.b_valider, "b_valider");
			this.b_valider.Name = "b_valider";
			this.b_valider.UseVisualStyleBackColor = true;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
			resources.ApplyResources(this.pictureBox2, "pictureBox2");
			this.pictureBox2.Cursor = System.Windows.Forms.Cursors.PanWest;
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
			// 
			// Localisation
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.b_valider);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cb_bornes);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tb_villes);
			this.Controls.Add(this.wb_map);
			this.Controls.Add(this.p_titre);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "Localisation";
			this.p_titre.ResumeLayout(false);
			this.p_titre.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel p_titre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.WebBrowser wb_map;
        private System.Windows.Forms.TextBox tb_villes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_bornes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button b_valider;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}

