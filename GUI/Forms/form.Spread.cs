using CoViD.GUI.Tools.Extensions.Profile;
using System;
using System.Windows.Forms;

namespace CoViD.GUI.Forms
{
	public partial class Spread : Form
	{

		private CoViD.CL.Grid Grid;

		/// <summary>
		/// The settings for this page.
		/// </summary>
		public CoViD.INI INICoViD;

		private bool isRunning
		{
			get { return tsbPause.Visible; }
		}


		#region Form's events

		/// <summary>
		/// Manin CTor. Runs 'InitializeComponent'.
		/// </summary>
		public Spread()
		{
			InitializeComponent();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Spread_Load(object sender, EventArgs e)
		{
			this.Location = Program.INIGUI.Read(this.Name, "Location", this.Location);
			this.Size = Program.INIGUI.Read(this.Name, "Size", this.Size);

			this.INICoViD = Program.INICoViD.Read(new CoViD.INI());
			this.legend1.IsSusceptible = false;
			this.legend1.IsImmune = false;
			Initialize();

			// ToDo: remove this and fix the bug that clears the
			//       diagrams the first time a tab become active
			tabControl1.SelectedIndex = 4;
			tabControl1.SelectedIndex = 3;
			tabControl1.SelectedIndex = 2;
			tabControl1.SelectedIndex = 1;
			tabControl1.SelectedIndex = 0;

		}


		private void Spread_FormClosing(object sender, FormClosingEventArgs e)
		{
			Program.INIGUI.Write(this.Name, "Location", this.Location);
			Program.INIGUI.Write(this.Name, "Size", this.Size);

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

			this.TicksMax = (int)this.INICoViD.Ticks;
			this.Play();
		}

		private void tsbReplay_Click(object sender, EventArgs e)
		{
			tsbPlay.Visible = false;
			tsbPause.Visible = true;
			tsbPause.Enabled = true;

			this.TicksMax = (int)this.INICoViD.Ticks;

			this.grid2.Cartesian.Clear();
			this.xySIR.Cartesian.Clear();
			this.xyDSIR.Cartesian.Clear();
			this.xyContaminated.Cartesian.Clear();
			this.xyPerformances.Cartesian.Clear();

			this.Grid.Reset();
			this.Contaminate();

			this.Play();
		}

		private void tsbNew_Click(object sender, EventArgs e)
		{
			tsbPlay.Visible = false;
			tsbPause.Visible = true;
			tsbPause.Enabled = true;

			Initialize();
			this.Play();
		}
		#endregion


		private void tsbSettings_Click(object sender, EventArgs e)
		{
			var isRunning = this.isRunning;
			tsbPause_Click(null, null);
			var frmSettings = new CoViD.GUI.Forms.Settings();
			frmSettings.ShowDialog();

			var iniCovid = Program.INICoViD.Read(new CoViD.INI());

			if (isRunning)
			{
				if (iniCovid == this.INICoViD)
				{
					tsbPlay_Click(null, null);
				}
				else
				{
					this.INICoViD = iniCovid;
					Initialize();
					tsbNew_Click(null, null);
				}
			}
			else
			{
				if (iniCovid != this.INICoViD)
				{
					this.INICoViD = iniCovid;
					Initialize();
				}
			}
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

		private void TsbPeople_Click(object sender, EventArgs e)
		{

		}

		private void TsbNew_Click(object sender, EventArgs e)
		{

		}

		private void TsbReplay_Click(object sender, EventArgs e)
		{

		}

		private void TsbPlay_Click(object sender, EventArgs e)
		{

		}

		private void TsbPause_Click(object sender, EventArgs e)
		{

		}
	}
}