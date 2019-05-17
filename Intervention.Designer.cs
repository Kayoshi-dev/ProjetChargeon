namespace ProjetChargeon
{
	partial class Intervention
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Intervention));
			this.p_Chargeon = new System.Windows.Forms.Panel();
			this.img_Return = new System.Windows.Forms.PictureBox();
			this.l_Titre_Chargeon = new System.Windows.Forms.Label();
			this.img_Close = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.cb_titreAssAtt = new System.Windows.Forms.ComboBox();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.l_typeAssAtt = new System.Windows.Forms.Label();
			this.l_numBorneAtt = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.p_Chargeon.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.img_Return)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.img_Close)).BeginInit();
			this.SuspendLayout();
			// 
			// p_Chargeon
			// 
			this.p_Chargeon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
			this.p_Chargeon.Controls.Add(this.img_Return);
			this.p_Chargeon.Controls.Add(this.l_Titre_Chargeon);
			this.p_Chargeon.Controls.Add(this.img_Close);
			this.p_Chargeon.Dock = System.Windows.Forms.DockStyle.Top;
			this.p_Chargeon.Location = new System.Drawing.Point(0, 0);
			this.p_Chargeon.Name = "p_Chargeon";
			this.p_Chargeon.Size = new System.Drawing.Size(800, 72);
			this.p_Chargeon.TabIndex = 12;
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
			// img_Close
			// 
			this.img_Close.Cursor = System.Windows.Forms.Cursors.Hand;
			this.img_Close.Image = ((System.Drawing.Image)(resources.GetObject("img_Close.Image")));
			this.img_Close.Location = new System.Drawing.Point(758, 12);
			this.img_Close.Name = "img_Close";
			this.img_Close.Size = new System.Drawing.Size(30, 30);
			this.img_Close.TabIndex = 1;
			this.img_Close.TabStop = false;
			this.img_Close.Click += new System.EventHandler(this.CloseProgram);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.panel1.Location = new System.Drawing.Point(263, 88);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(3, 340);
			this.panel1.TabIndex = 19;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.panel2.Location = new System.Drawing.Point(532, 88);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(3, 340);
			this.panel2.TabIndex = 20;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(294, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(214, 21);
			this.label1.TabIndex = 21;
			this.label1.Text = "Demandes d\'interventions";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(360, 109);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 21);
			this.label2.TabIndex = 22;
			this.label2.Text = "en cours";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(26, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(214, 21);
			this.label3.TabIndex = 23;
			this.label3.Text = "Demandes d\'interventions";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(86, 109);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 21);
			this.label4.TabIndex = 24;
			this.label4.Text = "en attente";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(628, 109);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(86, 21);
			this.label5.TabIndex = 26;
			this.label5.Text = "terminées";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(562, 88);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(214, 21);
			this.label6.TabIndex = 25;
			this.label6.Text = "Demandes d\'interventions";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(387, 163);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 29);
			this.comboBox1.TabIndex = 27;
			// 
			// cb_titreAssAtt
			// 
			this.cb_titreAssAtt.FormattingEnabled = true;
			this.cb_titreAssAtt.Location = new System.Drawing.Point(16, 169);
			this.cb_titreAssAtt.Name = "cb_titreAssAtt";
			this.cb_titreAssAtt.Size = new System.Drawing.Size(179, 29);
			this.cb_titreAssAtt.TabIndex = 28;
			this.cb_titreAssAtt.SelectedIndexChanged += new System.EventHandler(this.IndexChangePendingAssist);
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(655, 163);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(121, 29);
			this.comboBox3.TabIndex = 29;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 145);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(43, 21);
			this.label7.TabIndex = 30;
			this.label7.Text = "Titre";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(12, 217);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(147, 21);
			this.label8.TabIndex = 31;
			this.label8.Text = "Numéro de borne";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(12, 291);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(145, 21);
			this.label9.TabIndex = 32;
			this.label9.Text = "Type d\'assistance";
			// 
			// l_typeAssAtt
			// 
			this.l_typeAssAtt.Location = new System.Drawing.Point(12, 327);
			this.l_typeAssAtt.Name = "l_typeAssAtt";
			this.l_typeAssAtt.Size = new System.Drawing.Size(245, 27);
			this.l_typeAssAtt.TabIndex = 33;
			this.l_typeAssAtt.Text = "typeAssistance";
			// 
			// l_numBorneAtt
			// 
			this.l_numBorneAtt.Location = new System.Drawing.Point(12, 250);
			this.l_numBorneAtt.Name = "l_numBorneAtt";
			this.l_numBorneAtt.Size = new System.Drawing.Size(228, 24);
			this.l_numBorneAtt.TabIndex = 35;
			this.l_numBorneAtt.Text = "numBorne";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.panel3.Location = new System.Drawing.Point(16, 277);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(224, 3);
			this.panel3.TabIndex = 20;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.panel4.Location = new System.Drawing.Point(16, 211);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(224, 3);
			this.panel4.TabIndex = 21;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.panel5.Location = new System.Drawing.Point(16, 357);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(224, 3);
			this.panel5.TabIndex = 21;
			// 
			// Intervention
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.l_numBorneAtt);
			this.Controls.Add(this.l_typeAssAtt);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.cb_titreAssAtt);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.p_Chargeon);
			this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Intervention";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Intervention";
			this.p_Chargeon.ResumeLayout(false);
			this.p_Chargeon.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.img_Return)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.img_Close)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel p_Chargeon;
		private System.Windows.Forms.PictureBox img_Return;
		private System.Windows.Forms.Label l_Titre_Chargeon;
		private System.Windows.Forms.PictureBox img_Close;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox cb_titreAssAtt;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label l_typeAssAtt;
		private System.Windows.Forms.Label l_numBorneAtt;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
	}
}