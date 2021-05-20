namespace CoViD.GUI
{
	partial class Form1
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.grid1 = new CoViD.GUI.UC.Grid();
			this.legend1 = new CoViD.GUI.UC.Legend();
			this.toolStrip1 = new CoViD.GUI.UC.ToolStrip();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(12, 37);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
			this.checkBox1.BackColor = System.Drawing.Color.DarkRed;
			this.checkBox1.Location = new System.Drawing.Point(16, 161);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(23, 24);
			this.checkBox1.TabIndex = 3;
			this.checkBox1.UseVisualStyleBackColor = false;
			// 
			// grid1
			// 
			this.grid1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.grid1.Label = "Title";
			this.grid1.Location = new System.Drawing.Point(216, 4);
			this.grid1.MinimumSize = new System.Drawing.Size(458, 497);
			this.grid1.Name = "grid1";
			this.grid1.Size = new System.Drawing.Size(529, 531);
			this.grid1.TabIndex = 0;
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
			this.legend1.Location = new System.Drawing.Point(33, 549);
			this.legend1.Name = "legend1";
			this.legend1.Size = new System.Drawing.Size(771, 21);
			this.legend1.TabIndex = 4;
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
			this.toolStrip1.Location = new System.Drawing.Point(62, 586);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(215, 27);
			this.toolStrip1.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(871, 636);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.legend1);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.grid1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private UC.Grid grid1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.CheckBox checkBox1;
		private UC.Legend legend1;
		private UC.ToolStrip toolStrip1;
	}
}