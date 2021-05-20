namespace CoViD.GUI.Forms

{
	partial class MFI
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MFI));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tabs = new System.Windows.Forms.TabControl();
			this.tabInfection = new System.Windows.Forms.TabPage();
			this.tabPerson = new System.Windows.Forms.TabPage();
			this.tabSpread = new System.Windows.Forms.TabPage();
			this.panel1.SuspendLayout();
			this.tabs.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.toolStrip1.CanOverflow = false;
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip1.Size = new System.Drawing.Size(1018, 25);
			this.toolStrip1.TabIndex = 4;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.tabs);
			this.panel1.Location = new System.Drawing.Point(2, 27);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1016, 572);
			this.panel1.TabIndex = 5;
			// 
			// tabs
			// 
			this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabs.Controls.Add(this.tabInfection);
			this.tabs.Controls.Add(this.tabPerson);
			this.tabs.Controls.Add(this.tabSpread);
			this.tabs.Location = new System.Drawing.Point(0, 0);
			this.tabs.Name = "tabs";
			this.tabs.SelectedIndex = 0;
			this.tabs.Size = new System.Drawing.Size(1016, 572);
			this.tabs.TabIndex = 0;
			this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabs_SelectedIndexChanged);
			// 
			// tabInfection
			// 
			this.tabInfection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.tabInfection.Location = new System.Drawing.Point(4, 22);
			this.tabInfection.Name = "tabInfection";
			this.tabInfection.Padding = new System.Windows.Forms.Padding(3);
			this.tabInfection.Size = new System.Drawing.Size(1008, 546);
			this.tabInfection.TabIndex = 0;
			this.tabInfection.Text = "Infection";
			// 
			// tabPerson
			// 
			this.tabPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.tabPerson.Location = new System.Drawing.Point(4, 22);
			this.tabPerson.Name = "tabPerson";
			this.tabPerson.Padding = new System.Windows.Forms.Padding(3);
			this.tabPerson.Size = new System.Drawing.Size(1008, 546);
			this.tabPerson.TabIndex = 1;
			this.tabPerson.Text = "Person";
			// 
			// tabSpread
			// 
			this.tabSpread.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.tabSpread.Location = new System.Drawing.Point(4, 22);
			this.tabSpread.Name = "tabSpread";
			this.tabSpread.Size = new System.Drawing.Size(1008, 546);
			this.tabSpread.TabIndex = 2;
			this.tabSpread.Text = "Spread";
			// 
			// MFI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1018, 601);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.toolStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Name = "MFI";
			this.Text = "MFI";
			this.panel1.ResumeLayout(false);
			this.tabs.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TabControl tabs;
		private System.Windows.Forms.TabPage tabInfection;
		private System.Windows.Forms.TabPage tabPerson;
		private System.Windows.Forms.TabPage tabSpread;
	}
}