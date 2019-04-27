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
			// 
			// Intervention
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
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

		}

		#endregion

		private System.Windows.Forms.Panel p_Chargeon;
		private System.Windows.Forms.PictureBox img_Return;
		private System.Windows.Forms.Label l_Titre_Chargeon;
		private System.Windows.Forms.PictureBox img_Close;
	}
}