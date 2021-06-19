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
			this.SuspendLayout();
			// 
			// udTicks
			// 
			this.udTicks.Caption = "Ticks";
			this.udTicks.Decimals = ((sbyte)(0));
			this.udTicks.Location = new System.Drawing.Point(12, 175);
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
			this.udTicks.Visible = false;
			// 
			// udSegregationThreshold
			// 
			this.udSegregationThreshold.Caption = "Segregation %";
			this.udSegregationThreshold.Decimals = ((sbyte)(0));
			this.udSegregationThreshold.Location = new System.Drawing.Point(13, 226);
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
			this.udSegregationThreshold.Visible = false;
			// 
			// udSteps
			// 
			this.udSteps.Caption = "Steps";
			this.udSteps.Decimals = ((sbyte)(0));
			this.udSteps.Location = new System.Drawing.Point(12, 124);
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
			this.udSteps.Visible = false;
			// 
			// udPeople
			// 
			this.udPeople.Caption = "People";
			this.udPeople.Decimals = ((sbyte)(0));
			this.Location = new System.Drawing.Point(13, 73);
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
			this.udPeople.Visible = false;
			// 
			// udRadius
			// 
			this.udRadius.Caption = "Radius";
			this.udRadius.Decimals = ((sbyte)(0));
			this.udRadius.Location = new System.Drawing.Point(12, 22);
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
			this.udRadius.Visible = false;
			// 
			// Settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(556, 378);
			this.Controls.Add(this.udTicks);
			this.Controls.Add(this.udSegregationThreshold);
			this.Controls.Add(this.udSteps);
			this.Controls.Add(this.udPeople);
			this.Controls.Add(this.udRadius);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Settings";
			this.Text = "form";
			this.ResumeLayout(false);

		}

		#endregion

		private UC.UpDown udTicks;
		private UC.UpDown udSegregationThreshold;
		private UC.UpDown udSteps;
		private UC.UpDown udPeople;
		private UC.UpDown udRadius;
	}
}