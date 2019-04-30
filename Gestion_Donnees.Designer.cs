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
            this.p_titre = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AjoutTechnicien = new System.Windows.Forms.Button();
            this.btn_Intervention = new System.Windows.Forms.Button();
            this.btn_Technicien = new System.Windows.Forms.Button();
            this.btn_AjoutBorne = new System.Windows.Forms.Button();
            this.btn_AjoutClient = new System.Windows.Forms.Button();
            this.btn_Borne = new System.Windows.Forms.Button();
            this.btn_Client = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.p_titre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.pictureBox1.Click += new System.EventHandler(this.Close_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Name = "label1";
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
            // btn_Intervention
            // 
            this.btn_Intervention.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.btn_Intervention.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Intervention.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Intervention, "btn_Intervention");
            this.btn_Intervention.ForeColor = System.Drawing.Color.White;
            this.btn_Intervention.Name = "btn_Intervention";
            this.btn_Intervention.UseVisualStyleBackColor = false;
            // 
            // btn_Technicien
            // 
            this.btn_Technicien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.btn_Technicien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Technicien.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Technicien, "btn_Technicien");
            this.btn_Technicien.ForeColor = System.Drawing.Color.White;
            this.btn_Technicien.Name = "btn_Technicien";
            this.btn_Technicien.UseVisualStyleBackColor = false;

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
            // btn_AjoutClient
            // 
            this.btn_AjoutClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.btn_AjoutClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AjoutClient.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_AjoutClient, "btn_AjoutClient");
            this.btn_AjoutClient.ForeColor = System.Drawing.Color.White;
            this.btn_AjoutClient.Name = "btn_AjoutClient";
            this.btn_AjoutClient.UseVisualStyleBackColor = false;
            this.btn_AjoutClient.Click += new System.EventHandler(this.onClickToClientCRUD);
            // 
            // btn_Borne
            // 
            this.btn_Borne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.btn_Borne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Borne.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Borne, "btn_Borne");
            this.btn_Borne.ForeColor = System.Drawing.Color.White;
            this.btn_Borne.Name = "btn_Borne";
            this.btn_Borne.UseVisualStyleBackColor = false;
            this.btn_Borne.Click += new System.EventHandler(this.onClickToBornes);
            // 
            // btn_Client
            // 
            this.btn_Client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.btn_Client.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Client.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Client, "btn_Client");
            this.btn_Client.ForeColor = System.Drawing.Color.White;
            this.btn_Client.Name = "btn_Client";
            this.btn_Client.UseVisualStyleBackColor = false;
            this.btn_Client.Click += new System.EventHandler(this.onClickToCustomers);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.Return_Click);
            // 
            // Gestion_Donnees
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_AjoutTechnicien);
            this.Controls.Add(this.btn_Intervention);
            this.Controls.Add(this.p_titre);
            this.Controls.Add(this.btn_Technicien);
            this.Controls.Add(this.btn_Client);
            this.Controls.Add(this.btn_AjoutBorne);
            this.Controls.Add(this.btn_Borne);
            this.Controls.Add(this.btn_AjoutClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Gestion_Donnees";
            this.p_titre.ResumeLayout(false);
            this.p_titre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel p_titre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AjoutTechnicien;
        private System.Windows.Forms.Button btn_Intervention;
        private System.Windows.Forms.Button btn_Technicien;
        private System.Windows.Forms.Button btn_AjoutBorne;
        private System.Windows.Forms.Button btn_AjoutClient;
        private System.Windows.Forms.Button btn_Borne;
        private System.Windows.Forms.Button btn_Client;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}