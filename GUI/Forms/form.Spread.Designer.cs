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
			this.tabRegion = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tabSIR = new System.Windows.Forms.TabPage();
			this.tabDSIR = new System.Windows.Forms.TabPage();
			this.tabContaminated = new System.Windows.Forms.TabPage();
			this.tabPerformances = new System.Windows.Forms.TabPage();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsbSettings = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbPerson = new System.Windows.Forms.ToolStripButton();
			this.tsbInfection = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.SnapshotForm = new System.Windows.Forms.ToolStripMenuItem();
			this.SnapshotDiagram = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.SnapshotDirectory = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbNew = new System.Windows.Forms.ToolStripButton();
			this.tsbReplay = new System.Windows.Forms.ToolStripButton();
			this.tsbPlay = new System.Windows.Forms.ToolStripButton();
			this.tsbPause = new System.Windows.Forms.ToolStripButton();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsPeople = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsIsolation = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsTicks = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsProgressBar = new System.Windows.Forms.ToolStripProgressBar();
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
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsContaminatedGrids = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.legend1 = new CoViD.GUI.UC.Legend();
			this.regionL = new CoViD.GUI.UC.Region();
			this.regionR = new CoViD.GUI.UC.Region();
			this.xySIR = new CoViD.GUI.XY();
			this.xyDSIR = new CoViD.GUI.XY();
			this.xyContaminated = new CoViD.GUI.XY();
			this.xyPerformances = new CoViD.GUI.XY();
			this.tabControl1.SuspendLayout();
			this.tabRegion.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tabSIR.SuspendLayout();
			this.tabDSIR.SuspendLayout();
			this.tabContaminated.SuspendLayout();
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
			this.tabControl1.Controls.Add(this.tabRegion);
			this.tabControl1.Controls.Add(this.tabSIR);
			this.tabControl1.Controls.Add(this.tabDSIR);
			this.tabControl1.Controls.Add(this.tabContaminated);
			this.tabControl1.Controls.Add(this.tabPerformances);
			this.tabControl1.Location = new System.Drawing.Point(0, 29);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1194, 643);
			this.tabControl1.TabIndex = 65;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tabRegion
			// 
			this.tabRegion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.tabRegion.Controls.Add(this.tableLayoutPanel1);
			this.tabRegion.ForeColor = System.Drawing.SystemColors.ControlText;
			this.tabRegion.Location = new System.Drawing.Point(4, 22);
			this.tabRegion.Name = "tabRegion";
			this.tabRegion.Padding = new System.Windows.Forms.Padding(3);
			this.tabRegion.Size = new System.Drawing.Size(1186, 617);
			this.tabRegion.TabIndex = 0;
			this.tabRegion.Text = "Region";
			this.tabRegion.ToolTipText = "The area where people lives and interact and the CoViD spreads.";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.regionL, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.regionR, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 5);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1175, 607);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tabSIR
			// 
			this.tabSIR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.tabSIR.Controls.Add(this.xySIR);
			this.tabSIR.Location = new System.Drawing.Point(4, 22);
			this.tabSIR.Name = "tabSIR";
			this.tabSIR.Padding = new System.Windows.Forms.Padding(3);
			this.tabSIR.Size = new System.Drawing.Size(1143, 656);
			this.tabSIR.TabIndex = 1;
			this.tabSIR.Text = "SIR";
			this.tabSIR.ToolTipText = "The classical S.I.R. representation.";
			// 
			// tabDSIR
			// 
			this.tabDSIR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.tabDSIR.Controls.Add(this.xyDSIR);
			this.tabDSIR.Location = new System.Drawing.Point(4, 22);
			this.tabDSIR.Name = "tabDSIR";
			this.tabDSIR.Size = new System.Drawing.Size(1143, 656);
			this.tabDSIR.TabIndex = 4;
			this.tabDSIR.Text = "Delta SIR";
			this.tabDSIR.ToolTipText = "Visualization of the gap between the two model.";
			// 
			// tabContaminated
			// 
			this.tabContaminated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.tabContaminated.Controls.Add(this.xyContaminated);
			this.tabContaminated.Location = new System.Drawing.Point(4, 22);
			this.tabContaminated.Name = "tabContaminated";
			this.tabContaminated.Size = new System.Drawing.Size(1143, 656);
			this.tabContaminated.TabIndex = 2;
			this.tabContaminated.Text = "Contaminated points";
			this.tabContaminated.ToolTipText = "The evolution of the number of contaminated by the virus) points on the region.";
			// 
			// tabPerformances
			// 
			this.tabPerformances.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.tabPerformances.Controls.Add(this.xyPerformances);
			this.tabPerformances.Location = new System.Drawing.Point(4, 22);
			this.tabPerformances.Name = "tabPerformances";
			this.tabPerformances.Size = new System.Drawing.Size(1143, 656);
			this.tabPerformances.TabIndex = 3;
			this.tabPerformances.Text = "Performances";
			this.tabPerformances.ToolTipText = "Visualization of the computational power needed to run the simulation.";
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSettings,
            this.toolStripSeparator2,
            this.tsbPerson,
            this.tsbInfection,
            this.toolStripSeparator3,
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.tsbNew,
            this.tsbReplay,
            this.tsbPlay,
            this.tsbPause});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip1.Size = new System.Drawing.Size(1193, 27);
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
			// tsbPerson
			// 
			this.tsbPerson.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbPerson.Image = global::CoViD.GUI.Properties.Resources.Users_32x32;
			this.tsbPerson.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbPerson.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
			this.tsbPerson.Name = "tsbPerson";
			this.tsbPerson.Size = new System.Drawing.Size(24, 24);
			this.tsbPerson.ToolTipText = "Shows the distribution of people and their movements";
			this.tsbPerson.Visible = false;
			this.tsbPerson.Click += new System.EventHandler(this.tsbPerson_Click);
			// 
			// tsbInfection
			// 
			this.tsbInfection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbInfection.Image = global::CoViD.GUI.Properties.Resources.Contamination1;
			this.tsbInfection.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbInfection.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
			this.tsbInfection.Name = "tsbInfection";
			this.tsbInfection.Size = new System.Drawing.Size(24, 24);
			this.tsbInfection.ToolTipText = "Shows the evolution of a CoViD.";
			this.tsbInfection.Visible = false;
			this.tsbInfection.Click += new System.EventHandler(this.tsbInfection_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
			this.toolStripSeparator3.Visible = false;
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SnapshotForm,
            this.SnapshotDiagram,
            this.toolStripMenuItem2,
            this.SnapshotDirectory});
			this.toolStripDropDownButton1.Image = global::CoViD.GUI.Properties.Resources.snapshot_32x32;
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(33, 24);
			this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.ToolTipText = "Takes snapshot.";
			// 
			// SnapshotForm
			// 
			this.SnapshotForm.Name = "SnapshotForm";
			this.SnapshotForm.Size = new System.Drawing.Size(122, 22);
			this.SnapshotForm.Text = "Form";
			this.SnapshotForm.ToolTipText = "Takes a snapshot of the whole form.";
			this.SnapshotForm.Click += new System.EventHandler(this.SnapshotForm_Click);
			// 
			// SnapshotDiagram
			// 
			this.SnapshotDiagram.Name = "SnapshotDiagram";
			this.SnapshotDiagram.Size = new System.Drawing.Size(122, 22);
			this.SnapshotDiagram.Text = "Diagram";
			this.SnapshotDiagram.ToolTipText = "Takes a snapshot of the active diagram (the drawing region).";
			this.SnapshotDiagram.Click += new System.EventHandler(this.SnapshotDiagram_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(119, 6);
			// 
			// SnapshotDirectory
			// 
			this.SnapshotDirectory.Name = "SnapshotDirectory";
			this.SnapshotDirectory.Size = new System.Drawing.Size(122, 22);
			this.SnapshotDirectory.Text = "Directory";
			this.SnapshotDirectory.ToolTipText = "Opens the folder where all the snapshots are stored.";
			this.SnapshotDirectory.Click += new System.EventHandler(this.SnapshotDirectory_Click);
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
			this.tsbNew.ToolTipText = "Starts a totally new simulation with new random parameters.";
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
            this.toolStripStatusLabel4,
            this.tsPeople,
            this.toolStripStatusLabel6,
            this.tsIsolation,
            this.tsLabel1,
            this.tsTicks,
            this.toolStripStatusLabel8,
            this.tsProgressBar,
            this.toolStripStatusLabel1,
            this.tsSusceptibles,
            this.toolStripStatusLabel3,
            this.tsInfected,
            this.toolStripStatusLabel5,
            this.tsRecovered,
            this.toolStripStatusLabel7,
            this.tsImmune,
            this.toolStripStatusLabel9,
            this.tsDead,
            this.toolStripStatusLabel2,
            this.tsContaminatedGrids});
			this.statusStrip1.Location = new System.Drawing.Point(0, 669);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.ShowItemToolTips = true;
			this.statusStrip1.Size = new System.Drawing.Size(1193, 22);
			this.statusStrip1.TabIndex = 76;
			// 
			// toolStripStatusLabel4
			// 
			this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
			this.toolStripStatusLabel4.Size = new System.Drawing.Size(43, 17);
			this.toolStripStatusLabel4.Text = "People";
			this.toolStripStatusLabel4.ToolTipText = "The number of people in the simulation.";
			// 
			// tsPeople
			// 
			this.tsPeople.AutoSize = false;
			this.tsPeople.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.tsPeople.Name = "tsPeople";
			this.tsPeople.Size = new System.Drawing.Size(50, 17);
			this.tsPeople.Text = "0";
			this.tsPeople.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.tsPeople.ToolTipText = "The number of people in this simulation.";
			// 
			// toolStripStatusLabel6
			// 
			this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
			this.toolStripStatusLabel6.Size = new System.Drawing.Size(52, 17);
			this.toolStripStatusLabel6.Text = "Isolation";
			this.toolStripStatusLabel6.ToolTipText = "The percentage of people forced to stay at home.";
			// 
			// tsIsolation
			// 
			this.tsIsolation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.tsIsolation.Margin = new System.Windows.Forms.Padding(0, 3, 8, 2);
			this.tsIsolation.Name = "tsIsolation";
			this.tsIsolation.Size = new System.Drawing.Size(13, 17);
			this.tsIsolation.Text = "0";
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
			this.tsTicks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// toolStripStatusLabel8
			// 
			this.toolStripStatusLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
			this.toolStripStatusLabel8.Size = new System.Drawing.Size(45, 17);
			this.toolStripStatusLabel8.Text = "/15.000";
			// 
			// tsProgressBar
			// 
			this.tsProgressBar.AutoToolTip = true;
			this.tsProgressBar.Margin = new System.Windows.Forms.Padding(1, 3, 5, 3);
			this.tsProgressBar.Name = "tsProgressBar";
			this.tsProgressBar.Size = new System.Drawing.Size(100, 16);
			this.tsProgressBar.Step = 1;
			this.tsProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
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
			this.toolStripStatusLabel7.ToolTipText = "This  is the healed portion of \'Recovered\'.";
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
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(122, 17);
			this.toolStripStatusLabel2.Text = "Contaminated points:";
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
			// toolStrip2
			// 
			this.toolStrip2.Location = new System.Drawing.Point(0, 0);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Size = new System.Drawing.Size(100, 25);
			this.toolStrip2.TabIndex = 0;
			// 
			// legend1
			// 
			this.legend1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
			this.legend1.Location = new System.Drawing.Point(480, 32);
			this.legend1.Name = "legend1";
			this.legend1.Size = new System.Drawing.Size(705, 19);
			this.legend1.TabIndex = 77;
			// 
			// regionL
			// 
			this.regionL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.regionL.Dock = System.Windows.Forms.DockStyle.Fill;
			this.regionL.Location = new System.Drawing.Point(3, 3);
			this.regionL.MinimumSize = new System.Drawing.Size(258, 297);
			this.regionL.Name = "regionL";
			this.regionL.Size = new System.Drawing.Size(581, 601);
			this.regionL.TabIndex = 0;
			this.regionL.Title = "Title";
			// 
			// regionR
			// 
			this.regionR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.regionR.Dock = System.Windows.Forms.DockStyle.Fill;
			this.regionR.Location = new System.Drawing.Point(590, 3);
			this.regionR.MinimumSize = new System.Drawing.Size(258, 297);
			this.regionR.Name = "regionR";
			this.regionR.Size = new System.Drawing.Size(582, 601);
			this.regionR.TabIndex = 1;
			this.regionR.Title = "Title";
			// 
			// xySIR
			// 
			this.xySIR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.xySIR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.xySIR.Location = new System.Drawing.Point(5, 5);
			this.xySIR.Name = "xySIR";
			this.xySIR.Size = new System.Drawing.Size(1119, 621);
			this.xySIR.TabIndex = 0;
			// 
			// xyDSIR
			// 
			this.xyDSIR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.xyDSIR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.xyDSIR.Location = new System.Drawing.Point(5, 5);
			this.xyDSIR.Name = "xyDSIR";
			this.xyDSIR.Size = new System.Drawing.Size(1119, 621);
			this.xyDSIR.TabIndex = 1;
			// 
			// xyContaminated
			// 
			this.xyContaminated.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.xyContaminated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.xyContaminated.Location = new System.Drawing.Point(5, 5);
			this.xyContaminated.Name = "xyContaminated";
			this.xyContaminated.Size = new System.Drawing.Size(1119, 621);
			this.xyContaminated.TabIndex = 0;
			// 
			// xyPerformances
			// 
			this.xyPerformances.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.xyPerformances.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.xyPerformances.Location = new System.Drawing.Point(5, 5);
			this.xyPerformances.Name = "xyPerformances";
			this.xyPerformances.Size = new System.Drawing.Size(1119, 621);
			this.xyPerformances.TabIndex = 0;
			// 
			// Spread
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1193, 691);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.legend1);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.toolStrip1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(1150, 730);
			this.Name = "Spread";
			this.Text = "Spread";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Spread_FormClosing);
			this.Load += new System.EventHandler(this.Spread_Load);
			this.Click += new System.EventHandler(this.Spread_Click);
			this.Resize += new System.EventHandler(this.Spread_Resize);
			this.tabControl1.ResumeLayout(false);
			this.tabRegion.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tabSIR.ResumeLayout(false);
			this.tabDSIR.ResumeLayout(false);
			this.tabContaminated.ResumeLayout(false);
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
		private System.Windows.Forms.TabPage tabRegion;
		private System.Windows.Forms.TabPage tabSIR;
		private XY xySIR;
		private System.Windows.Forms.TabPage tabContaminated;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tsbReplay;
		private System.Windows.Forms.ToolStripButton tsbPlay;
		private System.Windows.Forms.ToolStripButton tsbPause;
		private System.Windows.Forms.ToolStripButton tsbNew;
		private XY xyContaminated;
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
		private System.Windows.Forms.TabPage tabPerformances;
		private XY xyPerformances;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private UC.Region regionL;
		private UC.Region regionR;
		private System.Windows.Forms.TabPage tabDSIR;
		private XY xyDSIR;
		private System.Windows.Forms.ToolStrip toolStrip2;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
		private System.Windows.Forms.ToolStripStatusLabel tsPeople;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
		private System.Windows.Forms.ToolStripStatusLabel tsIsolation;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripMenuItem SnapshotForm;
		private System.Windows.Forms.ToolStripMenuItem SnapshotDiagram;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem SnapshotDirectory;
		private UC.Legend legend1;
		private System.Windows.Forms.ToolStripButton tsbPerson;
		private System.Windows.Forms.ToolStripButton tsbInfection;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
	}
}