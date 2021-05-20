namespace CoViD.GUI.UC
{
	partial class Led
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
			this.pnlLed = new System.Windows.Forms.Panel();
			this.lblText = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// pnlLed
			// 
			this.pnlLed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.pnlLed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pnlLed.Location = new System.Drawing.Point(3, 3);
			this.pnlLed.Name = "pnlLed";
			this.pnlLed.Padding = new System.Windows.Forms.Padding(1);
			this.pnlLed.Size = new System.Drawing.Size(14, 12);
			this.pnlLed.TabIndex = 0;
			// 
			// lblText
			// 
			this.lblText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblText.Location = new System.Drawing.Point(28, 3);
			this.lblText.Name = "lblText";
			this.lblText.Size = new System.Drawing.Size(85, 16);
			this.lblText.TabIndex = 1;
			this.lblText.Text = "label1";
			// 
			// Led
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Controls.Add(this.lblText);
			this.Controls.Add(this.pnlLed);
			this.DoubleBuffered = true;
			this.MaximumSize = new System.Drawing.Size(381, 22);
			this.MinimumSize = new System.Drawing.Size(22, 22);
			this.Name = "Led";
			this.Size = new System.Drawing.Size(117, 22);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlLed;
		private System.Windows.Forms.Label lblText;
	}
}
