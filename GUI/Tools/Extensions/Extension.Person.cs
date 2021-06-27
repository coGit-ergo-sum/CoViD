using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Vi.Tools.Extensions.String;
using Vi.Tools.Extensions.Float;
using System.Drawing;

namespace CoViD.GUI.Tools.Extensions.Person
{
	public static class Methods
	{
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

