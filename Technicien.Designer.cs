namespace ProjetChargeon
{
    partial class Technicien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Technicien));
            this.p_Titre_Chargeon = new System.Windows.Forms.Panel();
            this.img_Return = new System.Windows.Forms.PictureBox();
            this.img_Close = new System.Windows.Forms.PictureBox();
            this.l_Titre_Chargeon = new System.Windows.Forms.Label();
            this.l_title_Puis = new System.Windows.Forms.Label();
            this.l_Nom = new System.Windows.Forms.Label();
            this.l_Titre_Nom = new System.Windows.Forms.Label();
            this.l_Titre_ID = new System.Windows.Forms.Label();
            this.p_Separator = new System.Windows.Forms.Panel();
            this.l_Dispo = new System.Windows.Forms.Label();
            this.l_Titre_Dispo = new System.Windows.Forms.Label();
            this.p_Dispo = new System.Windows.Forms.PictureBox();
            this.l_Titre_Technicien = new System.Windows.Forms.Label();
            this.cb_Technicien = new System.Windows.Forms.ComboBox();
            this.p_Nom = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.l_Prenom = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.l_ID = new System.Windows.Forms.Label();
            this.p_Titre_Chargeon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Return)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_Dispo)).BeginInit();
            this.p_Nom.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            // l_title_Puis
            // 
            this.l_title_Puis.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.l_title_Puis, "l_title_Puis");
            this.l_title_Puis.Name = "l_title_Puis";
            // 
            // l_Nom
            // 
            this.l_Nom.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.l_Nom, "l_Nom");
            this.l_Nom.Name = "l_Nom";
            // 
            // l_Titre_Nom
            // 
            resources.ApplyResources(this.l_Titre_Nom, "l_Titre_Nom");
            this.l_Titre_Nom.ForeColor = System.Drawing.Color.White;
            this.l_Titre_Nom.Name = "l_Titre_Nom";
            // 
            // l_Titre_ID
            // 
            resources.ApplyResources(this.l_Titre_ID, "l_Titre_ID");
            this.l_Titre_ID.BackColor = System.Drawing.Color.Transparent;
            this.l_Titre_ID.ForeColor = System.Drawing.Color.White;
            this.l_Titre_ID.Name = "l_Titre_ID";
            // 
            // p_Separator
            // 
            this.p_Separator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.p_Separator, "p_Separator");
            this.p_Separator.Name = "p_Separator";
            // 
            // l_Dispo
            // 
            this.l_Dispo.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.l_Dispo, "l_Dispo");
            this.l_Dispo.Name = "l_Dispo";
            // 
            // l_Titre_Dispo
            // 
            resources.ApplyResources(this.l_Titre_Dispo, "l_Titre_Dispo");
            this.l_Titre_Dispo.BackColor = System.Drawing.Color.Transparent;
            this.l_Titre_Dispo.ForeColor = System.Drawing.Color.White;
            this.l_Titre_Dispo.Name = "l_Titre_Dispo";
            // 
            // p_Dispo
            // 
            this.p_Dispo.Image = global::ProjetChargeon.Properties.Resources.circle_green;
            resources.ApplyResources(this.p_Dispo, "p_Dispo");
            this.p_Dispo.Name = "p_Dispo";
            this.p_Dispo.TabStop = false;
            // 
            // l_Titre_Technicien
            // 
            resources.ApplyResources(this.l_Titre_Technicien, "l_Titre_Technicien");
            this.l_Titre_Technicien.ForeColor = System.Drawing.Color.White;
            this.l_Titre_Technicien.Name = "l_Titre_Technicien";
            // 
            // cb_Technicien
            // 
            this.cb_Technicien.BackColor = System.Drawing.Color.White;
            this.cb_Technicien.ForeColor = System.Drawing.Color.Black;
            this.cb_Technicien.FormattingEnabled = true;
            resources.ApplyResources(this.cb_Technicien, "cb_Technicien");
            this.cb_Technicien.Name = "cb_Technicien";
            this.cb_Technicien.SelectedIndexChanged += new System.EventHandler(this.cb_Technicien_SelectedIndexChanged);
            // 
            // p_Nom
            // 
            this.p_Nom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_Nom.Controls.Add(this.l_Nom);
            resources.ApplyResources(this.p_Nom, "p_Nom");
            this.p_Nom.Name = "p_Nom";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.l_Prenom);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // l_Prenom
            // 
            this.l_Prenom.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.l_Prenom, "l_Prenom");
            this.l_Prenom.Name = "l_Prenom";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.l_ID);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // l_ID
            // 
            this.l_ID.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.l_ID, "l_ID");
            this.l_ID.Name = "l_ID";
            // 
            // Technicien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.p_Nom);
            this.Controls.Add(this.l_title_Puis);
            this.Controls.Add(this.l_Titre_Nom);
            this.Controls.Add(this.l_Titre_ID);
            this.Controls.Add(this.p_Separator);
            this.Controls.Add(this.l_Dispo);
            this.Controls.Add(this.l_Titre_Dispo);
            this.Controls.Add(this.p_Dispo);
            this.Controls.Add(this.l_Titre_Technicien);
            this.Controls.Add(this.cb_Technicien);
            this.Controls.Add(this.p_Titre_Chargeon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Technicien";
            this.p_Titre_Chargeon.ResumeLayout(false);
            this.p_Titre_Chargeon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Return)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_Dispo)).EndInit();
            this.p_Nom.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel p_Titre_Chargeon;
        private System.Windows.Forms.PictureBox img_Return;
        private System.Windows.Forms.PictureBox img_Close;
        private System.Windows.Forms.Label l_Titre_Chargeon;
        private System.Windows.Forms.Label l_title_Puis;
        private System.Windows.Forms.Label l_Nom;
        private System.Windows.Forms.Label l_Titre_Nom;
        private System.Windows.Forms.Label l_Titre_ID;
        private System.Windows.Forms.Panel p_Separator;
        private System.Windows.Forms.Label l_Dispo;
        private System.Windows.Forms.Label l_Titre_Dispo;
        private System.Windows.Forms.PictureBox p_Dispo;
        private System.Windows.Forms.Label l_Titre_Technicien;
        private System.Windows.Forms.ComboBox cb_Technicien;
        private System.Windows.Forms.Panel p_Nom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label l_Prenom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label l_ID;
    }
}