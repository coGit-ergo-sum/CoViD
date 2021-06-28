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
using Vi.Tools.Extensions.String;
using Vi.Tools.Extensions.Int;
using Vi.Tools.Extensions.Float;


namespace CoViD.GUI.Forms
{
	/// <summary>
	/// 
	/// </summary>
	public partial class Infection : Form
	{
		static Brush red = (Brush)Brushes.Red;
		static Brush black = (Brush)Brushes.Black;
		static Brush white = (Brush)Brushes.White;
		static Brush green = (Brush)Brushes.Lime;
		static Brush yellow = (Brush)Brushes.Yellow;
		static Brush blue = (Brush)Brushes.Blue;
		static Brush darkRed = (Brush)Brushes.DarkRed;
		static Brush gray = new SolidBrush(Color.FromArgb(50, 50, 50));

		//static Brush orange = (Brush)Brushes.Orange;
		static Brush orange = new SolidBrush(Color.FromArgb(255, 87, 51));

		private CoViD.CL.Person Person;

		public Infection()
		{
			InitializeComponent();
		}

		private void Disease_Load(object sender, EventArgs e) {
			this.Location = Program.INIGUI.Read(this.Name, "Location", this.Location);
			this.Size = Program.INIGUI.Read(this.Name, "Size", this.Size);
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			this.btnNewEvolution_Click(null, null);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnNewEvolution_Click(object sender, EventArgs e)
		{
			//this.ledGreen.On = false;
			//this.ledYellow.On = false;
			//this.ledRed.On = false;
			//this.ledBlue.On = false;
			//this.ledWhite.On = false;
			var person = new CoViD.CL.Person(new CoViD.CL.Locations() { new CoViD.CL.Point(0, 0) });
			this.Loop(person);
			this.Text = DateTime.Now.ToString();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="person"></param>
		private void Loop(CoViD.CL.Person person)
		{
			this.Person = person;
			float xMin = 0;
			float yMin = 0;
			float xMax = txtXMax.Text.ToFloat(1000);
			float yVMax = txtYVMax.Text.ToFloat(1000 * 1000 * 1000);
			float yAMax = txtYAMax.Text.ToFloat(150 * 1000 * 1000);

			this.xy1.SetXY(
				xMin, xMax, xMin.ToText(0), xMax.ToText(0), "Time [ticks]",
				yMin, yVMax, yMin.ToText(0), yVMax.ToString("0.00 E+00"), "# Viruses [Unities of]"
			);

			this.xy2.SetXY(
				xMin, xMax, xMin.ToText(0), xMax.ToText(0), "Time [ticks]",
				yMin, yAMax, yMin.ToText(0), yAMax.ToString("0.00 E+00"), "# Antibodies [Unities of]"
			);

			var viruses = udVirusesN.Value;
			Func<CoViD.CL.Point, decimal> person_Inhale = (location) => { 
				return viruses; 
			};
			person.Inhale += new CoViD.CL.Person.InhaleDelegate(person_Inhale);

			udVirusesGrowth.Value = person.VirusGrowth * 100;
			udAntibodiesGrowth.Value = person.AntibodyGrowth * 100;
			udAntibodiesDecay.Value = person.AntibodyDecay * 100;

			int iMax = txtXMax.Text.ToInt(1000);


			for (int i = 0; i < iMax; i++)
			{
				person.Tick();

				this.xy1.Cartesian.Point(i, person.Viruses, person.State.ToColor());
				this.xy2.Cartesian.Point(i, person.Antibodies, Color.Green);

				if (person.IsDead) { break; }
			}
			{
				lblVmax2.Text = "0"; // person.VirusMaxPercent.ToPercent2();
			}
		}

		private void ud_Click(object sender, EventArgs e) 
		{
			var virusGrowth = (decimal)(udVirusesGrowth.Value / 100);
			var antibodyGrowth = (decimal)(udAntibodiesGrowth.Value / 100);
			var antibodyDecay = (decimal)(udAntibodiesDecay.Value / 100);
			var deadThreshold = (decimal)0.95;
			byte mobility = 100;

			var locations = new CoViD.CL.Locations();
			var person = new CoViD.CL.Person(locations, virusGrowth,  antibodyGrowth, antibodyDecay, deadThreshold, mobility);

			Loop(person);
		}

		private void Disease_FormClosing(object sender, FormClosingEventArgs e)
		{
			Program.INIGUI.Write(this.Name, "Location", this.Location);
			Program.INIGUI.Write(this.Name, "Size", this.Size);
		}

	}
}
// NAADRSSSS