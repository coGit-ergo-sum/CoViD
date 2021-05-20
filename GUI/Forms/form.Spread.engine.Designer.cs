using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

using CoViD.GUI.Tools.Extensions.Person;
using Vi.Tools.Extensions.Random;
using Vi.Tools.Extensions.String;
using Vi.Tools.Extensions.Int;
using Vi.Tools.Extensions.Float;
using Vi.Tools.Extensions.Object;

namespace CoViD.GUI.Forms
{
	partial class Spread
	{
		int TicksMax;


		private void Initialize()
		{
			this.InitializeStatusStrip();

			var radius = (int)udRadius.Value;
			var people = (int)this.udPeople.Value;
			byte steps = (byte)udSteps.Value;
			this.TicksMax = (int)udTicks.Value;

			this.grid1.SetXY(radius, "People");
			this.grid2.SetXY(radius, "Contamination");

			this.xySIR.SetXY(
				0, this.TicksMax, "0", this.TicksMax.ToText(), "Ticks",
				0, people, "0", people.ToText(), ""
			);

			int deltaMax = 100; /// (int)Math.Round((double)(people / (double)10));
			this.xyDSIR.SetXY(
				0, this.TicksMax, "0", this.TicksMax.ToText(), "Ticks",
				-deltaMax, deltaMax, (-deltaMax).ToText(), deltaMax.ToText(), ""
			);

			var y2Max = 4 * (radius / 100) * (radius / 100);
			this.xyContaminated.SetXY(
				0, this.TicksMax, "0", this.TicksMax.ToText(), "Ticks",
				0, y2Max, "0", y2Max.ToText(), "Contaminated grids"
			);

			this.xyPerformances.SetXY(
				0, this.TicksMax, "0", this.TicksMax.ToText(), "Ticks",
				0, 150, "0", 150.ToText(), "Milliseconds"
			);

			// ------------------------------------------------------------------------------------- //
			this.grid1.Cartesian.Clear();
			this.grid2.Cartesian.Clear();

			Application.DoEvents();
			// ------------------------------------------------------------------------------------- //

			var popolation = new CoViD.CL.Popolation();
			var locations0 = new CoViD.CL.Locations(radius, steps);
			var p0 = new CoViD.CL.Person(locations0);

			for (int i = 0; i < people; i++)
			{
				var locations = new CoViD.CL.Locations(radius, steps);
				var person = new CoViD.CL.Person(locations);

				//var person = new CoViD.CL.Person(
				//	locations,
				//	p0.VirusGrowthPercent,
				//	p0.AntibodyGrowthPercent,
				//	p0.AntibodyDecayPercent,
				//	p0.DeadThreshold,
				//	p0.Mobility
				//);

				person.Sneeze += this.Person_Sneeze;
				person.Inhale += this.Person_Inhale;

				popolation.Add(person);
			}

			// ------------------------------------------------------------------------------------- //

			var hospitals = new CoViD.CL.Hospitals(){
				new CoViD.CL.Hospital(new CoViD.CL.Point(radius, radius), 500)
			};

			this.Grid = new CoViD.CL.Grid(radius, popolation, hospitals);

			this.Grid.Remove += this.Grid_Remove;
			this.Grid.Add += this.Grid_Add;

			this.Contaminate();

		}

		private void Contaminate()
		{
			var radius = (int)udRadius.Value;

			// XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX //
			// Simulate the sneeze of the first infected person. This creates a contaminated grid
			//this.Grid.Contaminate(1000, new CoViD.CL.Point(-(radius / 2), (radius / 2)));
			this.Grid.Contaminate(1000, new CoViD.CL.Point(0, 0));
			// XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX //
		}

		private void Grid_Remove(float x, float y)
		{
			this.grid2.Cartesian.Point(x, y,  Color.Black);
		}
		private void Grid_Add(float x, float y)
		{
			this.grid2.Cartesian.Point(x, y, Color.Red);
		}

		private void Play()
		{
			this.legend1.CheckedChanged -= this.Legend1_CheckedChanged;
			this.InitializeStatusStrip();


			while (this.Grid.Ticks < this.TicksMax)
			{
				CoViD.CL.Person.SegregationThreshold = (byte)this.udSegregationThreshold.Value;

				CoViD.Program.stopwatch.Restart();
				//CoViD.Program.stopwatch.Start();

				this.Grid.Tick();
				this.ShowPeople();

				var ticks = this.Grid.Ticks;
				var popolation = this.Grid.Popolation;
				this.xySIR.Cartesian.Point(ticks, popolation.Susceptibles, CoViD.CL.Person.SIRStates.Susceptible.ToColor());
				this.xySIR.Cartesian.Point(ticks, popolation.Infected, CoViD.CL.Person.SIRStates.Infected.ToColor());
				this.xySIR.Cartesian.Point(ticks, popolation.Recovered, CoViD.CL.Person.SIRStates.Recovered.ToColor());

				//if (popolation.Susceptibles != 0 && popolation.Infected != 0)
				if (popolation.Infected != 0)
				{
					//float ds = 1000F * 1000F * 10 * (float)popolation.DSusceptibles / ((float)popolation.Susceptibles  * (float)popolation.Infected);
					float ds = 1000F * ((float)popolation.DSusceptibles / (float)popolation.Infected);
					//float ds = -(1000F * 1000F * 10) / ((float)popolation.Susceptibles * (float)popolation.Infected);
					this.xyDSIR.Cartesian.Point(ticks, ds, CoViD.CL.Person.SIRStates.Susceptible.ToColor());
				}

				if (popolation.Infected != 0) // && popolation.DInfected == 1
				{
					float di = 1000F * (float)popolation.DInfected / (float)popolation.Infected;
					//float di = (float)popolation.DInfected10;
					//float di = 1000F / (float)popolation.Infected;
					this.xyDSIR.Cartesian.Point(ticks, di, CoViD.CL.Person.SIRStates.Infected.ToColor());
				}

				if (popolation.Recovered != 0)
				{
					float dr = 1000F * (float)popolation.DRecovered / (float)popolation.Recovered;
					//float dr = 1000F  / (float)popolation.Infected;
					this.xyDSIR.Cartesian.Point(ticks, dr, CoViD.CL.Person.SIRStates.Recovered.ToColor());
				}

				this.xyContaminated.Cartesian.Point(ticks, this.Grid.Contaminated.Count, Color.Red);

				this.tsTicks.Text = ticks.ToText();

				this.tsSusceptibles.Text = this.Grid.Popolation.Susceptibles.ToText();
				this.tsInfected.Text = this.Grid.Popolation.Infected.ToText();
				this.tsRecovered.Text = this.Grid.Popolation.Recovered.ToText();
				this.tsImmune.Text = this.Grid.Popolation.Immunes.ToText();
				this.tsDead.Text = this.Grid.Popolation.Deads.ToText();
				
				this.tsContaminatedGrids.Text = this.Grid.Contaminated.Count.ToText();
							   				 
				var percent = (int)Math.Min(100, Math.Round((100F * ((float)ticks / this.udTicks.Value))));
				if (!this.tsProgressBar.IsDisposed) { this.tsProgressBar.Value = percent; }

				System.Threading.Thread.Sleep(0);

				CoViD.Program.stopwatch.Stop();

				this.xyPerformances.Cartesian.Point(ticks, CoViD.Program.stopwatch.Elapsed.Milliseconds, Color.Yellow);

				if ((ticks & 3) == 3) { 
					Application.DoEvents(); 
				}


				this.Contaminate();
			}

			if (this.Grid.Ticks >= this.udTicks.Value)
			{
				tsbPlay.Enabled = false;
				tsbPause.Enabled = false;
			}
			this.legend1.CheckedChanged += this.Legend1_CheckedChanged;

			Application.DoEvents();
		}

		private void ShowPeople()
		{
			this.grid1.Cartesian.Clear();

			var image1 = this.grid1.Cartesian.NewGraph();

			foreach (var person in this.Grid.Popolation)
			{
				var location = person.IsSevere ? this.Grid.Hospitals[0].Location : person.Location;
				//var location = person.Location;

				var draw =
					(this.legend1.IsSusceptible && person.IsSusceptible) ||
					(this.legend1.IsLatency && person.IsLatency) ||
					(this.legend1.IsIll && person.IsIll) ||
					(this.legend1.IsSevere && person.IsSevere) ||
					(this.legend1.IsConvalescent && person.IsConvalescent) ||
					(this.legend1.IsImmune && person.IsImmune) ||
					(this.legend1.IsDead && person.IsDead);

				if (draw) { image1.Point(location.X, location.Y, person.State.ToColor()); }

			}

			this.grid1.Image = image1;

		}

		private void ShowContaminated(int tick)
		{
			this.grid2.Cartesian.Clear();

			var image2 = this.grid2.Cartesian.NewGraph();

			foreach (var point in this.Grid.Contaminated)
			{
				image2.Point(point.X, point.Y, Color.Red);
			}

			this.grid2.Image = image2;

		}

		/// <summary>
		/// Adjust the widths of the items in the 'StatusStrip' based on the current settings.
		/// </summary>
		private void InitializeStatusStrip()
		{
			Action<ToolStripStatusLabel, float> adjust = (ts, value) =>
			{
				ts.AutoSize = true;
				ts.Text = value.ToText(0);
				var width = ts.Width + 5;
				ts.Text = "0";
				ts.AutoSize = false;
				ts.Width = width;
				ts.TextAlign = ContentAlignment.MiddleLeft;
			};

			var people = this.udPeople.Value;

			adjust(this.tsTicks, this.udTicks.Value);
			adjust(this.tsSusceptibles, people);
			adjust(this.tsInfected, people);
			adjust(this.tsRecovered, people);
			adjust(this.tsImmune, people);
			adjust(this.tsDead, people);

			var contaminatedGrids = (float)Math.Pow((this.udRadius.Value / 100F), 2);

			adjust(this.tsContaminatedGrids, contaminatedGrids);
		}

		private float Person_Inhale(CoViD.CL.Point location)
		{
			return this.Grid.GetViruses(location);
		}

		private void Person_Sneeze(float viruses, CoViD.CL.Point location)
		{
			this.Grid.Contaminate(viruses, location);
		}

	}
}

