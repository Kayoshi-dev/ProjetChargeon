namespace ProjetChargeon
{
	partial class MesBornes
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MesBornes));
			this.p_form1 = new System.Windows.Forms.Panel();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.cb_bornesClient = new System.Windows.Forms.ComboBox();
			this.l_bornesClients = new System.Windows.Forms.Label();
			this.p_form1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// p_form1
			// 
			this.p_form1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
			this.p_form1.Controls.Add(this.pictureBox4);
			this.p_form1.Controls.Add(this.label4);
			this.p_form1.Controls.Add(this.pictureBox1);
			this.p_form1.Dock = System.Windows.Forms.DockStyle.Top;
			this.p_form1.Location = new System.Drawing.Point(0, 0);
			this.p_form1.Name = "p_form1";
			this.p_form1.Size = new System.Drawing.Size(800, 72);
			this.p_form1.TabIndex = 11;
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
			this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
			this.pictureBox4.Cursor = System.Windows.Forms.Cursors.PanWest;
			this.pictureBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.pictureBox4.Location = new System.Drawing.Point(707, 12);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(30, 30);
			this.pictureBox4.TabIndex = 13;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Click += new System.EventHandler(this.BackForm);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.label4.ForeColor = System.Drawing.SystemColors.Window;
			this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label4.Location = new System.Drawing.Point(12, 25);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 21);
			this.label4.TabIndex = 4;
			this.label4.Text = "Chargéon";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(758, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(30, 30);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.CloseProgram);
			// 
			// cb_bornesClient
			// 
			this.cb_bornesClient.FormattingEnabled = true;
			this.cb_bornesClient.Location = new System.Drawing.Point(28, 109);
			this.cb_bornesClient.Name = "cb_bornesClient";
			this.cb_bornesClient.Size = new System.Drawing.Size(121, 29);
			this.cb_bornesClient.TabIndex = 12;
			// 
			// l_bornesClients
			// 
			this.l_bornesClients.AutoSize = true;
			this.l_bornesClients.ForeColor = System.Drawing.Color.White;
			this.l_bornesClients.Location = new System.Drawing.Point(12, 85);
			this.l_bornesClients.Name = "l_bornesClients";
			this.l_bornesClients.Size = new System.Drawing.Size(154, 21);
			this.l_bornesClients.TabIndex = 13;
			this.l_bornesClients.Text = "Liste de vos bornes";
			// 
			// MesBornes
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.l_bornesClients);
			this.Controls.Add(this.cb_bornesClient);
			this.Controls.Add(this.p_form1);
			this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MesBornes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MesBornes";
			this.p_form1.ResumeLayout(false);
			this.p_form1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel p_form1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.ComboBox cb_bornesClient;
		private System.Windows.Forms.Label l_bornesClients;
	}
}