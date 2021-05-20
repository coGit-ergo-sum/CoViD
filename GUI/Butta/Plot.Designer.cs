namespace CoViD.GUI
{
	partial class Plot
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnPeople = new System.Windows.Forms.Button();
			this.btnContamination = new System.Windows.Forms.Button();
			this.btnInitialize = new System.Windows.Forms.Button();
			this.btnTick = new System.Windows.Forms.Button();
			this.btnInfected = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(81, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1067, 791);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// btnPeople
			// 
			this.btnPeople.Location = new System.Drawing.Point(1, 125);
			this.btnPeople.Name = "btnPeople";
			this.btnPeople.Size = new System.Drawing.Size(75, 23);
			this.btnPeople.TabIndex = 6;
			this.btnPeople.Text = "People";
			this.btnPeople.UseVisualStyleBackColor = true;
			this.btnPeople.Click += new System.EventHandler(this.btnPeople_Click);
			// 
			// btnContamination
			// 
			this.btnContamination.Location = new System.Drawing.Point(1, 154);
			this.btnContamination.Name = "btnContamination";
			this.btnContamination.Size = new System.Drawing.Size(75, 23);
			this.btnContamination.TabIndex = 7;
			this.btnContamination.Text = "Contamination";
			this.btnContamination.UseVisualStyleBackColor = true;
			this.btnContamination.Click += new System.EventHandler(this.btnContamination_Click);
			// 
			// btnInitialize
			// 
			this.btnInitialize.Location = new System.Drawing.Point(2, 5);
			this.btnInitialize.Name = "btnInitialize";
			this.btnInitialize.Size = new System.Drawing.Size(75, 23);
			this.btnInitialize.TabIndex = 10;
			this.btnInitialize.Text = "Initialize";
			this.btnInitialize.UseVisualStyleBackColor = true;
			this.btnInitialize.Click += new System.EventHandler(this.btnInitialize_Click);
			// 
			// btnTick
			// 
			this.btnTick.Location = new System.Drawing.Point(2, 34);
			this.btnTick.Name = "btnTick";
			this.btnTick.Size = new System.Drawing.Size(75, 23);
			this.btnTick.TabIndex = 11;
			this.btnTick.Text = "Tick";
			this.btnTick.UseVisualStyleBackColor = true;
			this.btnTick.Click += new System.EventHandler(this.btnTick_Click);
			// 
			// btnInfected
			// 
			this.btnInfected.Location = new System.Drawing.Point(0, 183);
			this.btnInfected.Name = "btnInfected";
			this.btnInfected.Size = new System.Drawing.Size(75, 23);
			this.btnInfected.TabIndex = 12;
			this.btnInfected.Text = "Infected";
			this.btnInfected.UseVisualStyleBackColor = true;
			this.btnInfected.Click += new System.EventHandler(this.btnInfected_Click);
			// 
			// Plot
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1151, 792);
			this.Controls.Add(this.btnInfected);
			this.Controls.Add(this.btnTick);
			this.Controls.Add(this.btnInitialize);
			this.Controls.Add(this.btnContamination);
			this.Controls.Add(this.btnPeople);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Plot";
			this.Text = "Plot";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnPeople;
		private System.Windows.Forms.Button btnContamination;
		private System.Windows.Forms.Button btnInitialize;
		private System.Windows.Forms.Button btnTick;
		private System.Windows.Forms.Button btnInfected;
	}
}