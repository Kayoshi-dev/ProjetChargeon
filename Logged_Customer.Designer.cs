namespace ProjetChargeon
{
    partial class Logged_Customer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logged_Customer));
			this.p_titre = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btn_factures = new System.Windows.Forms.Button();
			this.btn_bornes = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.p_titre.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// p_titre
			// 
			this.p_titre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
			this.p_titre.Controls.Add(this.label1);
			this.p_titre.Controls.Add(this.pictureBox1);
			this.p_titre.Dock = System.Windows.Forms.DockStyle.Top;
			this.p_titre.Location = new System.Drawing.Point(0, 0);
			this.p_titre.Name = "p_titre";
			this.p_titre.Size = new System.Drawing.Size(800, 73);
			this.p_titre.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.label1.ForeColor = System.Drawing.SystemColors.Window;
			this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label1.Location = new System.Drawing.Point(146, 161);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 21);
			this.label1.TabIndex = 3;
			this.label1.Text = "Chargéon";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.pictureBox1.Location = new System.Drawing.Point(758, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(30, 30);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
			// 
			// btn_factures
			// 
			this.btn_factures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
			this.btn_factures.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_factures.FlatAppearance.BorderSize = 0;
			this.btn_factures.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_factures.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.btn_factures.ForeColor = System.Drawing.Color.White;
			this.btn_factures.Image = ((System.Drawing.Image)(resources.GetObject("btn_factures.Image")));
			this.btn_factures.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btn_factures.Location = new System.Drawing.Point(449, 161);
			this.btn_factures.Name = "btn_factures";
			this.btn_factures.Size = new System.Drawing.Size(200, 200);
			this.btn_factures.TabIndex = 13;
			this.btn_factures.Text = "Mes Factures";
			this.btn_factures.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_factures.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_factures.UseVisualStyleBackColor = false;
			this.btn_factures.Click += new System.EventHandler(this.Btn_factures_Click);
			// 
			// btn_bornes
			// 
			this.btn_bornes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
			this.btn_bornes.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_bornes.FlatAppearance.BorderSize = 0;
			this.btn_bornes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_bornes.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.btn_bornes.ForeColor = System.Drawing.Color.White;
			this.btn_bornes.Image = ((System.Drawing.Image)(resources.GetObject("btn_bornes.Image")));
			this.btn_bornes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btn_bornes.Location = new System.Drawing.Point(146, 161);
			this.btn_bornes.Name = "btn_bornes";
			this.btn_bornes.Size = new System.Drawing.Size(200, 200);
			this.btn_bornes.TabIndex = 14;
			this.btn_bornes.Text = "Mes Bornes";
			this.btn_bornes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_bornes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_bornes.UseVisualStyleBackColor = false;
			this.btn_bornes.Click += new System.EventHandler(this.Btn_bornes_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
			this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
			this.pictureBox2.Cursor = System.Windows.Forms.Cursors.PanWest;
			this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.pictureBox2.Location = new System.Drawing.Point(707, 12);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(30, 30);
			this.pictureBox2.TabIndex = 15;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.Window;
			this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label2.Location = new System.Drawing.Point(12, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 21);
			this.label2.TabIndex = 16;
			this.label2.Text = "Chargéon";
			// 
			// Logged_Customer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.btn_bornes);
			this.Controls.Add(this.btn_factures);
			this.Controls.Add(this.p_titre);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Logged_Customer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Logged_Customer";
			this.p_titre.ResumeLayout(false);
			this.p_titre.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel p_titre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_factures;
        private System.Windows.Forms.Button btn_bornes;
        private System.Windows.Forms.Button btn_stats;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label2;
	}
}