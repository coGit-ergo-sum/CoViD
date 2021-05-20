namespace CoViD.GUI.Forms
{
	partial class Persona
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
			this.area2 = new CoViD.GUI.UC.Area();
			this.area1 = new CoViD.GUI.UC.Area();
			this.xy1 = new CoViD.GUI.XY();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// area2
			// 
			this.area2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.area2.Label = "Title";
			this.area2.Location = new System.Drawing.Point(471, 291);
			this.area2.MinimumSize = new System.Drawing.Size(458, 497);
			this.area2.Name = "area2";
			this.area2.Size = new System.Drawing.Size(458, 497);
			this.area2.TabIndex = 1;
			// 
			// area1
			// 
			this.area1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.area1.Label = "Title";
			this.area1.Location = new System.Drawing.Point(7, 291);
			this.area1.MinimumSize = new System.Drawing.Size(458, 497);
			this.area1.Name = "area1";
			this.area1.Size = new System.Drawing.Size(458, 497);
			this.area1.TabIndex = 0;
			// 
			// xy1
			// 
			this.xy1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.xy1.Location = new System.Drawing.Point(7, 66);
			this.xy1.Name = "xy1";
			this.xy1.Size = new System.Drawing.Size(922, 218);
			this.xy1.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(7, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(95, 29);
			this.button1.TabIndex = 4;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Persona
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(938, 796);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.xy1);
			this.Controls.Add(this.area2);
			this.Controls.Add(this.area1);
			this.Name = "Persona";
			this.Text = "Persona";
			this.ResumeLayout(false);

		}

		#endregion

		private UC.Area area1;
		private UC.Area area2;
		private XY xy1;
		private System.Windows.Forms.Button button1;
	}
}