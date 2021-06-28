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
	public partial class Legend : UserControl
	{
		public delegate void CheckedChangedDelegate(bool isSusceptibles, bool isLatency, bool isIll, bool isSevere, bool isConvalescent, bool isImmune, bool isDead);
		public event CheckedChangedDelegate CheckedChanged;
		private void OnCheckedChanged()
		{
			if (this.CheckedChanged.IsNotNull()) { 
				this.CheckedChanged(
					this.itmSusceptible.Checked,
					this.itmLatency.Checked,
					this.itmIll.Checked,
					this.itmSevere.Checked,
					this.itmConvalescent.Checked,
					this.itmImmune.Checked,
					this.itmDead.Checked
				); 
			}
		}

		private void itm_CheckedChanged(bool isChecked)
		{
			this.OnCheckedChanged();
		}

		public Legend()
		{
			InitializeComponent();


			this.itmConvalescent.Color = CoViD.CL.Person.States.Convalescent.ToColor();
			this.itmSusceptible.Color = CoViD.CL.Person.States.Susceptible.ToColor();
			this.itmLatency.Color = CoViD.CL.Person.States.Latency.ToColor();
			this.itmIll.Color = CoViD.CL.Person.States.Ill.ToColor();
			this.itmSevere.Color = CoViD.CL.Person.States.Severe.ToColor();
			this.itmImmune.Color = CoViD.CL.Person.States.Immune.ToColor();
			this.itmDead.Color = CoViD.CL.Person.States.Dead.ToColor();

			this.itmInfected.Color = CoViD.CL.Person.SIRStates.Infected.ToColor();
			this.itmRecovered.Color = CoViD.CL.Person.SIRStates.Recovered.ToColor();

			this.itmConvalescent.Text = CoViD.CL.Person.States.Convalescent.ToString();
			this.itmSusceptible.Text = CoViD.CL.Person.States.Susceptible.ToString();
			this.itmLatency.Text = CoViD.CL.Person.States.Latency.ToString();
			this.itmIll.Text = CoViD.CL.Person.States.Ill.ToString();
			this.itmSevere.Text = CoViD.CL.Person.States.Severe.ToString();
			this.itmImmune.Text = CoViD.CL.Person.States.Immune.ToString();
			this.itmDead.Text = CoViD.CL.Person.States.Dead.ToString();

			this.itmInfected.Text = CoViD.CL.Person.SIRStates.Infected.ToString();
			this.itmRecovered.Text = CoViD.CL.Person.SIRStates.Recovered.ToString();

			this.itmSusceptible.CheckedChanged += itm_CheckedChanged;
			this.itmLatency.CheckedChanged += itm_CheckedChanged;
			this.itmIll.CheckedChanged += itm_CheckedChanged;
			this.itmSevere.CheckedChanged += itm_CheckedChanged;
			this.itmConvalescent.CheckedChanged += itm_CheckedChanged;
			this.itmImmune.CheckedChanged += itm_CheckedChanged;
			this.itmDead.CheckedChanged += itm_CheckedChanged;

			this.IsSIR = false;

			//this.pnlSusceptible.BackColor = CoViD.CL.Person.States.Susceptible.ToColor();
			//this.chkSusceptible.Text = CoViD.CL.Person.States.Susceptible.ToString();

			//this.pnlLatency.BackColor = CoViD.CL.Person.States.Latency.ToColor();
			//this.chkLatency.Text = CoViD.CL.Person.States.Latency.ToString();

			this.itmInfected.Left = this.itmLatency.Left;
			this.itmRecovered.Left = this.itmIll.Left;

			this.itmConvalescent.TooltipText = "The disease has passed its peak and the person is doing better (not the concept of recovery in SIR)";
			this.itmSusceptible.TooltipText = "The number of susceptible individuals. When a susceptible and an infectious individual come into 'infectious contact', the susceptible individual contracts the disease and transitions to the infectious compartment. [Wiki]";
			this.itmLatency.TooltipText = "Person in 'Latency': infected but still not contagious.";
			this.itmIll.TooltipText = "People ill and contaious.";
			this.itmSevere.TooltipText = "People with a severe illness condition in needs for hospitalization.";
			this.itmImmune.TooltipText = "The people recovered alive from the illness.";
			this.itmDead.TooltipText = "People recovered dead from the illness.";
		}

		/// <summary>
		/// Hides the checkboxes lefting the colored icon still visible;
		/// </summary>
		[DisplayName("CheckBox")]
		[Category("CoViD")]
		[Description("Sets the checkboxes visible or not.")]
		public bool CheckBoxes
		{
			get { return this.itmSusceptible.CheckBox; }
			set
			{
				this.itmSusceptible.CheckBox = value;
				this.itmLatency.CheckBox = value;
				this.itmIll.CheckBox = value;
				this.itmSevere.CheckBox = value;
				this.itmConvalescent.CheckBox = value;
				this.itmImmune.CheckBox = value;
				this.itmDead.CheckBox = value;
				this.itmInfected.CheckBox = value;
				this.itmRecovered.CheckBox = value;
			}
		}

		#region IsXYZ
		/// <summary>
		/// Sets the visibility of the Items related to the SIR visualization.
		/// </summary>
		public bool IsSIR
		{
			get { return itmInfected.Visible; }
			set {
				this.itmSusceptible.Color = value ? CoViD.CL.Person.SIRStates.Susceptible.ToColor() : CoViD.CL.Person.States.Susceptible.ToColor();

				this.itmLatency.Visible = !value;
				this.itmIll.Visible = !value;
				this.itmSevere.Visible = !value;
				this.itmConvalescent.Visible = !value;
				this.itmImmune.Visible = !value;
				this.itmDead.Visible = !value;

				this.itmInfected.Visible = value;
				this.itmRecovered.Visible = value;
			}
		}

		/// <summary>
		/// True if the checkbox 'Susceptible' is checked.
		/// </summary>
		public bool IsSusceptible
		{
			get { return this.itmSusceptible.Checked; }
			set { this.itmSusceptible.Checked = value; }
		}

		/// <summary>
		/// True if the checkbox 'Latency' is checked.
		/// </summary>
		public bool IsLatency
		{
			get { return this.itmLatency.Checked; }
			set { this.itmLatency.Checked = value; }
		}

		/// <summary>
		/// True if the checkbox 'Ill' is checked.
		/// </summary>
		public bool IsIll
		{
			get { return this.itmIll.Checked; }
			set { this.itmIll.Checked = value; }
		}

		/// <summary>
		/// True if the checkbox 'Severe' is checked.
		/// </summary>
		public bool IsSevere
		{
			get { return this.itmSevere.Checked; }
			set { this.itmSevere.Checked = value; }
		}

		/// <summary>
		/// True if the checkbox 'Convalescent' is checked.
		/// </summary>
		public bool IsConvalescent
		{
			get { return this.itmConvalescent.Checked; }
			set { this.itmConvalescent.Checked = value; }
		}

		/// <summary>
		/// True if the checkbox 'Immune' is checked.
		/// </summary>
		public bool IsImmune
		{
			get { return this.itmImmune.Checked; }
			set { this.itmImmune.Checked = value; }
		}

		/// <summary>
		/// True if the checkbox 'Dead' is checked.
		/// </summary>
		public bool IsDead
		{
			get { return this.itmDead.Checked; }
			set { this.itmDead.Checked = value; }
		}
		#endregion


	}
}
