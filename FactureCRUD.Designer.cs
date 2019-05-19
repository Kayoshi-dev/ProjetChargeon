namespace ProjetChargeon
{
    partial class FactureCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FactureCRUD));
            this.l_Titre_Chargeon = new System.Windows.Forms.Label();
            this.p_form1 = new System.Windows.Forms.Panel();
            this.img_Return = new System.Windows.Forms.PictureBox();
            this.img_Close = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Titre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Montant = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Creer = new System.Windows.Forms.Button();
            this.cb_Client = new System.Windows.Forms.ComboBox();
            this.cb_Borne = new System.Windows.Forms.ComboBox();
            this.dtp_Debut = new System.Windows.Forms.DateTimePicker();
            this.dtp_Fin = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.l_statut = new System.Windows.Forms.Label();
            this.p_form1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Return)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Close)).BeginInit();
            this.SuspendLayout();
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
            this.p_form1.TabIndex = 14;
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(263, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Faire une nouvelle facture";
            // 
            // tb_Titre
            // 
            this.tb_Titre.Location = new System.Drawing.Point(12, 154);
            this.tb_Titre.MaxLength = 30;
            this.tb_Titre.Name = "tb_Titre";
            this.tb_Titre.Size = new System.Drawing.Size(182, 27);
            this.tb_Titre.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Titre de la facture";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Montant à regler";
            // 
            // tb_Montant
            // 
            this.tb_Montant.Location = new System.Drawing.Point(12, 247);
            this.tb_Montant.MaxLength = 5;
            this.tb_Montant.Name = "tb_Montant";
            this.tb_Montant.Size = new System.Drawing.Size(182, 27);
            this.tb_Montant.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(335, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Selection client";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(332, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Selection borne";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(598, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "Date début";
            // 
            // btn_Creer
            // 
            this.btn_Creer.Location = new System.Drawing.Point(358, 410);
            this.btn_Creer.Name = "btn_Creer";
            this.btn_Creer.Size = new System.Drawing.Size(75, 28);
            this.btn_Creer.TabIndex = 26;
            this.btn_Creer.Text = "Créer";
            this.btn_Creer.UseVisualStyleBackColor = true;
            this.btn_Creer.Click += new System.EventHandler(this.btn_CreateFacture);
            // 
            // cb_Client
            // 
            this.cb_Client.FormattingEnabled = true;
            this.cb_Client.Location = new System.Drawing.Point(306, 154);
            this.cb_Client.Name = "cb_Client";
            this.cb_Client.Size = new System.Drawing.Size(182, 29);
            this.cb_Client.TabIndex = 27;
            this.cb_Client.SelectedIndexChanged += new System.EventHandler(this.SelectedClientIndexChange);
            // 
            // cb_Borne
            // 
            this.cb_Borne.FormattingEnabled = true;
            this.cb_Borne.Location = new System.Drawing.Point(306, 247);
            this.cb_Borne.Name = "cb_Borne";
            this.cb_Borne.Size = new System.Drawing.Size(182, 29);
            this.cb_Borne.TabIndex = 28;
            // 
            // dtp_Debut
            // 
            this.dtp_Debut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtp_Debut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Debut.Location = new System.Drawing.Point(602, 156);
            this.dtp_Debut.Name = "dtp_Debut";
            this.dtp_Debut.Size = new System.Drawing.Size(182, 27);
            this.dtp_Debut.TabIndex = 29;
            // 
            // dtp_Fin
            // 
            this.dtp_Fin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtp_Fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Fin.Location = new System.Drawing.Point(602, 245);
            this.dtp_Fin.Name = "dtp_Fin";
            this.dtp_Fin.Size = new System.Drawing.Size(182, 27);
            this.dtp_Fin.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(598, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 21);
            this.label7.TabIndex = 31;
            this.label7.Text = "Date fin";
            // 
            // l_statut
            // 
            this.l_statut.AutoSize = true;
            this.l_statut.ForeColor = System.Drawing.Color.White;
            this.l_statut.Location = new System.Drawing.Point(450, 414);
            this.l_statut.Name = "l_statut";
            this.l_statut.Size = new System.Drawing.Size(0, 21);
            this.l_statut.TabIndex = 32;
            // 
            // FactureCRUD
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.l_statut);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtp_Fin);
            this.Controls.Add(this.dtp_Debut);
            this.Controls.Add(this.cb_Borne);
            this.Controls.Add(this.cb_Client);
            this.Controls.Add(this.btn_Creer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Montant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Titre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p_form1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FactureCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des factures";
            this.p_form1.ResumeLayout(false);
            this.p_form1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Return)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_Titre_Chargeon;
        private System.Windows.Forms.Panel p_form1;
        private System.Windows.Forms.PictureBox img_Return;
        private System.Windows.Forms.PictureBox img_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Titre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Montant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Creer;
        private System.Windows.Forms.ComboBox cb_Client;
        private System.Windows.Forms.ComboBox cb_Borne;
        private System.Windows.Forms.DateTimePicker dtp_Debut;
        private System.Windows.Forms.DateTimePicker dtp_Fin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label l_statut;
    }
}