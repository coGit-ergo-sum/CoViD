using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using CoViD.GUI.Tools.Extensions.Person;
using Vi.Tools.Extensions.Random;
using Vi.Tools.Extensions.String;
using Vi.Tools.Extensions.Object;

namespace CoViD.GUI.Forms
{
	public partial class Spread : Form
	{

		private CoViD.CL.Grid Grid;


		#region Form's events
		public Spread()
		{
			InitializeComponent();
		}

		private void Spread_Load(object sender, EventArgs e)
		{
			this.legend1.IsSusceptible = false;
			this.legend1.IsImmune = false;
			Initialize();
		}


		private void Spread_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.tsbPause_Click(null, null);
		}
		#endregion
		
	
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

			this.grid2.Cartesian.Clear();
			this.xySIR.Cartesian.Clear();
			this.xyDSIR.Cartesian.Clear();
			this.xyContaminated.Cartesian.Clear();
			this.xyPerformances.Cartesian.Clear();

			this.Grid.Reset();
			this.Contaminate();
			//this.Spread_Load(null, null);

			this.Play();
		}

		private void tsbNew_Click(object sender, EventArgs e)
		{
			tsbPlay.Visible = false;
			tsbPause.Visible = true;
			tsbPause.Enabled = true;

			Initialize();
			//this.Spread_Load(null, null);
			//this.tsbReplay_Click(null, null);
			this.Play();
		}
		#endregion
	

		private void up_Click(object sender, EventArgs e)
		{
			this.grid1.Cartesian.Clear();
			this.grid2.Cartesian.Clear();
			this.xySIR.Cartesian.Clear();
			this.xyContaminated.Cartesian.Clear();
			//this.Initialize();
		}

		private void tsbSettings_Click(object sender, EventArgs e)
		{
		}

		private void tsbPeople_Click(object sender, EventArgs e)
		{
			this.ShowPeople();
		}

		private void Spread_Resize(object sender, EventArgs e)
		{
			var spazio = this.grid1.Left;
			var width = this.tabPage1.ClientSize.Width;
			var w = (width - (4 * spazio)) / 2;

			this.grid1.Width = w;
			this.grid2.Width = w;
			this.grid2.Left = this.grid2.Width + (3 * spazio);
		}

		private void Spread_Click(object sender, EventArgs e)
		{
			var spazio = (this.tabPage1.ClientSize.Width - (this.grid1.Width + this.grid2.Width)) / 4;
			this.grid1.Left = spazio;
			this.grid2.Left = (3 * spazio) + this.grid1.Width;
		}

		private void Legend1_CheckedChanged(
			bool isSusceptibles, 
			bool isLatency, 
			bool isIll, 
			bool isSevere, 
			bool isConvalescent, 
			bool isImmune, 
			bool isDead
		)
		{
			this.ShowPeople();
		}

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.legend1.CheckBoxes = this.tabControl1.SelectedIndex == 0;
			this.legend1.IsSIR = this.tabControl1.SelectedIndex == 1;
			this.legend1.Visible = this.tabControl1.SelectedIndex != 2;
		}

	}
}