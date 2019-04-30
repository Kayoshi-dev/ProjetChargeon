namespace ProjetChargeon
{
	partial class Gestion_Donnees
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_Donnees));
			this.btn_AjoutClient = new System.Windows.Forms.Button();
			this.btn_AjoutBorne = new System.Windows.Forms.Button();
			this.btn_AjoutTechnicien = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_AjoutClient
			// 
			this.btn_AjoutClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
			this.btn_AjoutClient.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_AjoutClient.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(this.btn_AjoutClient, "btn_AjoutClient");
			this.btn_AjoutClient.ForeColor = System.Drawing.Color.White;
			this.btn_AjoutClient.Name = "btn_AjoutClient";
			this.btn_AjoutClient.UseVisualStyleBackColor = false;
			// 
			// btn_AjoutBorne
			// 
			this.btn_AjoutBorne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
			this.btn_AjoutBorne.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_AjoutBorne.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(this.btn_AjoutBorne, "btn_AjoutBorne");
			this.btn_AjoutBorne.ForeColor = System.Drawing.Color.White;
			this.btn_AjoutBorne.Name = "btn_AjoutBorne";
			this.btn_AjoutBorne.UseVisualStyleBackColor = false;
			// 
			// btn_AjoutTechnicien
			// 
			this.btn_AjoutTechnicien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
			this.btn_AjoutTechnicien.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_AjoutTechnicien.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(this.btn_AjoutTechnicien, "btn_AjoutTechnicien");
			this.btn_AjoutTechnicien.ForeColor = System.Drawing.Color.White;
			this.btn_AjoutTechnicien.Name = "btn_AjoutTechnicien";
			this.btn_AjoutTechnicien.UseVisualStyleBackColor = false;
			this.btn_AjoutTechnicien.Click += new System.EventHandler(this.onClickToCRUDTechnicien);
			// 
			// Gestion_Donnees
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.btn_AjoutTechnicien);
			this.Controls.Add(this.btn_AjoutBorne);
			this.Controls.Add(this.btn_AjoutClient);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "Gestion_Donnees";
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btn_AjoutClient;
		private System.Windows.Forms.Button btn_AjoutBorne;
		private System.Windows.Forms.Button btn_AjoutTechnicien;
	}
}