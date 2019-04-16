namespace ProjetChargeon
{
    partial class Accueil
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
			this.btn_connect = new System.Windows.Forms.Button();
			this.p_titre = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_localisation = new System.Windows.Forms.Button();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.button1 = new System.Windows.Forms.Button();
			this.p_titre.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_connect
			// 
			this.btn_connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
			this.btn_connect.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_connect.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(this.btn_connect, "btn_connect");
			this.btn_connect.ForeColor = System.Drawing.Color.White;
			this.btn_connect.Name = "btn_connect";
			this.btn_connect.UseVisualStyleBackColor = false;
			this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
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
			// btn_localisation
			// 
			this.btn_localisation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
			this.btn_localisation.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_localisation.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(this.btn_localisation, "btn_localisation");
			this.btn_localisation.ForeColor = System.Drawing.Color.White;
			this.btn_localisation.Name = "btn_localisation";
			this.btn_localisation.UseVisualStyleBackColor = false;
			this.btn_localisation.Click += new System.EventHandler(this.Btn_localisation_Click);
			// 
			// linkLabel1
			// 
			this.linkLabel1.ActiveLinkColor = System.Drawing.Color.White;
			resources.ApplyResources(this.linkLabel1, "linkLabel1");
			this.linkLabel1.LinkColor = System.Drawing.Color.White;
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.TabStop = true;
			this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Black;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(this.button1, "button1");
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Name = "button1";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// Accueil
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.button1);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.btn_localisation);
			this.Controls.Add(this.p_titre);
			this.Controls.Add(this.btn_connect);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "Accueil";
			this.p_titre.ResumeLayout(false);
			this.p_titre.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Panel p_titre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_localisation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Button button1;
	}
}

