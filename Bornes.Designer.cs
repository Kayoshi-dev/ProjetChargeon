namespace ProjetChargeon
{
    partial class Bornes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bornes));
            this.p_Titre_Chargeon = new System.Windows.Forms.Panel();
            this.img_Return = new System.Windows.Forms.PictureBox();
            this.img_Close = new System.Windows.Forms.PictureBox();
            this.l_Titre_Borne = new System.Windows.Forms.Label();
            this.cb_Borne = new System.Windows.Forms.ComboBox();
            this.l_Titre_ID = new System.Windows.Forms.Label();
            this.p_ID = new System.Windows.Forms.Panel();
            this.l_ID = new System.Windows.Forms.Label();
            this.p_Separator = new System.Windows.Forms.Panel();
            this.p_Dispo = new System.Windows.Forms.PictureBox();
            this.l_Titre_Dispo = new System.Windows.Forms.Label();
            this.l_Dispo = new System.Windows.Forms.Label();
            this.l_Titre_NS = new System.Windows.Forms.Label();
            this.p_NS = new System.Windows.Forms.Panel();
            this.l_NS = new System.Windows.Forms.Label();
            this.p_Description = new System.Windows.Forms.Panel();
            this.l_Description = new System.Windows.Forms.Label();
            this.l_Titre_Description = new System.Windows.Forms.Label();
            this.l_Titre_Type = new System.Windows.Forms.Label();
            this.l_Titre_Puissance = new System.Windows.Forms.Label();
            this.p_Type = new System.Windows.Forms.Panel();
            this.l_Type = new System.Windows.Forms.Label();
            this.p_Puissance = new System.Windows.Forms.Panel();
            this.l_Puissance = new System.Windows.Forms.Label();
            this.l_Titre_Site = new System.Windows.Forms.Label();
            this.p_Site = new System.Windows.Forms.Panel();
            this.l_Site = new System.Windows.Forms.Label();
            this.p_Priorite = new System.Windows.Forms.Panel();
            this.l_Priorite = new System.Windows.Forms.Label();
            this.l_Titre_Priorite = new System.Windows.Forms.Label();
            this.p_Client = new System.Windows.Forms.Panel();
            this.l_Client = new System.Windows.Forms.Label();
            this.l_Titre_Client = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.p_Titre_Chargeon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Return)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Close)).BeginInit();
            this.p_ID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_Dispo)).BeginInit();
            this.p_NS.SuspendLayout();
            this.p_Description.SuspendLayout();
            this.p_Type.SuspendLayout();
            this.p_Puissance.SuspendLayout();
            this.p_Site.SuspendLayout();
            this.p_Priorite.SuspendLayout();
            this.p_Client.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_Titre_Chargeon
            // 
            this.p_Titre_Chargeon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.p_Titre_Chargeon.Controls.Add(this.label2);
            this.p_Titre_Chargeon.Controls.Add(this.img_Return);
            this.p_Titre_Chargeon.Controls.Add(this.img_Close);
            this.p_Titre_Chargeon.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Titre_Chargeon.Location = new System.Drawing.Point(0, 0);
            this.p_Titre_Chargeon.Name = "p_Titre_Chargeon";
            this.p_Titre_Chargeon.Size = new System.Drawing.Size(800, 72);
            this.p_Titre_Chargeon.TabIndex = 13;
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
            this.img_Return.Click += new System.EventHandler(this.Return);
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
            // l_Titre_Borne
            // 
            this.l_Titre_Borne.AutoSize = true;
            this.l_Titre_Borne.ForeColor = System.Drawing.Color.White;
            this.l_Titre_Borne.Location = new System.Drawing.Point(80, 94);
            this.l_Titre_Borne.Name = "l_Titre_Borne";
            this.l_Titre_Borne.Size = new System.Drawing.Size(52, 20);
            this.l_Titre_Borne.TabIndex = 15;
            this.l_Titre_Borne.Text = "Borne";
            // 
            // cb_Borne
            // 
            this.cb_Borne.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Borne.FormattingEnabled = true;
            this.cb_Borne.Location = new System.Drawing.Point(12, 119);
            this.cb_Borne.Name = "cb_Borne";
            this.cb_Borne.Size = new System.Drawing.Size(193, 26);
            this.cb_Borne.TabIndex = 16;
            this.cb_Borne.SelectedIndexChanged += new System.EventHandler(this.DataBorne);
            // 
            // l_Titre_ID
            // 
            this.l_Titre_ID.AutoSize = true;
            this.l_Titre_ID.BackColor = System.Drawing.Color.Transparent;
            this.l_Titre_ID.ForeColor = System.Drawing.Color.White;
            this.l_Titre_ID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_Titre_ID.Location = new System.Drawing.Point(97, 185);
            this.l_Titre_ID.Name = "l_Titre_ID";
            this.l_Titre_ID.Size = new System.Drawing.Size(26, 20);
            this.l_Titre_ID.TabIndex = 38;
            this.l_Titre_ID.Text = "ID";
            // 
            // p_ID
            // 
            this.p_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_ID.Controls.Add(this.l_ID);
            this.p_ID.Location = new System.Drawing.Point(49, 209);
            this.p_ID.Name = "p_ID";
            this.p_ID.Size = new System.Drawing.Size(121, 54);
            this.p_ID.TabIndex = 48;
            // 
            // l_ID
            // 
            this.l_ID.ForeColor = System.Drawing.Color.White;
            this.l_ID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_ID.Location = new System.Drawing.Point(0, 17);
            this.l_ID.Name = "l_ID";
            this.l_ID.Size = new System.Drawing.Size(120, 21);
            this.l_ID.TabIndex = 42;
            this.l_ID.Text = "AfficheID";
            this.l_ID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // p_Separator
            // 
            this.p_Separator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.p_Separator.Location = new System.Drawing.Point(221, 94);
            this.p_Separator.Name = "p_Separator";
            this.p_Separator.Size = new System.Drawing.Size(3, 340);
            this.p_Separator.TabIndex = 49;
            // 
            // p_Dispo
            // 
            this.p_Dispo.Image = global::ProjetChargeon.Properties.Resources.circle_green;
            this.p_Dispo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.p_Dispo.Location = new System.Drawing.Point(61, 314);
            this.p_Dispo.Name = "p_Dispo";
            this.p_Dispo.Size = new System.Drawing.Size(100, 101);
            this.p_Dispo.TabIndex = 50;
            this.p_Dispo.TabStop = false;
            // 
            // l_Titre_Dispo
            // 
            this.l_Titre_Dispo.AutoSize = true;
            this.l_Titre_Dispo.BackColor = System.Drawing.Color.Transparent;
            this.l_Titre_Dispo.ForeColor = System.Drawing.Color.White;
            this.l_Titre_Dispo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_Titre_Dispo.Location = new System.Drawing.Point(67, 290);
            this.l_Titre_Dispo.Name = "l_Titre_Dispo";
            this.l_Titre_Dispo.Size = new System.Drawing.Size(83, 20);
            this.l_Titre_Dispo.TabIndex = 51;
            this.l_Titre_Dispo.Text = "Disponible";
            // 
            // l_Dispo
            // 
            this.l_Dispo.ForeColor = System.Drawing.Color.White;
            this.l_Dispo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_Dispo.Location = new System.Drawing.Point(83, 352);
            this.l_Dispo.Name = "l_Dispo";
            this.l_Dispo.Size = new System.Drawing.Size(56, 21);
            this.l_Dispo.TabIndex = 52;
            this.l_Dispo.Text = "ON";
            this.l_Dispo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // l_Titre_NS
            // 
            this.l_Titre_NS.AutoSize = true;
            this.l_Titre_NS.BackColor = System.Drawing.Color.Transparent;
            this.l_Titre_NS.ForeColor = System.Drawing.Color.White;
            this.l_Titre_NS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_Titre_NS.Location = new System.Drawing.Point(263, 95);
            this.l_Titre_NS.Name = "l_Titre_NS";
            this.l_Titre_NS.Size = new System.Drawing.Size(128, 20);
            this.l_Titre_NS.TabIndex = 53;
            this.l_Titre_NS.Text = "Numéro de Série";
            // 
            // p_NS
            // 
            this.p_NS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_NS.Controls.Add(this.l_NS);
            this.p_NS.Location = new System.Drawing.Point(270, 119);
            this.p_NS.Name = "p_NS";
            this.p_NS.Size = new System.Drawing.Size(121, 54);
            this.p_NS.TabIndex = 49;
            // 
            // l_NS
            // 
            this.l_NS.ForeColor = System.Drawing.Color.White;
            this.l_NS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_NS.Location = new System.Drawing.Point(0, 17);
            this.l_NS.Name = "l_NS";
            this.l_NS.Size = new System.Drawing.Size(120, 21);
            this.l_NS.TabIndex = 42;
            this.l_NS.Text = "AfficheNS";
            this.l_NS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // p_Description
            // 
            this.p_Description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_Description.Controls.Add(this.l_Description);
            this.p_Description.Location = new System.Drawing.Point(483, 119);
            this.p_Description.Name = "p_Description";
            this.p_Description.Size = new System.Drawing.Size(305, 87);
            this.p_Description.TabIndex = 50;
            // 
            // l_Description
            // 
            this.l_Description.ForeColor = System.Drawing.Color.White;
            this.l_Description.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_Description.Location = new System.Drawing.Point(0, 17);
            this.l_Description.Name = "l_Description";
            this.l_Description.Size = new System.Drawing.Size(304, 54);
            this.l_Description.TabIndex = 42;
            this.l_Description.Text = "AfficheDescription";
            this.l_Description.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // l_Titre_Description
            // 
            this.l_Titre_Description.AutoSize = true;
            this.l_Titre_Description.BackColor = System.Drawing.Color.Transparent;
            this.l_Titre_Description.ForeColor = System.Drawing.Color.White;
            this.l_Titre_Description.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_Titre_Description.Location = new System.Drawing.Point(593, 95);
            this.l_Titre_Description.Name = "l_Titre_Description";
            this.l_Titre_Description.Size = new System.Drawing.Size(89, 20);
            this.l_Titre_Description.TabIndex = 54;
            this.l_Titre_Description.Text = "Description";
            // 
            // l_Titre_Type
            // 
            this.l_Titre_Type.AutoSize = true;
            this.l_Titre_Type.BackColor = System.Drawing.Color.Transparent;
            this.l_Titre_Type.ForeColor = System.Drawing.Color.White;
            this.l_Titre_Type.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_Titre_Type.Location = new System.Drawing.Point(271, 260);
            this.l_Titre_Type.Name = "l_Titre_Type";
            this.l_Titre_Type.Size = new System.Drawing.Size(112, 20);
            this.l_Titre_Type.TabIndex = 55;
            this.l_Titre_Type.Text = "Type de Borne";
            // 
            // l_Titre_Puissance
            // 
            this.l_Titre_Puissance.AutoSize = true;
            this.l_Titre_Puissance.BackColor = System.Drawing.Color.Transparent;
            this.l_Titre_Puissance.ForeColor = System.Drawing.Color.White;
            this.l_Titre_Puissance.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_Titre_Puissance.Location = new System.Drawing.Point(468, 260);
            this.l_Titre_Puissance.Name = "l_Titre_Puissance";
            this.l_Titre_Puissance.Size = new System.Drawing.Size(82, 20);
            this.l_Titre_Puissance.TabIndex = 56;
            this.l_Titre_Puissance.Text = "Puissance";
            // 
            // p_Type
            // 
            this.p_Type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_Type.Controls.Add(this.l_Type);
            this.p_Type.Location = new System.Drawing.Point(270, 285);
            this.p_Type.Name = "p_Type";
            this.p_Type.Size = new System.Drawing.Size(121, 54);
            this.p_Type.TabIndex = 50;
            // 
            // l_Type
            // 
            this.l_Type.ForeColor = System.Drawing.Color.White;
            this.l_Type.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_Type.Location = new System.Drawing.Point(0, 17);
            this.l_Type.Name = "l_Type";
            this.l_Type.Size = new System.Drawing.Size(120, 21);
            this.l_Type.TabIndex = 42;
            this.l_Type.Text = "AfficheType";
            this.l_Type.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // p_Puissance
            // 
            this.p_Puissance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_Puissance.Controls.Add(this.l_Puissance);
            this.p_Puissance.Location = new System.Drawing.Point(450, 285);
            this.p_Puissance.Name = "p_Puissance";
            this.p_Puissance.Size = new System.Drawing.Size(121, 54);
            this.p_Puissance.TabIndex = 51;
            // 
            // l_Puissance
            // 
            this.l_Puissance.ForeColor = System.Drawing.Color.White;
            this.l_Puissance.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_Puissance.Location = new System.Drawing.Point(0, 17);
            this.l_Puissance.Name = "l_Puissance";
            this.l_Puissance.Size = new System.Drawing.Size(120, 21);
            this.l_Puissance.TabIndex = 42;
            this.l_Puissance.Text = "AffichePuiss";
            this.l_Puissance.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // l_Titre_Site
            // 
            this.l_Titre_Site.AutoSize = true;
            this.l_Titre_Site.BackColor = System.Drawing.Color.Transparent;
            this.l_Titre_Site.ForeColor = System.Drawing.Color.White;
            this.l_Titre_Site.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_Titre_Site.Location = new System.Drawing.Point(672, 260);
            this.l_Titre_Site.Name = "l_Titre_Site";
            this.l_Titre_Site.Size = new System.Drawing.Size(37, 20);
            this.l_Titre_Site.TabIndex = 57;
            this.l_Titre_Site.Text = "Site";
            // 
            // p_Site
            // 
            this.p_Site.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_Site.Controls.Add(this.l_Site);
            this.p_Site.Location = new System.Drawing.Point(633, 285);
            this.p_Site.Name = "p_Site";
            this.p_Site.Size = new System.Drawing.Size(121, 54);
            this.p_Site.TabIndex = 52;
            // 
            // l_Site
            // 
            this.l_Site.ForeColor = System.Drawing.Color.White;
            this.l_Site.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_Site.Location = new System.Drawing.Point(0, 17);
            this.l_Site.Name = "l_Site";
            this.l_Site.Size = new System.Drawing.Size(120, 21);
            this.l_Site.TabIndex = 42;
            this.l_Site.Text = "AfficheSite";
            this.l_Site.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // p_Priorite
            // 
            this.p_Priorite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_Priorite.Controls.Add(this.l_Priorite);
            this.p_Priorite.Location = new System.Drawing.Point(270, 384);
            this.p_Priorite.Name = "p_Priorite";
            this.p_Priorite.Size = new System.Drawing.Size(121, 54);
            this.p_Priorite.TabIndex = 59;
            // 
            // l_Priorite
            // 
            this.l_Priorite.ForeColor = System.Drawing.Color.White;
            this.l_Priorite.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_Priorite.Location = new System.Drawing.Point(0, 17);
            this.l_Priorite.Name = "l_Priorite";
            this.l_Priorite.Size = new System.Drawing.Size(120, 21);
            this.l_Priorite.TabIndex = 42;
            this.l_Priorite.Text = "AffichePrio";
            this.l_Priorite.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // l_Titre_Priorite
            // 
            this.l_Titre_Priorite.AutoSize = true;
            this.l_Titre_Priorite.BackColor = System.Drawing.Color.Transparent;
            this.l_Titre_Priorite.ForeColor = System.Drawing.Color.White;
            this.l_Titre_Priorite.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_Titre_Priorite.Location = new System.Drawing.Point(302, 361);
            this.l_Titre_Priorite.Name = "l_Titre_Priorite";
            this.l_Titre_Priorite.Size = new System.Drawing.Size(58, 20);
            this.l_Titre_Priorite.TabIndex = 60;
            this.l_Titre_Priorite.Text = "Priorité";
            // 
            // p_Client
            // 
            this.p_Client.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_Client.Controls.Add(this.l_Client);
            this.p_Client.Location = new System.Drawing.Point(597, 384);
            this.p_Client.Name = "p_Client";
            this.p_Client.Size = new System.Drawing.Size(157, 54);
            this.p_Client.TabIndex = 60;
            // 
            // l_Client
            // 
            this.l_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Client.ForeColor = System.Drawing.Color.White;
            this.l_Client.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_Client.Location = new System.Drawing.Point(0, 17);
            this.l_Client.Name = "l_Client";
            this.l_Client.Size = new System.Drawing.Size(156, 21);
            this.l_Client.TabIndex = 42;
            this.l_Client.Text = "AfficheClient";
            this.l_Client.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // l_Titre_Client
            // 
            this.l_Titre_Client.AutoSize = true;
            this.l_Titre_Client.BackColor = System.Drawing.Color.Transparent;
            this.l_Titre_Client.ForeColor = System.Drawing.Color.White;
            this.l_Titre_Client.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_Titre_Client.Location = new System.Drawing.Point(651, 361);
            this.l_Titre_Client.Name = "l_Titre_Client";
            this.l_Titre_Client.Size = new System.Drawing.Size(49, 20);
            this.l_Titre_Client.TabIndex = 61;
            this.l_Titre_Client.Text = "Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Chargéon";
            // 
            // Bornes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.l_Titre_Client);
            this.Controls.Add(this.p_Client);
            this.Controls.Add(this.l_Titre_Priorite);
            this.Controls.Add(this.p_Priorite);
            this.Controls.Add(this.p_Site);
            this.Controls.Add(this.l_Titre_Site);
            this.Controls.Add(this.p_Puissance);
            this.Controls.Add(this.p_Type);
            this.Controls.Add(this.l_Titre_Puissance);
            this.Controls.Add(this.l_Titre_Type);
            this.Controls.Add(this.l_Titre_Description);
            this.Controls.Add(this.p_Description);
            this.Controls.Add(this.p_NS);
            this.Controls.Add(this.l_Titre_NS);
            this.Controls.Add(this.l_Dispo);
            this.Controls.Add(this.l_Titre_Dispo);
            this.Controls.Add(this.p_Dispo);
            this.Controls.Add(this.p_Separator);
            this.Controls.Add(this.p_ID);
            this.Controls.Add(this.l_Titre_ID);
            this.Controls.Add(this.cb_Borne);
            this.Controls.Add(this.l_Titre_Borne);
            this.Controls.Add(this.p_Titre_Chargeon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bornes";
            this.Text = "Template - Bornes";
            this.p_Titre_Chargeon.ResumeLayout(false);
            this.p_Titre_Chargeon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Return)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Close)).EndInit();
            this.p_ID.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.p_Dispo)).EndInit();
            this.p_NS.ResumeLayout(false);
            this.p_Description.ResumeLayout(false);
            this.p_Type.ResumeLayout(false);
            this.p_Puissance.ResumeLayout(false);
            this.p_Site.ResumeLayout(false);
            this.p_Priorite.ResumeLayout(false);
            this.p_Client.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel p_Titre_Chargeon;
        private System.Windows.Forms.PictureBox img_Return;
        private System.Windows.Forms.PictureBox img_Close;
        private System.Windows.Forms.Label l_Titre_Borne;
        private System.Windows.Forms.ComboBox cb_Borne;
        private System.Windows.Forms.Label l_Titre_ID;
        private System.Windows.Forms.Panel p_ID;
        private System.Windows.Forms.Label l_ID;
        private System.Windows.Forms.Panel p_Separator;
        private System.Windows.Forms.PictureBox p_Dispo;
        private System.Windows.Forms.Label l_Titre_Dispo;
        private System.Windows.Forms.Label l_Dispo;
        private System.Windows.Forms.Label l_Titre_NS;
        private System.Windows.Forms.Panel p_NS;
        private System.Windows.Forms.Label l_NS;
        private System.Windows.Forms.Panel p_Description;
        private System.Windows.Forms.Label l_Description;
        private System.Windows.Forms.Label l_Titre_Description;
        private System.Windows.Forms.Label l_Titre_Type;
        private System.Windows.Forms.Label l_Titre_Puissance;
        private System.Windows.Forms.Panel p_Type;
        private System.Windows.Forms.Label l_Type;
        private System.Windows.Forms.Panel p_Puissance;
        private System.Windows.Forms.Label l_Puissance;
        private System.Windows.Forms.Label l_Titre_Site;
        private System.Windows.Forms.Panel p_Site;
        private System.Windows.Forms.Label l_Site;
        private System.Windows.Forms.Panel p_Priorite;
        private System.Windows.Forms.Label l_Priorite;
        private System.Windows.Forms.Label l_Titre_Priorite;
        private System.Windows.Forms.Panel p_Client;
        private System.Windows.Forms.Label l_Client;
        private System.Windows.Forms.Label l_Titre_Client;
        private System.Windows.Forms.Label label2;
    }
}