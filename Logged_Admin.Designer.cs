namespace ProjetChargeon
{
    partial class Logged_Admin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logged_Admin));
			this.p_titre = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_client = new System.Windows.Forms.Button();
			this.btn_bornes = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.btn_ajout = new System.Windows.Forms.Button();
			this.p_titre.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
			// btn_client
			// 
			this.btn_client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
			this.btn_client.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_client.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(this.btn_client, "btn_client");
			this.btn_client.ForeColor = System.Drawing.Color.White;
			this.btn_client.Name = "btn_client";
			this.btn_client.UseVisualStyleBackColor = false;
			this.btn_client.Click += new System.EventHandler(this.onClickToCustomers);
			// 
			// btn_bornes
			// 
			this.btn_bornes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
			this.btn_bornes.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_bornes.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(this.btn_bornes, "btn_bornes");
			this.btn_bornes.ForeColor = System.Drawing.Color.White;
			this.btn_bornes.Name = "btn_bornes";
			this.btn_bornes.UseVisualStyleBackColor = false;
			this.btn_bornes.Click += new System.EventHandler(this.onClickToBornes);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(this.button2, "button2");
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Name = "button2";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.onClickToStats);
			// 
			// btn_ajout
			// 
			this.btn_ajout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
			this.btn_ajout.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_ajout.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(this.btn_ajout, "btn_ajout");
			this.btn_ajout.ForeColor = System.Drawing.Color.White;
			this.btn_ajout.Name = "btn_ajout";
			this.btn_ajout.UseVisualStyleBackColor = false;
			this.btn_ajout.Click += new System.EventHandler(this.onClickToAdd);
			// 
			// Logged_Admin
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.btn_ajout);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btn_bornes);
			this.Controls.Add(this.btn_client);
			this.Controls.Add(this.p_titre);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "Logged_Admin";
			this.p_titre.ResumeLayout(false);
			this.p_titre.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel p_titre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_client;
        private System.Windows.Forms.Button btn_bornes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_ajout;
    }
}

