﻿namespace ProjetChargeon
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_localisation = new System.Windows.Forms.Button();
            this.p_titre.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_connect
            // 
            this.btn_connect.BackColor = System.Drawing.Color.Black;
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
            this.p_titre.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.p_titre.Controls.Add(this.label1);
            resources.ApplyResources(this.p_titre, "p_titre");
            this.p_titre.Name = "p_titre";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Name = "label1";
            // 
            // btn_localisation
            // 
            this.btn_localisation.BackColor = System.Drawing.Color.Black;
            this.btn_localisation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_localisation.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_localisation, "btn_localisation");
            this.btn_localisation.ForeColor = System.Drawing.Color.White;
            this.btn_localisation.Name = "btn_localisation";
            this.btn_localisation.UseVisualStyleBackColor = false;
            // 
            // Accueil
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.btn_localisation);
            this.Controls.Add(this.p_titre);
            this.Controls.Add(this.btn_connect);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MaximizeBox = false;
            this.Name = "Accueil";
            this.p_titre.ResumeLayout(false);
            this.p_titre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Panel p_titre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_localisation;
    }
}
