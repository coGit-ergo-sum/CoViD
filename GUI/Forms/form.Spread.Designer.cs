namespace CoViD.GUI.Forms
{
	partial class Spread
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spread));
			this.tsmDisease = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.grid1 = new CoViD.GUI.UC.Grid();
			this.grid2 = new CoViD.GUI.UC.Grid();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.xySIR = new CoViD.GUI.XY();
			this.tabDSIR = new System.Windows.Forms.TabPage();
			this.xyDSIR = new CoViD.GUI.XY();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.xyContaminated = new CoViD.GUI.XY();
			this.tabPerformances = new System.Windows.Forms.TabPage();
			this.xyPerformances = new CoViD.GUI.XY();
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
			this.legend1 = new CoViD.GUI.UC.Legend();
			this.udTicks = new CoViD.GUI.UC.UpDown();
			this.udSegregationThreshold = new CoViD.GUI.UC.UpDown();
			this.udSteps = new CoViD.GUI.UC.UpDown();
			this.udPeople = new CoViD.GUI.UC.UpDown();
			this.udRadius = new CoViD.GUI.UC.UpDown();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabDSIR.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPerformances.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tsmDisease
			// 
			this.tsmDisease.Name = "tsmDisease";
			this.tsmDisease.Size = new System.Drawing.Size(66, 20);
			this.tsmDisease.Text = "&Infection";
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabDSIR);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPerformances);
			this.tabControl1.Location = new System.Drawing.Point(9, 93);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1121, 610);
			this.tabControl1.TabIndex = 65;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.tabPage1.Controls.Add(this.tableLayoutPanel1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1113, 584);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Region";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.grid1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.grid2, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 5);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1102, 574);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// grid1
			// 
			this.grid1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.grid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grid1.Label = "Title";
			this.grid1.Location = new System.Drawing.Point(3, 3);
			this.grid1.MinimumSize = new System.Drawing.Size(258, 297);
			this.grid1.Name = "grid1";
			this.grid1.Size = new System.Drawing.Size(545, 568);
			this.grid1.TabIndex = 0;
			// 
			// grid2
			// 
			this.grid2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.grid2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grid2.Label = "Title";
			this.grid2.Location = new System.Drawing.Point(554, 3);
			this.grid2.MinimumSize = new System.Drawing.Size(258, 297);
			this.grid2.Name = "grid2";
			this.grid2.Size = new System.Drawing.Size(545, 568);
			this.grid2.TabIndex = 1;
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.tabPage2.Controls.Add(this.xySIR);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1113, 584);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "SIR";
			// 
			// xySIR
			// 
			this.xySIR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.xySIR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.xySIR.Location = new System.Drawing.Point(5, 5);
			this.xySIR.Name = "xySIR";
			this.xySIR.Size = new System.Drawing.Size(1103, 574);
			this.xySIR.TabIndex = 0;
			// 
			// tabDSIR
			// 
			this.tabDSIR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.tabDSIR.Controls.Add(this.xyDSIR);
			this.tabDSIR.Location = new System.Drawing.Point(4, 22);
			this.tabDSIR.Name = "tabDSIR";
			this.tabDSIR.Size = new System.Drawing.Size(1113, 584);
			this.tabDSIR.TabIndex = 4;
			this.tabDSIR.Text = "Delta SIR";
			// 
			// xyDSIR
			// 
			this.xyDSIR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.xyDSIR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.xyDSIR.Location = new System.Drawing.Point(5, 5);
			this.xyDSIR.Name = "xyDSIR";
			this.xyDSIR.Size = new System.Drawing.Size(1103, 574);
			this.xyDSIR.TabIndex = 1;
			// 
			// tabPage3
			// 
			this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.tabPage3.Controls.Add(this.xyContaminated);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(1113, 584);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Contaminated grids";
			// 
			// xyContaminated
			// 
			this.xyContaminated.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.xyContaminated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.xyContaminated.Location = new System.Drawing.Point(5, 5);
			this.xyContaminated.Name = "xyContaminated";
			this.xyContaminated.Size = new System.Drawing.Size(1103, 574);
			this.xyContaminated.TabIndex = 0;
			// 
			// tabPerformances
			// 
			this.tabPerformances.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.tabPerformances.Controls.Add(this.xyPerformances);
			this.tabPerformances.Location = new System.Drawing.Point(4, 22);
			this.tabPerformances.Name = "tabPerformances";
			this.tabPerformances.Size = new System.Drawing.Size(1113, 584);
			this.tabPerformances.TabIndex = 3;
			this.tabPerformances.Text = "Performances";
			// 
			// xyPerformances
			// 
			this.xyPerformances.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.xyPerformances.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.xyPerformances.Location = new System.Drawing.Point(5, 5);
			this.xyPerformances.Name = "xyPerformances";
			this.xyPerformances.Size = new System.Drawing.Size(1103, 574);
			this.xyPerformances.TabIndex = 0;
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
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip1.Size = new System.Drawing.Size(1135, 27);
			this.toolStrip1.TabIndex = 72;
			// 
			// tsbSettings
			// 
			this.tsbSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbSettings.Image = global::CoViD.GUI.Properties.Resources.settings_32x32;
			this.tsbSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbSettings.Name = "tsbSettings";
			this.tsbSettings.Size = new System.Drawing.Size(24, 24);
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
			this.tsbPause.ToolTipText = "Pauses the simulation.";
			this.tsbPause.Visible = false;
			this.tsbPause.Click += new System.EventHandler(this.tsbPause_Click);
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
			this.statusStrip1.Location = new System.Drawing.Point(0, 710);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1135, 22);
			this.statusStrip1.TabIndex = 76;
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
			// legend1
			// 
			this.legend1.BackColor = System.Drawing.SystemColors.Control;
			this.legend1.CheckBoxes = true;
			this.legend1.IsConvalescent = true;
			this.legend1.IsDead = true;
			this.legend1.IsIll = true;
			this.legend1.IsImmune = true;
			this.legend1.IsLatency = true;
			this.legend1.IsSevere = true;
			this.legend1.IsSIR = false;
			this.legend1.IsSusceptible = true;
			this.legend1.Location = new System.Drawing.Point(388, 98);
			this.legend1.Name = "legend1";
			this.legend1.Size = new System.Drawing.Size(717, 15);
			this.legend1.TabIndex = 77;
			// 
			// udTicks
			// 
			this.udTicks.Caption = "Ticks";
			this.udTicks.Decimals = ((sbyte)(0));
			this.udTicks.Location = new System.Drawing.Point(643, 42);
			this.udTicks.MaximumSize = new System.Drawing.Size(335, 45);
			this.udTicks.MinimumSize = new System.Drawing.Size(162, 45);
			this.udTicks.Name = "udTicks";
			this.udTicks.Size = new System.Drawing.Size(214, 45);
			this.udTicks.TabIndex = 74;
			this.udTicks.Value = 25000;
			// 
			// udSegregationThreshold
			// 
			this.udSegregationThreshold.Caption = "Segregation level";
			this.udSegregationThreshold.Decimals = ((sbyte)(0));
			this.udSegregationThreshold.Location = new System.Drawing.Point(946, 42);
			this.udSegregationThreshold.MaximumSize = new System.Drawing.Size(335, 45);
			this.udSegregationThreshold.MinimumSize = new System.Drawing.Size(162, 45);
			this.udSegregationThreshold.Name = "udSegregationThreshold";
			this.udSegregationThreshold.Size = new System.Drawing.Size(177, 45);
			this.udSegregationThreshold.TabIndex = 73;
			this.udSegregationThreshold.Value = 0;
			// 
			// udSteps
			// 
			this.udSteps.Caption = "Steps";
			this.udSteps.Decimals = ((sbyte)(0));
			this.udSteps.Location = new System.Drawing.Point(465, 42);
			this.udSteps.MaximumSize = new System.Drawing.Size(335, 45);
			this.udSteps.MinimumSize = new System.Drawing.Size(162, 45);
			this.udSteps.Name = "udSteps";
			this.udSteps.Size = new System.Drawing.Size(172, 45);
			this.udSteps.TabIndex = 51;
			this.udSteps.Value = 1;
			this.udSteps.Click += new System.EventHandler(this.up_Click);
			// 
			// udPeople
			// 
			this.udPeople.Caption = "People";
			this.udPeople.Decimals = ((sbyte)(0));
			this.udPeople.Location = new System.Drawing.Point(244, 42);
			this.udPeople.MaximumSize = new System.Drawing.Size(335, 45);
			this.udPeople.MinimumSize = new System.Drawing.Size(162, 45);
			this.udPeople.Name = "udPeople";
			this.udPeople.Size = new System.Drawing.Size(215, 45);
			this.udPeople.TabIndex = 50;
			this.udPeople.Value = 10000;
			this.udPeople.Click += new System.EventHandler(this.up_Click);
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
			this.udRadius.Value = 12000;
			this.udRadius.Click += new System.EventHandler(this.up_Click);
			// 
			// Spread
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1135, 732);
			this.Controls.Add(this.legend1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.udTicks);
			this.Controls.Add(this.udSegregationThreshold);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.udSteps);
			this.Controls.Add(this.udPeople);
			this.Controls.Add(this.udRadius);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(730, 730);
			this.Name = "Spread";
			this.Text = "Spread";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Spread_FormClosing);
			this.Load += new System.EventHandler(this.Spread_Load);
			this.Click += new System.EventHandler(this.Spread_Click);
			this.Resize += new System.EventHandler(this.Spread_Resize);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabDSIR.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPerformances.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		//private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsmDisease;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private UC.UpDown udSteps;
		private UC.UpDown udPeople;
		private UC.UpDown udRadius;
		private XY xySIR;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tsbReplay;
		private System.Windows.Forms.ToolStripButton tsbPlay;
		private System.Windows.Forms.ToolStripButton tsbPause;
		private System.Windows.Forms.ToolStripButton tsbPeople;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton tsbContamination;
		private System.Windows.Forms.ToolStripButton tsbNew;
		private XY xyContaminated;
		private UC.UpDown udSegregationThreshold;
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
		private System.Windows.Forms.ToolStripButton tsbSettings;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private UC.Legend legend1;
		private System.Windows.Forms.TabPage tabPerformances;
		private XY xyPerformances;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private UC.Grid grid1;
		private UC.Grid grid2;
		private System.Windows.Forms.TabPage tabDSIR;
		private XY xyDSIR;
	}
}