using System.Drawing;

namespace CoViD.GUI.Tools.Extensions.Person
{
	/// <summary>
	/// extension methods for the 'Person.States' and the 'Person.SIRStates'
	/// </summary>
	public static class Methods
	{
		/// <summary>
		/// Used when plotting diagrams to get the color associated to the state.
		/// </summary>
		/// <param name="state">One of the States</param>
		/// <returns>The color associated with the current State</returns>
		public static Color ToColor(this CoViD.CL.Person.States state)
		{
			var color =
				state == CL.Person.States.Latency ? Color.Yellow :
				state == CL.Person.States.Ill ? Color.FromArgb(102, 255, 51) : //Color.FromArgb(255, 153, 51) : //Color.FromArgb(255, 127, 0): // White :
				state == CL.Person.States.Severe ? Color.FromArgb(255, 51, 0) : //Color.White: // Color.Red :
				state == CL.Person.States.Convalescent ? Color.Cyan :
				state == CL.Person.States.Immune ? Color.LightGray: // Color.Green :
				state == CL.Person.States.Dead ? Color.Blue :
				Color.FromArgb(100, 100, 100);

			return color;
		}

		/// <summary>
		/// Used when plotting diagrams to get the color associated to the state.
		/// </summary>
		/// <param name="state">One of the SIR states</param>
		/// <returns>The color associated with the current SIRState</returns>
		public static Color ToColor(this CoViD.CL.Person.SIRStates state)
		{
			var color =
				state == CL.Person.SIRStates.Susceptible ? Color.Blue :
				state == CL.Person.SIRStates.Infected ? Color.Red :
				state == CL.Person.SIRStates.Recovered ? Color.Green :
				Color.FromArgb(100, 100, 100);

			return color;
		}
	}
}

