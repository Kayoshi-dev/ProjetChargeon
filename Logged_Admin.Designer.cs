﻿namespace ProjetChargeon
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
            this.p_Titre_Chargeon = new System.Windows.Forms.Panel();
            this.img_Close = new System.Windows.Forms.PictureBox();
            this.l_Titre_Chargeon = new System.Windows.Forms.Label();
            this.bt_Données = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.img_Return = new System.Windows.Forms.PictureBox();
            this.p_Titre_Chargeon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Return)).BeginInit();
            this.SuspendLayout();
            // 
            // p_Titre_Chargeon
            // 
            this.p_Titre_Chargeon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.p_Titre_Chargeon.Controls.Add(this.img_Close);
            this.p_Titre_Chargeon.Controls.Add(this.l_Titre_Chargeon);
            resources.ApplyResources(this.p_Titre_Chargeon, "p_Titre_Chargeon");
            this.p_Titre_Chargeon.Name = "p_Titre_Chargeon";
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
            // bt_Données
            // 
            this.bt_Données.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.bt_Données.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Données.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.bt_Données, "bt_Données");
            this.bt_Données.ForeColor = System.Drawing.Color.White;
            this.bt_Données.Name = "bt_Données";
            this.bt_Données.UseVisualStyleBackColor = false;
            this.bt_Données.Click += new System.EventHandler(this.onClickToData);
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
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bt_Données);
            this.Controls.Add(this.p_Titre_Chargeon);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Logged_Admin";
            this.p_Titre_Chargeon.ResumeLayout(false);
            this.p_Titre_Chargeon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Return)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel p_Titre_Chargeon;
        private System.Windows.Forms.Label l_Titre_Chargeon;
        private System.Windows.Forms.PictureBox img_Close;
        private System.Windows.Forms.Button bt_Données;
        private System.Windows.Forms.Button button2;
		private System.Windows.Forms.PictureBox img_Return;
	}
}

