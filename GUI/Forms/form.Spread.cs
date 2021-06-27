using CoViD.GUI.Tools.Extensions.Profile;
using System;
using System.Drawing;
using System.Windows.Forms;
using Vi.Tools.Extensions.Exception;

namespace CoViD.GUI.Forms
{
	public partial class Spread : Form
	{
		/// <summary>
		/// The matrix that reperesents the rigion for the simulation.
		/// </summary>
		private CoViD.CL.Grid Grid;

		/// <summary>
		/// The settings for this page.
		/// </summary>
		public CoViD.INI INICoViD;

		/// <summary>
		/// True if the simulation is in progress.
		/// </summary>
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
		/// Inizializes the form.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Spread_Load(object sender, EventArgs e)
		{

			try
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
			catch (System.Exception se)
			{
				se.Show();
			}
		}

		/// <summary>
		/// Saves the Location and Size of the form & calls 'tsbPause_Click'.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Spread_FormClosing(object sender, FormClosingEventArgs e)
		{
			Program.INIGUI.Write(this.Name, "Location", this.Location);
			Program.INIGUI.Write(this.Name, "Size", this.Size);

			this.tsbPause_Click(null, null);
		}
		#endregion


		#region Run stop resume

		/// <summary>
		/// Pauses the simulation.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void tsbPause_Click(object sender, EventArgs e)
		{
			try
			{
				tsbPause.Visible = false;
				tsbPlay.Visible = true;
				tsbPlay.Enabled = true;

				this.TicksMax = this.Grid.Ticks;
			}
			catch (System.Exception se)
			{
				se.Show();
			}
		}

		private void tsbPlay_Click(object sender, EventArgs e)
		{

			try
			{
			tsbPlay.Visible = false;
			tsbPause.Visible = true;

			this.TicksMax = (int)this.INICoViD.Ticks;
			this.Play();
			}
			catch (System.Exception se)
			{
				se.Show();
			}
		}

		/// <summary>
		/// Restart the current simulation
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void tsbReplay_Click(object sender, EventArgs e)
		{
			try
			{
				tsbPlay.Visible = false;
				tsbPause.Visible = true;
				tsbPause.Enabled = true;

				this.TicksMax = (int)this.INICoViD.Ticks;

				this.regionR.Cartesian.Clear();
				this.xySIR.Cartesian.Clear();
				this.xyDSIR.Cartesian.Clear();
				this.xyContaminated.Cartesian.Clear();
				this.xyPerformances.Cartesian.Clear();

				this.Grid.Reset();
				this.Contaminate();

				this.Play();
			}
			catch (System.Exception se)
			{
				se.Show();
			}
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

		//     
		//
		//   e:
		//     
		/// <summary>
		/// Opens the form Settings stopping the process if running. When closed 
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">An object that contains no event data.</param>
		private void tsbSettings_Click(object sender, EventArgs e)
		{
			try
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
			catch (System.Exception se)
			{
				se.Show();
			}
		}

		private void tsbPeople_Click(object sender, EventArgs e)
		{
			try
			{
			this.ShowPeople();
			}
			catch (System.Exception se)
			{
				se.Show();
			}
		}

		private void Spread_Resize(object sender, EventArgs e)
		{
			try
			{
				var spazio = this.regionL.Left;
				var width = this.tabRegion.ClientSize.Width;
				var w = (width - (4 * spazio)) / 2;

				this.regionL.Width = w;
				this.regionR.Width = w;
				this.regionR.Left = this.regionR.Width + (3 * spazio);
			}
			catch (System.Exception se)
			{
				se.Show();
			}
		}

		private void Spread_Click(object sender, EventArgs e)
		{
			try
			{
				var spazio = (this.tabRegion.ClientSize.Width - (this.regionL.Width + this.regionR.Width)) / 4;
				this.regionL.Left = spazio;
				this.regionR.Left = (3 * spazio) + this.regionL.Width;
			}
			catch (System.Exception se)
			{
				se.Show();
			}
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
			try
			{
				this.ShowPeople();
			}
			catch (System.Exception se)
			{
				se.Show();
			}
		}

		/// <summary>
		/// Manages the visibility of the UC legend
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.legend1.CheckBoxes = this.tabControl1.SelectedIndex == 0;
				this.legend1.IsSIR = this.tabControl1.SelectedIndex == 1;
				this.legend1.Visible = this.tabControl1.SelectedIndex < 2;
			}
			catch (System.Exception se)
			{
				se.Show();
			}
		}

		private void SnapshotForm_Click(object sender, EventArgs e)
		{
			// ----------------------------------------------------------------------------------- //
			// The control 'Legend1' belongs to the form but its location overlaps the tabControl
			// for this reason the methods 'this.DrawToBitmap' does not print 'Legend1' (because
			// 'tabControl1' hides it)
			// To fix this bug the bmp for 'legend1' is merged runtime.
			// ----------------------------------------------------------------------------------- //

			// the screenshot of the form 'Spread' having the 'legend1' not rendered.
			var form = new Bitmap(this.Width, this.Height);
			this.DrawToBitmap(form, new Rectangle(0, 0, form.Width, form.Height));

			using (Graphics graphics = Graphics.FromImage(form))
			{           
				// the screenshot of the 'legend1'.
				var legend = new Bitmap(this.legend1.Width, this.legend1.Height);
				this.legend1.DrawToBitmap(legend, new Rectangle(0, 0, legend.Width, legend.Height));

				var location = new Point(this.tabControl1.Left + this.legend1.Left, this.tabControl1.Top + this.legend1.Top);
				graphics.DrawImage(legend, location);
			}

			this.SaveBitmap(form, "Form");
		}

		private void SnapshotDiagram_Click(object sender, EventArgs e)
		{
			var tab = new Bitmap(this.tabControl1.SelectedTab.Width, this.tabControl1.SelectedTab.Height);
			this.tabControl1.SelectedTab.DrawToBitmap(tab, new Rectangle(0, 0, tab.Width, tab.Height));

			this.SaveBitmap(tab, "Diagram");
		}

		private void SaveBitmap(Bitmap bmp, string name) {
			var fileName = String.Format(
				"{0:yyyy-MM-dd.hh-mm-ss}.{1}.{2}.png",
				DateTime.Now,
				name,
				tabControl1.SelectedTab.Name
			);
			var fullFileName = System.IO.Path.Combine(this.SnapshotsPath, fileName);

			if (System.IO.File.Exists(fullFileName))
			{
				System.Threading.Thread.Sleep(1000);
				this.SaveBitmap(bmp, name);
			}
			else
			{
				bmp.Save(fullFileName);
				System.Diagnostics.Process.Start(fullFileName);
			}
		}


		private string SnapshotsPath
		{
			get
			{
				var path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Snapshots");
				System.IO.Directory.CreateDirectory(path);
				return path;
			}
			set { }
		}

		private void DrawToBitmap(Control control, string name) {
			try
			{
				using (var bmp = new Bitmap(control.Width, control.Height))
				{
					var fileName = String.Format(
						"{0:yyyy-MM-dd.hh-mm-ss}.{1}.{2}.png", 
						DateTime.Now, 
						name, 
						tabControl1.SelectedTab.Name
					);
					var fullFileName = System.IO.Path.Combine(this.SnapshotsPath, fileName);

					if (System.IO.File.Exists(fullFileName))
					{
						System.Threading.Thread.Sleep(1000);
						this.DrawToBitmap(control, name);
					}
					else
					{
						control.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
						bmp.Save(fullFileName);
						System.Diagnostics.Process.Start(fullFileName);
					}
				}
			}
			catch (System.Exception se) {
				se.Show();
			}
		}

		private void SnapshotDirectory_Click(object sender, EventArgs e)
		{
			try
			{
				System.Diagnostics.Process.Start(this.SnapshotsPath);
			}
			catch (System.Exception se) {
				se.Show();
			}
		}
	}
}