namespace CoViD.GUI.Forms
{
	partial class Settings
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
			this.udTicks = new CoViD.GUI.UC.UpDown();
			this.udSegregationThreshold = new CoViD.GUI.UC.UpDown();
			this.udSteps = new CoViD.GUI.UC.UpDown();
			this.udPeople = new CoViD.GUI.UC.UpDown();
			this.udRadius = new CoViD.GUI.UC.UpDown();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
			this.mniOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// udTicks
			// 
			this.udTicks.Caption = "Ticks";
			this.udTicks.Decimals = ((sbyte)(0));
			this.udTicks.Location = new System.Drawing.Point(12, 196);
			this.udTicks.MaximumSize = new System.Drawing.Size(335, 45);
			this.udTicks.MinimumSize = new System.Drawing.Size(162, 45);
			this.udTicks.Name = "udTicks";
			this.udTicks.Size = new System.Drawing.Size(227, 45);
			this.udTicks.TabIndex = 79;
			this.udTicks.Value = new decimal(new int[] {
            25000,
            0,
            0,
            0});
			// 
			// udSegregationThreshold
			// 
			this.udSegregationThreshold.Caption = "Segregation %";
			this.udSegregationThreshold.Decimals = ((sbyte)(0));
			this.udSegregationThreshold.Location = new System.Drawing.Point(13, 247);
			this.udSegregationThreshold.MaximumSize = new System.Drawing.Size(335, 45);
			this.udSegregationThreshold.MinimumSize = new System.Drawing.Size(162, 45);
			this.udSegregationThreshold.Name = "udSegregationThreshold";
			this.udSegregationThreshold.Size = new System.Drawing.Size(226, 45);
			this.udSegregationThreshold.TabIndex = 78;
			this.udSegregationThreshold.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			// 
			// udSteps
			// 
			this.udSteps.Caption = "Steps";
			this.udSteps.Decimals = ((sbyte)(0));
			this.udSteps.Location = new System.Drawing.Point(12, 145);
			this.udSteps.MaximumSize = new System.Drawing.Size(335, 45);
			this.udSteps.MinimumSize = new System.Drawing.Size(162, 45);
			this.udSteps.Name = "udSteps";
			this.udSteps.Size = new System.Drawing.Size(227, 45);
			this.udSteps.TabIndex = 77;
			this.udSteps.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// udPeople
			// 
			this.udPeople.Caption = "People";
			this.udPeople.Decimals = ((sbyte)(0));
			this.udPeople.Location = new System.Drawing.Point(12, 43);
			this.udPeople.MaximumSize = new System.Drawing.Size(335, 45);
			this.udPeople.MinimumSize = new System.Drawing.Size(162, 45);
			this.udPeople.Name = "udPeople";
			this.udPeople.Size = new System.Drawing.Size(226, 45);
			this.udPeople.TabIndex = 76;
			this.udPeople.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			// 
			// udRadius
			// 
			this.udRadius.Caption = "Radius";
			this.udRadius.Decimals = ((sbyte)(0));
			this.udRadius.Location = new System.Drawing.Point(11, 94);
			this.udRadius.MaximumSize = new System.Drawing.Size(335, 45);
			this.udRadius.MinimumSize = new System.Drawing.Size(162, 45);
			this.udRadius.Name = "udRadius";
			this.udRadius.Size = new System.Drawing.Size(227, 45);
			this.udRadius.TabIndex = 75;
			this.udRadius.Value = new decimal(new int[] {
            12000,
            0,
            0,
            0});
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(568, 24);
			this.menuStrip1.TabIndex = 80;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// mniFile
			// 
			this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniOpen});
			this.mniFile.Name = "mniFile";
			this.mniFile.Size = new System.Drawing.Size(37, 20);
			this.mniFile.Text = "File";
			// 
			// mniOpen
			// 
			this.mniOpen.Name = "mniOpen";
			this.mniOpen.Size = new System.Drawing.Size(180, 22);
			this.mniOpen.Text = "Open";
			this.mniOpen.Click += new System.EventHandler(this.mniOpen_Click);
			// 
			// Settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(568, 502);
			this.Controls.Add(this.udTicks);
			this.Controls.Add(this.udSegregationThreshold);
			this.Controls.Add(this.udSteps);
			this.Controls.Add(this.udPeople);
			this.Controls.Add(this.udRadius);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Location = new System.Drawing.Point(13, 73);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "Settings";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Settings";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
			this.Load += new System.EventHandler(this.Settings_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private UC.UpDown udTicks;
		private UC.UpDown udSegregationThreshold;
		private UC.UpDown udSteps;
		private UC.UpDown udPeople;
		private UC.UpDown udRadius;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem mniFile;
		private System.Windows.Forms.ToolStripMenuItem mniOpen;
	}
}