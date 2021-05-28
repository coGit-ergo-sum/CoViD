using System;
using System.Windows.Forms;

namespace CoViD.GUI.Forms
{
	/// <summary>
	/// Represents 1) the dynamic of viruses; 2) the movement of the person 3) the place contaminated by the person. 
	/// (This form shows the same data shown from the other forms, limited to one person.)
	/// </summary>
	public partial class Person : Form
	{

		private CoViD.CL.Grid Grid;


		#region Form's events

		/// <summary>
		/// Main CTor It just runs 'InitializeComponent'. 
		/// </summary>
		public Person()
		{
			InitializeComponent();
		}


		private void Person_Load(object sender, EventArgs e)
		{
			Initialize();
			tsbPause.Visible = false;
		}


		private void Person_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.tsbPause_Click(null, null);
		}
		#endregion
		
		

		private void up_Click(object sender, EventArgs e)
		{
			this.grid1.Cartesian.Clear();
			this.Initialize();
		}


		private void tsmDisease_Click(object sender, EventArgs e)
		{
			CoViD.GUI.Forms.Infection infection = null;
			{
				foreach (var form in Application.OpenForms)
				{
					if (form is CoViD.GUI.Forms.Infection)
					{
						infection = (CoViD.GUI.Forms.Infection)form;
						if (infection.WindowState == FormWindowState.Minimized)
						{
							infection.WindowState = FormWindowState.Normal;
							break;
						}
					}
				}
			}
			infection = infection ?? new CoViD.GUI.Forms.Infection();
			infection.BringToFront();
			infection.Show();

		}

		#region Run stop resume
		private void tsbPause_Click(object sender, EventArgs e)
		{
			tsbPause.Visible = false;
			tsbPlay.Visible = true;
			tsbPlay.Enabled = true;

			this.TicksMax = this.Grid.Ticks;
		}

		private void tsbPlay_Click(object sender, EventArgs e)
		{
			tsbPlay.Visible = false;
			tsbPause.Visible = true;
			this.TicksMax = (int)this.udTicks.Value;

			this.Play();
		}

		private void tsbReplay_Click(object sender, EventArgs e)
		{
			tsbPlay.Visible = false;
			tsbPause.Visible = true;
			tsbPause.Enabled = true;

			this.TicksMax = (int)this.udTicks.Value;

			this.xyViruses.Cartesian.Clear();
			this.grid1.Cartesian.Clear();
			this.grid2.Cartesian.Clear();


			this.Grid.Reset();
			this.Grid.Contaminate(1000, new CoViD.CL.Point(0, 0));

			this.Play();
		}

		private void tsbNew_Click(object sender, EventArgs e)
		{
			this.Person_Load(null, null);
			this.tsbReplay_Click(null, null);
		}
		#endregion

		private void tsbSettings_Click(object sender, EventArgs e)
		{
		}
	}
}