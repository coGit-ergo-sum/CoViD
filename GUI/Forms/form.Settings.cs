using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Vi.Tools.Extensions.Int;
using Vi.Tools.Extensions.String;
using CoViD.GUI.Tools.Extensions.Profile;


namespace CoViD.GUI.Forms
{
	public partial class Settings : Form
	{
		private CoViD.INI INI;
		public Settings()
		{
			InitializeComponent();
		}

		private void mniOpen_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(Program.profile.FileName);
		}

		private void Settings_Load(object sender, EventArgs e)
		{
			this.Location = Program.profile.Read(this.Name, "Location", this.Location);
			this.Size = Program.profile.Read(this.Name, "Size", this.Size);

			this.INI = Program.profile.Read(new CoViD.INI());

			this.udPeople.Value = this.INI.People;
			this.udRadius.Value = this.INI.Radius;
			this.udSegregationThreshold.Value = this.INI.Segregation;
			this.udSteps.Value = this.INI.Steps;
			this.udTicks.Value = this.INI.Ticks;
		}

		private void Settings_FormClosing(object sender, FormClosingEventArgs e)
		{
			Program.profile.Write(this.Name, "Location", this.Location);
			Program.profile.Write(this.Name, "Size", this.Size);
			Program.profile.Write(this.INI);
		}


	}
}
