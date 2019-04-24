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
            this.btn_ajoutTechnicien = new System.Windows.Forms.Button();
            this.btn_interventions = new System.Windows.Forms.Button();
            this.btn_techniciens = new System.Windows.Forms.Button();
            this.btn_ajoutBorne = new System.Windows.Forms.Button();
            this.btn_ajoutClient = new System.Windows.Forms.Button();
            this.btn_bornes = new System.Windows.Forms.Button();
            this.btn_client = new System.Windows.Forms.Button();
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
            this.pictureBox1.Click += new System.EventHandler(this.Close_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Name = "label1";
            // 
            // btn_ajoutTechnicien
            // 
            this.btn_ajoutTechnicien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.btn_ajoutTechnicien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ajoutTechnicien.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_ajoutTechnicien, "btn_ajoutTechnicien");
            this.btn_ajoutTechnicien.ForeColor = System.Drawing.Color.White;
            this.btn_ajoutTechnicien.Name = "btn_ajoutTechnicien";
            this.btn_ajoutTechnicien.UseVisualStyleBackColor = false;
            // 
            // btn_interventions
            // 
            this.btn_interventions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.btn_interventions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_interventions.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_interventions, "btn_interventions");
            this.btn_interventions.ForeColor = System.Drawing.Color.White;
            this.btn_interventions.Name = "btn_interventions";
            this.btn_interventions.UseVisualStyleBackColor = false;
            // 
            // btn_techniciens
            // 
            this.btn_techniciens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.btn_techniciens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_techniciens.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_techniciens, "btn_techniciens");
            this.btn_techniciens.ForeColor = System.Drawing.Color.White;
            this.btn_techniciens.Name = "btn_techniciens";
            this.btn_techniciens.UseVisualStyleBackColor = false;
            // 
            // btn_ajoutBorne
            // 
            this.btn_ajoutBorne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.btn_ajoutBorne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ajoutBorne.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_ajoutBorne, "btn_ajoutBorne");
            this.btn_ajoutBorne.ForeColor = System.Drawing.Color.White;
            this.btn_ajoutBorne.Name = "btn_ajoutBorne";
            this.btn_ajoutBorne.UseVisualStyleBackColor = false;
            // 
            // btn_ajoutClient
            // 
            this.btn_ajoutClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.btn_ajoutClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ajoutClient.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_ajoutClient, "btn_ajoutClient");
            this.btn_ajoutClient.ForeColor = System.Drawing.Color.White;
            this.btn_ajoutClient.Name = "btn_ajoutClient";
            this.btn_ajoutClient.UseVisualStyleBackColor = false;
            this.btn_ajoutClient.Click += new System.EventHandler(this.onClickToClientCRUD);
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
            this.Controls.Add(this.btn_ajoutTechnicien);
            this.Controls.Add(this.btn_interventions);
            this.Controls.Add(this.p_titre);
            this.Controls.Add(this.btn_techniciens);
            this.Controls.Add(this.btn_client);
            this.Controls.Add(this.btn_ajoutBorne);
            this.Controls.Add(this.btn_bornes);
            this.Controls.Add(this.btn_ajoutClient);
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
        private System.Windows.Forms.Button btn_ajoutTechnicien;
        private System.Windows.Forms.Button btn_interventions;
        private System.Windows.Forms.Button btn_techniciens;
        private System.Windows.Forms.Button btn_ajoutBorne;
        private System.Windows.Forms.Button btn_ajoutClient;
        private System.Windows.Forms.Button btn_bornes;
        private System.Windows.Forms.Button btn_client;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}