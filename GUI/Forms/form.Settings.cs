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
using Vi.Tools.Extensions.DialogResult;


namespace CoViD.GUI.Forms
{
	/// <summary>
	/// Form specialized to manage the settings.
	/// </summary>
	public partial class Settings : Form
	{
		/// <summary>
		/// contains the settings from the INI file (if exists) Default values otherwise.
		/// </summary>
		private CoViD.INI INI;

		/// <summary>
		/// Main CTor inizializes component.
		/// </summary>
		public Settings()
		{
			InitializeComponent();
		}

		private void mniOpen_Click(object sender, EventArgs e)
		{
			if (System.IO.File.Exists(Program.INICoViD.FileName))
			{
				System.Diagnostics.Process.Start(Program.INICoViD.FileName);
			}
			else
			{
				MessageBox.Show("File: " + Program.INICoViD.FileName + ", doesn't exist");
			}
		}

		private void Settings_Load(object sender, EventArgs e)
		{
			this.Location = Program.INIGUI.Read(this.Name, "Location", this.Location);
			this.Size = Program.INIGUI.Read(this.Name, "Size", this.Size);

			this.INI = Program.INICoViD.Read(new CoViD.INI());

			this.udPeople.Value = this.INI.People;
			this.udRadius.Value = this.INI.Radius;
			this.udSegregation.Value = this.INI.Segregation;
			this.udSteps.Value = this.INI.Steps;
			this.udTicks.Value = this.INI.Ticks;
		}

		private void Settings_FormClosing(object sender, FormClosingEventArgs e)
		{
			Program.INIGUI.Write(this.Name, "Location", this.Location);
			Program.INIGUI.Write(this.Name, "Size", this.Size);

			var ini = new CoViD.INI(udRadius, udPeople, udSteps, udTicks, udSegregation);

			if (ini != this.INI)
			{
				DialogResult result = MessageBox.Show("Settings are changed. Saving the changes will clear all the diagrams and restart the elaboration.\nWant you save changes?", "Data changed", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
				var data = result.IsYes() ? ini : INI;
				Program.INICoViD.Write(data);
			}
		}

		private void tabINI_SelectedIndexChanged(object sender, EventArgs e)
		{
			var SelectedIndex = tabINI.SelectedIndex;
			switch (tabINI.SelectedTab.Name)
			{
				case "tabGUI":
					Program.INIGUI.Write(new INI());
					txtINIGUI.Text = System.IO.File.ReadAllText(Program.INIGUI.FileName);
					break;

				case "tabCoViD":

					break;
			}


		}
	}
}
