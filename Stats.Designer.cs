namespace ProjetChargeon
{
    partial class Stats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stats));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.p_titre = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ch_Graphe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cb_Bornes = new System.Windows.Forms.ComboBox();
            this.lb_TitreCb = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.l_titre_stats = new System.Windows.Forms.Label();
            this.panel_titre = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.l_Duree = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.l_PuisAbs = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.l_Date = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.l_Titre = new System.Windows.Forms.Label();
            this.panel_duree = new System.Windows.Forms.Panel();
            this.l_titre_duree = new System.Windows.Forms.Label();
            this.panel_puisAbs = new System.Windows.Forms.Panel();
            this.l_titre_puisAbs = new System.Windows.Forms.Label();
            this.panel_date = new System.Windows.Forms.Panel();
            this.l_titre_date = new System.Windows.Forms.Label();
            this.p_titre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_Graphe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel_titre.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_duree.SuspendLayout();
            this.panel_puisAbs.SuspendLayout();
            this.panel_date.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_titre
            // 
            this.p_titre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.p_titre.Controls.Add(this.pictureBox1);
            this.p_titre.Controls.Add(this.label1);
            resources.ApplyResources(this.p_titre, "p_titre");
            this.p_titre.Name = "p_titre";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.CloseProgram);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Name = "label1";
            // 
            // ch_Graphe
            // 
            chartArea1.Name = "ChartArea1";
            this.ch_Graphe.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ch_Graphe.Legends.Add(legend1);
            resources.ApplyResources(this.ch_Graphe, "ch_Graphe");
            this.ch_Graphe.Name = "ch_Graphe";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ch_Graphe.Series.Add(series1);
            // 
            // cb_Bornes
            // 
            this.cb_Bornes.FormattingEnabled = true;
            resources.ApplyResources(this.cb_Bornes, "cb_Bornes");
            this.cb_Bornes.Name = "cb_Bornes";
            this.cb_Bornes.SelectedIndexChanged += new System.EventHandler(this.ComboIndexChange);
            // 
            // lb_TitreCb
            // 
            resources.ApplyResources(this.lb_TitreCb, "lb_TitreCb");
            this.lb_TitreCb.ForeColor = System.Drawing.Color.White;
            this.lb_TitreCb.Name = "lb_TitreCb";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.PictureBox4_Click);
            // 
            // l_titre_stats
            // 
            resources.ApplyResources(this.l_titre_stats, "l_titre_stats");
            this.l_titre_stats.ForeColor = System.Drawing.Color.White;
            this.l_titre_stats.Name = "l_titre_stats";
            // 
            // panel_titre
            // 
            this.panel_titre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
            this.panel_titre.Controls.Add(this.l_titre_stats);
            resources.ApplyResources(this.panel_titre, "panel_titre");
            this.panel_titre.Name = "panel_titre";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.panel_duree);
            this.panel4.Controls.Add(this.panel_puisAbs);
            this.panel4.Controls.Add(this.panel_date);
            this.panel4.Controls.Add(this.panel_titre);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
            this.panel5.Controls.Add(this.l_Duree);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // l_Duree
            // 
            resources.ApplyResources(this.l_Duree, "l_Duree");
            this.l_Duree.ForeColor = System.Drawing.Color.White;
            this.l_Duree.Name = "l_Duree";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
            this.panel3.Controls.Add(this.l_PuisAbs);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // l_PuisAbs
            // 
            resources.ApplyResources(this.l_PuisAbs, "l_PuisAbs");
            this.l_PuisAbs.ForeColor = System.Drawing.Color.White;
            this.l_PuisAbs.Name = "l_PuisAbs";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
            this.panel2.Controls.Add(this.l_Date);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // l_Date
            // 
            resources.ApplyResources(this.l_Date, "l_Date");
            this.l_Date.ForeColor = System.Drawing.Color.White;
            this.l_Date.Name = "l_Date";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.l_Titre);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // l_Titre
            // 
            resources.ApplyResources(this.l_Titre, "l_Titre");
            this.l_Titre.ForeColor = System.Drawing.Color.White;
            this.l_Titre.Name = "l_Titre";
            // 
            // panel_duree
            // 
            this.panel_duree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
            this.panel_duree.Controls.Add(this.l_titre_duree);
            resources.ApplyResources(this.panel_duree, "panel_duree");
            this.panel_duree.Name = "panel_duree";
            // 
            // l_titre_duree
            // 
            resources.ApplyResources(this.l_titre_duree, "l_titre_duree");
            this.l_titre_duree.ForeColor = System.Drawing.Color.White;
            this.l_titre_duree.Name = "l_titre_duree";
            // 
            // panel_puisAbs
            // 
            this.panel_puisAbs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
            this.panel_puisAbs.Controls.Add(this.l_titre_puisAbs);
            resources.ApplyResources(this.panel_puisAbs, "panel_puisAbs");
            this.panel_puisAbs.Name = "panel_puisAbs";
            // 
            // l_titre_puisAbs
            // 
            resources.ApplyResources(this.l_titre_puisAbs, "l_titre_puisAbs");
            this.l_titre_puisAbs.ForeColor = System.Drawing.Color.White;
            this.l_titre_puisAbs.Name = "l_titre_puisAbs";
            // 
            // panel_date
            // 
            this.panel_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
            this.panel_date.Controls.Add(this.l_titre_date);
            resources.ApplyResources(this.panel_date, "panel_date");
            this.panel_date.Name = "panel_date";
            // 
            // l_titre_date
            // 
            resources.ApplyResources(this.l_titre_date, "l_titre_date");
            this.l_titre_date.ForeColor = System.Drawing.Color.White;
            this.l_titre_date.Name = "l_titre_date";
            // 
            // Stats
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lb_TitreCb);
            this.Controls.Add(this.cb_Bornes);
            this.Controls.Add(this.ch_Graphe);
            this.Controls.Add(this.p_titre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Stats";
            this.p_titre.ResumeLayout(false);
            this.p_titre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_Graphe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel_titre.ResumeLayout(false);
            this.panel_titre.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_duree.ResumeLayout(false);
            this.panel_duree.PerformLayout();
            this.panel_puisAbs.ResumeLayout(false);
            this.panel_puisAbs.PerformLayout();
            this.panel_date.ResumeLayout(false);
            this.panel_date.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel p_titre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch_Graphe;
        private System.Windows.Forms.ComboBox cb_Bornes;
        private System.Windows.Forms.Label lb_TitreCb;
		private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label l_titre_stats;
        private System.Windows.Forms.Panel panel_titre;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel_duree;
        private System.Windows.Forms.Label l_titre_duree;
        private System.Windows.Forms.Panel panel_puisAbs;
        private System.Windows.Forms.Label l_titre_puisAbs;
        private System.Windows.Forms.Panel panel_date;
        private System.Windows.Forms.Label l_titre_date;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label l_Titre;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label l_Duree;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label l_PuisAbs;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label l_Date;
    }
}