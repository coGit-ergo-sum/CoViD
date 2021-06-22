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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
			this.mniOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.OpenFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabINI = new System.Windows.Forms.TabControl();
			this.tabCoViD = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.tabGUI = new System.Windows.Forms.TabPage();
			this.txtINIGUI = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.udTicks = new CoViD.GUI.UC.UpDown();
			this.udSegregation = new CoViD.GUI.UC.UpDown();
			this.udSteps = new CoViD.GUI.UC.UpDown();
			this.udPeople = new CoViD.GUI.UC.UpDown();
			this.udRadius = new CoViD.GUI.UC.UpDown();
			this.menuStrip1.SuspendLayout();
			this.tabINI.SuspendLayout();
			this.tabCoViD.SuspendLayout();
			this.tabGUI.SuspendLayout();
			this.SuspendLayout();
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
            this.mniOpen,
            this.OpenFolderToolStripMenuItem});
			this.mniFile.Name = "mniFile";
			this.mniFile.Size = new System.Drawing.Size(37, 20);
			this.mniFile.Text = "File";
			// 
			// mniOpen
			// 
			this.mniOpen.Name = "mniOpen";
			this.mniOpen.Size = new System.Drawing.Size(137, 22);
			this.mniOpen.Text = "Open file";
			this.mniOpen.Click += new System.EventHandler(this.mniOpen_Click);
			// 
			// OpenFolderToolStripMenuItem
			// 
			this.OpenFolderToolStripMenuItem.Name = "OpenFolderToolStripMenuItem";
			this.OpenFolderToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.OpenFolderToolStripMenuItem.Text = "Open folder";
			// 
			// tabINI
			// 
			this.tabINI.Controls.Add(this.tabCoViD);
			this.tabINI.Controls.Add(this.tabGUI);
			this.tabINI.Location = new System.Drawing.Point(0, 27);
			this.tabINI.Name = "tabINI";
			this.tabINI.SelectedIndex = 0;
			this.tabINI.Size = new System.Drawing.Size(568, 424);
			this.tabINI.TabIndex = 81;
			this.tabINI.SelectedIndexChanged += new System.EventHandler(this.tabINI_SelectedIndexChanged);
			// 
			// tabCoViD
			// 
			this.tabCoViD.Controls.Add(this.label1);
			this.tabCoViD.Controls.Add(this.udTicks);
			this.tabCoViD.Controls.Add(this.udSegregation);
			this.tabCoViD.Controls.Add(this.udSteps);
			this.tabCoViD.Controls.Add(this.udPeople);
			this.tabCoViD.Controls.Add(this.udRadius);
			this.tabCoViD.Location = new System.Drawing.Point(4, 22);
			this.tabCoViD.Name = "tabCoViD";
			this.tabCoViD.Padding = new System.Windows.Forms.Padding(3);
			this.tabCoViD.Size = new System.Drawing.Size(560, 398);
			this.tabCoViD.TabIndex = 0;
			this.tabCoViD.Text = "CoViD";
			this.tabCoViD.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(225, 13);
			this.label1.TabIndex = 85;
			this.label1.Text = "Settings for the spread simulation of the CoViD";
			// 
			// tabGUI
			// 
			this.tabGUI.Controls.Add(this.txtINIGUI);
			this.tabGUI.Controls.Add(this.label2);
			this.tabGUI.Location = new System.Drawing.Point(4, 22);
			this.tabGUI.Name = "tabGUI";
			this.tabGUI.Padding = new System.Windows.Forms.Padding(3);
			this.tabGUI.Size = new System.Drawing.Size(560, 398);
			this.tabGUI.TabIndex = 1;
			this.tabGUI.Text = "GUI";
			this.tabGUI.UseVisualStyleBackColor = true;
			// 
			// txtINIGUI
			// 
			this.txtINIGUI.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtINIGUI.Location = new System.Drawing.Point(1, 22);
			this.txtINIGUI.Multiline = true;
			this.txtINIGUI.Name = "txtINIGUI";
			this.txtINIGUI.Size = new System.Drawing.Size(557, 375);
			this.txtINIGUI.TabIndex = 87;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(135, 13);
			this.label2.TabIndex = 86;
			this.label2.Text = "Settings for the application.";
			// 
			// btnOk
			// 
			this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.Location = new System.Drawing.Point(509, 457);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(53, 33);
			this.btnOk.TabIndex = 82;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(391, 457);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(112, 33);
			this.btnCancel.TabIndex = 83;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// udTicks
			// 
			this.udTicks.Caption = "Ticks";
			this.udTicks.Decimals = ((sbyte)(0));
			this.udTicks.Location = new System.Drawing.Point(23, 197);
			this.udTicks.MaximumSize = new System.Drawing.Size(335, 45);
			this.udTicks.MinimumSize = new System.Drawing.Size(162, 45);
			this.udTicks.Name = "udTicks";
			this.udTicks.Size = new System.Drawing.Size(227, 45);
			this.udTicks.TabIndex = 84;
			this.udTicks.Value = new decimal(new int[] {
            25000,
            0,
            0,
            0});
			// 
			// udSegregation
			// 
			this.udSegregation.Caption = "Segregation %";
			this.udSegregation.Decimals = ((sbyte)(0));
			this.udSegregation.Location = new System.Drawing.Point(24, 248);
			this.udSegregation.MaximumSize = new System.Drawing.Size(335, 45);
			this.udSegregation.MinimumSize = new System.Drawing.Size(162, 45);
			this.udSegregation.Name = "udSegregation";
			this.udSegregation.Size = new System.Drawing.Size(226, 45);
			this.udSegregation.TabIndex = 83;
			this.udSegregation.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			// 
			// udSteps
			// 
			this.udSteps.Caption = "Steps";
			this.udSteps.Decimals = ((sbyte)(0));
			this.udSteps.Location = new System.Drawing.Point(23, 146);
			this.udSteps.MaximumSize = new System.Drawing.Size(335, 45);
			this.udSteps.MinimumSize = new System.Drawing.Size(162, 45);
			this.udSteps.Name = "udSteps";
			this.udSteps.Size = new System.Drawing.Size(227, 45);
			this.udSteps.TabIndex = 82;
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
			this.udPeople.Location = new System.Drawing.Point(23, 44);
			this.udPeople.MaximumSize = new System.Drawing.Size(335, 45);
			this.udPeople.MinimumSize = new System.Drawing.Size(162, 45);
			this.udPeople.Name = "udPeople";
			this.udPeople.Size = new System.Drawing.Size(226, 45);
			this.udPeople.TabIndex = 81;
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
			this.udRadius.Location = new System.Drawing.Point(22, 95);
			this.udRadius.MaximumSize = new System.Drawing.Size(335, 45);
			this.udRadius.MinimumSize = new System.Drawing.Size(162, 45);
			this.udRadius.Name = "udRadius";
			this.udRadius.Size = new System.Drawing.Size(227, 45);
			this.udRadius.TabIndex = 80;
			this.udRadius.Value = new decimal(new int[] {
            12000,
            0,
            0,
            0});
			// 
			// Settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(568, 502);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.tabINI);
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
			this.tabINI.ResumeLayout(false);
			this.tabCoViD.ResumeLayout(false);
			this.tabCoViD.PerformLayout();
			this.tabGUI.ResumeLayout(false);
			this.tabGUI.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem mniFile;
		private System.Windows.Forms.ToolStripMenuItem mniOpen;
		private System.Windows.Forms.TabControl tabINI;
		private System.Windows.Forms.TabPage tabCoViD;
		private UC.UpDown udTicks;
		private UC.UpDown udSegregation;
		private UC.UpDown udSteps;
		private UC.UpDown udPeople;
		private UC.UpDown udRadius;
		private System.Windows.Forms.TabPage tabGUI;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.ToolStripMenuItem OpenFolderToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtINIGUI;
	}
}