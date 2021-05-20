using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CoViD.GUI.Tools.Extensions.Person;
using Vi.Tools.Extensions.Object;

namespace CoViD.GUI.UC
{
	public partial class Item : UserControl
	{
		public delegate void CheckedChangedDelegate(bool isChecked);
		public event CheckedChangedDelegate CheckedChanged;
		private void OnCheckedChanged()
		{
			if (this.CheckedChanged.IsNotNull()) { this.CheckedChanged(this.Checked); }
		}

		public Item()
		{
			InitializeComponent();
			//this.chk.Checked = false;
			//this.pnl_Click(null, null);
		}

		public bool Checked
		{
			get { return this.chk.Checked; }
			set { this.chk.Checked = value; }
		}

		private CoViD.CL.Person.States _State;

		////////[DisplayName("State")]
		////////[Category("CoViD")]
		////////[Description("One of the possible states of a 'Person' (object).")]
		////////public CoViD.CL.Person.States State
		////////{
		////////	set
		////////	{
		////////		this._State = value;
		////////		this.pnl.BackColor = value.ToColor();
		////////		this.lblText.Text = value.ToString();
		////////		this.Width = this.lblText.Left + this.lblText.Width + 2;
		////////	}
		////////	get { return this._State == null ? CL.Person.States.Susceptible : this._State; }
		////////}


		[DisplayName("Color")]
		[Category("CoViD")]
		[Description("The color associated to the state.")]
		public System.Drawing.Color Color
		{
			set
			{
				this.pnl.BackColor = value;
			}
			get { return this.pnl.BackColor; }
		}

		[DisplayName("Text")]
		[Category("CoViD")]
		[Description(" Gets or sets the text associated with this control.")]
		new public string Text
		{
			set
			{
				this.lblText.Text = value.ToString();
				this.Width = this.lblText.Left + this.lblText.Width + 2;
			}
			get { return this.lblText.Text; }
		}

		private void pnl_Click(object sender, EventArgs e)
		{
			this.chk.Checked = !this.chk.Checked;
			//this.pnl.BackgroundImage = this.chk.Checked ? global::CoViD.GUI.Properties.Resources.Check : null;
		}

		private void lblText_Click(object sender, EventArgs e)
		{
			this.chk.Checked = !this.chk.Checked;
		}

		[DisplayName("CheckBox")]
		[Category("CoViD")]
		[Description("Sets the checkbox visible or not.")]
		public bool CheckBox
		{
			get { return this.chk.Visible; }
			set { 
				this.chk.Visible = value;
				this.lblText.Left = this.pnl.Left + this.pnl.Width + 1 + (value ? (this.chk.Width + 1) : 0);
			}
		}

		private void chk_CheckedChanged(object sender, EventArgs e)
		{
			this.OnCheckedChanged();
		}
	}
}
