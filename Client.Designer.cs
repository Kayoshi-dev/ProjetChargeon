namespace ProjetChargeon
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.p_form1 = new System.Windows.Forms.Panel();
            this.img_Return = new System.Windows.Forms.PictureBox();
            this.l_Titre_Chargeon = new System.Windows.Forms.Label();
            this.img_Close = new System.Windows.Forms.PictureBox();
            this.l_Titre_Client = new System.Windows.Forms.Label();
            this.cb_Client = new System.Windows.Forms.ComboBox();
            this.p_separator = new System.Windows.Forms.Panel();
            this.l_titleNom = new System.Windows.Forms.Label();
            this.l_titleAdresse = new System.Windows.Forms.Label();
            this.l_titleID = new System.Windows.Forms.Label();
            this.l_titleVille = new System.Windows.Forms.Label();
            this.l_titleCP = new System.Windows.Forms.Label();
            this.l_Nom = new System.Windows.Forms.Label();
            this.p_Nom = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.l_Adresse = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.l_CP = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.l_Ville = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.l_ID = new System.Windows.Forms.Label();
            this.p_form1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Return)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Close)).BeginInit();
            this.p_Nom.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_form1
            // 
            this.p_form1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.p_form1.Controls.Add(this.img_Return);
            this.p_form1.Controls.Add(this.l_Titre_Chargeon);
            this.p_form1.Controls.Add(this.img_Close);
            this.p_form1.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_form1.Location = new System.Drawing.Point(0, 0);
            this.p_form1.Name = "p_form1";
            this.p_form1.Size = new System.Drawing.Size(800, 72);
            this.p_form1.TabIndex = 12;
            // 
            // img_Return
            // 
            this.img_Return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.img_Return.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("img_Return.BackgroundImage")));
            this.img_Return.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.img_Return.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.img_Return.Location = new System.Drawing.Point(707, 12);
            this.img_Return.Name = "img_Return";
            this.img_Return.Size = new System.Drawing.Size(30, 30);
            this.img_Return.TabIndex = 13;
            this.img_Return.TabStop = false;
            this.img_Return.Click += new System.EventHandler(this.BackForm);
            // 
            // l_Titre_Chargeon
            // 
            this.l_Titre_Chargeon.AutoSize = true;
            this.l_Titre_Chargeon.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.l_Titre_Chargeon.ForeColor = System.Drawing.SystemColors.Window;
            this.l_Titre_Chargeon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_Titre_Chargeon.Location = new System.Drawing.Point(12, 25);
            this.l_Titre_Chargeon.Name = "l_Titre_Chargeon";
            this.l_Titre_Chargeon.Size = new System.Drawing.Size(90, 21);
            this.l_Titre_Chargeon.TabIndex = 4;
            this.l_Titre_Chargeon.Text = "Chargéon";
            // 
            // img_Close
            // 
            this.img_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img_Close.Image = ((System.Drawing.Image)(resources.GetObject("img_Close.Image")));
            this.img_Close.Location = new System.Drawing.Point(758, 12);
            this.img_Close.Name = "img_Close";
            this.img_Close.Size = new System.Drawing.Size(30, 30);
            this.img_Close.TabIndex = 1;
            this.img_Close.TabStop = false;
            this.img_Close.Click += new System.EventHandler(this.Close);
            // 
            // l_Titre_Client
            // 
            this.l_Titre_Client.AutoSize = true;
            this.l_Titre_Client.ForeColor = System.Drawing.Color.White;
            this.l_Titre_Client.Location = new System.Drawing.Point(69, 119);
            this.l_Titre_Client.Name = "l_Titre_Client";
            this.l_Titre_Client.Size = new System.Drawing.Size(56, 21);
            this.l_Titre_Client.TabIndex = 14;
            this.l_Titre_Client.Text = "Client";
            // 
            // cb_Client
            // 
            this.cb_Client.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Client.FormattingEnabled = true;
            this.cb_Client.Location = new System.Drawing.Point(12, 143);
            this.cb_Client.Name = "cb_Client";
            this.cb_Client.Size = new System.Drawing.Size(182, 28);
            this.cb_Client.TabIndex = 15;
            this.cb_Client.SelectedIndexChanged += new System.EventHandler(this.cb_Client_SelectedIndexChanged);
            // 
            // p_separator
            // 
            this.p_separator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.p_separator.Location = new System.Drawing.Point(211, 92);
            this.p_separator.Name = "p_separator";
            this.p_separator.Size = new System.Drawing.Size(1, 340);
            this.p_separator.TabIndex = 16;
            // 
            // l_titleNom
            // 
            this.l_titleNom.AutoSize = true;
            this.l_titleNom.ForeColor = System.Drawing.Color.White;
            this.l_titleNom.Location = new System.Drawing.Point(329, 110);
            this.l_titleNom.Name = "l_titleNom";
            this.l_titleNom.Size = new System.Drawing.Size(97, 21);
            this.l_titleNom.TabIndex = 24;
            this.l_titleNom.Text = "Nom Client";
            // 
            // l_titleAdresse
            // 
            this.l_titleAdresse.AutoSize = true;
            this.l_titleAdresse.ForeColor = System.Drawing.Color.White;
            this.l_titleAdresse.Location = new System.Drawing.Point(548, 109);
            this.l_titleAdresse.Name = "l_titleAdresse";
            this.l_titleAdresse.Size = new System.Drawing.Size(121, 21);
            this.l_titleAdresse.TabIndex = 26;
            this.l_titleAdresse.Text = "Adresse Client";
            // 
            // l_titleID
            // 
            this.l_titleID.AutoSize = true;
            this.l_titleID.ForeColor = System.Drawing.Color.White;
            this.l_titleID.Location = new System.Drawing.Point(86, 297);
            this.l_titleID.Name = "l_titleID";
            this.l_titleID.Size = new System.Drawing.Size(27, 21);
            this.l_titleID.TabIndex = 27;
            this.l_titleID.Text = "ID";
            // 
            // l_titleVille
            // 
            this.l_titleVille.AutoSize = true;
            this.l_titleVille.ForeColor = System.Drawing.Color.White;
            this.l_titleVille.Location = new System.Drawing.Point(591, 297);
            this.l_titleVille.Name = "l_titleVille";
            this.l_titleVille.Size = new System.Drawing.Size(40, 21);
            this.l_titleVille.TabIndex = 28;
            this.l_titleVille.Text = "Ville";
            // 
            // l_titleCP
            // 
            this.l_titleCP.AutoSize = true;
            this.l_titleCP.ForeColor = System.Drawing.Color.White;
            this.l_titleCP.Location = new System.Drawing.Point(325, 297);
            this.l_titleCP.Name = "l_titleCP";
            this.l_titleCP.Size = new System.Drawing.Size(104, 21);
            this.l_titleCP.TabIndex = 29;
            this.l_titleCP.Text = "Code Postal";
            // 
            // l_Nom
            // 
            this.l_Nom.ForeColor = System.Drawing.Color.White;
            this.l_Nom.Location = new System.Drawing.Point(-1, 12);
            this.l_Nom.Name = "l_Nom";
            this.l_Nom.Size = new System.Drawing.Size(189, 21);
            this.l_Nom.TabIndex = 30;
            this.l_Nom.Text = "AfficheNom";
            this.l_Nom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // p_Nom
            // 
            this.p_Nom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_Nom.Controls.Add(this.l_Nom);
            this.p_Nom.Location = new System.Drawing.Point(287, 134);
            this.p_Nom.Name = "p_Nom";
            this.p_Nom.Size = new System.Drawing.Size(189, 45);
            this.p_Nom.TabIndex = 35;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.l_Adresse);
            this.panel1.Location = new System.Drawing.Point(516, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 86);
            this.panel1.TabIndex = 36;
            // 
            // l_Adresse
            // 
            this.l_Adresse.ForeColor = System.Drawing.Color.White;
            this.l_Adresse.Location = new System.Drawing.Point(-1, 12);
            this.l_Adresse.Name = "l_Adresse";
            this.l_Adresse.Size = new System.Drawing.Size(189, 59);
            this.l_Adresse.TabIndex = 30;
            this.l_Adresse.Text = "AfficheAdresse";
            this.l_Adresse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.l_CP);
            this.panel2.Location = new System.Drawing.Point(287, 321);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 45);
            this.panel2.TabIndex = 36;
            // 
            // l_CP
            // 
            this.l_CP.ForeColor = System.Drawing.Color.White;
            this.l_CP.Location = new System.Drawing.Point(-1, 12);
            this.l_CP.Name = "l_CP";
            this.l_CP.Size = new System.Drawing.Size(189, 21);
            this.l_CP.TabIndex = 30;
            this.l_CP.Text = "AfficheCP";
            this.l_CP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.l_Ville);
            this.panel3.Location = new System.Drawing.Point(516, 321);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(189, 45);
            this.panel3.TabIndex = 37;
            // 
            // l_Ville
            // 
            this.l_Ville.ForeColor = System.Drawing.Color.White;
            this.l_Ville.Location = new System.Drawing.Point(-1, 12);
            this.l_Ville.Name = "l_Ville";
            this.l_Ville.Size = new System.Drawing.Size(189, 21);
            this.l_Ville.TabIndex = 30;
            this.l_Ville.Text = "AfficheVille";
            this.l_Ville.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.l_ID);
            this.panel4.Location = new System.Drawing.Point(38, 321);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(121, 45);
            this.panel4.TabIndex = 37;
            // 
            // l_ID
            // 
            this.l_ID.ForeColor = System.Drawing.Color.White;
            this.l_ID.Location = new System.Drawing.Point(-1, 12);
            this.l_ID.Name = "l_ID";
            this.l_ID.Size = new System.Drawing.Size(121, 21);
            this.l_ID.TabIndex = 30;
            this.l_ID.Text = "AfficheID";
            this.l_ID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Client
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.p_Nom);
            this.Controls.Add(this.l_titleCP);
            this.Controls.Add(this.l_titleVille);
            this.Controls.Add(this.l_titleID);
            this.Controls.Add(this.l_titleAdresse);
            this.Controls.Add(this.l_titleNom);
            this.Controls.Add(this.p_separator);
            this.Controls.Add(this.cb_Client);
            this.Controls.Add(this.l_Titre_Client);
            this.Controls.Add(this.p_form1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.p_form1.ResumeLayout(false);
            this.p_form1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Return)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Close)).EndInit();
            this.p_Nom.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel p_form1;
        private System.Windows.Forms.PictureBox img_Return;
        private System.Windows.Forms.Label l_Titre_Chargeon;
        private System.Windows.Forms.PictureBox img_Close;
        private System.Windows.Forms.Label l_Titre_Client;
        private System.Windows.Forms.ComboBox cb_Client;
        private System.Windows.Forms.Panel p_separator;
        private System.Windows.Forms.Label l_titleNom;
        private System.Windows.Forms.Label l_titleAdresse;
        private System.Windows.Forms.Label l_titleID;
        private System.Windows.Forms.Label l_titleVille;
        private System.Windows.Forms.Label l_titleCP;
        private System.Windows.Forms.Label l_Nom;
        private System.Windows.Forms.Panel p_Nom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label l_Adresse;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label l_CP;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label l_Ville;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label l_ID;
    }
}