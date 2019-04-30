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
            this.btn_AjoutBorne = new System.Windows.Forms.Button();
            this.btn_AjoutClient = new System.Windows.Forms.Button();
            this.btn_AjoutTechnicien = new System.Windows.Forms.Button();
            this.p_Titre_Chargeon = new System.Windows.Forms.Panel();
            this.img_Return = new System.Windows.Forms.PictureBox();
            this.img_Close = new System.Windows.Forms.PictureBox();
            this.l_Titre_Chargeon = new System.Windows.Forms.Label();
            this.btn_Gestion_Client = new System.Windows.Forms.Button();
            this.btn_Gestion_Borne = new System.Windows.Forms.Button();
            this.btn_Gestion_Technicien = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.p_Titre_Chargeon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Return)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Close)).BeginInit();
            this.SuspendLayout();
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
            this.btn_AjoutBorne.Click += new System.EventHandler(this.onClickToCRUDBorne);
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
            // btn_Gestion_Client
            // 
            this.btn_Gestion_Client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.btn_Gestion_Client.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Gestion_Client.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Gestion_Client, "btn_Gestion_Client");
            this.btn_Gestion_Client.ForeColor = System.Drawing.Color.White;
            this.btn_Gestion_Client.Name = "btn_Gestion_Client";
            this.btn_Gestion_Client.UseVisualStyleBackColor = false;
            this.btn_Gestion_Client.Click += new System.EventHandler(this.onClickToClient);
            // 
            // btn_Gestion_Borne
            // 
            this.btn_Gestion_Borne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.btn_Gestion_Borne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Gestion_Borne.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Gestion_Borne, "btn_Gestion_Borne");
            this.btn_Gestion_Borne.ForeColor = System.Drawing.Color.White;
            this.btn_Gestion_Borne.Name = "btn_Gestion_Borne";
            this.btn_Gestion_Borne.UseVisualStyleBackColor = false;
            this.btn_Gestion_Borne.Click += new System.EventHandler(this.onClickToBorne);
            // 
            // btn_Gestion_Technicien
            // 
            this.btn_Gestion_Technicien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.btn_Gestion_Technicien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Gestion_Technicien.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Gestion_Technicien, "btn_Gestion_Technicien");
            this.btn_Gestion_Technicien.ForeColor = System.Drawing.Color.White;
            this.btn_Gestion_Technicien.Name = "btn_Gestion_Technicien";
            this.btn_Gestion_Technicien.UseVisualStyleBackColor = false;
            this.btn_Gestion_Technicien.Click += new System.EventHandler(this.onClickToTechnicien);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button4, "button4");
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.onClickToIntervention);
            // 
            // Gestion_Donnees
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_Gestion_Technicien);
            this.Controls.Add(this.btn_Gestion_Borne);
            this.Controls.Add(this.btn_Gestion_Client);
            this.Controls.Add(this.p_Titre_Chargeon);
            this.Controls.Add(this.btn_AjoutTechnicien);
            this.Controls.Add(this.btn_AjoutBorne);
            this.Controls.Add(this.btn_AjoutClient);
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
        private System.Windows.Forms.Button btn_AjoutBorne;
        private System.Windows.Forms.Button btn_AjoutClient;
        private System.Windows.Forms.Button btn_AjoutTechnicien;
        private System.Windows.Forms.Panel p_Titre_Chargeon;
        private System.Windows.Forms.PictureBox img_Return;
        private System.Windows.Forms.PictureBox img_Close;
        private System.Windows.Forms.Label l_Titre_Chargeon;
        private System.Windows.Forms.Button btn_Gestion_Client;
        private System.Windows.Forms.Button btn_Gestion_Borne;
        private System.Windows.Forms.Button btn_Gestion_Technicien;
        private System.Windows.Forms.Button button4;
    }
}