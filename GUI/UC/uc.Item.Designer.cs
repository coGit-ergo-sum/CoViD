namespace CoViD.GUI.UC
{
	partial class Item
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
			this.components = new System.ComponentModel.Container();
			this.chk = new System.Windows.Forms.CheckBox();
			this.pnl = new System.Windows.Forms.Panel();
			this.lblText = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// chk
			// 
			this.chk.AutoSize = true;
			this.chk.BackColor = System.Drawing.Color.Transparent;
			this.chk.Checked = true;
			this.chk.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk.Location = new System.Drawing.Point(15, 3);
			this.chk.Margin = new System.Windows.Forms.Padding(0);
			this.chk.Name = "chk";
			this.chk.Size = new System.Drawing.Size(15, 14);
			this.chk.TabIndex = 6;
			this.chk.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.chk.UseVisualStyleBackColor = false;
			this.chk.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
			// 
			// pnl
			// 
			this.pnl.Location = new System.Drawing.Point(1, 3);
			this.pnl.Name = "pnl";
			this.pnl.Size = new System.Drawing.Size(13, 13);
			this.pnl.TabIndex = 7;
			this.pnl.Click += new System.EventHandler(this.pnl_Click);
			// 
			// lblText
			// 
			this.lblText.Location = new System.Drawing.Point(30, 3);
			this.lblText.Name = "lblText";
			this.lblText.Size = new System.Drawing.Size(35, 13);
			this.lblText.TabIndex = 8;
			this.lblText.Text = "label1";
			this.toolTip1.SetToolTip(this.lblText, "ffffffffff");
			this.lblText.Click += new System.EventHandler(this.lblText_Click);
			// 
			// Item
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblText);
			this.Controls.Add(this.pnl);
			this.Controls.Add(this.chk);
			this.Name = "Item";
			this.Size = new System.Drawing.Size(75, 22);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnl;
		private System.Windows.Forms.CheckBox chk;
		private System.Windows.Forms.Label lblText;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}
