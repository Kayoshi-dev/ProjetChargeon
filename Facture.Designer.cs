namespace ProjetChargeon
{
    partial class Facture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facture));
            this.l_Titre_Chargeon = new System.Windows.Forms.Label();
            this.p_form1 = new System.Windows.Forms.Panel();
            this.img_Return = new System.Windows.Forms.PictureBox();
            this.img_Close = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Facture = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.l_deb = new System.Windows.Forms.Label();
            this.l_fin = new System.Windows.Forms.Label();
            this.rtb_data = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.p_form1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Return)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Close)).BeginInit();
            this.SuspendLayout();
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
            // p_form1
            // 
            this.p_form1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.p_form1.Controls.Add(this.img_Return);
            this.p_form1.Controls.Add(this.l_Titre_Chargeon);
            this.p_form1.Controls.Add(this.img_Close);
            this.p_form1.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_form1.Location = new System.Drawing.Point(0, 0);
            this.p_form1.Name = "p_form1";
            this.p_form1.Size = new System.Drawing.Size(800, 72);
            this.p_form1.TabIndex = 13;
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
            this.img_Return.Click += new System.EventHandler(this.BackForm);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mes factures";
            // 
            // cb_Facture
            // 
            this.cb_Facture.FormattingEnabled = true;
            this.cb_Facture.Location = new System.Drawing.Point(16, 108);
            this.cb_Facture.Name = "cb_Facture";
            this.cb_Facture.Size = new System.Drawing.Size(189, 29);
            this.cb_Facture.TabIndex = 15;
            this.cb_Facture.SelectedIndexChanged += new System.EventHandler(this.SelectedFactureIndexChange);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Date début";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(627, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Date fin";
            // 
            // l_deb
            // 
            this.l_deb.AutoSize = true;
            this.l_deb.Location = new System.Drawing.Point(337, 111);
            this.l_deb.Name = "l_deb";
            this.l_deb.Size = new System.Drawing.Size(57, 21);
            this.l_deb.TabIndex = 18;
            this.l_deb.Text = "label4";
            // 
            // l_fin
            // 
            this.l_fin.AutoSize = true;
            this.l_fin.Location = new System.Drawing.Point(627, 111);
            this.l_fin.Name = "l_fin";
            this.l_fin.Size = new System.Drawing.Size(57, 21);
            this.l_fin.TabIndex = 19;
            this.l_fin.Text = "label5";
            // 
            // rtb_data
            // 
            this.rtb_data.Cursor = System.Windows.Forms.Cursors.No;
            this.rtb_data.Location = new System.Drawing.Point(16, 158);
            this.rtb_data.Name = "rtb_data";
            this.rtb_data.ReadOnly = true;
            this.rtb_data.Size = new System.Drawing.Size(772, 238);
            this.rtb_data.TabIndex = 20;
            this.rtb_data.Text = "";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(657, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 31);
            this.button1.TabIndex = 21;
            this.button1.Text = "Telecharger";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Click_Sauvegarde);
            // 
            // Facturation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtb_data);
            this.Controls.Add(this.l_fin);
            this.Controls.Add(this.l_deb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Facture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p_form1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Facturation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturation";
            this.p_form1.ResumeLayout(false);
            this.p_form1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Return)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_Titre_Chargeon;
        private System.Windows.Forms.Panel p_form1;
        private System.Windows.Forms.PictureBox img_Return;
        private System.Windows.Forms.PictureBox img_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Facture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l_deb;
        private System.Windows.Forms.Label l_fin;
        private System.Windows.Forms.RichTextBox rtb_data;
        private System.Windows.Forms.Button button1;
    }
}