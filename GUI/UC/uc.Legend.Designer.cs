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
			this.itmSusceptible = new CoViD.GUI.UC.Item();
			this.itmLatency = new CoViD.GUI.UC.Item();
			this.itmIll = new CoViD.GUI.UC.Item();
			this.itmSevere = new CoViD.GUI.UC.Item();
			this.itmConvalescent = new CoViD.GUI.UC.Item();
			this.itmImmune = new CoViD.GUI.UC.Item();
			this.itmDead = new CoViD.GUI.UC.Item();
			this.itmInfected = new CoViD.GUI.UC.Item();
			this.itmRecovered = new CoViD.GUI.UC.Item();
			this.SuspendLayout();
			// 
			// itmSusceptible
			// 
			this.itmSusceptible.CheckBox = true;
			this.itmSusceptible.Checked = true;
			this.itmSusceptible.Location = new System.Drawing.Point(8, 0);
			this.itmSusceptible.Name = "itmSusceptible";
			this.itmSusceptible.Size = new System.Drawing.Size(97, 14);
			this.itmSusceptible.TabIndex = 0;
			// 
			// itmLatency
			// 
			this.itmLatency.CheckBox = true;
			this.itmLatency.Checked = true;
			this.itmLatency.Location = new System.Drawing.Point(161, 0);
			this.itmLatency.Name = "itmLatency";
			this.itmLatency.Size = new System.Drawing.Size(92, 14);
			this.itmLatency.TabIndex = 1;
			// 
			// itmIll
			// 
			this.itmIll.CheckBox = true;
			this.itmIll.Checked = true;
			this.itmIll.Location = new System.Drawing.Point(260, 0);
			this.itmIll.Name = "itmIll";
			this.itmIll.Size = new System.Drawing.Size(49, 14);
			this.itmIll.TabIndex = 2;
			// 
			// itmSevere
			// 
			this.itmSevere.CheckBox = true;
			this.itmSevere.Checked = true;
			this.itmSevere.Location = new System.Drawing.Point(321, 0);
			this.itmSevere.Name = "itmSevere";
			this.itmSevere.Size = new System.Drawing.Size(76, 14);
			this.itmSevere.TabIndex = 3;
			// 
			// itmConvalescent
			// 
			this.itmConvalescent.CheckBox = true;
			this.itmConvalescent.Checked = true;
			this.itmConvalescent.Location = new System.Drawing.Point(402, 0);
			this.itmConvalescent.Name = "itmConvalescent";
			this.itmConvalescent.Size = new System.Drawing.Size(107, 14);
			this.itmConvalescent.TabIndex = 4;
			// 
			// itmImmune
			// 
			this.itmImmune.CheckBox = true;
			this.itmImmune.Checked = true;
			this.itmImmune.Location = new System.Drawing.Point(555, 0);
			this.itmImmune.Name = "itmImmune";
			this.itmImmune.Size = new System.Drawing.Size(79, 14);
			this.itmImmune.TabIndex = 5;
			// 
			// itmDead
			// 
			this.itmDead.CheckBox = true;
			this.itmDead.Checked = true;
			this.itmDead.Location = new System.Drawing.Point(642, 0);
			this.itmDead.Name = "itmDead";
			this.itmDead.Size = new System.Drawing.Size(68, 14);
			this.itmDead.TabIndex = 6;
			// 
			// itmInfected
			// 
			this.itmInfected.CheckBox = true;
			this.itmInfected.Checked = true;
			this.itmInfected.Location = new System.Drawing.Point(98, 0);
			this.itmInfected.Name = "itmInfected";
			this.itmInfected.Size = new System.Drawing.Size(47, 14);
			this.itmInfected.TabIndex = 7;
			// 
			// itmRecovered
			// 
			this.itmRecovered.CheckBox = true;
			this.itmRecovered.Checked = true;
			this.itmRecovered.Location = new System.Drawing.Point(486, 0);
			this.itmRecovered.Name = "itmRecovered";
			this.itmRecovered.Size = new System.Drawing.Size(49, 14);
			this.itmRecovered.TabIndex = 8;
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
			this.Size = new System.Drawing.Size(721, 15);
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
