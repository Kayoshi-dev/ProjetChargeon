namespace ProjetChargeon
{
	partial class MesBornes
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MesBornes));
			this.p_Chargeon = new System.Windows.Forms.Panel();
			this.img_Return = new System.Windows.Forms.PictureBox();
			this.l_Titre_Chargeon = new System.Windows.Forms.Label();
			this.img_Close = new System.Windows.Forms.PictureBox();
			this.cb_mesBornes = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.l_bornesClients = new System.Windows.Forms.Label();
			this.l_etat = new System.Windows.Forms.Label();
			this.p_etat = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.l_ville = new System.Windows.Forms.Label();
			this.l_titreType = new System.Windows.Forms.Label();
			this.l_type = new System.Windows.Forms.Label();
			this.l_ns = new System.Windows.Forms.Label();
			this.l_titleNS = new System.Windows.Forms.Label();
			this.l_puis = new System.Windows.Forms.Label();
			this.l_title_Puis = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.l_valid = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.cb_typepb = new System.Windows.Forms.ComboBox();
			this.tb_intitule = new System.Windows.Forms.TextBox();
			this.p_Chargeon.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.img_Return)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.img_Close)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.p_etat)).BeginInit();
			this.SuspendLayout();
			// 
			// p_Chargeon
			// 
			this.p_Chargeon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
			this.p_Chargeon.Controls.Add(this.img_Return);
			this.p_Chargeon.Controls.Add(this.l_Titre_Chargeon);
			this.p_Chargeon.Controls.Add(this.img_Close);
			this.p_Chargeon.Dock = System.Windows.Forms.DockStyle.Top;
			this.p_Chargeon.Location = new System.Drawing.Point(0, 0);
			this.p_Chargeon.Name = "p_Chargeon";
			this.p_Chargeon.Size = new System.Drawing.Size(800, 72);
			this.p_Chargeon.TabIndex = 11;
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
			this.img_Close.Click += new System.EventHandler(this.CloseProgram);
			// 
			// cb_mesBornes
			// 
			this.cb_mesBornes.BackColor = System.Drawing.Color.White;
			this.cb_mesBornes.ForeColor = System.Drawing.Color.Black;
			this.cb_mesBornes.FormattingEnabled = true;
			this.cb_mesBornes.Location = new System.Drawing.Point(44, 117);
			this.cb_mesBornes.Name = "cb_mesBornes";
			this.cb_mesBornes.Size = new System.Drawing.Size(121, 29);
			this.cb_mesBornes.TabIndex = 12;
			this.cb_mesBornes.SelectedIndexChanged += new System.EventHandler(this.Cb_bornesClient_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(79, 297);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 21);
			this.label1.TabIndex = 14;
			this.label1.Text = "État";
			// 
			// l_bornesClients
			// 
			this.l_bornesClients.AutoSize = true;
			this.l_bornesClients.ForeColor = System.Drawing.Color.White;
			this.l_bornesClients.Location = new System.Drawing.Point(54, 93);
			this.l_bornesClients.Name = "l_bornesClients";
			this.l_bornesClients.Size = new System.Drawing.Size(97, 21);
			this.l_bornesClients.TabIndex = 13;
			this.l_bornesClients.Text = "Mes bornes";
			// 
			// l_etat
			// 
			this.l_etat.ForeColor = System.Drawing.Color.White;
			this.l_etat.Location = new System.Drawing.Point(73, 350);
			this.l_etat.Name = "l_etat";
			this.l_etat.Size = new System.Drawing.Size(56, 21);
			this.l_etat.TabIndex = 16;
			this.l_etat.Text = "ON";
			this.l_etat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// p_etat
			// 
			this.p_etat.Image = global::ProjetChargeon.Properties.Resources.circle_green;
			this.p_etat.Location = new System.Drawing.Point(51, 312);
			this.p_etat.Name = "p_etat";
			this.p_etat.Size = new System.Drawing.Size(100, 101);
			this.p_etat.TabIndex = 15;
			this.p_etat.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.panel1.Location = new System.Drawing.Point(211, 92);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(3, 340);
			this.panel1.TabIndex = 18;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(79, 183);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 21);
			this.label2.TabIndex = 19;
			this.label2.Text = "Ville";
			// 
			// l_ville
			// 
			this.l_ville.BackColor = System.Drawing.Color.Transparent;
			this.l_ville.ForeColor = System.Drawing.Color.White;
			this.l_ville.Location = new System.Drawing.Point(0, 224);
			this.l_ville.Name = "l_ville";
			this.l_ville.Size = new System.Drawing.Size(211, 21);
			this.l_ville.TabIndex = 20;
			this.l_ville.Text = "Grenoble";
			this.l_ville.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// l_titreType
			// 
			this.l_titreType.AutoSize = true;
			this.l_titreType.ForeColor = System.Drawing.Color.White;
			this.l_titreType.Location = new System.Drawing.Point(330, 297);
			this.l_titreType.Name = "l_titreType";
			this.l_titreType.Size = new System.Drawing.Size(47, 21);
			this.l_titreType.TabIndex = 21;
			this.l_titreType.Text = "Type";
			// 
			// l_type
			// 
			this.l_type.ForeColor = System.Drawing.Color.White;
			this.l_type.Location = new System.Drawing.Point(285, 338);
			this.l_type.Name = "l_type";
			this.l_type.Size = new System.Drawing.Size(135, 21);
			this.l_type.TabIndex = 22;
			this.l_type.Text = "AfficheType";
			this.l_type.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// l_ns
			// 
			this.l_ns.ForeColor = System.Drawing.Color.White;
			this.l_ns.Location = new System.Drawing.Point(277, 135);
			this.l_ns.Name = "l_ns";
			this.l_ns.Size = new System.Drawing.Size(142, 21);
			this.l_ns.TabIndex = 24;
			this.l_ns.Text = "AfficheNS";
			this.l_ns.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// l_titleNS
			// 
			this.l_titleNS.AutoSize = true;
			this.l_titleNS.ForeColor = System.Drawing.Color.White;
			this.l_titleNS.Location = new System.Drawing.Point(284, 93);
			this.l_titleNS.Name = "l_titleNS";
			this.l_titleNS.Size = new System.Drawing.Size(135, 21);
			this.l_titleNS.TabIndex = 23;
			this.l_titleNS.Text = "Numéro de série";
			// 
			// l_puis
			// 
			this.l_puis.ForeColor = System.Drawing.Color.White;
			this.l_puis.Location = new System.Drawing.Point(598, 135);
			this.l_puis.Name = "l_puis";
			this.l_puis.Size = new System.Drawing.Size(135, 21);
			this.l_puis.TabIndex = 26;
			this.l_puis.Text = "AffichePuis";
			this.l_puis.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// l_title_Puis
			// 
			this.l_title_Puis.ForeColor = System.Drawing.Color.White;
			this.l_title_Puis.Location = new System.Drawing.Point(578, 92);
			this.l_title_Puis.Name = "l_title_Puis";
			this.l_title_Puis.Size = new System.Drawing.Size(178, 21);
			this.l_title_Puis.TabIndex = 25;
			this.l_title_Puis.Text = "Puissance de la borne";
			this.l_title_Puis.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(578, 297);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(178, 21);
			this.label3.TabIndex = 27;
			this.label3.Text = "Demander de l\'aide";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// l_valid
			// 
			this.l_valid.Location = new System.Drawing.Point(712, 406);
			this.l_valid.Name = "l_valid";
			this.l_valid.Size = new System.Drawing.Size(88, 29);
			this.l_valid.TabIndex = 31;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(631, 412);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 29;
			this.button1.Text = "Envoyer";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.needHelp);
			// 
			// cb_typepb
			// 
			this.cb_typepb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_typepb.FormattingEnabled = true;
			this.cb_typepb.Location = new System.Drawing.Point(577, 377);
			this.cb_typepb.Name = "cb_typepb";
			this.cb_typepb.Size = new System.Drawing.Size(186, 28);
			this.cb_typepb.TabIndex = 32;
			// 
			// tb_intitule
			// 
			this.tb_intitule.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_intitule.Location = new System.Drawing.Point(577, 329);
			this.tb_intitule.MaxLength = 500;
			this.tb_intitule.Multiline = true;
			this.tb_intitule.Name = "tb_intitule";
			this.tb_intitule.Size = new System.Drawing.Size(186, 42);
			this.tb_intitule.TabIndex = 30;
			this.tb_intitule.Text = "Intitulé de votre problème";
			this.tb_intitule.MouseClick += new System.Windows.Forms.MouseEventHandler(this.messageHelpClick);
			// 
			// MesBornes
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cb_typepb);
			this.Controls.Add(this.l_valid);
			this.Controls.Add(this.tb_intitule);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.l_puis);
			this.Controls.Add(this.l_title_Puis);
			this.Controls.Add(this.l_ns);
			this.Controls.Add(this.l_titleNS);
			this.Controls.Add(this.l_type);
			this.Controls.Add(this.l_titreType);
			this.Controls.Add(this.l_ville);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.l_etat);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.p_Chargeon);
			this.Controls.Add(this.p_etat);
			this.Controls.Add(this.l_bornesClients);
			this.Controls.Add(this.cb_mesBornes);
			this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MesBornes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MesBornes";
			this.p_Chargeon.ResumeLayout(false);
			this.p_Chargeon.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.img_Return)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.img_Close)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.p_etat)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel p_Chargeon;
		private System.Windows.Forms.Label l_Titre_Chargeon;
		private System.Windows.Forms.PictureBox img_Close;
		private System.Windows.Forms.PictureBox img_Return;
		private System.Windows.Forms.ComboBox cb_mesBornes;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label l_bornesClients;
		private System.Windows.Forms.PictureBox p_etat;
		private System.Windows.Forms.Label l_etat;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label l_ville;
		private System.Windows.Forms.Label l_titreType;
		private System.Windows.Forms.Label l_type;
		private System.Windows.Forms.Label l_ns;
		private System.Windows.Forms.Label l_titleNS;
		private System.Windows.Forms.Label l_puis;
		private System.Windows.Forms.Label l_title_Puis;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label l_valid;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox cb_typepb;
		private System.Windows.Forms.TextBox tb_intitule;
	}
}