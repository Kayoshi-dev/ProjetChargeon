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
			this.p_titre.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ch_Graphe)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
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
			// Stats
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
			resources.ApplyResources(this, "$this");
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
	}
}