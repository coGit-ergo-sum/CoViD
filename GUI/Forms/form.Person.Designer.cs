namespace CoViD.GUI.Forms
{
	partial class Person
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Person));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.tsmDisease = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.grid2 = new CoViD.GUI.UC.Grid();
			this.grid1 = new CoViD.GUI.UC.Grid();
			this.xyViruses = new CoViD.GUI.XY();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsbSettings = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbFilter = new System.Windows.Forms.ToolStripDropDownButton();
			this.tsmFilterS = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmFilterI = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmFilterR = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbNew = new System.Windows.Forms.ToolStripButton();
			this.tsbReplay = new System.Windows.Forms.ToolStripButton();
			this.tsbPlay = new System.Windows.Forms.ToolStripButton();
			this.tsbPause = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.tsLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsTicks = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsProgressBar = new System.Windows.Forms.ToolStripProgressBar();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsContaminatedGrids = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsSusceptibles = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsInfected = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsRecovered = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsImmune = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel9 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsDead = new System.Windows.Forms.ToolStripStatusLabel();
			this.udTicks = new CoViD.GUI.UC.UpDown();
			this.udSegregation = new CoViD.GUI.UC.UpDown();
			this.udSteps = new CoViD.GUI.UC.UpDown();
			this.udRadius = new CoViD.GUI.UC.UpDown();
			this.menuStrip1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDisease});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1136, 24);
			this.menuStrip1.TabIndex = 23;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.Visible = false;
			// 
			// tsmDisease
			// 
			this.tsmDisease.Name = "tsmDisease";
			this.tsmDisease.Size = new System.Drawing.Size(66, 20);
			this.tsmDisease.Text = "&Infection";
			this.tsmDisease.Click += new System.EventHandler(this.tsmDisease_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Location = new System.Drawing.Point(9, 93);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(790, 778);
			this.tabControl1.TabIndex = 65;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.tabPage1.Controls.Add(this.grid2);
			this.tabPage1.Controls.Add(this.grid1);
			this.tabPage1.Controls.Add(this.xyViruses);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(782, 752);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Region";
			// 
			// grid2
			// 
			this.grid2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.grid2.Label = "Title";
			this.grid2.Location = new System.Drawing.Point(398, 257);
			this.grid2.MinimumSize = new System.Drawing.Size(258, 297);
			this.grid2.Name = "grid2";
			this.grid2.Size = new System.Drawing.Size(362, 392);
			this.grid2.TabIndex = 77;
			// 
			// grid1
			// 
			this.grid1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.grid1.Label = "Title";
			this.grid1.Location = new System.Drawing.Point(30, 257);
			this.grid1.MinimumSize = new System.Drawing.Size(258, 297);
			this.grid1.Name = "grid1";
			this.grid1.Size = new System.Drawing.Size(362, 392);
			this.grid1.TabIndex = 40;
			// 
			// xyViruses
			// 
			this.xyViruses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.xyViruses.Location = new System.Drawing.Point(3, 8);
			this.xyViruses.Name = "xyViruses";
			this.xyViruses.Size = new System.Drawing.Size(757, 236);
			this.xyViruses.TabIndex = 39;
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSettings,
            this.toolStripSeparator2,
            this.tsbFilter,
            this.toolStripButton5,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.tsbNew,
            this.tsbReplay,
            this.tsbPlay,
            this.tsbPause,
            this.toolStripButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip1.Size = new System.Drawing.Size(801, 27);
			this.toolStrip1.TabIndex = 72;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsbSettings
			// 
			this.tsbSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbSettings.Image = global::CoViD.GUI.Properties.Resources.settings_32x32;
			this.tsbSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbSettings.Name = "tsbSettings";
			this.tsbSettings.Size = new System.Drawing.Size(24, 24);
			this.tsbSettings.Text = "toolStripButton2";
			this.tsbSettings.ToolTipText = "Shows the setting\'s page.";
			this.tsbSettings.Click += new System.EventHandler(this.tsbSettings_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
			// 
			// tsbFilter
			// 
			this.tsbFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbFilter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFilterS,
            this.tsmFilterI,
            this.tsmFilterR});
			this.tsbFilter.Image = global::CoViD.GUI.Properties.Resources.Users_32x32;
			this.tsbFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbFilter.Name = "tsbFilter";
			this.tsbFilter.Size = new System.Drawing.Size(33, 24);
			this.tsbFilter.Text = "toolStripDropDownButton1";
			this.tsbFilter.ToolTipText = "Selects which category to show in the left graph  for the \'Region\' tab.";
			// 
			// tsmFilterS
			// 
			this.tsmFilterS.Checked = true;
			this.tsmFilterS.CheckOnClick = true;
			this.tsmFilterS.CheckState = System.Windows.Forms.CheckState.Checked;
			this.tsmFilterS.Name = "tsmFilterS";
			this.tsmFilterS.Size = new System.Drawing.Size(139, 22);
			this.tsmFilterS.Text = "Susceptibles";
			this.tsmFilterS.ToolTipText = "Shows People Susceptible to be infected by the virus.";
			// 
			// tsmFilterI
			// 
			this.tsmFilterI.Checked = true;
			this.tsmFilterI.CheckOnClick = true;
			this.tsmFilterI.CheckState = System.Windows.Forms.CheckState.Checked;
			this.tsmFilterI.Name = "tsmFilterI";
			this.tsmFilterI.Size = new System.Drawing.Size(139, 22);
			this.tsmFilterI.Text = "Infected";
			this.tsmFilterI.ToolTipText = "Shows People infected by the virus.\r\n\r\n";
			// 
			// tsmFilterR
			// 
			this.tsmFilterR.Checked = true;
			this.tsmFilterR.CheckOnClick = true;
			this.tsmFilterR.CheckState = System.Windows.Forms.CheckState.Checked;
			this.tsmFilterR.Name = "tsmFilterR";
			this.tsmFilterR.Size = new System.Drawing.Size(139, 22);
			this.tsmFilterR.Text = "Recovered";
			this.tsmFilterR.ToolTipText = "Shows People recovered from the Infection (Immune & dead).\r\n";
			// 
			// toolStripButton5
			// 
			this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton5.Image = global::CoViD.GUI.Properties.Resources.biohazard_32x32;
			this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton5.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
			this.toolStripButton5.Name = "toolStripButton5";
			this.toolStripButton5.Size = new System.Drawing.Size(24, 24);
			this.toolStripButton5.Text = "toolStripButton5";
			this.toolStripButton5.ToolTipText = "Shows the contaminated grids.";
			// 
			// toolStripButton4
			// 
			this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton4.Image = global::CoViD.GUI.Properties.Resources.Users_32x32;
			this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton4.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
			this.toolStripButton4.Name = "toolStripButton4";
			this.toolStripButton4.Size = new System.Drawing.Size(24, 24);
			this.toolStripButton4.Text = "toolStripButton4";
			this.toolStripButton4.ToolTipText = "Shows the distribution of people and their movements";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
			// 
			// tsbNew
			// 
			this.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbNew.Image = global::CoViD.GUI.Properties.Resources.New_32x32;
			this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbNew.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
			this.tsbNew.Name = "tsbNew";
			this.tsbNew.Size = new System.Drawing.Size(24, 24);
			this.tsbNew.Text = "toolStripButton6";
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
			this.tsbReplay.Text = "toolStripButton1";
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
			this.tsbPlay.Text = "toolStripButton2";
			this.tsbPlay.ToolTipText = "Starts / Resumes the simulation.";
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
			this.tsbPause.Text = "toolStripButton3";
			this.tsbPause.ToolTipText = "Pauses the simulation.";
			this.tsbPause.Click += new System.EventHandler(this.tsbPause_Click);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.CheckOnClick = true;
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
			this.toolStripButton1.Text = "toolStripButton1";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLabel1,
            this.tsTicks,
            this.tsProgressBar,
            this.toolStripStatusLabel2,
            this.tsContaminatedGrids,
            this.toolStripStatusLabel1,
            this.tsSusceptibles,
            this.toolStripStatusLabel3,
            this.tsInfected,
            this.toolStripStatusLabel5,
            this.tsRecovered,
            this.toolStripStatusLabel7,
            this.tsImmune,
            this.toolStripStatusLabel9,
            this.tsDead});
			this.statusStrip1.Location = new System.Drawing.Point(0, 761);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(801, 22);
			this.statusStrip1.TabIndex = 76;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// tsLabel1
			// 
			this.tsLabel1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 2);
			this.tsLabel1.Name = "tsLabel1";
			this.tsLabel1.Size = new System.Drawing.Size(36, 17);
			this.tsLabel1.Text = "Ticks:";
			this.tsLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.tsLabel1.ToolTipText = "The \'tick\' is a unity of time (about 20 minutes). And this is the number of ticks" +
    " from the begining of the infection.";
			// 
			// tsTicks
			// 
			this.tsTicks.ForeColor = System.Drawing.Color.DarkRed;
			this.tsTicks.Margin = new System.Windows.Forms.Padding(0, 1, 1, 2);
			this.tsTicks.Name = "tsTicks";
			this.tsTicks.Size = new System.Drawing.Size(13, 19);
			this.tsTicks.Text = "0";
			// 
			// tsProgressBar
			// 
			this.tsProgressBar.Margin = new System.Windows.Forms.Padding(1, 3, 5, 3);
			this.tsProgressBar.Name = "tsProgressBar";
			this.tsProgressBar.Size = new System.Drawing.Size(100, 16);
			this.tsProgressBar.Step = 1;
			this.tsProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(116, 17);
			this.toolStripStatusLabel2.Text = "Contaminated grids:";
			this.toolStripStatusLabel2.ToolTipText = "The number of place contaminated by the virus.";
			// 
			// tsContaminatedGrids
			// 
			this.tsContaminatedGrids.ForeColor = System.Drawing.Color.DarkRed;
			this.tsContaminatedGrids.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
			this.tsContaminatedGrids.Name = "tsContaminatedGrids";
			this.tsContaminatedGrids.Size = new System.Drawing.Size(13, 19);
			this.tsContaminatedGrids.Text = "0";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(75, 17);
			this.toolStripStatusLabel1.Text = "Susceptibles:";
			this.toolStripStatusLabel1.ToolTipText = "The numbero of \'Susceptibles\' according the definition of the \'SIR\' model.";
			// 
			// tsSusceptibles
			// 
			this.tsSusceptibles.ForeColor = System.Drawing.Color.DarkRed;
			this.tsSusceptibles.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
			this.tsSusceptibles.Name = "tsSusceptibles";
			this.tsSusceptibles.Size = new System.Drawing.Size(13, 19);
			this.tsSusceptibles.Text = "0";
			// 
			// toolStripStatusLabel3
			// 
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new System.Drawing.Size(53, 17);
			this.toolStripStatusLabel3.Text = "Infected:";
			this.toolStripStatusLabel3.ToolTipText = "The numbero of \'Infected\' according the definition of the \'SIR\' model.";
			// 
			// tsInfected
			// 
			this.tsInfected.ForeColor = System.Drawing.Color.DarkRed;
			this.tsInfected.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
			this.tsInfected.Name = "tsInfected";
			this.tsInfected.Size = new System.Drawing.Size(13, 19);
			this.tsInfected.Text = "0";
			// 
			// toolStripStatusLabel5
			// 
			this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
			this.toolStripStatusLabel5.Size = new System.Drawing.Size(65, 17);
			this.toolStripStatusLabel5.Text = "Recovered:";
			this.toolStripStatusLabel5.ToolTipText = "The numbero of \'Recovered\' according the definition of the \'SIR\' model.";
			// 
			// tsRecovered
			// 
			this.tsRecovered.ForeColor = System.Drawing.Color.DarkRed;
			this.tsRecovered.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
			this.tsRecovered.Name = "tsRecovered";
			this.tsRecovered.Size = new System.Drawing.Size(13, 19);
			this.tsRecovered.Text = "0";
			// 
			// toolStripStatusLabel7
			// 
			this.toolStripStatusLabel7.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
			this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
			this.toolStripStatusLabel7.Size = new System.Drawing.Size(55, 20);
			this.toolStripStatusLabel7.Text = "Immune:";
			this.toolStripStatusLabel7.ToolTipText = "These  is a portion of \'Recovered\'.";
			// 
			// tsImmune
			// 
			this.tsImmune.ForeColor = System.Drawing.Color.DarkRed;
			this.tsImmune.Margin = new System.Windows.Forms.Padding(0, 1, 3, 2);
			this.tsImmune.Name = "tsImmune";
			this.tsImmune.Size = new System.Drawing.Size(13, 19);
			this.tsImmune.Text = "0";
			// 
			// toolStripStatusLabel9
			// 
			this.toolStripStatusLabel9.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
			this.toolStripStatusLabel9.Name = "toolStripStatusLabel9";
			this.toolStripStatusLabel9.Size = new System.Drawing.Size(34, 20);
			this.toolStripStatusLabel9.Text = "Dead";
			this.toolStripStatusLabel9.ToolTipText = "The other portion of the recovered.";
			// 
			// tsDead
			// 
			this.tsDead.ForeColor = System.Drawing.Color.Red;
			this.tsDead.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
			this.tsDead.Name = "tsDead";
			this.tsDead.Size = new System.Drawing.Size(13, 19);
			this.tsDead.Text = "0";
			// 
			// udTicks
			// 
			this.udTicks.Caption = "Ticks";
			this.udTicks.Decimals = ((sbyte)(0));
			this.udTicks.Location = new System.Drawing.Point(585, 42);
			this.udTicks.MaximumSize = new System.Drawing.Size(335, 45);
			this.udTicks.MinimumSize = new System.Drawing.Size(162, 45);
			this.udTicks.Name = "udTicks";
			this.udTicks.Size = new System.Drawing.Size(214, 45);
			this.udTicks.TabIndex = 74;
			this.udTicks.Value = 3750;
			// 
			// udSegregation
			// 
			this.udSegregation.Caption = "Segregation level";
			this.udSegregation.Decimals = ((sbyte)(0));
			this.udSegregation.Location = new System.Drawing.Point(382, 42);
			this.udSegregation.MaximumSize = new System.Drawing.Size(335, 45);
			this.udSegregation.MinimumSize = new System.Drawing.Size(162, 45);
			this.udSegregation.Name = "udSegregation";
			this.udSegregation.Size = new System.Drawing.Size(177, 45);
			this.udSegregation.TabIndex = 73;
			this.udSegregation.Value = 5;
			// 
			// udSteps
			// 
			this.udSteps.Caption = "Steps";
			this.udSteps.Decimals = ((sbyte)(0));
			this.udSteps.Location = new System.Drawing.Point(177, 42);
			this.udSteps.MaximumSize = new System.Drawing.Size(335, 45);
			this.udSteps.MinimumSize = new System.Drawing.Size(162, 45);
			this.udSteps.Name = "udSteps";
			this.udSteps.Size = new System.Drawing.Size(172, 45);
			this.udSteps.TabIndex = 51;
			this.udSteps.Value = 2;
			this.udSteps.Click += new System.EventHandler(this.up_Click);
			// 
			// udRadius
			// 
			this.udRadius.Caption = "Radius";
			this.udRadius.Decimals = ((sbyte)(0));
			this.udRadius.Location = new System.Drawing.Point(11, 42);
			this.udRadius.MaximumSize = new System.Drawing.Size(335, 45);
			this.udRadius.MinimumSize = new System.Drawing.Size(162, 45);
			this.udRadius.Name = "udRadius";
			this.udRadius.Size = new System.Drawing.Size(227, 45);
			this.udRadius.TabIndex = 48;
			this.udRadius.Value = 20000;
			this.udRadius.Click += new System.EventHandler(this.up_Click);
			// 
			// Person
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(801, 783);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.udTicks);
			this.Controls.Add(this.udSegregation);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.udSteps);
			this.Controls.Add(this.udRadius);
			this.Controls.Add(this.menuStrip1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(730, 730);
			this.Name = "Person";
			this.Text = "Person";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Person_FormClosing);
			this.Load += new System.EventHandler(this.Person_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsmDisease;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private UC.UpDown udSteps;
		private UC.UpDown udRadius;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tsbReplay;
		private System.Windows.Forms.ToolStripButton tsbPlay;
		private System.Windows.Forms.ToolStripButton tsbPause;
		private System.Windows.Forms.ToolStripButton toolStripButton4;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton toolStripButton5;
		private System.Windows.Forms.ToolStripButton tsbNew;
		private UC.UpDown udSegregation;
		private UC.UpDown udTicks;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel tsLabel1;
		private System.Windows.Forms.ToolStripStatusLabel tsTicks;
		private System.Windows.Forms.ToolStripProgressBar tsProgressBar;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel tsSusceptibles;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
		private System.Windows.Forms.ToolStripStatusLabel tsInfected;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
		private System.Windows.Forms.ToolStripStatusLabel tsRecovered;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
		private System.Windows.Forms.ToolStripStatusLabel tsImmune;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel9;
		private System.Windows.Forms.ToolStripStatusLabel tsDead;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.ToolStripStatusLabel tsContaminatedGrids;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton tsbSettings;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripDropDownButton tsbFilter;
		private System.Windows.Forms.ToolStripMenuItem tsmFilterS;
		private System.Windows.Forms.ToolStripMenuItem tsmFilterI;
		private System.Windows.Forms.ToolStripMenuItem tsmFilterR;
		private XY xyViruses;
		private UC.Grid grid2;
		private UC.Grid grid1;
	}
}