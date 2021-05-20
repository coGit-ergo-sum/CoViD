using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//////////using CoViD.GUI.Tools.Extensions.Control;
using Vi.Tools.Extensions.String;


namespace CoViD.GUI.UC
{
	public partial class UpDown : UserControl
	{
		new public System.EventHandler Click;

		[DisplayName("Decimals")]
		[Category("CoViD")]
		[Description("The number of decimal figures to show.")]
		public sbyte Decimals { get; set; }

		/// <summary>
		/// The value shown.
		/// </summary>
		[DisplayName("Value")]
		[Category("CoViD")]
		[Description("The value shown.")]
		public float Value {
			get { return this.lblValue.Text.ToFloat(0); }
			set {
				var format = "#,##0" + ((this.Decimals == 0) ? "" : "." + new string('0', this.Decimals));
				lblValue.Text = value.ToString(format);
			}
		}

		/// <summary>
		/// The message to show.
		/// </summary>
		[DisplayName("Caption")]
		[Category("CoViD")]
		[Description("The message to show.")]/// 
		public string Caption
		{
			set { this.lblCaption.Text = value; } get { return this.lblCaption.Text;  }
		}

		public UpDown()
		{
			InitializeComponent();

			this.btnMinus1.Click += new System.EventHandler(this.btnMinus1_Click);
			this.btnMinus10.Click += new System.EventHandler(this.btnMinus10_Click);
			this.btnMinus100.Click += new System.EventHandler(this.btnMinus100_Click);
			this.btnPlus1.Click += new System.EventHandler(this.btnPlus1_Click);
			this.btnPlus10.Click += new System.EventHandler(this.btnPlus10_Click);
			this.btnPlus100.Click += new System.EventHandler(this.btnPlus100_Click);
		}

		private void btnMinus1_Click(object sender, EventArgs e) { this.Add(-1); }
		private void btnPlus1_Click(object sender, EventArgs e) { this.Add(1); }
		private void btnMinus10_Click(object sender, EventArgs e) { this.Add(-10); }
		private void btnPlus10_Click(object sender, EventArgs e) { this.Add(10); }
		private void btnMinus100_Click(object sender, EventArgs e) { this.Add(-100); }
		private void btnPlus100_Click(object sender, EventArgs e) { this.Add(100); }

		private void Add(int amount)
		{
			var value = this.Value;

			int step = (int)Math.Pow(10, Decimals);
			value += ((float)amount / (float)step);
			//value = Math.Max(0, value);
			this.Value = value;
			//////var format = "#,##0" + ((this.Decimals == 0) ? "" : "." + new string('0', this.Decimals));
			//////control.Text = v.ToString(format); 

			if (this.Click != null) { this.Click(this, null); }
		}
	}
}
