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
            this.p_Titre_Chargeon = new System.Windows.Forms.Panel();
            this.img_Return = new System.Windows.Forms.PictureBox();
            this.img_Close = new System.Windows.Forms.PictureBox();
            this.l_Titre_Chargeon = new System.Windows.Forms.Label();
            this.btn_Client = new System.Windows.Forms.Button();
            this.btn_Borne = new System.Windows.Forms.Button();
            this.btn_Intervention = new System.Windows.Forms.Button();
            this.btn_Technicien = new System.Windows.Forms.Button();
            this.p_Titre_Chargeon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Return)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // p_Titre_Chargeon
            // 
            this.p_Titre_Chargeon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.p_Titre_Chargeon.Controls.Add(this.img_Return);
            this.p_Titre_Chargeon.Controls.Add(this.img_Close);
            this.p_Titre_Chargeon.Controls.Add(this.l_Titre_Chargeon);
            resources.ApplyResources(this.p_Titre_Chargeon, "p_Titre_Chargeon");
            this.p_Titre_Chargeon.Name = "p_Titre_Chargeon";
            // 
            // img_Return
            // 
            this.img_Return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            resources.ApplyResources(this.img_Return, "img_Return");
            this.img_Return.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.img_Return.Name = "img_Return";
            this.img_Return.TabStop = false;
            this.img_Return.Click += new System.EventHandler(this.Return);
            // 
            // img_Close
            // 
            resources.ApplyResources(this.img_Close, "img_Close");
            this.img_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img_Close.Name = "img_Close";
            this.img_Close.TabStop = false;
            this.img_Close.Click += new System.EventHandler(this.Close);
            // 
            // l_Titre_Chargeon
            // 
            resources.ApplyResources(this.l_Titre_Chargeon, "l_Titre_Chargeon");
            this.l_Titre_Chargeon.ForeColor = System.Drawing.SystemColors.Window;
            this.l_Titre_Chargeon.Name = "l_Titre_Chargeon";
            // 
            // btn_Client
            // 
            this.btn_Client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.btn_Client.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Client.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Client, "btn_Client");
            this.btn_Client.ForeColor = System.Drawing.Color.White;
            this.btn_Client.Name = "btn_Client";
            this.btn_Client.UseVisualStyleBackColor = false;
            // 
            // btn_Borne
            // 
            this.btn_Borne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.btn_Borne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Borne.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Borne, "btn_Borne");
            this.btn_Borne.ForeColor = System.Drawing.Color.White;
            this.btn_Borne.Name = "btn_Borne";
            this.btn_Borne.UseVisualStyleBackColor = false;
            // 
            // btn_Intervention
            // 
            this.btn_Intervention.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.btn_Intervention.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Intervention.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Intervention, "btn_Intervention");
            this.btn_Intervention.ForeColor = System.Drawing.Color.White;
            this.btn_Intervention.Name = "btn_Intervention";
            this.btn_Intervention.UseVisualStyleBackColor = false;
            // 
            // btn_Technicien
            // 
            this.btn_Technicien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.btn_Technicien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Technicien.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Technicien, "btn_Technicien");
            this.btn_Technicien.ForeColor = System.Drawing.Color.White;
            this.btn_Technicien.Name = "btn_Technicien";
            this.btn_Technicien.UseVisualStyleBackColor = false;
            // 
            // Gestion_Donnees
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.btn_Technicien);
            this.Controls.Add(this.btn_Intervention);
            this.Controls.Add(this.btn_Borne);
            this.Controls.Add(this.btn_Client);
            this.Controls.Add(this.p_Titre_Chargeon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Gestion_Donnees";
            this.p_Titre_Chargeon.ResumeLayout(false);
            this.p_Titre_Chargeon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Return)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_Titre_Chargeon;
        private System.Windows.Forms.PictureBox img_Close;
        private System.Windows.Forms.Label l_Titre_Chargeon;
        private System.Windows.Forms.PictureBox img_Return;
        private System.Windows.Forms.Button btn_Client;
        private System.Windows.Forms.Button btn_Borne;
        private System.Windows.Forms.Button btn_Intervention;
        private System.Windows.Forms.Button btn_Technicien;
    }
}