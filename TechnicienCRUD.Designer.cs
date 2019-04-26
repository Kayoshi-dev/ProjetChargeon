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
            this.p_Ajout_Technicien = new System.Windows.Forms.Panel();
            this.l_Titre_Nom_Ajout = new System.Windows.Forms.Label();
            this.l_Titre_Prenom_Ajout = new System.Windows.Forms.Label();
            this.l_Titre_Dispo_Ajout = new System.Windows.Forms.Label();
            this.btn_Ajout = new System.Windows.Forms.Button();
            this.tb_Nom_Ajout = new System.Windows.Forms.TextBox();
            this.tb_Prenom_Ajout = new System.Windows.Forms.TextBox();
            this.cb_Dispo_Ajout = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.p_Titre_Chargeon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Return)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Close)).BeginInit();
            this.p_Ajout_Technicien.SuspendLayout();
            this.panel1.SuspendLayout();
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
            // p_Ajout_Technicien
            // 
            this.p_Ajout_Technicien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_Ajout_Technicien.Controls.Add(this.tb_Prenom_Ajout);
            this.p_Ajout_Technicien.Controls.Add(this.cb_Dispo_Ajout);
            this.p_Ajout_Technicien.Controls.Add(this.l_Titre_Nom_Ajout);
            this.p_Ajout_Technicien.Controls.Add(this.tb_Nom_Ajout);
            this.p_Ajout_Technicien.Controls.Add(this.btn_Ajout);
            this.p_Ajout_Technicien.Controls.Add(this.l_Titre_Prenom_Ajout);
            this.p_Ajout_Technicien.Controls.Add(this.l_Titre_Dispo_Ajout);
            resources.ApplyResources(this.p_Ajout_Technicien, "p_Ajout_Technicien");
            this.p_Ajout_Technicien.Name = "p_Ajout_Technicien";
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // TechnicienCRUD
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.p_Ajout_Technicien);
            this.Controls.Add(this.l_Titre_Ajout);
            this.Controls.Add(this.p_Titre_Chargeon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "TechnicienCRUD";
            this.p_Titre_Chargeon.ResumeLayout(false);
            this.p_Titre_Chargeon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Return)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Close)).EndInit();
            this.p_Ajout_Technicien.ResumeLayout(false);
            this.p_Ajout_Technicien.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel p_Titre_Chargeon;
        private System.Windows.Forms.PictureBox img_Return;
        private System.Windows.Forms.PictureBox img_Close;
        private System.Windows.Forms.Label l_Titre_Chargeon;
        private System.Windows.Forms.Label l_Titre_Ajout;
        private System.Windows.Forms.Panel p_Ajout_Technicien;
        private System.Windows.Forms.Label l_Titre_Nom_Ajout;
        private System.Windows.Forms.Label l_Titre_Prenom_Ajout;
        private System.Windows.Forms.Label l_Titre_Dispo_Ajout;
        private System.Windows.Forms.Button btn_Ajout;
        private System.Windows.Forms.TextBox tb_Nom_Ajout;
        private System.Windows.Forms.TextBox tb_Prenom_Ajout;
        private System.Windows.Forms.ComboBox cb_Dispo_Ajout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}