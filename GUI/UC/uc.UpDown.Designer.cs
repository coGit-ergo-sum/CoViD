namespace CoViD.GUI.UC
{
	partial class UpDown
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
			this.lblValue = new System.Windows.Forms.Label();
			this.btnPlus100 = new System.Windows.Forms.Button();
			this.btnMinus100 = new System.Windows.Forms.Button();
			this.btnPlus10 = new System.Windows.Forms.Button();
			this.btnMinus10 = new System.Windows.Forms.Button();
			this.lblCaption = new System.Windows.Forms.Label();
			this.btnPlus1 = new System.Windows.Forms.Button();
			this.btnMinus1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblValue
			// 
			this.lblValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblValue.BackColor = System.Drawing.SystemColors.Control;
			this.lblValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblValue.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblValue.Location = new System.Drawing.Point(67, 19);
			this.lblValue.Name = "lblValue";
			this.lblValue.Size = new System.Drawing.Size(27, 20);
			this.lblValue.TabIndex = 69;
			this.lblValue.Text = "0";
			this.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnPlus100
			// 
			this.btnPlus100.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPlus100.Location = new System.Drawing.Point(136, 18);
			this.btnPlus100.Name = "btnPlus100";
			this.btnPlus100.Size = new System.Drawing.Size(22, 22);
			this.btnPlus100.TabIndex = 68;
			this.btnPlus100.Text = "+";
			this.btnPlus100.UseVisualStyleBackColor = true;
			// 
			// btnMinus100
			// 
			this.btnMinus100.Location = new System.Drawing.Point(3, 18);
			this.btnMinus100.Name = "btnMinus100";
			this.btnMinus100.Size = new System.Drawing.Size(22, 22);
			this.btnMinus100.TabIndex = 67;
			this.btnMinus100.Text = "-";
			this.btnMinus100.UseVisualStyleBackColor = true;
			// 
			// btnPlus10
			// 
			this.btnPlus10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPlus10.Location = new System.Drawing.Point(115, 18);
			this.btnPlus10.Name = "btnPlus10";
			this.btnPlus10.Size = new System.Drawing.Size(22, 22);
			this.btnPlus10.TabIndex = 66;
			this.btnPlus10.Text = "+";
			this.btnPlus10.UseVisualStyleBackColor = true;
			// 
			// btnMinus10
			// 
			this.btnMinus10.Location = new System.Drawing.Point(24, 18);
			this.btnMinus10.Name = "btnMinus10";
			this.btnMinus10.Size = new System.Drawing.Size(22, 22);
			this.btnMinus10.TabIndex = 65;
			this.btnMinus10.Text = "-";
			this.btnMinus10.UseVisualStyleBackColor = true;
			// 
			// lblCaption
			// 
			this.lblCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblCaption.Location = new System.Drawing.Point(4, 2);
			this.lblCaption.Name = "lblCaption";
			this.lblCaption.Size = new System.Drawing.Size(154, 13);
			this.lblCaption.TabIndex = 64;
			this.lblCaption.Text = "Caption";
			this.lblCaption.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnPlus1
			// 
			this.btnPlus1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPlus1.Location = new System.Drawing.Point(94, 18);
			this.btnPlus1.Name = "btnPlus1";
			this.btnPlus1.Size = new System.Drawing.Size(22, 22);
			this.btnPlus1.TabIndex = 63;
			this.btnPlus1.Text = "+";
			this.btnPlus1.UseVisualStyleBackColor = true;
			// 
			// btnMinus1
			// 
			this.btnMinus1.Location = new System.Drawing.Point(45, 18);
			this.btnMinus1.Name = "btnMinus1";
			this.btnMinus1.Size = new System.Drawing.Size(22, 22);
			this.btnMinus1.TabIndex = 62;
			this.btnMinus1.Text = "-";
			this.btnMinus1.UseVisualStyleBackColor = true;
			// 
			// UpDown
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblValue);
			this.Controls.Add(this.btnPlus100);
			this.Controls.Add(this.btnMinus100);
			this.Controls.Add(this.btnPlus10);
			this.Controls.Add(this.btnMinus10);
			this.Controls.Add(this.lblCaption);
			this.Controls.Add(this.btnPlus1);
			this.Controls.Add(this.btnMinus1);
			this.MaximumSize = new System.Drawing.Size(335, 45);
			this.MinimumSize = new System.Drawing.Size(162, 45);
			this.Name = "UpDown";
			this.Size = new System.Drawing.Size(162, 45);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblValue;
		private System.Windows.Forms.Button btnPlus100;
		private System.Windows.Forms.Button btnMinus100;
		private System.Windows.Forms.Button btnPlus10;
		private System.Windows.Forms.Button btnMinus10;
		private System.Windows.Forms.Label lblCaption;
		private System.Windows.Forms.Button btnPlus1;
		private System.Windows.Forms.Button btnMinus1;
	}
}
