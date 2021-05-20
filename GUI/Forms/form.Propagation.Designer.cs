namespace CoViD.GUI.Forms
{
	partial class Propagation
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.area1 = new CoViD.GUI.UC.Area();
			this.upDown1 = new CoViD.GUI.UC.UpDown();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.button1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(479, 100);
			this.panel1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.button1.Location = new System.Drawing.Point(12, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(83, 26);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.Control;
			this.panel2.Controls.Add(this.upDown1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(786, 49);
			this.panel2.TabIndex = 1;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(0, 0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// area1
			// 
			this.area1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.area1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.area1.Label = "Title";
			this.area1.Location = new System.Drawing.Point(0, 97);
			this.area1.MinimumSize = new System.Drawing.Size(458, 497);
			this.area1.Name = "area1";
			this.area1.Size = new System.Drawing.Size(786, 746);
			this.area1.TabIndex = 2;
			// 
			// upDown1
			// 
			this.upDown1.Caption = "Caption";
			this.upDown1.Decimals = ((sbyte)(0));
			this.upDown1.Location = new System.Drawing.Point(162, 0);
			this.upDown1.MaximumSize = new System.Drawing.Size(335, 45);
			this.upDown1.MinimumSize = new System.Drawing.Size(162, 45);
			this.upDown1.Name = "upDown1";
			this.upDown1.Size = new System.Drawing.Size(162, 45);
			this.upDown1.TabIndex = 0;
			this.upDown1.Value = 0F;
			// 
			// Propagation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(786, 845);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.area1);
			this.Controls.Add(this.panel2);
			this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.HelpButton = true;
			this.Name = "Propagation";
			this.Text = "Propagation";
			this.Load += new System.EventHandler(this.Propagation_Load);
			this.Resize += new System.EventHandler(this.Propagation_Resize);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private UC.Area ground1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel2;
		private UC.Area area1;
		private System.Windows.Forms.Button button2;
		private UC.UpDown upDown1;
	}
}