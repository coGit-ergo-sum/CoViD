using System;
using System.ComponentModel;
using System.Windows.Forms;
using Vi.Tools.Extensions.Object;

namespace CoViD.GUI.UC
{
	/// <summary>
	/// Specializes a checkbox adding a colored square region to the left.
	/// </summary>
	public partial class Item : UserControl
	{

		/// <summary>
		/// The toolTip message
		/// </summary>
		public string TooltipText 
		{
			get { return this.toolTip1.GetToolTip(this.lblText); }
			set { this.toolTip1.SetToolTip(this.lblText,value); }
		}
		/// <summary>
		/// the delegate for the 'CheckedChanged' event.
		/// </summary>
		/// <param name="isChecked">The value of the 'checked' property of the inner checkbox.</param>
		public delegate void CheckedChangedDelegate(bool isChecked);

		/// <summary>
		/// Event raised each time the inner checkbox change the 'checked' status.
		/// </summary>
		public event CheckedChangedDelegate CheckedChanged;

		/// <summary>
		/// Method to 'safely' call the event 'Coordinates'.
		/// </summary>
		private void OnCheckedChanged()
		{
			if (this.CheckedChanged.IsNotNull()) { this.CheckedChanged(this.Checked); }
		}

		/// <summary>
		/// The main CTor, Initialize Component.
		/// </summary>
		public Item()
		{
			InitializeComponent();
			////////////_tt.AutoPopDelay = 1500;
			////////////_tt.InitialDelay = 400;
			//////////////            _tt.IsBalloon = true;
			////////////_tt.UseAnimation = true;
			////////////_tt.UseFading = true;
			////////////_tt.Active = true;
			////////////this.MouseEnter += new EventHandler(this.lblText_MouseEnter);
			//this.chk.Checked = false;
			//this.pnl_Click(null, null);
		}

		/// <summary>
		/// Gets/Sets the checked status of the inner checkbox.
		/// </summary>
		public bool Checked
		{
			get { return this.chk.Checked; }
			set { this.chk.Checked = value; }
		}


		//////////private void lblText_MouseEnter(object sender, EventArgs ea)
		//////////{
		//////////	if (!string.IsNullOrEmpty(this.TooltipText))
		//////////	{
		//////////		_tt.SetToolTip(this, this.TooltipText);
		//////////		_tt.Show(this.TooltipText, this.Parent);
		//////////	}
		//////////}

		////////////private CoViD.CL.Person.States _State;

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


		/// <summary>
		/// Sets/Gets the background color of the small square at the left side of the control.
		/// </summary>
		[DisplayName("Color")]
		[Category("CoViD")]
		[Description("The color associated to the state.")]
		public System.Drawing.Color Color
		{
			set
			{
				this.pnl.BackColor = value;
				//this.lblText.BackColor = value;
				//this.chk.BackColor = value;
			}
			get { return this.pnl.BackColor; }
		}

		/// <summary>
		/// Set/Gets the text in the label and adjust the width of the control.
		/// </summary>
		[DisplayName("Text")]
		[Category("CoViD")]
		[Description(" Gets or sets the text associated with this control.")]
		new public string Text
		{
			set
			{
				//this.chk.Left = 2;
				this.lblText.Left = this.chk.Left + this.chk.Width + 2;

				this.lblText.AutoSize = true;
				this.lblText.Text = value.ToString();
				this.Width = this.lblText.Left + this.lblText.Width + 2;

				/*
				this.pnl.Left = this.chk.Left;
				this.pnl.Top = 0; // this.Height - 2;
				this.pnl.Width = this.Width - this.pnl.Left;
				this.pnl.Height = 2;
				*/
			}
			get { return this.lblText.Text; }
		}

		/// <summary>
		/// Toggle the 'Checked' state of the checkbox.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void pnl_Click(object sender, EventArgs e)
		{
			this.chk.Checked = !this.chk.Checked;
			//this.pnl.BackgroundImage = this.chk.Checked ? global::CoViD.GUI.Properties.Resources.Check : null;
		}

		/// <summary>
		/// Toggle the 'Checked' state of the checkbox. 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void lblText_Click(object sender, EventArgs e)
		{
			this.chk.Checked = !this.chk.Checked;
		}

		/// <summary>
		/// Sets/gets checkbox's visibility
		/// </summary>
		[DisplayName("CheckBox")]
		[Category("CoViD")]
		[Description("Sets the checkbox visible or not.")]
		public bool CheckBox
		{
			get { return this.chk.Visible; }
			set { 
				this.chk.Visible = value;
				this.lblText.Left = this.pnl.Left + this.pnl.Width + 1 + (value ? (this.chk.Width + 1) : 0);
				//this.lblText.Left = this.chk.Left - 2 + (value ? (this.chk.Width + 2) : 0);
				//this.pnl.Width = value ? this.Width : (this.lblText.Width - 2);
			}
		}

		/// <summary>
		/// Raises the event 'CheckedChanged'.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void chk_CheckedChanged(object sender, EventArgs e)
		{
			this.OnCheckedChanged();
		}
	}
}
