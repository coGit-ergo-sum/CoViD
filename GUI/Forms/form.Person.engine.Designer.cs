using CoViD.GUI.Tools.Extensions.Person;
using System;
using System.Drawing;
using System.Windows.Forms;
using Vi.Tools.Extensions.Float;
using Vi.Tools.Extensions.Int;

namespace CoViD.GUI.Forms
{
	partial class Person
	{
		int TicksMax;

		private void Initialize()
		{
			this.InitializeStatusStrip();

			var radius = (int)udRadius.Value;
			var people = 1; // (int)this.udPeople.Value;
			byte steps = (byte)udSteps.Value;
			this.TicksMax = (int)udTicks.Value;
			CoViD.CL.Person.SegregationThreshold = (byte)this.udSegregationThreshold.Value;


			this.grid1.SetXY(radius, "People");
			this.grid2.SetXY(radius, "Contamination");

			var tv = (this.TicksMax / 1);
			this.xyViruses.SetXY(
				0, tv, "0", tv.ToText(), "Ticks",
				0, 1, "0", 1.ToText(), ""
			);

			// ------------------------------------------------------------------------------------- //

			var popolation = new CoViD.CL.Popolation();

			for (int i = 0; i < people; i++)
			{
				var locations = new CoViD.CL.Locations(radius, steps);
				var person = new CoViD.CL.Person(locations);
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

			// XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX //
			// Simulate the sneeze of the first infected person. This creates a contaminated grid
			this.Grid.Contaminate(1000, new CoViD.CL.Point(0, 0));
			// XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX //

		}

		private void Grid_Remove(float x, float y)
		{
			this.grid2.Cartesian.Point(x, y, Color.Black);
		}
		private void Grid_Add(float x, float y)
		{
			this.grid2.Cartesian.Point(x, y, Color.Red);
		}

		private void Play()
		{
			this.InitializeStatusStrip();
			//var counter = 0;
			//while (this.Grid.Ticks < this.TicksMax)
			//{
			//	this.Grid.Tick();

			//	this.ShowPeople(this.Grid.Ticks);

			//	this.grid1.Cartesian.Point(0, 0, this.Grid.Popolation[0].State.ToColor());
			//	this.xyViruses.Cartesian.Point(counter, this.Grid.Popolation[0].VirusPercent, this.Grid.Popolation[0].State.ToColor());
			//	counter++;
			//}

			while (this.Grid.Ticks < this.TicksMax)
			{
				var ticks = this.Grid.Ticks;
				this.Grid.Tick();
				this.ShowPeople(this.Grid.Ticks);
				////////this.ShowContaminated(this.Grid.Ticks);

				this.tsTicks.Text = this.Grid.Ticks.ToText();

				var percent = (int)Math.Min(100, Math.Round((100F * ((float)this.Grid.Ticks / this.udTicks.Value))));
				if (!this.tsProgressBar.IsDisposed) { this.tsProgressBar.Value = percent; }

				if ((ticks % 10) == 0) { Application.DoEvents(); }
			}

			if (this.Grid.Ticks >= this.udTicks.Value)
			{
				tsbPlay.Enabled = false;
				tsbPause.Enabled = false;
			}

			Application.DoEvents();
		}

		private void ShowPeople(int tick)
		{

			foreach (var person in this.Grid.Popolation)
			{
				var location = person.IsSevere ? this.Grid.Hospitals[0].Location : person.Location;
				this.grid1.Cartesian.Point(location.X, location.Y, person.State.ToColor());
				this.xyViruses.Cartesian.Point(tick, person.VirusPercent, person.State.ToColor());
			}

			this.tsContaminatedGrids.Text = this.Grid.Contaminated.Count.ToText();

			this.tsSusceptibles.Text = this.Grid.Popolation.Susceptibles.ToText();
			this.tsInfected.Text = this.Grid.Popolation.Infected.ToText();
			this.tsRecovered.Text = this.Grid.Popolation.Recovered.ToText();
			this.tsImmune.Text = this.Grid.Popolation.Immunes.ToText();
			this.tsDead.Text = this.Grid.Popolation.Deads.ToText();

			//Application.DoEvents();
		}

		////////////private void ShowContaminated(int tick)
		////////////{
		////////////	/////Application.DoEvents();

		////////////	//this.grid2.Cartesian.Clear();

		////////////	//var image2 = this.grid2.Cartesian.NewGraph();

			
		////////////	foreach (var point in this.Grid.Contaminated)
		////////////	{
		////////////		this.grid2.Cartesian.Point(point.X, point.Y, Color.Red);
		////////////	}
			

		////////////	//this.grid2.Image = image2;

		////////////	//Application.DoEvents();
		////////////}


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

			var ticks = this.udTicks.Value;

			adjust(this.tsTicks, ticks);
			adjust(this.tsSusceptibles, ticks);
			adjust(this.tsInfected, ticks);
			adjust(this.tsRecovered, ticks);
			adjust(this.tsImmune, ticks);
			adjust(this.tsDead, ticks);

			var contaminatedGrids = (float)Math.Pow((this.udRadius.Value / 100F), 2);

			adjust(this.tsContaminatedGrids, contaminatedGrids);
		}

		private float Person_Inhale(CoViD.CL.Point location)
		{
			return 1000 + this.Grid.GetViruses(location);
		}

		private void Person_Sneeze(float viruses, CoViD.CL.Point location)
		{
			this.Grid.Contaminate(viruses, location);
		}

	}
}