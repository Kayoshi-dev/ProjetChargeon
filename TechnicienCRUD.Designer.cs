namespace ProjetChargeon
{
    partial class TechnicienCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TechnicienCRUD));
            this.p_Titre_Chargeon = new System.Windows.Forms.Panel();
            this.img_Return = new System.Windows.Forms.PictureBox();
            this.img_Close = new System.Windows.Forms.PictureBox();
            this.l_Titre_Chargeon = new System.Windows.Forms.Label();
            this.l_Titre_Ajout = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.p_Separator_1 = new System.Windows.Forms.Panel();
            this.p_Separator_2 = new System.Windows.Forms.Panel();
            this.cb_Nom_Modif = new System.Windows.Forms.ComboBox();
            this.l_Titre_Nom_Modif = new System.Windows.Forms.Label();
            this.l_Titre_Prenom_Modif = new System.Windows.Forms.Label();
            this.l_Titre_Dispo_Modif = new System.Windows.Forms.Label();
            this.tb_Prenom = new System.Windows.Forms.TextBox();
            this.btn_Modifier = new System.Windows.Forms.Button();
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.l_Titre_Nom_Supprimer = new System.Windows.Forms.Label();
            this.cb_Nom_Supprimer = new System.Windows.Forms.ComboBox();
            this.cb_Dispo_Modif = new System.Windows.Forms.ComboBox();
            this.l_Titre_Nom_Ajout = new System.Windows.Forms.Label();
            this.l_Titre_Prenom_Ajout = new System.Windows.Forms.Label();
            this.l_Titre_Dispo_Ajout = new System.Windows.Forms.Label();
            this.btn_Ajout = new System.Windows.Forms.Button();
            this.tb_Nom_Ajout = new System.Windows.Forms.TextBox();
            this.tb_Prenom_Ajout = new System.Windows.Forms.TextBox();
            this.cb_Dispo_Ajout = new System.Windows.Forms.ComboBox();
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
            // l_Titre_Ajout
            // 
            resources.ApplyResources(this.l_Titre_Ajout, "l_Titre_Ajout");
            this.l_Titre_Ajout.ForeColor = System.Drawing.Color.White;
            this.l_Titre_Ajout.Name = "l_Titre_Ajout";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // p_Separator_1
            // 
            this.p_Separator_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.p_Separator_1, "p_Separator_1");
            this.p_Separator_1.Name = "p_Separator_1";
            // 
            // p_Separator_2
            // 
            this.p_Separator_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.p_Separator_2, "p_Separator_2");
            this.p_Separator_2.Name = "p_Separator_2";
            // 
            // cb_Nom_Modif
            // 
            this.cb_Nom_Modif.FormattingEnabled = true;
            resources.ApplyResources(this.cb_Nom_Modif, "cb_Nom_Modif");
            this.cb_Nom_Modif.Name = "cb_Nom_Modif";
            // 
            // l_Titre_Nom_Modif
            // 
            resources.ApplyResources(this.l_Titre_Nom_Modif, "l_Titre_Nom_Modif");
            this.l_Titre_Nom_Modif.ForeColor = System.Drawing.Color.White;
            this.l_Titre_Nom_Modif.Name = "l_Titre_Nom_Modif";
            // 
            // l_Titre_Prenom_Modif
            // 
            resources.ApplyResources(this.l_Titre_Prenom_Modif, "l_Titre_Prenom_Modif");
            this.l_Titre_Prenom_Modif.ForeColor = System.Drawing.Color.White;
            this.l_Titre_Prenom_Modif.Name = "l_Titre_Prenom_Modif";
            // 
            // l_Titre_Dispo_Modif
            // 
            resources.ApplyResources(this.l_Titre_Dispo_Modif, "l_Titre_Dispo_Modif");
            this.l_Titre_Dispo_Modif.ForeColor = System.Drawing.Color.White;
            this.l_Titre_Dispo_Modif.Name = "l_Titre_Dispo_Modif";
            // 
            // tb_Prenom
            // 
            resources.ApplyResources(this.tb_Prenom, "tb_Prenom");
            this.tb_Prenom.Name = "tb_Prenom";
            // 
            // btn_Modifier
            // 
            resources.ApplyResources(this.btn_Modifier, "btn_Modifier");
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.UseVisualStyleBackColor = true;
            // 
            // btn_Supprimer
            // 
            resources.ApplyResources(this.btn_Supprimer, "btn_Supprimer");
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            // 
            // l_Titre_Nom_Supprimer
            // 
            resources.ApplyResources(this.l_Titre_Nom_Supprimer, "l_Titre_Nom_Supprimer");
            this.l_Titre_Nom_Supprimer.ForeColor = System.Drawing.Color.White;
            this.l_Titre_Nom_Supprimer.Name = "l_Titre_Nom_Supprimer";
            // 
            // cb_Nom_Supprimer
            // 
            this.cb_Nom_Supprimer.FormattingEnabled = true;
            resources.ApplyResources(this.cb_Nom_Supprimer, "cb_Nom_Supprimer");
            this.cb_Nom_Supprimer.Name = "cb_Nom_Supprimer";
            // 
            // cb_Dispo_Modif
            // 
            this.cb_Dispo_Modif.FormattingEnabled = true;
            resources.ApplyResources(this.cb_Dispo_Modif, "cb_Dispo_Modif");
            this.cb_Dispo_Modif.Name = "cb_Dispo_Modif";
            // 
            // l_Titre_Nom_Ajout
            // 
            resources.ApplyResources(this.l_Titre_Nom_Ajout, "l_Titre_Nom_Ajout");
            this.l_Titre_Nom_Ajout.ForeColor = System.Drawing.Color.White;
            this.l_Titre_Nom_Ajout.Name = "l_Titre_Nom_Ajout";
            // 
            // l_Titre_Prenom_Ajout
            // 
            resources.ApplyResources(this.l_Titre_Prenom_Ajout, "l_Titre_Prenom_Ajout");
            this.l_Titre_Prenom_Ajout.ForeColor = System.Drawing.Color.White;
            this.l_Titre_Prenom_Ajout.Name = "l_Titre_Prenom_Ajout";
            // 
            // l_Titre_Dispo_Ajout
            // 
            resources.ApplyResources(this.l_Titre_Dispo_Ajout, "l_Titre_Dispo_Ajout");
            this.l_Titre_Dispo_Ajout.ForeColor = System.Drawing.Color.White;
            this.l_Titre_Dispo_Ajout.Name = "l_Titre_Dispo_Ajout";
            // 
            // btn_Ajout
            // 
            resources.ApplyResources(this.btn_Ajout, "btn_Ajout");
            this.btn_Ajout.Name = "btn_Ajout";
            this.btn_Ajout.UseVisualStyleBackColor = true;
            // 
            // tb_Nom_Ajout
            // 
            resources.ApplyResources(this.tb_Nom_Ajout, "tb_Nom_Ajout");
            this.tb_Nom_Ajout.Name = "tb_Nom_Ajout";
            // 
            // tb_Prenom_Ajout
            // 
            resources.ApplyResources(this.tb_Prenom_Ajout, "tb_Prenom_Ajout");
            this.tb_Prenom_Ajout.Name = "tb_Prenom_Ajout";
            // 
            // cb_Dispo_Ajout
            // 
            this.cb_Dispo_Ajout.FormattingEnabled = true;
            resources.ApplyResources(this.cb_Dispo_Ajout, "cb_Dispo_Ajout");
            this.cb_Dispo_Ajout.Name = "cb_Dispo_Ajout";
            // 
            // TechnicienCRUD
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.cb_Dispo_Ajout);
            this.Controls.Add(this.tb_Prenom_Ajout);
            this.Controls.Add(this.tb_Nom_Ajout);
            this.Controls.Add(this.btn_Ajout);
            this.Controls.Add(this.l_Titre_Dispo_Ajout);
            this.Controls.Add(this.l_Titre_Prenom_Ajout);
            this.Controls.Add(this.l_Titre_Nom_Ajout);
            this.Controls.Add(this.cb_Dispo_Modif);
            this.Controls.Add(this.cb_Nom_Supprimer);
            this.Controls.Add(this.l_Titre_Nom_Supprimer);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_Modifier);
            this.Controls.Add(this.tb_Prenom);
            this.Controls.Add(this.l_Titre_Dispo_Modif);
            this.Controls.Add(this.l_Titre_Prenom_Modif);
            this.Controls.Add(this.l_Titre_Nom_Modif);
            this.Controls.Add(this.cb_Nom_Modif);
            this.Controls.Add(this.p_Separator_2);
            this.Controls.Add(this.p_Separator_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l_Titre_Ajout);
            this.Controls.Add(this.p_Titre_Chargeon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "TechnicienCRUD";
            this.p_Titre_Chargeon.ResumeLayout(false);
            this.p_Titre_Chargeon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Return)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel p_Titre_Chargeon;
        private System.Windows.Forms.PictureBox img_Return;
        private System.Windows.Forms.PictureBox img_Close;
        private System.Windows.Forms.Label l_Titre_Chargeon;
        private System.Windows.Forms.Label l_Titre_Ajout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel p_Separator_1;
        private System.Windows.Forms.Panel p_Separator_2;
        private System.Windows.Forms.ComboBox cb_Nom_Modif;
        private System.Windows.Forms.Label l_Titre_Nom_Modif;
        private System.Windows.Forms.Label l_Titre_Prenom_Modif;
        private System.Windows.Forms.Label l_Titre_Dispo_Modif;
        private System.Windows.Forms.TextBox tb_Prenom;
        private System.Windows.Forms.Button btn_Modifier;
        private System.Windows.Forms.Button btn_Supprimer;
        private System.Windows.Forms.Label l_Titre_Nom_Supprimer;
        private System.Windows.Forms.ComboBox cb_Nom_Supprimer;
        private System.Windows.Forms.ComboBox cb_Dispo_Modif;
        private System.Windows.Forms.Label l_Titre_Nom_Ajout;
        private System.Windows.Forms.Label l_Titre_Prenom_Ajout;
        private System.Windows.Forms.Label l_Titre_Dispo_Ajout;
        private System.Windows.Forms.Button btn_Ajout;
        private System.Windows.Forms.TextBox tb_Nom_Ajout;
        private System.Windows.Forms.TextBox tb_Prenom_Ajout;
        private System.Windows.Forms.ComboBox cb_Dispo_Ajout;
    }
}