namespace ProjetChargeon
{
    partial class Gestion_Donnees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_Donnees));
            this.p_Titre_Chargeon = new System.Windows.Forms.Panel();
            this.img_Return = new System.Windows.Forms.PictureBox();
            this.img_Close = new System.Windows.Forms.PictureBox();
            this.l_Titre_Chargeon = new System.Windows.Forms.Label();
            this.btn_Clients = new System.Windows.Forms.Button();
            this.btn_Bornes = new System.Windows.Forms.Button();
            this.btn_Interventions = new System.Windows.Forms.Button();
            this.btn_Techniciens = new System.Windows.Forms.Button();
            this.btn_AjoutClient = new System.Windows.Forms.Button();
            this.btn_AjoutBorne = new System.Windows.Forms.Button();
            this.btn_AjoutTechnicien = new System.Windows.Forms.Button();
            this.p_Titre_Chargeon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Return)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // p_Titre_Chargeon
            // 
            this.p_Titre_Chargeon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.p_Titre_Chargeon.Controls.Add(this.img_Return);
            this.p_Titre_Chargeon.Controls.Add(this.img_Close);
            this.p_Titre_Chargeon.Controls.Add(this.l_Titre_Chargeon);
            resources.ApplyResources(this.p_Titre_Chargeon, "p_Titre_Chargeon");
            this.p_Titre_Chargeon.Name = "p_Titre_Chargeon";
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
            // btn_Clients
            // 
            this.btn_Clients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.btn_Clients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clients.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Clients, "btn_Clients");
            this.btn_Clients.ForeColor = System.Drawing.Color.White;
            this.btn_Clients.Name = "btn_Clients";
            this.btn_Clients.UseVisualStyleBackColor = false;
            // 
            // btn_Bornes
            // 
            this.btn_Bornes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.btn_Bornes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Bornes.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Bornes, "btn_Bornes");
            this.btn_Bornes.ForeColor = System.Drawing.Color.White;
            this.btn_Bornes.Name = "btn_Bornes";
            this.btn_Bornes.UseVisualStyleBackColor = false;
            this.btn_Bornes.Click += new System.EventHandler(this.onClickToBorne);
            // 
            // btn_Interventions
            // 
            this.btn_Interventions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.btn_Interventions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Interventions.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Interventions, "btn_Interventions");
            this.btn_Interventions.ForeColor = System.Drawing.Color.White;
            this.btn_Interventions.Name = "btn_Interventions";
            this.btn_Interventions.UseVisualStyleBackColor = false;
            // 
            // btn_Techniciens
            // 
            this.btn_Techniciens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.btn_Techniciens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Techniciens.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Techniciens, "btn_Techniciens");
            this.btn_Techniciens.ForeColor = System.Drawing.Color.White;
            this.btn_Techniciens.Name = "btn_Techniciens";
            this.btn_Techniciens.UseVisualStyleBackColor = false;
            this.btn_Techniciens.Click += new System.EventHandler(this.onClickToTechnicien);
            // 
            // btn_AjoutClient
            // 
            this.btn_AjoutClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.btn_AjoutClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AjoutClient.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_AjoutClient, "btn_AjoutClient");
            this.btn_AjoutClient.ForeColor = System.Drawing.Color.White;
            this.btn_AjoutClient.Name = "btn_AjoutClient";
            this.btn_AjoutClient.UseVisualStyleBackColor = false;
            // 
            // btn_AjoutBorne
            // 
            this.btn_AjoutBorne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.btn_AjoutBorne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AjoutBorne.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_AjoutBorne, "btn_AjoutBorne");
            this.btn_AjoutBorne.ForeColor = System.Drawing.Color.White;
            this.btn_AjoutBorne.Name = "btn_AjoutBorne";
            this.btn_AjoutBorne.UseVisualStyleBackColor = false;
            // 
            // btn_AjoutTechnicien
            // 
            this.btn_AjoutTechnicien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.btn_AjoutTechnicien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AjoutTechnicien.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_AjoutTechnicien, "btn_AjoutTechnicien");
            this.btn_AjoutTechnicien.ForeColor = System.Drawing.Color.White;
            this.btn_AjoutTechnicien.Name = "btn_AjoutTechnicien";
            this.btn_AjoutTechnicien.UseVisualStyleBackColor = false;
            this.btn_AjoutTechnicien.Click += new System.EventHandler(this.onClickToCRUDTechnicien);
            // 
            // Gestion_Donnees
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.btn_AjoutTechnicien);
            this.Controls.Add(this.btn_AjoutBorne);
            this.Controls.Add(this.btn_AjoutClient);
            this.Controls.Add(this.btn_Techniciens);
            this.Controls.Add(this.btn_Interventions);
            this.Controls.Add(this.btn_Bornes);
            this.Controls.Add(this.btn_Clients);
            this.Controls.Add(this.p_Titre_Chargeon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Gestion_Donnees";
            this.p_Titre_Chargeon.ResumeLayout(false);
            this.p_Titre_Chargeon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Return)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_Titre_Chargeon;
        private System.Windows.Forms.PictureBox img_Close;
        private System.Windows.Forms.Label l_Titre_Chargeon;
        private System.Windows.Forms.PictureBox img_Return;
        private System.Windows.Forms.Button btn_Clients;
        private System.Windows.Forms.Button btn_Bornes;
        private System.Windows.Forms.Button btn_Interventions;
        private System.Windows.Forms.Button btn_Techniciens;
        private System.Windows.Forms.Button btn_AjoutClient;
        private System.Windows.Forms.Button btn_AjoutBorne;
        private System.Windows.Forms.Button btn_AjoutTechnicien;
    }
}