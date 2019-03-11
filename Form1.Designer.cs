namespace ProjetChargeon
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_localisation = new System.Windows.Forms.Button();
            this.p_titre = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.p_titre.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_connect
            // 
            this.btn_connect.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btn_connect, "btn_connect");
            this.btn_connect.ForeColor = System.Drawing.Color.White;
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.UseVisualStyleBackColor = false;
            // 
            // btn_localisation
            // 
            this.btn_localisation.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btn_localisation, "btn_localisation");
            this.btn_localisation.ForeColor = System.Drawing.Color.White;
            this.btn_localisation.Name = "btn_localisation";
            this.btn_localisation.UseVisualStyleBackColor = false;
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
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.p_titre);
            this.Controls.Add(this.btn_localisation);
            this.Controls.Add(this.btn_connect);
            this.Name = "Form1";
            this.p_titre.ResumeLayout(false);
            this.p_titre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_localisation;
        private System.Windows.Forms.Panel p_titre;
        private System.Windows.Forms.Label label1;
    }
}

