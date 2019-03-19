namespace ProjetChargeon
{
    partial class Crud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crud));
            this.p_titre = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSites = new System.Windows.Forms.TabPage();
            this.tabBornes = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.bAjouterSites = new System.Windows.Forms.Button();
            this.bModifierSites = new System.Windows.Forms.Button();
            this.bSupprimerSites = new System.Windows.Forms.Button();
            this.bAjouterBornes = new System.Windows.Forms.Button();
            this.bModifierBornes = new System.Windows.Forms.Button();
            this.bSupprimerBornes = new System.Windows.Forms.Button();
            this.id_site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse_site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cp_site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ville_site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_borne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ref_borne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no_borne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puissance_borne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_borne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorite_borne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etat_borne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.p_titre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabSites.SuspendLayout();
            this.tabBornes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // p_titre
            // 
            this.p_titre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.p_titre.Controls.Add(this.pictureBox1);
            this.p_titre.Controls.Add(this.label1);
            this.p_titre.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_titre.Location = new System.Drawing.Point(0, 0);
            this.p_titre.Name = "p_titre";
            this.p_titre.Size = new System.Drawing.Size(800, 73);
            this.p_titre.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(758, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chargéon";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSites);
            this.tabControl1.Controls.Add(this.tabBornes);
            this.tabControl1.Location = new System.Drawing.Point(12, 79);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 346);
            this.tabControl1.TabIndex = 9;
            // 
            // tabSites
            // 
            this.tabSites.BackColor = System.Drawing.Color.White;
            this.tabSites.Controls.Add(this.bSupprimerSites);
            this.tabSites.Controls.Add(this.bModifierSites);
            this.tabSites.Controls.Add(this.bAjouterSites);
            this.tabSites.Controls.Add(this.label5);
            this.tabSites.Controls.Add(this.textBox4);
            this.tabSites.Controls.Add(this.label4);
            this.tabSites.Controls.Add(this.textBox3);
            this.tabSites.Controls.Add(this.textBox2);
            this.tabSites.Controls.Add(this.label3);
            this.tabSites.Controls.Add(this.textBox1);
            this.tabSites.Controls.Add(this.label2);
            this.tabSites.Controls.Add(this.dataGridView1);
            this.tabSites.Location = new System.Drawing.Point(4, 22);
            this.tabSites.Name = "tabSites";
            this.tabSites.Padding = new System.Windows.Forms.Padding(3);
            this.tabSites.Size = new System.Drawing.Size(768, 320);
            this.tabSites.TabIndex = 0;
            this.tabSites.Text = "Sites";
            // 
            // tabBornes
            // 
            this.tabBornes.Controls.Add(this.bSupprimerBornes);
            this.tabBornes.Controls.Add(this.bModifierBornes);
            this.tabBornes.Controls.Add(this.bAjouterBornes);
            this.tabBornes.Controls.Add(this.label11);
            this.tabBornes.Controls.Add(this.label10);
            this.tabBornes.Controls.Add(this.textBox10);
            this.tabBornes.Controls.Add(this.textBox9);
            this.tabBornes.Controls.Add(this.textBox7);
            this.tabBornes.Controls.Add(this.textBox6);
            this.tabBornes.Controls.Add(this.textBox5);
            this.tabBornes.Controls.Add(this.label6);
            this.tabBornes.Controls.Add(this.label7);
            this.tabBornes.Controls.Add(this.label8);
            this.tabBornes.Controls.Add(this.textBox8);
            this.tabBornes.Controls.Add(this.label9);
            this.tabBornes.Controls.Add(this.dataGridView2);
            this.tabBornes.Location = new System.Drawing.Point(4, 22);
            this.tabBornes.Name = "tabBornes";
            this.tabBornes.Padding = new System.Windows.Forms.Padding(3);
            this.tabBornes.Size = new System.Drawing.Size(768, 320);
            this.tabBornes.TabIndex = 1;
            this.tabBornes.Text = "Bornes";
            this.tabBornes.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_site,
            this.nom_site,
            this.adresse_site,
            this.cp_site,
            this.ville_site});
            this.dataGridView1.Location = new System.Drawing.Point(4, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(667, 250);
            this.dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 283);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Adresse";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(226, 283);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(345, 283);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Code postal";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(460, 283);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(501, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ville";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_borne,
            this.ref_borne,
            this.no_borne,
            this.puissance_borne,
            this.type_borne,
            this.priorite_borne,
            this.etat_borne});
            this.dataGridView2.Location = new System.Drawing.Point(7, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(664, 250);
            this.dataGridView2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Puissance";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(172, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "N° Série";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(53, 284);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(82, 20);
            this.textBox8.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Référence";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(373, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Type";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(151, 284);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(82, 20);
            this.textBox5.TabIndex = 17;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(249, 284);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(82, 20);
            this.textBox6.TabIndex = 18;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(346, 284);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(82, 20);
            this.textBox7.TabIndex = 19;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(442, 284);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(82, 20);
            this.textBox9.TabIndex = 20;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(539, 284);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(82, 20);
            this.textBox10.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(565, 268);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "État";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(466, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Priorité";
            // 
            // bAjouterSites
            // 
            this.bAjouterSites.Location = new System.Drawing.Point(677, 64);
            this.bAjouterSites.Name = "bAjouterSites";
            this.bAjouterSites.Size = new System.Drawing.Size(85, 32);
            this.bAjouterSites.TabIndex = 9;
            this.bAjouterSites.Text = "Ajouter";
            this.bAjouterSites.UseVisualStyleBackColor = true;
            // 
            // bModifierSites
            // 
            this.bModifierSites.Location = new System.Drawing.Point(677, 111);
            this.bModifierSites.Name = "bModifierSites";
            this.bModifierSites.Size = new System.Drawing.Size(85, 32);
            this.bModifierSites.TabIndex = 10;
            this.bModifierSites.Text = "Modifier";
            this.bModifierSites.UseVisualStyleBackColor = true;
            // 
            // bSupprimerSites
            // 
            this.bSupprimerSites.Location = new System.Drawing.Point(677, 158);
            this.bSupprimerSites.Name = "bSupprimerSites";
            this.bSupprimerSites.Size = new System.Drawing.Size(85, 32);
            this.bSupprimerSites.TabIndex = 11;
            this.bSupprimerSites.Text = "Supprimer";
            this.bSupprimerSites.UseVisualStyleBackColor = true;
            // 
            // bAjouterBornes
            // 
            this.bAjouterBornes.Location = new System.Drawing.Point(677, 68);
            this.bAjouterBornes.Name = "bAjouterBornes";
            this.bAjouterBornes.Size = new System.Drawing.Size(85, 32);
            this.bAjouterBornes.TabIndex = 24;
            this.bAjouterBornes.Text = "Ajouter";
            this.bAjouterBornes.UseVisualStyleBackColor = true;
            // 
            // bModifierBornes
            // 
            this.bModifierBornes.Location = new System.Drawing.Point(677, 115);
            this.bModifierBornes.Name = "bModifierBornes";
            this.bModifierBornes.Size = new System.Drawing.Size(85, 32);
            this.bModifierBornes.TabIndex = 25;
            this.bModifierBornes.Text = "Modifier";
            this.bModifierBornes.UseVisualStyleBackColor = true;
            // 
            // bSupprimerBornes
            // 
            this.bSupprimerBornes.Location = new System.Drawing.Point(677, 163);
            this.bSupprimerBornes.Name = "bSupprimerBornes";
            this.bSupprimerBornes.Size = new System.Drawing.Size(85, 32);
            this.bSupprimerBornes.TabIndex = 26;
            this.bSupprimerBornes.Text = "Supprimer";
            this.bSupprimerBornes.UseVisualStyleBackColor = true;
            // 
            // id_site
            // 
            this.id_site.HeaderText = "Id";
            this.id_site.Name = "id_site";
            // 
            // nom_site
            // 
            this.nom_site.HeaderText = "Nom ";
            this.nom_site.Name = "nom_site";
            // 
            // adresse_site
            // 
            this.adresse_site.HeaderText = "Adresse";
            this.adresse_site.Name = "adresse_site";
            // 
            // cp_site
            // 
            this.cp_site.HeaderText = "Code postal ";
            this.cp_site.Name = "cp_site";
            // 
            // ville_site
            // 
            this.ville_site.HeaderText = "Ville";
            this.ville_site.Name = "ville_site";
            // 
            // id_borne
            // 
            this.id_borne.HeaderText = "Id";
            this.id_borne.Name = "id_borne";
            this.id_borne.Width = 20;
            // 
            // ref_borne
            // 
            this.ref_borne.HeaderText = "Référence";
            this.ref_borne.Name = "ref_borne";
            // 
            // no_borne
            // 
            this.no_borne.HeaderText = "N° Série ";
            this.no_borne.Name = "no_borne";
            // 
            // puissance_borne
            // 
            this.puissance_borne.HeaderText = "Puissance ";
            this.puissance_borne.Name = "puissance_borne";
            // 
            // type_borne
            // 
            this.type_borne.HeaderText = "Type ";
            this.type_borne.Name = "type_borne";
            // 
            // priorite_borne
            // 
            this.priorite_borne.HeaderText = "Priorité ";
            this.priorite_borne.Name = "priorite_borne";
            // 
            // etat_borne
            // 
            this.etat_borne.HeaderText = "État";
            this.etat_borne.Name = "etat_borne";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label12.ForeColor = System.Drawing.SystemColors.Info;
            this.label12.Location = new System.Drawing.Point(360, 428);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 15);
            this.label12.TabIndex = 10;
            this.label12.Text = "Mentions légales";
            // 
            // Crud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.p_titre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Crud";
            this.Text = "Crud";
            this.p_titre.ResumeLayout(false);
            this.p_titre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabSites.ResumeLayout(false);
            this.tabSites.PerformLayout();
            this.tabBornes.ResumeLayout(false);
            this.tabBornes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel p_titre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSites;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabBornes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bSupprimerSites;
        private System.Windows.Forms.Button bModifierSites;
        private System.Windows.Forms.Button bAjouterSites;
        private System.Windows.Forms.Button bSupprimerBornes;
        private System.Windows.Forms.Button bModifierBornes;
        private System.Windows.Forms.Button bAjouterBornes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_site;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_site;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse_site;
        private System.Windows.Forms.DataGridViewTextBoxColumn cp_site;
        private System.Windows.Forms.DataGridViewTextBoxColumn ville_site;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_borne;
        private System.Windows.Forms.DataGridViewTextBoxColumn ref_borne;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_borne;
        private System.Windows.Forms.DataGridViewTextBoxColumn puissance_borne;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_borne;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorite_borne;
        private System.Windows.Forms.DataGridViewTextBoxColumn etat_borne;
        private System.Windows.Forms.Label label12;
    }
}