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
            this.p_Chargeon = new System.Windows.Forms.Panel();
            this.img_Close = new System.Windows.Forms.PictureBox();
            this.l_Titre_Chargeon = new System.Windows.Forms.Label();
            this.btn_Données = new System.Windows.Forms.Button();
            this.btn_Stats = new System.Windows.Forms.Button();
            this.img_Return = new System.Windows.Forms.PictureBox();
            this.p_Chargeon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Return)).BeginInit();
            this.SuspendLayout();
            // 
            // p_Chargeon
            // 
            this.p_Chargeon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.p_Chargeon.Controls.Add(this.img_Close);
            this.p_Chargeon.Controls.Add(this.l_Titre_Chargeon);
            resources.ApplyResources(this.p_Chargeon, "p_Chargeon");
            this.p_Chargeon.Name = "p_Chargeon";
            // 
            // img_Close
            // 
            resources.ApplyResources(this.img_Close, "img_Close");
            this.img_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img_Close.Name = "img_Close";
            this.img_Close.TabStop = false;
            this.img_Close.Click += new System.EventHandler(this.Close);
            // 
            // l_Titre_Chargeon
            // 
            resources.ApplyResources(this.l_Titre_Chargeon, "l_Titre_Chargeon");
            this.l_Titre_Chargeon.ForeColor = System.Drawing.SystemColors.Window;
            this.l_Titre_Chargeon.Name = "l_Titre_Chargeon";
            // 
            // btn_Données
            // 
            this.btn_Données.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.btn_Données.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Données.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Données, "btn_Données");
            this.btn_Données.ForeColor = System.Drawing.Color.White;
            this.btn_Données.Name = "btn_Données";
            this.btn_Données.UseVisualStyleBackColor = false;
            this.btn_Données.Click += new System.EventHandler(this.onClickToData);
            // 
            // btn_Stats
            // 
            this.btn_Stats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.btn_Stats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Stats.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Stats, "btn_Stats");
            this.btn_Stats.ForeColor = System.Drawing.Color.White;
            this.btn_Stats.Name = "btn_Stats";
            this.btn_Stats.UseVisualStyleBackColor = false;
            this.btn_Stats.Click += new System.EventHandler(this.onClickToStats);
            // 
            // img_Return
            // 
            this.img_Return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            resources.ApplyResources(this.img_Return, "img_Return");
            this.img_Return.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.img_Return.Name = "img_Return";
            this.img_Return.TabStop = false;
            this.img_Return.Click += new System.EventHandler(this.Return);
            // 
            // Logged_Admin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.img_Return);
            this.Controls.Add(this.btn_Stats);
            this.Controls.Add(this.btn_Données);
            this.Controls.Add(this.p_Chargeon);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Logged_Admin";
            this.p_Chargeon.ResumeLayout(false);
            this.p_Chargeon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Return)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel p_Chargeon;
        private System.Windows.Forms.Label l_Titre_Chargeon;
        private System.Windows.Forms.PictureBox img_Close;
        private System.Windows.Forms.Button btn_Données;
        private System.Windows.Forms.Button btn_Stats;
		private System.Windows.Forms.PictureBox img_Return;
	}
}

