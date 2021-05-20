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
using Vi.Tools.Extensions.Int;
using Vi.Tools.Extensions.Float;
using Vi.Tools.Extensions.Object;


namespace CoViD.GUI.Forms
{
	public partial class Persona : Form
	{
		private CoViD.CL.Area Area;
		int TicksMax;

		public Persona()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Initialize();
		}

		private void Play()
		{
			//this.InitializeStatusStrip();

			while (this.Area.Ticks < this.TicksMax)
			{
				this.Area.Tick();
				this.ShowPeople(this.Area.Ticks);
				this.ShowContaminated(this.Area.Ticks);

				this.tsTicks.Text = this.Area.Ticks.ToText();

				var percent = (int)Math.Min(100, Math.Round((100F * ((float)this.Area.Ticks / this.udTicks.Value))));
				if (!this.tsProgressBar.IsDisposed) { this.tsProgressBar.Value = percent; }

				System.Threading.Thread.Sleep(0);
			}

			if (this.Area.Ticks >= this.udTicks.Value)
			{
				tsbPlay.Enabled = false;
				tsbPause.Enabled = false;
			}
		}


		private void Initialize()
		{
			//this.InitializeStatusStrip();

			var radius = 20 * 1000;
			var people = 1;
			byte steps = 3;
			this.TicksMax = 4 * 1000;
			CoViD.CL.Person.SegregationThreshold = 0;


			this.area1.SetXY(radius, "People");
			this.area2.SetXY(radius, "Contamination");

			this.xy1.SetXY(
				0, this.TicksMax, "0", this.TicksMax.ToText(), "Ticks",
				0, people, "0", people.ToText(), "Viruses"
			);

			/*
			var y2Max = 4 * (radius / 100) * (radius / 100);
			this.xy2.SetXY(
				0, this.TicksMax, "0", this.TicksMax.ToText(), "Ticks",
				0, y2Max, "0", y2Max.ToText(), "Contaminated areas"
			);
			*/
			// ------------------------------------------------------------------------------------- //

			var popolation = new CoViD.CL.Popolation();

			for (int i = 0; i < people; i++)
			{
				var person = new CoViD.CL.Person(radius, steps);
				person.Sneeze += this.Person_Sneeze;
				person.Inhale += this.Person_Inhale;

				popolation.Add(person);
			}

			// ------------------------------------------------------------------------------------- //

			var hospitals = new CoViD.CL.Hospitals(){
				new CoViD.CL.Hospital(new CoViD.CL.Point(radius, radius), 500)
			};

			this.Area = new CoViD.CL.Area(radius, popolation, hospitals);

			// XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX //
			// Simulate the sneeze of the first infected person. This creates a contaminated area
			this.Area.Contaminate(1000, new CoViD.CL.Point(0, 0));
			// XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX //

		}


		private float Person_Inhale(CoViD.CL.Point location)
		{
			return this.Area.GetViruses(location);
		}

		private void Person_Sneeze(float viruses, CoViD.CL.Point location)
		{
			this.Area.Contaminate(viruses, location);
		}

	}
}
