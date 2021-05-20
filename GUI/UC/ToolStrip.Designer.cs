namespace CoViD.GUI.UC
{
	partial class ToolStrip
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsbSettings = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbContamination = new System.Windows.Forms.ToolStripButton();
			this.tsbPeople = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbNew = new System.Windows.Forms.ToolStripButton();
			this.tsbReplay = new System.Windows.Forms.ToolStripButton();
			this.tsbPlay = new System.Windows.Forms.ToolStripButton();
			this.tsbPause = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSettings,
            this.toolStripSeparator2,
            this.tsbContamination,
            this.tsbPeople,
            this.toolStripSeparator1,
            this.tsbNew,
            this.tsbReplay,
            this.tsbPlay,
            this.tsbPause});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.MaximumSize = new System.Drawing.Size(234, 27);
			this.toolStrip1.MinimumSize = new System.Drawing.Size(234, 27);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip1.Size = new System.Drawing.Size(234, 27);
			this.toolStrip1.TabIndex = 72;
			this.toolStrip1.Text = "";
			// 
			// tsbSettings
			// 
			this.tsbSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbSettings.Image = global::CoViD.GUI.Properties.Resources.settings_32x32;
			this.tsbSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbSettings.Name = "tsbSettings";
			this.tsbSettings.Size = new System.Drawing.Size(24, 24);
			this.tsbSettings.Text = "";
			this.tsbSettings.ToolTipText = "Shows the setting\'s page.";
			this.tsbSettings.Click += new System.EventHandler(this.tsbSettings_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
			// 
			// tsbContamination
			// 
			this.tsbContamination.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbContamination.Image = global::CoViD.GUI.Properties.Resources.biohazard_32x32;
			this.tsbContamination.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbContamination.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
			this.tsbContamination.Name = "tsbContamination";
			this.tsbContamination.Size = new System.Drawing.Size(24, 24);
			this.tsbContamination.Text = "";
			this.tsbContamination.ToolTipText = "Shows the contaminated grids.";
			// 
			// tsbPeople
			// 
			this.tsbPeople.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbPeople.Image = global::CoViD.GUI.Properties.Resources.Users_32x32;
			this.tsbPeople.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbPeople.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
			this.tsbPeople.Name = "tsbPeople";
			this.tsbPeople.Size = new System.Drawing.Size(24, 24);
			this.tsbPeople.Text = "";
			this.tsbPeople.ToolTipText = "Shows the distribution of people and their movements";
			this.tsbPeople.Click += new System.EventHandler(this.tsbPeople_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
			// 
			// tsbNew
			// 
			this.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbNew.Image = global::CoViD.GUI.Properties.Resources.refresh_New1;
			this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbNew.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
			this.tsbNew.Name = "tsbNew";
			this.tsbNew.Size = new System.Drawing.Size(24, 24);
			this.tsbNew.Text = "";
			this.tsbNew.ToolTipText = "Starts a totally new simulation.";
			this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
			// 
			// tsbReplay
			// 
			this.tsbReplay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbReplay.Image = global::CoViD.GUI.Properties.Resources.refresh_32x32;
			this.tsbReplay.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbReplay.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
			this.tsbReplay.Name = "tsbReplay";
			this.tsbReplay.Size = new System.Drawing.Size(24, 24);
			this.tsbReplay.Text = "";
			this.tsbReplay.ToolTipText = "Restarts from the beginning, the current simulation.";
			this.tsbReplay.Click += new System.EventHandler(this.tsbReplay_Click);
			// 
			// tsbPlay
			// 
			this.tsbPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbPlay.Image = global::CoViD.GUI.Properties.Resources.Start_32x32;
			this.tsbPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbPlay.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
			this.tsbPlay.Name = "tsbPlay";
			this.tsbPlay.Size = new System.Drawing.Size(24, 24);
			this.tsbPlay.Text = "";
			this.tsbPlay.ToolTipText = "Starts / Resumes the current simulation.";
			this.tsbPlay.Click += new System.EventHandler(this.tsbPlay_Click);
			// 
			// tsbPause
			// 
			this.tsbPause.Checked = true;
			this.tsbPause.CheckOnClick = true;
			this.tsbPause.CheckState = System.Windows.Forms.CheckState.Checked;
			this.tsbPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbPause.Image = global::CoViD.GUI.Properties.Resources.Pause_32x32;
			this.tsbPause.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbPause.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
			this.tsbPause.Name = "tsbPause";
			this.tsbPause.Size = new System.Drawing.Size(24, 24);
			this.tsbPause.Text = "";
			this.tsbPause.ToolTipText = "Pauses the simulation.";
			this.tsbPause.Click += new System.EventHandler(this.tsbPause_Click);
			// 
			// ToolStrip
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.Controls.Add(this.toolStrip1);
			this.DoubleBuffered = true;
			this.MaximumSize = new System.Drawing.Size(213, 27);
			this.MinimumSize = new System.Drawing.Size(213, 27);
			this.Name = "ToolStrip";
			this.Size = new System.Drawing.Size(213, 27);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}


		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tsbReplay;
		private System.Windows.Forms.ToolStripButton tsbPlay;
		private System.Windows.Forms.ToolStripButton tsbPause;
		private System.Windows.Forms.ToolStripButton tsbPeople;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton tsbContamination;
		private System.Windows.Forms.ToolStripButton tsbNew;
		private System.Windows.Forms.ToolStripButton tsbSettings;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
	}
}
