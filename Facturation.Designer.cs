namespace ProjetChargeon
{
    partial class Facturation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturation));
            this.p_titre = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_facture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titre_facture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montant_facture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDeb_facture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFin_facture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_fac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_titre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.p_titre.TabIndex = 4;
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
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_facture,
            this.titre_facture,
            this.montant_facture,
            this.dateDeb_facture,
            this.dateFin_facture,
            this.type_fac});
            this.dataGridView1.Location = new System.Drawing.Point(12, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 359);
            this.dataGridView1.TabIndex = 5;
            // 
            // Id_facture
            // 
            this.Id_facture.HeaderText = "Id ";
            this.Id_facture.Name = "Id_facture";
            this.Id_facture.Width = 80;
            // 
            // titre_facture
            // 
            this.titre_facture.HeaderText = "Facture";
            this.titre_facture.Name = "titre_facture";
            this.titre_facture.Width = 150;
            // 
            // montant_facture
            // 
            this.montant_facture.HeaderText = "Montant";
            this.montant_facture.Name = "montant_facture";
            this.montant_facture.Width = 150;
            // 
            // dateDeb_facture
            // 
            this.dateDeb_facture.HeaderText = "Date début";
            this.dateDeb_facture.Name = "dateDeb_facture";
            // 
            // dateFin_facture
            // 
            this.dateFin_facture.HeaderText = "Date fin";
            this.dateFin_facture.Name = "dateFin_facture";
            // 
            // type_fac
            // 
            this.type_fac.HeaderText = "Type";
            this.type_fac.Name = "type_fac";
            this.type_fac.Width = 150;
            // 
            // Facturation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.p_titre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Facturation";
            this.Text = "facturation";
            this.p_titre.ResumeLayout(false);
            this.p_titre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_titre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_facture;
        private System.Windows.Forms.DataGridViewTextBoxColumn titre_facture;
        private System.Windows.Forms.DataGridViewTextBoxColumn montant_facture;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDeb_facture;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFin_facture;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_fac;
    }
}