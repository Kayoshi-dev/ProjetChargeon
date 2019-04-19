namespace ProjetChargeon
{
	partial class StatutBornes
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatutBornes));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.p_titre = new System.Windows.Forms.Panel();
			this.cb_bornes = new System.Windows.Forms.ComboBox();
			this.l_title = new System.Windows.Forms.Label();
			this.l_titre_id = new System.Windows.Forms.Label();
			this.l_titre_zone = new System.Windows.Forms.Label();
			this.l_title_ref = new System.Windows.Forms.Label();
			this.l_title_desc = new System.Windows.Forms.Label();
			this.l_title_ns = new System.Windows.Forms.Label();
			this.l_title_type = new System.Windows.Forms.Label();
			this.l_id = new System.Windows.Forms.Label();
			this.l_zone = new System.Windows.Forms.Label();
			this.l_desc = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.p_titre.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
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
			this.label1.ForeColor = System.Drawing.SystemColors.Window;
			this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label1.Location = new System.Drawing.Point(12, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "Chargéon";
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
			// cb_bornes
			// 
			this.cb_bornes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cb_bornes.FormattingEnabled = true;
			this.cb_bornes.Location = new System.Drawing.Point(32, 83);
			this.cb_bornes.Name = "cb_bornes";
			this.cb_bornes.Size = new System.Drawing.Size(121, 29);
			this.cb_bornes.TabIndex = 4;
			this.cb_bornes.SelectedIndexChanged += new System.EventHandler(this.ComboIndexChange);
			// 
			// l_title
			// 
			this.l_title.AutoSize = true;
			this.l_title.ForeColor = System.Drawing.Color.White;
			this.l_title.Location = new System.Drawing.Point(15, 27);
			this.l_title.Name = "l_title";
			this.l_title.Size = new System.Drawing.Size(168, 21);
			this.l_title.TabIndex = 5;
			this.l_title.Text = "Choisissez une borne";
			// 
			// l_titre_id
			// 
			this.l_titre_id.AutoSize = true;
			this.l_titre_id.ForeColor = System.Drawing.Color.White;
			this.l_titre_id.Location = new System.Drawing.Point(230, 100);
			this.l_titre_id.Name = "l_titre_id";
			this.l_titre_id.Size = new System.Drawing.Size(75, 21);
			this.l_titre_id.TabIndex = 6;
			this.l_titre_id.Text = "ID Borne";
			// 
			// l_titre_zone
			// 
			this.l_titre_zone.AutoSize = true;
			this.l_titre_zone.ForeColor = System.Drawing.Color.White;
			this.l_titre_zone.Location = new System.Drawing.Point(395, 100);
			this.l_titre_zone.Name = "l_titre_zone";
			this.l_titre_zone.Size = new System.Drawing.Size(96, 21);
			this.l_titre_zone.TabIndex = 7;
			this.l_titre_zone.Text = "Zone Borne";
			// 
			// l_title_ref
			// 
			this.l_title_ref.AutoSize = true;
			this.l_title_ref.ForeColor = System.Drawing.Color.White;
			this.l_title_ref.Location = new System.Drawing.Point(619, 100);
			this.l_title_ref.Name = "l_title_ref";
			this.l_title_ref.Size = new System.Drawing.Size(138, 21);
			this.l_title_ref.TabIndex = 8;
			this.l_title_ref.Text = "Référence Borne";
			// 
			// l_title_desc
			// 
			this.l_title_desc.AutoSize = true;
			this.l_title_desc.ForeColor = System.Drawing.Color.White;
			this.l_title_desc.Location = new System.Drawing.Point(346, 276);
			this.l_title_desc.Name = "l_title_desc";
			this.l_title_desc.Size = new System.Drawing.Size(145, 21);
			this.l_title_desc.TabIndex = 9;
			this.l_title_desc.Text = "Description Borne";
			// 
			// l_title_ns
			// 
			this.l_title_ns.AutoSize = true;
			this.l_title_ns.ForeColor = System.Drawing.Color.White;
			this.l_title_ns.Location = new System.Drawing.Point(45, 276);
			this.l_title_ns.Name = "l_title_ns";
			this.l_title_ns.Size = new System.Drawing.Size(185, 21);
			this.l_title_ns.TabIndex = 10;
			this.l_title_ns.Text = "Numéro de Série Borne";
			// 
			// l_title_type
			// 
			this.l_title_type.AutoSize = true;
			this.l_title_type.ForeColor = System.Drawing.Color.White;
			this.l_title_type.Location = new System.Drawing.Point(644, 276);
			this.l_title_type.Name = "l_title_type";
			this.l_title_type.Size = new System.Drawing.Size(95, 21);
			this.l_title_type.TabIndex = 11;
			this.l_title_type.Text = "Type Borne";
			// 
			// l_id
			// 
			this.l_id.AutoSize = true;
			this.l_id.ForeColor = System.Drawing.Color.White;
			this.l_id.Location = new System.Drawing.Point(230, 156);
			this.l_id.Name = "l_id";
			this.l_id.Size = new System.Drawing.Size(57, 21);
			this.l_id.TabIndex = 16;
			this.l_id.Text = "label2";
			// 
			// l_zone
			// 
			this.l_zone.AutoSize = true;
			this.l_zone.ForeColor = System.Drawing.Color.White;
			this.l_zone.Location = new System.Drawing.Point(414, 156);
			this.l_zone.Name = "l_zone";
			this.l_zone.Size = new System.Drawing.Size(57, 21);
			this.l_zone.TabIndex = 17;
			this.l_zone.Text = "label2";
			// 
			// l_desc
			// 
			this.l_desc.AutoSize = true;
			this.l_desc.ForeColor = System.Drawing.Color.White;
			this.l_desc.Location = new System.Drawing.Point(383, 340);
			this.l_desc.Name = "l_desc";
			this.l_desc.Size = new System.Drawing.Size(57, 21);
			this.l_desc.TabIndex = 18;
			this.l_desc.Text = "label2";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
			this.panel1.Controls.Add(this.cb_bornes);
			this.panel1.Controls.Add(this.l_title);
			this.panel1.Location = new System.Drawing.Point(0, 73);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 188);
			this.panel1.TabIndex = 19;
			// 
			// StatutBornes
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.ControlBox = false;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.l_desc);
			this.Controls.Add(this.l_zone);
			this.Controls.Add(this.l_id);
			this.Controls.Add(this.l_title_type);
			this.Controls.Add(this.l_title_ns);
			this.Controls.Add(this.l_title_desc);
			this.Controls.Add(this.l_title_ref);
			this.Controls.Add(this.l_titre_zone);
			this.Controls.Add(this.l_titre_id);
			this.Controls.Add(this.p_titre);
			this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "StatutBornes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "StatutBornes";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.p_titre.ResumeLayout(false);
			this.p_titre.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel p_titre;
		private System.Windows.Forms.ComboBox cb_bornes;
		private System.Windows.Forms.Label l_title;
		private System.Windows.Forms.Label l_titre_id;
		private System.Windows.Forms.Label l_titre_zone;
		private System.Windows.Forms.Label l_title_ref;
		private System.Windows.Forms.Label l_title_desc;
		private System.Windows.Forms.Label l_title_ns;
		private System.Windows.Forms.Label l_title_type;
		private System.Windows.Forms.Label l_id;
		private System.Windows.Forms.Label l_zone;
		private System.Windows.Forms.Label l_desc;
		private System.Windows.Forms.Panel panel1;
	}
}