namespace ProjetChargeon
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
            this.p_Titre_Chargeon = new System.Windows.Forms.Panel();
            this.img_Return = new System.Windows.Forms.PictureBox();
            this.l_Titre_Chargeon = new System.Windows.Forms.Label();
            this.img_Close = new System.Windows.Forms.PictureBox();
            this.cb_Nom = new System.Windows.Forms.ComboBox();
            this.tb_Titre_Nom = new System.Windows.Forms.Label();
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
            this.p_Separator_1 = new System.Windows.Forms.Panel();
            this.p_MAJ_Client = new System.Windows.Forms.Panel();
            this.bt_MAJ = new System.Windows.Forms.Button();
            this.tb_Ville_Modif = new System.Windows.Forms.TextBox();
            this.tb_CP_Modif = new System.Windows.Forms.TextBox();
            this.tb_Titre_Ville_MAJ = new System.Windows.Forms.Label();
            this.tb_Adresse_Modif = new System.Windows.Forms.TextBox();
            this.tb_Titre_CP_MAJ = new System.Windows.Forms.Label();
            this.tb_Nom_Modif = new System.Windows.Forms.TextBox();
            this.tb_Titre_Nom_MAJ = new System.Windows.Forms.Label();
            this.tb_Titre_Adresse_MAJ = new System.Windows.Forms.Label();
            this.l_Titre_MAJ = new System.Windows.Forms.Label();
            this.p_Separator_2 = new System.Windows.Forms.Panel();
            this.l_Titre_Supprimer = new System.Windows.Forms.Label();
            this.p_Supprimer_Client = new System.Windows.Forms.Panel();
            this.l_Nom_Supprimer = new System.Windows.Forms.Label();
            this.bt_Supprimer = new System.Windows.Forms.Button();
            this.l_test = new System.Windows.Forms.Label();
            this.p_Titre_Chargeon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Return)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Close)).BeginInit();
            this.p_Ajout_Client.SuspendLayout();
            this.p_MAJ_Client.SuspendLayout();
            this.p_Supprimer_Client.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_Titre_Chargeon
            // 
            this.p_Titre_Chargeon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.p_Titre_Chargeon.Controls.Add(this.img_Return);
            this.p_Titre_Chargeon.Controls.Add(this.l_Titre_Chargeon);
            this.p_Titre_Chargeon.Controls.Add(this.img_Close);
            this.p_Titre_Chargeon.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Titre_Chargeon.Location = new System.Drawing.Point(0, 0);
            this.p_Titre_Chargeon.Name = "p_Titre_Chargeon";
            this.p_Titre_Chargeon.Size = new System.Drawing.Size(1000, 72);
            this.p_Titre_Chargeon.TabIndex = 13;
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
            this.l_Titre_Chargeon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.l_Titre_Chargeon.ForeColor = System.Drawing.SystemColors.Window;
            this.l_Titre_Chargeon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_Titre_Chargeon.Location = new System.Drawing.Point(12, 25);
            this.l_Titre_Chargeon.Name = "l_Titre_Chargeon";
            this.l_Titre_Chargeon.Size = new System.Drawing.Size(79, 20);
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
            // cb_Nom
            // 
            this.cb_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Nom.FormattingEnabled = true;
            this.cb_Nom.Location = new System.Drawing.Point(784, 88);
            this.cb_Nom.Name = "cb_Nom";
            this.cb_Nom.Size = new System.Drawing.Size(187, 26);
            this.cb_Nom.TabIndex = 6;
            this.cb_Nom.SelectedIndexChanged += new System.EventHandler(this.NameIndexChange);
            // 
            // tb_Titre_Nom
            // 
            this.tb_Titre_Nom.AutoSize = true;
            this.tb_Titre_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Titre_Nom.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_Titre_Nom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tb_Titre_Nom.Location = new System.Drawing.Point(708, 91);
            this.tb_Titre_Nom.Name = "tb_Titre_Nom";
            this.tb_Titre_Nom.Size = new System.Drawing.Size(54, 20);
            this.tb_Titre_Nom.TabIndex = 15;
            this.tb_Titre_Nom.Text = "Nom : ";
            // 
            // l_Titre_Ajout
            // 
            this.l_Titre_Ajout.AutoSize = true;
            this.l_Titre_Ajout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Titre_Ajout.ForeColor = System.Drawing.SystemColors.Window;
            this.l_Titre_Ajout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_Titre_Ajout.Location = new System.Drawing.Point(78, 88);
            this.l_Titre_Ajout.Name = "l_Titre_Ajout";
            this.l_Titre_Ajout.Size = new System.Drawing.Size(171, 25);
            this.l_Titre_Ajout.TabIndex = 14;
            this.l_Titre_Ajout.Text = "Ajouter un Client";
            // 
            // l_Titre_Nom_Ajout
            // 
            this.l_Titre_Nom_Ajout.AutoSize = true;
            this.l_Titre_Nom_Ajout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.l_Titre_Nom_Ajout.ForeColor = System.Drawing.SystemColors.Window;
            this.l_Titre_Nom_Ajout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_Titre_Nom_Ajout.Location = new System.Drawing.Point(15, 16);
            this.l_Titre_Nom_Ajout.Name = "l_Titre_Nom_Ajout";
            this.l_Titre_Nom_Ajout.Size = new System.Drawing.Size(54, 20);
            this.l_Titre_Nom_Ajout.TabIndex = 15;
            this.l_Titre_Nom_Ajout.Text = "Nom : ";
            // 
            // l_Titre_Adresse_Ajout
            // 
            this.l_Titre_Adresse_Ajout.AutoSize = true;
            this.l_Titre_Adresse_Ajout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.l_Titre_Adresse_Ajout.ForeColor = System.Drawing.SystemColors.Window;
            this.l_Titre_Adresse_Ajout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_Titre_Adresse_Ajout.Location = new System.Drawing.Point(15, 57);
            this.l_Titre_Adresse_Ajout.Name = "l_Titre_Adresse_Ajout";
            this.l_Titre_Adresse_Ajout.Size = new System.Drawing.Size(76, 20);
            this.l_Titre_Adresse_Ajout.TabIndex = 16;
            this.l_Titre_Adresse_Ajout.Text = "Adresse :";
            // 
            // l_Titre_Ville_Ajout
            // 
            this.l_Titre_Ville_Ajout.AutoSize = true;
            this.l_Titre_Ville_Ajout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.l_Titre_Ville_Ajout.ForeColor = System.Drawing.SystemColors.Window;
            this.l_Titre_Ville_Ajout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_Titre_Ville_Ajout.Location = new System.Drawing.Point(15, 194);
            this.l_Titre_Ville_Ajout.Name = "l_Titre_Ville_Ajout";
            this.l_Titre_Ville_Ajout.Size = new System.Drawing.Size(46, 20);
            this.l_Titre_Ville_Ajout.TabIndex = 17;
            this.l_Titre_Ville_Ajout.Text = "Ville :";
            // 
            // l_Titre_CP_Ajout
            // 
            this.l_Titre_CP_Ajout.AutoSize = true;
            this.l_Titre_CP_Ajout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.l_Titre_CP_Ajout.ForeColor = System.Drawing.SystemColors.Window;
            this.l_Titre_CP_Ajout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_Titre_CP_Ajout.Location = new System.Drawing.Point(15, 147);
            this.l_Titre_CP_Ajout.Name = "l_Titre_CP_Ajout";
            this.l_Titre_CP_Ajout.Size = new System.Drawing.Size(38, 20);
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
            this.bt_Ajout.Location = new System.Drawing.Point(100, 246);
            this.bt_Ajout.Name = "bt_Ajout";
            this.bt_Ajout.Size = new System.Drawing.Size(105, 29);
            this.bt_Ajout.TabIndex = 5;
            this.bt_Ajout.Text = "Ajouter";
            this.bt_Ajout.UseVisualStyleBackColor = true;
            this.bt_Ajout.Click += new System.EventHandler(this.AddClick);
            // 
            // tb_Ville_Ajout
            // 
            this.tb_Ville_Ajout.Location = new System.Drawing.Point(100, 191);
            this.tb_Ville_Ajout.Name = "tb_Ville_Ajout";
            this.tb_Ville_Ajout.Size = new System.Drawing.Size(172, 26);
            this.tb_Ville_Ajout.TabIndex = 4;
            // 
            // tb_CP_Ajout
            // 
            this.tb_CP_Ajout.Location = new System.Drawing.Point(100, 144);
            this.tb_CP_Ajout.Name = "tb_CP_Ajout";
            this.tb_CP_Ajout.Size = new System.Drawing.Size(172, 26);
            this.tb_CP_Ajout.TabIndex = 3;
            // 
            // tb_Adresse_Ajout
            // 
            this.tb_Adresse_Ajout.Location = new System.Drawing.Point(100, 57);
            this.tb_Adresse_Ajout.Multiline = true;
            this.tb_Adresse_Ajout.Name = "tb_Adresse_Ajout";
            this.tb_Adresse_Ajout.Size = new System.Drawing.Size(172, 73);
            this.tb_Adresse_Ajout.TabIndex = 2;
            // 
            // tb_Nom_Ajout
            // 
            this.tb_Nom_Ajout.Location = new System.Drawing.Point(100, 13);
            this.tb_Nom_Ajout.Name = "tb_Nom_Ajout";
            this.tb_Nom_Ajout.Size = new System.Drawing.Size(172, 26);
            this.tb_Nom_Ajout.TabIndex = 1;
            // 
            // p_Separator_1
            // 
            this.p_Separator_1.BackColor = System.Drawing.Color.White;
            this.p_Separator_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p_Separator_1.Location = new System.Drawing.Point(329, 78);
            this.p_Separator_1.Name = "p_Separator_1";
            this.p_Separator_1.Size = new System.Drawing.Size(1, 360);
            this.p_Separator_1.TabIndex = 20;
            // 
            // p_MAJ_Client
            // 
            this.p_MAJ_Client.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_MAJ_Client.Controls.Add(this.bt_MAJ);
            this.p_MAJ_Client.Controls.Add(this.tb_Ville_Modif);
            this.p_MAJ_Client.Controls.Add(this.tb_CP_Modif);
            this.p_MAJ_Client.Controls.Add(this.tb_Titre_Ville_MAJ);
            this.p_MAJ_Client.Controls.Add(this.tb_Adresse_Modif);
            this.p_MAJ_Client.Controls.Add(this.tb_Titre_CP_MAJ);
            this.p_MAJ_Client.Controls.Add(this.tb_Nom_Modif);
            this.p_MAJ_Client.Controls.Add(this.tb_Titre_Nom_MAJ);
            this.p_MAJ_Client.Controls.Add(this.tb_Titre_Adresse_MAJ);
            this.p_MAJ_Client.Location = new System.Drawing.Point(351, 125);
            this.p_MAJ_Client.Name = "p_MAJ_Client";
            this.p_MAJ_Client.Size = new System.Drawing.Size(296, 292);
            this.p_MAJ_Client.TabIndex = 24;
            // 
            // bt_MAJ
            // 
            this.bt_MAJ.Location = new System.Drawing.Point(100, 246);
            this.bt_MAJ.Name = "bt_MAJ";
            this.bt_MAJ.Size = new System.Drawing.Size(105, 29);
            this.bt_MAJ.TabIndex = 11;
            this.bt_MAJ.Text = "Modifier";
            this.bt_MAJ.UseVisualStyleBackColor = true;
            this.bt_MAJ.Click += new System.EventHandler(this.UpdateClick);
            // 
            // tb_Ville_Modif
            // 
            this.tb_Ville_Modif.Location = new System.Drawing.Point(100, 191);
            this.tb_Ville_Modif.Name = "tb_Ville_Modif";
            this.tb_Ville_Modif.Size = new System.Drawing.Size(172, 26);
            this.tb_Ville_Modif.TabIndex = 10;
            // 
            // tb_CP_Modif
            // 
            this.tb_CP_Modif.Location = new System.Drawing.Point(100, 144);
            this.tb_CP_Modif.Name = "tb_CP_Modif";
            this.tb_CP_Modif.Size = new System.Drawing.Size(172, 26);
            this.tb_CP_Modif.TabIndex = 9;
            // 
            // tb_Titre_Ville_MAJ
            // 
            this.tb_Titre_Ville_MAJ.AutoSize = true;
            this.tb_Titre_Ville_MAJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Titre_Ville_MAJ.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_Titre_Ville_MAJ.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tb_Titre_Ville_MAJ.Location = new System.Drawing.Point(15, 194);
            this.tb_Titre_Ville_MAJ.Name = "tb_Titre_Ville_MAJ";
            this.tb_Titre_Ville_MAJ.Size = new System.Drawing.Size(46, 20);
            this.tb_Titre_Ville_MAJ.TabIndex = 17;
            this.tb_Titre_Ville_MAJ.Text = "Ville :";
            // 
            // tb_Adresse_Modif
            // 
            this.tb_Adresse_Modif.Location = new System.Drawing.Point(100, 57);
            this.tb_Adresse_Modif.Multiline = true;
            this.tb_Adresse_Modif.Name = "tb_Adresse_Modif";
            this.tb_Adresse_Modif.Size = new System.Drawing.Size(172, 73);
            this.tb_Adresse_Modif.TabIndex = 8;
            // 
            // tb_Titre_CP_MAJ
            // 
            this.tb_Titre_CP_MAJ.AutoSize = true;
            this.tb_Titre_CP_MAJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Titre_CP_MAJ.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_Titre_CP_MAJ.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tb_Titre_CP_MAJ.Location = new System.Drawing.Point(15, 147);
            this.tb_Titre_CP_MAJ.Name = "tb_Titre_CP_MAJ";
            this.tb_Titre_CP_MAJ.Size = new System.Drawing.Size(38, 20);
            this.tb_Titre_CP_MAJ.TabIndex = 18;
            this.tb_Titre_CP_MAJ.Text = "CP :";
            // 
            // tb_Nom_Modif
            // 
            this.tb_Nom_Modif.Location = new System.Drawing.Point(100, 13);
            this.tb_Nom_Modif.Name = "tb_Nom_Modif";
            this.tb_Nom_Modif.Size = new System.Drawing.Size(172, 26);
            this.tb_Nom_Modif.TabIndex = 7;
            // 
            // tb_Titre_Nom_MAJ
            // 
            this.tb_Titre_Nom_MAJ.AutoSize = true;
            this.tb_Titre_Nom_MAJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Titre_Nom_MAJ.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_Titre_Nom_MAJ.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tb_Titre_Nom_MAJ.Location = new System.Drawing.Point(15, 16);
            this.tb_Titre_Nom_MAJ.Name = "tb_Titre_Nom_MAJ";
            this.tb_Titre_Nom_MAJ.Size = new System.Drawing.Size(54, 20);
            this.tb_Titre_Nom_MAJ.TabIndex = 15;
            this.tb_Titre_Nom_MAJ.Text = "Nom : ";
            // 
            // tb_Titre_Adresse_MAJ
            // 
            this.tb_Titre_Adresse_MAJ.AutoSize = true;
            this.tb_Titre_Adresse_MAJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Titre_Adresse_MAJ.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_Titre_Adresse_MAJ.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tb_Titre_Adresse_MAJ.Location = new System.Drawing.Point(15, 57);
            this.tb_Titre_Adresse_MAJ.Name = "tb_Titre_Adresse_MAJ";
            this.tb_Titre_Adresse_MAJ.Size = new System.Drawing.Size(76, 20);
            this.tb_Titre_Adresse_MAJ.TabIndex = 16;
            this.tb_Titre_Adresse_MAJ.Text = "Adresse :";
            // 
            // l_Titre_MAJ
            // 
            this.l_Titre_MAJ.AutoSize = true;
            this.l_Titre_MAJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Titre_MAJ.ForeColor = System.Drawing.SystemColors.Window;
            this.l_Titre_MAJ.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_Titre_MAJ.Location = new System.Drawing.Point(382, 88);
            this.l_Titre_MAJ.Name = "l_Titre_MAJ";
            this.l_Titre_MAJ.Size = new System.Drawing.Size(231, 25);
            this.l_Titre_MAJ.TabIndex = 25;
            this.l_Titre_MAJ.Text = "Mise à Jour d\'un Client";
            // 
            // p_Separator_2
            // 
            this.p_Separator_2.BackColor = System.Drawing.Color.White;
            this.p_Separator_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p_Separator_2.Location = new System.Drawing.Point(670, 78);
            this.p_Separator_2.Name = "p_Separator_2";
            this.p_Separator_2.Size = new System.Drawing.Size(1, 360);
            this.p_Separator_2.TabIndex = 21;
            // 
            // l_Titre_Supprimer
            // 
            this.l_Titre_Supprimer.AutoSize = true;
            this.l_Titre_Supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Titre_Supprimer.ForeColor = System.Drawing.SystemColors.Window;
            this.l_Titre_Supprimer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_Titre_Supprimer.Location = new System.Drawing.Point(745, 184);
            this.l_Titre_Supprimer.Name = "l_Titre_Supprimer";
            this.l_Titre_Supprimer.Size = new System.Drawing.Size(201, 25);
            this.l_Titre_Supprimer.TabIndex = 26;
            this.l_Titre_Supprimer.Text = "Supprimer un Client";
            // 
            // p_Supprimer_Client
            // 
            this.p_Supprimer_Client.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_Supprimer_Client.Controls.Add(this.l_Nom_Supprimer);
            this.p_Supprimer_Client.Controls.Add(this.bt_Supprimer);
            this.p_Supprimer_Client.Location = new System.Drawing.Point(692, 212);
            this.p_Supprimer_Client.Name = "p_Supprimer_Client";
            this.p_Supprimer_Client.Size = new System.Drawing.Size(296, 110);
            this.p_Supprimer_Client.TabIndex = 25;
            // 
            // l_Nom_Supprimer
            // 
            this.l_Nom_Supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Nom_Supprimer.ForeColor = System.Drawing.Color.White;
            this.l_Nom_Supprimer.Location = new System.Drawing.Point(19, 22);
            this.l_Nom_Supprimer.Name = "l_Nom_Supprimer";
            this.l_Nom_Supprimer.Size = new System.Drawing.Size(259, 21);
            this.l_Nom_Supprimer.TabIndex = 24;
            this.l_Nom_Supprimer.Text = "Nom";
            this.l_Nom_Supprimer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bt_Supprimer
            // 
            this.bt_Supprimer.Location = new System.Drawing.Point(91, 69);
            this.bt_Supprimer.Name = "bt_Supprimer";
            this.bt_Supprimer.Size = new System.Drawing.Size(105, 29);
            this.bt_Supprimer.TabIndex = 12;
            this.bt_Supprimer.Text = "Supprimer";
            this.bt_Supprimer.UseVisualStyleBackColor = true;
            this.bt_Supprimer.Click += new System.EventHandler(this.DeleteClick);
            // 
            // l_test
            // 
            this.l_test.ForeColor = System.Drawing.Color.White;
            this.l_test.Location = new System.Drawing.Point(692, 380);
            this.l_test.Name = "l_test";
            this.l_test.Size = new System.Drawing.Size(296, 21);
            this.l_test.TabIndex = 27;
            this.l_test.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ClientCRUD
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.l_test);
            this.Controls.Add(this.cb_Nom);
            this.Controls.Add(this.p_Supprimer_Client);
            this.Controls.Add(this.tb_Titre_Nom);
            this.Controls.Add(this.l_Titre_Supprimer);
            this.Controls.Add(this.p_Separator_2);
            this.Controls.Add(this.l_Titre_MAJ);
            this.Controls.Add(this.p_MAJ_Client);
            this.Controls.Add(this.p_Separator_1);
            this.Controls.Add(this.p_Ajout_Client);
            this.Controls.Add(this.l_Titre_Ajout);
            this.Controls.Add(this.p_Titre_Chargeon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientCRUD";
            this.p_Titre_Chargeon.ResumeLayout(false);
            this.p_Titre_Chargeon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Return)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Close)).EndInit();
            this.p_Ajout_Client.ResumeLayout(false);
            this.p_Ajout_Client.PerformLayout();
            this.p_MAJ_Client.ResumeLayout(false);
            this.p_MAJ_Client.PerformLayout();
            this.p_Supprimer_Client.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel p_Titre_Chargeon;
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
        private System.Windows.Forms.Panel p_Separator_1;
        private System.Windows.Forms.Button bt_Ajout;
        private System.Windows.Forms.Panel p_MAJ_Client;
        private System.Windows.Forms.Button bt_MAJ;
        private System.Windows.Forms.TextBox tb_Ville_Modif;
        private System.Windows.Forms.TextBox tb_CP_Modif;
        private System.Windows.Forms.Label tb_Titre_Ville_MAJ;
        private System.Windows.Forms.TextBox tb_Adresse_Modif;
        private System.Windows.Forms.Label tb_Titre_CP_MAJ;
        private System.Windows.Forms.TextBox tb_Nom_Modif;
        private System.Windows.Forms.Label tb_Titre_Nom_MAJ;
        private System.Windows.Forms.Label tb_Titre_Adresse_MAJ;
        private System.Windows.Forms.Label l_Titre_MAJ;
        private System.Windows.Forms.Panel p_Separator_2;
        private System.Windows.Forms.Label l_Titre_Supprimer;
        private System.Windows.Forms.Panel p_Supprimer_Client;
        private System.Windows.Forms.Button bt_Supprimer;
        private System.Windows.Forms.Label tb_Titre_Nom;
        private System.Windows.Forms.ComboBox cb_Nom;
		private System.Windows.Forms.Label l_Nom_Supprimer;
		private System.Windows.Forms.Label l_test;
	}
}