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

namespace CoViD.GUI.UC
{
	public partial class Led : UserControl
	{
		////////////public enum Colors
		////////////{
		////////////	Gray = 0,
		////////////	Red = 1,
		////////////	Green = 2,
		////////////	Blue = 3,
		////////////	Yellow = 4,
		////////////	White = 5
		////////////}

		////////////public bool IsGrey { get { return this._Color == Led.Colors.Gray; } }
		////////////public bool IsRed { get { return this._Color == Led.Colors.Red; } }
		////////////public bool IsGreen { get { return this._Color == Led.Colors.Green; } }
		////////////public bool IsBlue { get { return this._Color == Led.Colors.Blue; } }
		////////////public bool IsYellow { get { return this._Color == Led.Colors.Yellow; } }
		////////////public bool IsWhite { get { return this._Color == Led.Colors.White; } }

		////////private bool _On = true;
		////////public bool On
		////////{
		////////	get { return this._On; }
		////////	set
		////////	{
		////////		this._On = value;
		////////		this.SetColor(value, this.Color);
		////////	}
		////////}

		[DisplayName("State")]
		[Category("CoViD")]
		[Description("One of the possible states of a 'Person' (object).")]
		public CoViD.CL.Person.States State
		{
			set {
				this._State = value;
				this.pnlLed.BackColor = value.ToColor();
				this.lblText.Text = value.ToString();
				this.Width = this.lblText.Left + this.lblText.Width + 5;
			}
			get { return this._State == null ? CL.Person.States.Susceptible : this._State; }
		}

		private CoViD.CL.Person.States _State;

		////////private Led.Colors _Color;
		////////public Led.Colors Color { 
		////////	get { return this._Color; }
		////////	set {
		////////		this._Color = value;
		////////		this.SetColor(this.On, value);
		////////	} 
		////////}

		////////private void SetColor(bool on, Led.Colors color)
		////////{
		////////	if (on)
		////////	{
		////////		this.pnlLed.BackgroundImage =
		////////			this.IsRed ? global::CoViD.GUI.Properties.Resources.LedRed_32x32 :
		////////			this.IsGreen ? global::CoViD.GUI.Properties.Resources.LedGreen_32x32 :
		////////			this.IsBlue ? global::CoViD.GUI.Properties.Resources.LedBlue_32x32 :
		////////			this.IsYellow ? global::CoViD.GUI.Properties.Resources.LedYellow_32x32 :
		////////			this.IsWhite ? global::CoViD.GUI.Properties.Resources.LedWhite_32x32 :
		////////			global::CoViD.GUI.Properties.Resources.LedGrey_32x32;
		////////	}
		////////	else
		////////	{
		////////		this.pnlLed.BackgroundImage = global::CoViD.GUI.Properties.Resources.LedGrey_32x32;
		////////	}
		////////}

		////////new public string Caption
		////////{
		////////	get { return this.lblText.Text; }
		////////	set { this.lblText.Text = value; }
		////////}

		public Led()
		{
			InitializeComponent();
		}


	}
}

//QWWW
