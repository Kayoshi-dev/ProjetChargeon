﻿namespace ProjetChargeon
{
    partial class ClientCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientCRUD));
            this.p_form1 = new System.Windows.Forms.Panel();
            this.img_Return = new System.Windows.Forms.PictureBox();
            this.l_Titre_Chargeon = new System.Windows.Forms.Label();
            this.img_Close = new System.Windows.Forms.PictureBox();
            this.l_Titre_Ajout = new System.Windows.Forms.Label();
            this.l_Titre_Nom_Ajout = new System.Windows.Forms.Label();
            this.l_Titre_Adresse_Ajout = new System.Windows.Forms.Label();
            this.l_Titre_Ville_Ajout = new System.Windows.Forms.Label();
            this.l_Titre_CP_Ajout = new System.Windows.Forms.Label();
            this.p_Ajout_Client = new System.Windows.Forms.Panel();
            this.bt_Ajout = new System.Windows.Forms.Button();
            this.tb_Ville_Ajout = new System.Windows.Forms.TextBox();
            this.tb_CP_Ajout = new System.Windows.Forms.TextBox();
            this.tb_Adresse_Ajout = new System.Windows.Forms.TextBox();
            this.tb_Nom_Ajout = new System.Windows.Forms.TextBox();
            this.p_separator_1 = new System.Windows.Forms.Panel();
            this.p_MAJ_Client = new System.Windows.Forms.Panel();
            this.chb_Ville = new System.Windows.Forms.CheckBox();
            this.chb_CP = new System.Windows.Forms.CheckBox();
            this.chb_Adresse = new System.Windows.Forms.CheckBox();
            this.chb_Nom_MAJ = new System.Windows.Forms.CheckBox();
            this.bt_MAJ = new System.Windows.Forms.Button();
            this.tb_Ville_MAJ = new System.Windows.Forms.TextBox();
            this.tb_CP_MAJ = new System.Windows.Forms.TextBox();
            this.tb_Titre_Ville_MAJ = new System.Windows.Forms.Label();
            this.tb_Adresse_MAJ = new System.Windows.Forms.TextBox();
            this.tb_Titre_CP_MAJ = new System.Windows.Forms.Label();
            this.tb_Nom_MAJ = new System.Windows.Forms.TextBox();
            this.tb_Titre_Nom_MAJ = new System.Windows.Forms.Label();
            this.tb_Titre_Adresse_MAJ = new System.Windows.Forms.Label();
            this.l_Titre_MAJ = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.l_Titre_Supprimer = new System.Windows.Forms.Label();
            this.p_Supprimer_Client = new System.Windows.Forms.Panel();
            this.chb_Nom_Supprimer = new System.Windows.Forms.CheckBox();
            this.cb_Nom = new System.Windows.Forms.ComboBox();
            this.bt_Supprimer = new System.Windows.Forms.Button();
            this.tb_Titre_Nom_Supprimer = new System.Windows.Forms.Label();
            this.p_form1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Return)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Close)).BeginInit();
            this.p_Ajout_Client.SuspendLayout();
            this.p_MAJ_Client.SuspendLayout();
            this.p_Supprimer_Client.SuspendLayout();
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
            this.p_form1.Size = new System.Drawing.Size(1000, 72);
            this.p_form1.TabIndex = 13;
            // 
            // img_Return
            // 
            this.img_Return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.img_Return.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("img_Return.BackgroundImage")));
            this.img_Return.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.img_Return.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.img_Return.Location = new System.Drawing.Point(907, 12);
            this.img_Return.Name = "img_Return";
            this.img_Return.Size = new System.Drawing.Size(30, 30);
            this.img_Return.TabIndex = 13;
            this.img_Return.TabStop = false;
            this.img_Return.Click += new System.EventHandler(this.Return);
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
            this.img_Close.Location = new System.Drawing.Point(958, 12);
            this.img_Close.Name = "img_Close";
            this.img_Close.Size = new System.Drawing.Size(30, 30);
            this.img_Close.TabIndex = 1;
            this.img_Close.TabStop = false;
            this.img_Close.Click += new System.EventHandler(this.Close);
            // 
            // l_Titre_Ajout
            // 
            this.l_Titre_Ajout.AutoSize = true;
            this.l_Titre_Ajout.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Titre_Ajout.ForeColor = System.Drawing.SystemColors.Window;
            this.l_Titre_Ajout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_Titre_Ajout.Location = new System.Drawing.Point(78, 88);
            this.l_Titre_Ajout.Name = "l_Titre_Ajout";
            this.l_Titre_Ajout.Size = new System.Drawing.Size(181, 25);
            this.l_Titre_Ajout.TabIndex = 14;
            this.l_Titre_Ajout.Text = "Ajouter un Client";
            // 
            // l_Titre_Nom_Ajout
            // 
            this.l_Titre_Nom_Ajout.AutoSize = true;
            this.l_Titre_Nom_Ajout.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.l_Titre_Nom_Ajout.ForeColor = System.Drawing.SystemColors.Window;
            this.l_Titre_Nom_Ajout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_Titre_Nom_Ajout.Location = new System.Drawing.Point(15, 16);
            this.l_Titre_Nom_Ajout.Name = "l_Titre_Nom_Ajout";
            this.l_Titre_Nom_Ajout.Size = new System.Drawing.Size(59, 21);
            this.l_Titre_Nom_Ajout.TabIndex = 15;
            this.l_Titre_Nom_Ajout.Text = "Nom : ";
            // 
            // l_Titre_Adresse_Ajout
            // 
            this.l_Titre_Adresse_Ajout.AutoSize = true;
            this.l_Titre_Adresse_Ajout.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.l_Titre_Adresse_Ajout.ForeColor = System.Drawing.SystemColors.Window;
            this.l_Titre_Adresse_Ajout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_Titre_Adresse_Ajout.Location = new System.Drawing.Point(15, 57);
            this.l_Titre_Adresse_Ajout.Name = "l_Titre_Adresse_Ajout";
            this.l_Titre_Adresse_Ajout.Size = new System.Drawing.Size(79, 21);
            this.l_Titre_Adresse_Ajout.TabIndex = 16;
            this.l_Titre_Adresse_Ajout.Text = "Adresse :";
            // 
            // l_Titre_Ville_Ajout
            // 
            this.l_Titre_Ville_Ajout.AutoSize = true;
            this.l_Titre_Ville_Ajout.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.l_Titre_Ville_Ajout.ForeColor = System.Drawing.SystemColors.Window;
            this.l_Titre_Ville_Ajout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_Titre_Ville_Ajout.Location = new System.Drawing.Point(15, 194);
            this.l_Titre_Ville_Ajout.Name = "l_Titre_Ville_Ajout";
            this.l_Titre_Ville_Ajout.Size = new System.Drawing.Size(48, 21);
            this.l_Titre_Ville_Ajout.TabIndex = 17;
            this.l_Titre_Ville_Ajout.Text = "Ville :";
            // 
            // l_Titre_CP_Ajout
            // 
            this.l_Titre_CP_Ajout.AutoSize = true;
            this.l_Titre_CP_Ajout.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.l_Titre_CP_Ajout.ForeColor = System.Drawing.SystemColors.Window;
            this.l_Titre_CP_Ajout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_Titre_CP_Ajout.Location = new System.Drawing.Point(15, 147);
            this.l_Titre_CP_Ajout.Name = "l_Titre_CP_Ajout";
            this.l_Titre_CP_Ajout.Size = new System.Drawing.Size(40, 21);
            this.l_Titre_CP_Ajout.TabIndex = 18;
            this.l_Titre_CP_Ajout.Text = "CP :";
            // 
            // p_Ajout_Client
            // 
            this.p_Ajout_Client.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_Ajout_Client.Controls.Add(this.bt_Ajout);
            this.p_Ajout_Client.Controls.Add(this.tb_Ville_Ajout);
            this.p_Ajout_Client.Controls.Add(this.tb_CP_Ajout);
            this.p_Ajout_Client.Controls.Add(this.l_Titre_Ville_Ajout);
            this.p_Ajout_Client.Controls.Add(this.tb_Adresse_Ajout);
            this.p_Ajout_Client.Controls.Add(this.l_Titre_CP_Ajout);
            this.p_Ajout_Client.Controls.Add(this.tb_Nom_Ajout);
            this.p_Ajout_Client.Controls.Add(this.l_Titre_Nom_Ajout);
            this.p_Ajout_Client.Controls.Add(this.l_Titre_Adresse_Ajout);
            this.p_Ajout_Client.Location = new System.Drawing.Point(12, 125);
            this.p_Ajout_Client.Name = "p_Ajout_Client";
            this.p_Ajout_Client.Size = new System.Drawing.Size(296, 292);
            this.p_Ajout_Client.TabIndex = 19;
            // 
            // bt_Ajout
            // 
            this.bt_Ajout.Location = new System.Drawing.Point(130, 246);
            this.bt_Ajout.Name = "bt_Ajout";
            this.bt_Ajout.Size = new System.Drawing.Size(105, 29);
            this.bt_Ajout.TabIndex = 23;
            this.bt_Ajout.Text = "Enregistrer";
            this.bt_Ajout.UseVisualStyleBackColor = true;
            this.bt_Ajout.Click += new System.EventHandler(this.Ajouter_Client);
            // 
            // tb_Ville_Ajout
            // 
            this.tb_Ville_Ajout.Location = new System.Drawing.Point(100, 191);
            this.tb_Ville_Ajout.Name = "tb_Ville_Ajout";
            this.tb_Ville_Ajout.Size = new System.Drawing.Size(172, 27);
            this.tb_Ville_Ajout.TabIndex = 22;
            // 
            // tb_CP_Ajout
            // 
            this.tb_CP_Ajout.Location = new System.Drawing.Point(100, 144);
            this.tb_CP_Ajout.Name = "tb_CP_Ajout";
            this.tb_CP_Ajout.Size = new System.Drawing.Size(172, 27);
            this.tb_CP_Ajout.TabIndex = 21;
            // 
            // tb_Adresse_Ajout
            // 
            this.tb_Adresse_Ajout.Location = new System.Drawing.Point(100, 57);
            this.tb_Adresse_Ajout.Multiline = true;
            this.tb_Adresse_Ajout.Name = "tb_Adresse_Ajout";
            this.tb_Adresse_Ajout.Size = new System.Drawing.Size(172, 73);
            this.tb_Adresse_Ajout.TabIndex = 20;
            // 
            // tb_Nom_Ajout
            // 
            this.tb_Nom_Ajout.Location = new System.Drawing.Point(100, 10);
            this.tb_Nom_Ajout.Name = "tb_Nom_Ajout";
            this.tb_Nom_Ajout.Size = new System.Drawing.Size(172, 27);
            this.tb_Nom_Ajout.TabIndex = 20;
            // 
            // p_separator_1
            // 
            this.p_separator_1.BackColor = System.Drawing.Color.White;
            this.p_separator_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p_separator_1.Location = new System.Drawing.Point(329, 78);
            this.p_separator_1.Name = "p_separator_1";
            this.p_separator_1.Size = new System.Drawing.Size(1, 360);
            this.p_separator_1.TabIndex = 20;
            // 
            // p_MAJ_Client
            // 
            this.p_MAJ_Client.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_MAJ_Client.Controls.Add(this.chb_Ville);
            this.p_MAJ_Client.Controls.Add(this.chb_CP);
            this.p_MAJ_Client.Controls.Add(this.chb_Adresse);
            this.p_MAJ_Client.Controls.Add(this.chb_Nom_MAJ);
            this.p_MAJ_Client.Controls.Add(this.bt_MAJ);
            this.p_MAJ_Client.Controls.Add(this.tb_Ville_MAJ);
            this.p_MAJ_Client.Controls.Add(this.tb_CP_MAJ);
            this.p_MAJ_Client.Controls.Add(this.tb_Titre_Ville_MAJ);
            this.p_MAJ_Client.Controls.Add(this.tb_Adresse_MAJ);
            this.p_MAJ_Client.Controls.Add(this.tb_Titre_CP_MAJ);
            this.p_MAJ_Client.Controls.Add(this.tb_Nom_MAJ);
            this.p_MAJ_Client.Controls.Add(this.tb_Titre_Nom_MAJ);
            this.p_MAJ_Client.Controls.Add(this.tb_Titre_Adresse_MAJ);
            this.p_MAJ_Client.Location = new System.Drawing.Point(351, 125);
            this.p_MAJ_Client.Name = "p_MAJ_Client";
            this.p_MAJ_Client.Size = new System.Drawing.Size(296, 292);
            this.p_MAJ_Client.TabIndex = 24;
            // 
            // chb_Ville
            // 
            this.chb_Ville.AutoSize = true;
            this.chb_Ville.Location = new System.Drawing.Point(-1, 198);
            this.chb_Ville.Name = "chb_Ville";
            this.chb_Ville.Size = new System.Drawing.Size(15, 14);
            this.chb_Ville.TabIndex = 30;
            this.chb_Ville.UseVisualStyleBackColor = true;
            this.chb_Ville.CheckedChanged += new System.EventHandler(this.VilleIsCheck);
            // 
            // chb_CP
            // 
            this.chb_CP.AutoSize = true;
            this.chb_CP.Location = new System.Drawing.Point(-1, 151);
            this.chb_CP.Name = "chb_CP";
            this.chb_CP.Size = new System.Drawing.Size(15, 14);
            this.chb_CP.TabIndex = 29;
            this.chb_CP.UseVisualStyleBackColor = true;
            this.chb_CP.CheckedChanged += new System.EventHandler(this.CPIsCheck);
            // 
            // chb_Adresse
            // 
            this.chb_Adresse.AutoSize = true;
            this.chb_Adresse.Location = new System.Drawing.Point(-1, 61);
            this.chb_Adresse.Name = "chb_Adresse";
            this.chb_Adresse.Size = new System.Drawing.Size(15, 14);
            this.chb_Adresse.TabIndex = 28;
            this.chb_Adresse.UseVisualStyleBackColor = true;
            this.chb_Adresse.CheckedChanged += new System.EventHandler(this.AdresseIsCheck);
            // 
            // chb_Nom_MAJ
            // 
            this.chb_Nom_MAJ.AutoSize = true;
            this.chb_Nom_MAJ.Location = new System.Drawing.Point(-1, 20);
            this.chb_Nom_MAJ.Name = "chb_Nom_MAJ";
            this.chb_Nom_MAJ.Size = new System.Drawing.Size(15, 14);
            this.chb_Nom_MAJ.TabIndex = 27;
            this.chb_Nom_MAJ.UseVisualStyleBackColor = true;
            this.chb_Nom_MAJ.CheckedChanged += new System.EventHandler(this.NomIsCheck);
            // 
            // bt_MAJ
            // 
            this.bt_MAJ.Location = new System.Drawing.Point(130, 246);
            this.bt_MAJ.Name = "bt_MAJ";
            this.bt_MAJ.Size = new System.Drawing.Size(105, 29);
            this.bt_MAJ.TabIndex = 23;
            this.bt_MAJ.Text = "Enregistrer";
            this.bt_MAJ.UseVisualStyleBackColor = true;
            // 
            // tb_Ville_MAJ
            // 
            this.tb_Ville_MAJ.Location = new System.Drawing.Point(100, 191);
            this.tb_Ville_MAJ.Name = "tb_Ville_MAJ";
            this.tb_Ville_MAJ.Size = new System.Drawing.Size(172, 27);
            this.tb_Ville_MAJ.TabIndex = 22;
            // 
            // tb_CP_MAJ
            // 
            this.tb_CP_MAJ.Location = new System.Drawing.Point(100, 144);
            this.tb_CP_MAJ.Name = "tb_CP_MAJ";
            this.tb_CP_MAJ.Size = new System.Drawing.Size(172, 27);
            this.tb_CP_MAJ.TabIndex = 21;
            // 
            // tb_Titre_Ville_MAJ
            // 
            this.tb_Titre_Ville_MAJ.AutoSize = true;
            this.tb_Titre_Ville_MAJ.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tb_Titre_Ville_MAJ.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_Titre_Ville_MAJ.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tb_Titre_Ville_MAJ.Location = new System.Drawing.Point(15, 194);
            this.tb_Titre_Ville_MAJ.Name = "tb_Titre_Ville_MAJ";
            this.tb_Titre_Ville_MAJ.Size = new System.Drawing.Size(48, 21);
            this.tb_Titre_Ville_MAJ.TabIndex = 17;
            this.tb_Titre_Ville_MAJ.Text = "Ville :";
            // 
            // tb_Adresse_MAJ
            // 
            this.tb_Adresse_MAJ.Location = new System.Drawing.Point(100, 57);
            this.tb_Adresse_MAJ.Multiline = true;
            this.tb_Adresse_MAJ.Name = "tb_Adresse_MAJ";
            this.tb_Adresse_MAJ.Size = new System.Drawing.Size(172, 73);
            this.tb_Adresse_MAJ.TabIndex = 20;
            // 
            // tb_Titre_CP_MAJ
            // 
            this.tb_Titre_CP_MAJ.AutoSize = true;
            this.tb_Titre_CP_MAJ.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tb_Titre_CP_MAJ.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_Titre_CP_MAJ.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tb_Titre_CP_MAJ.Location = new System.Drawing.Point(15, 147);
            this.tb_Titre_CP_MAJ.Name = "tb_Titre_CP_MAJ";
            this.tb_Titre_CP_MAJ.Size = new System.Drawing.Size(40, 21);
            this.tb_Titre_CP_MAJ.TabIndex = 18;
            this.tb_Titre_CP_MAJ.Text = "CP :";
            // 
            // tb_Nom_MAJ
            // 
            this.tb_Nom_MAJ.Location = new System.Drawing.Point(100, 13);
            this.tb_Nom_MAJ.Name = "tb_Nom_MAJ";
            this.tb_Nom_MAJ.Size = new System.Drawing.Size(172, 27);
            this.tb_Nom_MAJ.TabIndex = 20;
            // 
            // tb_Titre_Nom_MAJ
            // 
            this.tb_Titre_Nom_MAJ.AutoSize = true;
            this.tb_Titre_Nom_MAJ.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tb_Titre_Nom_MAJ.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_Titre_Nom_MAJ.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tb_Titre_Nom_MAJ.Location = new System.Drawing.Point(15, 16);
            this.tb_Titre_Nom_MAJ.Name = "tb_Titre_Nom_MAJ";
            this.tb_Titre_Nom_MAJ.Size = new System.Drawing.Size(59, 21);
            this.tb_Titre_Nom_MAJ.TabIndex = 15;
            this.tb_Titre_Nom_MAJ.Text = "Nom : ";
            // 
            // tb_Titre_Adresse_MAJ
            // 
            this.tb_Titre_Adresse_MAJ.AutoSize = true;
            this.tb_Titre_Adresse_MAJ.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tb_Titre_Adresse_MAJ.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_Titre_Adresse_MAJ.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tb_Titre_Adresse_MAJ.Location = new System.Drawing.Point(15, 57);
            this.tb_Titre_Adresse_MAJ.Name = "tb_Titre_Adresse_MAJ";
            this.tb_Titre_Adresse_MAJ.Size = new System.Drawing.Size(79, 21);
            this.tb_Titre_Adresse_MAJ.TabIndex = 16;
            this.tb_Titre_Adresse_MAJ.Text = "Adresse :";
            // 
            // l_Titre_MAJ
            // 
            this.l_Titre_MAJ.AutoSize = true;
            this.l_Titre_MAJ.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Titre_MAJ.ForeColor = System.Drawing.SystemColors.Window;
            this.l_Titre_MAJ.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_Titre_MAJ.Location = new System.Drawing.Point(382, 88);
            this.l_Titre_MAJ.Name = "l_Titre_MAJ";
            this.l_Titre_MAJ.Size = new System.Drawing.Size(242, 25);
            this.l_Titre_MAJ.TabIndex = 25;
            this.l_Titre_MAJ.Text = "Mise à Jour d\'un Client";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(670, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 360);
            this.panel1.TabIndex = 21;
            // 
            // l_Titre_Supprimer
            // 
            this.l_Titre_Supprimer.AutoSize = true;
            this.l_Titre_Supprimer.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Titre_Supprimer.ForeColor = System.Drawing.SystemColors.Window;
            this.l_Titre_Supprimer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_Titre_Supprimer.Location = new System.Drawing.Point(725, 88);
            this.l_Titre_Supprimer.Name = "l_Titre_Supprimer";
            this.l_Titre_Supprimer.Size = new System.Drawing.Size(212, 25);
            this.l_Titre_Supprimer.TabIndex = 26;
            this.l_Titre_Supprimer.Text = "Supprimer un Client";
            // 
            // p_Supprimer_Client
            // 
            this.p_Supprimer_Client.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_Supprimer_Client.Controls.Add(this.chb_Nom_Supprimer);
            this.p_Supprimer_Client.Controls.Add(this.cb_Nom);
            this.p_Supprimer_Client.Controls.Add(this.bt_Supprimer);
            this.p_Supprimer_Client.Controls.Add(this.tb_Titre_Nom_Supprimer);
            this.p_Supprimer_Client.Location = new System.Drawing.Point(692, 125);
            this.p_Supprimer_Client.Name = "p_Supprimer_Client";
            this.p_Supprimer_Client.Size = new System.Drawing.Size(296, 110);
            this.p_Supprimer_Client.TabIndex = 25;
            // 
            // chb_Nom_Supprimer
            // 
            this.chb_Nom_Supprimer.AutoSize = true;
            this.chb_Nom_Supprimer.Location = new System.Drawing.Point(-1, 20);
            this.chb_Nom_Supprimer.Name = "chb_Nom_Supprimer";
            this.chb_Nom_Supprimer.Size = new System.Drawing.Size(15, 14);
            this.chb_Nom_Supprimer.TabIndex = 31;
            this.chb_Nom_Supprimer.UseVisualStyleBackColor = true;
            this.chb_Nom_Supprimer.CheckedChanged += new System.EventHandler(this.NomIsCheck_2);
            // 
            // cb_Nom
            // 
            this.cb_Nom.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Nom.FormattingEnabled = true;
            this.cb_Nom.Location = new System.Drawing.Point(91, 13);
            this.cb_Nom.Name = "cb_Nom";
            this.cb_Nom.Size = new System.Drawing.Size(187, 28);
            this.cb_Nom.TabIndex = 24;
            // 
            // bt_Supprimer
            // 
            this.bt_Supprimer.Location = new System.Drawing.Point(91, 69);
            this.bt_Supprimer.Name = "bt_Supprimer";
            this.bt_Supprimer.Size = new System.Drawing.Size(105, 29);
            this.bt_Supprimer.TabIndex = 23;
            this.bt_Supprimer.Text = "Enregistrer";
            this.bt_Supprimer.UseVisualStyleBackColor = true;
            this.bt_Supprimer.Click += new System.EventHandler(this.Supprimer_Client);
            // 
            // tb_Titre_Nom_Supprimer
            // 
            this.tb_Titre_Nom_Supprimer.AutoSize = true;
            this.tb_Titre_Nom_Supprimer.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tb_Titre_Nom_Supprimer.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_Titre_Nom_Supprimer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tb_Titre_Nom_Supprimer.Location = new System.Drawing.Point(15, 16);
            this.tb_Titre_Nom_Supprimer.Name = "tb_Titre_Nom_Supprimer";
            this.tb_Titre_Nom_Supprimer.Size = new System.Drawing.Size(59, 21);
            this.tb_Titre_Nom_Supprimer.TabIndex = 15;
            this.tb_Titre_Nom_Supprimer.Text = "Nom : ";
            // 
            // ClientCRUD
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.p_Supprimer_Client);
            this.Controls.Add(this.l_Titre_Supprimer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.l_Titre_MAJ);
            this.Controls.Add(this.p_MAJ_Client);
            this.Controls.Add(this.p_separator_1);
            this.Controls.Add(this.p_Ajout_Client);
            this.Controls.Add(this.l_Titre_Ajout);
            this.Controls.Add(this.p_form1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientCRUD";
            this.p_form1.ResumeLayout(false);
            this.p_form1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Return)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Close)).EndInit();
            this.p_Ajout_Client.ResumeLayout(false);
            this.p_Ajout_Client.PerformLayout();
            this.p_MAJ_Client.ResumeLayout(false);
            this.p_MAJ_Client.PerformLayout();
            this.p_Supprimer_Client.ResumeLayout(false);
            this.p_Supprimer_Client.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel p_form1;
        private System.Windows.Forms.PictureBox img_Return;
        private System.Windows.Forms.Label l_Titre_Chargeon;
        private System.Windows.Forms.PictureBox img_Close;
        private System.Windows.Forms.Label l_Titre_Ajout;
        private System.Windows.Forms.Label l_Titre_Nom_Ajout;
        private System.Windows.Forms.Label l_Titre_Adresse_Ajout;
        private System.Windows.Forms.Label l_Titre_Ville_Ajout;
        private System.Windows.Forms.Label l_Titre_CP_Ajout;
        private System.Windows.Forms.Panel p_Ajout_Client;
        private System.Windows.Forms.TextBox tb_CP_Ajout;
        private System.Windows.Forms.TextBox tb_Adresse_Ajout;
        private System.Windows.Forms.TextBox tb_Nom_Ajout;
        private System.Windows.Forms.TextBox tb_Ville_Ajout;
        private System.Windows.Forms.Panel p_separator_1;
        private System.Windows.Forms.Button bt_Ajout;
        private System.Windows.Forms.Panel p_MAJ_Client;
        private System.Windows.Forms.Button bt_MAJ;
        private System.Windows.Forms.TextBox tb_Ville_MAJ;
        private System.Windows.Forms.TextBox tb_CP_MAJ;
        private System.Windows.Forms.Label tb_Titre_Ville_MAJ;
        private System.Windows.Forms.TextBox tb_Adresse_MAJ;
        private System.Windows.Forms.Label tb_Titre_CP_MAJ;
        private System.Windows.Forms.TextBox tb_Nom_MAJ;
        private System.Windows.Forms.Label tb_Titre_Nom_MAJ;
        private System.Windows.Forms.Label tb_Titre_Adresse_MAJ;
        private System.Windows.Forms.Label l_Titre_MAJ;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label l_Titre_Supprimer;
        private System.Windows.Forms.Panel p_Supprimer_Client;
        private System.Windows.Forms.Button bt_Supprimer;
        private System.Windows.Forms.Label tb_Titre_Nom_Supprimer;
        private System.Windows.Forms.CheckBox chb_Ville;
        private System.Windows.Forms.CheckBox chb_CP;
        private System.Windows.Forms.CheckBox chb_Adresse;
        private System.Windows.Forms.CheckBox chb_Nom_MAJ;
        private System.Windows.Forms.ComboBox cb_Nom;
        private System.Windows.Forms.CheckBox chb_Nom_Supprimer;
    }
}