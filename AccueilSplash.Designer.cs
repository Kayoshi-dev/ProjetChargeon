namespace ProjetChargeon
{
    partial class AccueilSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccueilSplash));
            this.p_titre = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_statut = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_localisation = new System.Windows.Forms.Button();
            this.p_titre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.p_titre.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(758, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.CloseProgram);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chargéon";
            // 
            // btn_connect
            // 
            this.btn_connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.btn_connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_connect.FlatAppearance.BorderSize = 0;
            this.btn_connect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_connect.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connect.ForeColor = System.Drawing.Color.White;
            this.btn_connect.Image = ((System.Drawing.Image)(resources.GetObject("btn_connect.Image")));
            this.btn_connect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_connect.Location = new System.Drawing.Point(146, 115);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(200, 200);
            this.btn_connect.TabIndex = 11;
            this.btn_connect.Text = "Connexion";
            this.btn_connect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_connect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_connect.UseVisualStyleBackColor = false;
            this.btn_connect.Click += new System.EventHandler(this.OpenLogin);
            // 
            // btn_statut
            // 
            this.btn_statut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.btn_statut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_statut.FlatAppearance.BorderSize = 0;
            this.btn_statut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_statut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_statut.ForeColor = System.Drawing.Color.White;
            this.btn_statut.Image = ((System.Drawing.Image)(resources.GetObject("btn_statut.Image")));
            this.btn_statut.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_statut.Location = new System.Drawing.Point(449, 115);
            this.btn_statut.Name = "btn_statut";
            this.btn_statut.Size = new System.Drawing.Size(200, 200);
            this.btn_statut.TabIndex = 13;
            this.btn_statut.Text = "Statut";
            this.btn_statut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_statut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_statut.UseVisualStyleBackColor = false;
            this.btn_statut.Click += new System.EventHandler(this.OpenStatut);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(331, 420);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(143, 21);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Mentions Légales";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // btn_localisation
            // 
            this.btn_localisation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.btn_localisation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_localisation.FlatAppearance.BorderSize = 0;
            this.btn_localisation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_localisation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_localisation.ForeColor = System.Drawing.Color.White;
            this.btn_localisation.Image = ((System.Drawing.Image)(resources.GetObject("btn_localisation.Image")));
            this.btn_localisation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_localisation.Location = new System.Drawing.Point(293, 326);
            this.btn_localisation.Name = "btn_localisation";
            this.btn_localisation.Size = new System.Drawing.Size(200, 78);
            this.btn_localisation.TabIndex = 14;
            this.btn_localisation.Text = "Carte";
            this.btn_localisation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_localisation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_localisation.UseVisualStyleBackColor = false;
            this.btn_localisation.Click += new System.EventHandler(this.OpenCarte);
            // 
            // AccueilSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.p_titre);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.btn_statut);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_localisation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccueilSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccueilSplash";
            this.p_titre.ResumeLayout(false);
            this.p_titre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel p_titre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_statut;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btn_localisation;
    }
}