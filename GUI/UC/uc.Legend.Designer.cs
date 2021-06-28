namespace CoViD.GUI.UC
{
	partial class Legend
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
			this.itmRecovered = new CoViD.GUI.UC.Item();
			this.itmInfected = new CoViD.GUI.UC.Item();
			this.itmDead = new CoViD.GUI.UC.Item();
			this.itmImmune = new CoViD.GUI.UC.Item();
			this.itmConvalescent = new CoViD.GUI.UC.Item();
			this.itmSevere = new CoViD.GUI.UC.Item();
			this.itmIll = new CoViD.GUI.UC.Item();
			this.itmLatency = new CoViD.GUI.UC.Item();
			this.itmSusceptible = new CoViD.GUI.UC.Item();
			this.SuspendLayout();
			// 
			// itmRecovered
			// 
			this.itmRecovered.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.itmRecovered.CheckBox = true;
			this.itmRecovered.Checked = true;
			this.itmRecovered.Color = System.Drawing.SystemColors.Control;
			this.itmRecovered.Location = new System.Drawing.Point(486, 0);
			this.itmRecovered.Name = "itmRecovered";
			this.itmRecovered.Size = new System.Drawing.Size(49, 16);
			this.itmRecovered.TabIndex = 8;
			this.itmRecovered.TooltipText = "The person Recoverd  (The \'R\' in the SIR model)";
			// 
			// itmInfected
			// 
			this.itmInfected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.itmInfected.CheckBox = true;
			this.itmInfected.Checked = true;
			this.itmInfected.Color = System.Drawing.SystemColors.Control;
			this.itmInfected.Location = new System.Drawing.Point(98, 0);
			this.itmInfected.Name = "itmInfected";
			this.itmInfected.Size = new System.Drawing.Size(47, 16);
			this.itmInfected.TabIndex = 7;
			this.itmInfected.TooltipText = "Infected by the virus. (The \'I\' in the SIR model)";
			// 
			// itmDead
			// 
			this.itmDead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.itmDead.CheckBox = true;
			this.itmDead.Checked = true;
			this.itmDead.Color = System.Drawing.SystemColors.Control;
			this.itmDead.Location = new System.Drawing.Point(642, 0);
			this.itmDead.Name = "itmDead";
			this.itmDead.Size = new System.Drawing.Size(68, 16);
			this.itmDead.TabIndex = 6;
			this.itmDead.TooltipText = "The disease killed the person.";
			// 
			// itmImmune
			// 
			this.itmImmune.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.itmImmune.CheckBox = true;
			this.itmImmune.Checked = true;
			this.itmImmune.Color = System.Drawing.SystemColors.Control;
			this.itmImmune.Location = new System.Drawing.Point(555, 0);
			this.itmImmune.Name = "itmImmune";
			this.itmImmune.Size = new System.Drawing.Size(79, 16);
			this.itmImmune.TabIndex = 5;
			this.itmImmune.TooltipText = "The person recoverd alive from the disease.";
			// 
			// itmConvalescent
			// 
			this.itmConvalescent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.itmConvalescent.CheckBox = true;
			this.itmConvalescent.Checked = true;
			this.itmConvalescent.Color = System.Drawing.SystemColors.Control;
			this.itmConvalescent.Location = new System.Drawing.Point(402, 0);
			this.itmConvalescent.Name = "itmConvalescent";
			this.itmConvalescent.Size = new System.Drawing.Size(107, 16);
			this.itmConvalescent.TabIndex = 4;
			this.itmConvalescent.TooltipText = "This state begins immediately after the peak of the disease.";
			// 
			// itmSevere
			// 
			this.itmSevere.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.itmSevere.CheckBox = true;
			this.itmSevere.Checked = true;
			this.itmSevere.Color = System.Drawing.SystemColors.Control;
			this.itmSevere.Location = new System.Drawing.Point(321, 0);
			this.itmSevere.Name = "itmSevere";
			this.itmSevere.Size = new System.Drawing.Size(76, 16);
			this.itmSevere.TabIndex = 3;
			this.itmSevere.TooltipText = "The person needs to go to the hospital";
			// 
			// itmIll
			// 
			this.itmIll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.itmIll.CheckBox = true;
			this.itmIll.Checked = true;
			this.itmIll.Color = System.Drawing.SystemColors.Control;
			this.itmIll.Location = new System.Drawing.Point(260, 0);
			this.itmIll.Name = "itmIll";
			this.itmIll.Size = new System.Drawing.Size(49, 16);
			this.itmIll.TabIndex = 2;
			this.itmIll.TooltipText = "A person is considered \'Ill\' when get the infection and the \'Latency period elaps" +
    "ed. Infected people are contagious.";
			// 
			// itmLatency
			// 
			this.itmLatency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.itmLatency.CheckBox = true;
			this.itmLatency.Checked = true;
			this.itmLatency.Color = System.Drawing.SystemColors.Control;
			this.itmLatency.Location = new System.Drawing.Point(161, 0);
			this.itmLatency.Name = "itmLatency";
			this.itmLatency.Size = new System.Drawing.Size(92, 16);
			this.itmLatency.TabIndex = 1;
			this.itmLatency.TooltipText = "The \'Latency period\' is when a person get infected but not yet contagious.";
			// 
			// itmSusceptible
			// 
			this.itmSusceptible.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.itmSusceptible.CheckBox = true;
			this.itmSusceptible.Checked = true;
			this.itmSusceptible.Color = System.Drawing.SystemColors.Control;
			this.itmSusceptible.Location = new System.Drawing.Point(8, 0);
			this.itmSusceptible.Name = "itmSusceptible";
			this.itmSusceptible.Size = new System.Drawing.Size(97, 16);
			this.itmSusceptible.TabIndex = 0;
			this.itmSusceptible.TooltipText = "Person susceptibles (that can be infected. The \'S\' in the SIR model.)";
			// 
			// Legend
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.Controls.Add(this.itmRecovered);
			this.Controls.Add(this.itmInfected);
			this.Controls.Add(this.itmDead);
			this.Controls.Add(this.itmImmune);
			this.Controls.Add(this.itmConvalescent);
			this.Controls.Add(this.itmSevere);
			this.Controls.Add(this.itmIll);
			this.Controls.Add(this.itmLatency);
			this.Controls.Add(this.itmSusceptible);
			this.Name = "Legend";
			this.Size = new System.Drawing.Size(721, 16);
			this.ResumeLayout(false);

		}

		#endregion

		private Item itmSusceptible;
		private Item itmLatency;
		private Item itmIll;
		private Item itmSevere;
		private Item itmConvalescent;
		private Item itmImmune;
		private Item itmDead;
		private Item itmInfected;
		private Item itmRecovered;
	}
}
