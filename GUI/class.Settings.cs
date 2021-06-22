using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vi.Tools.Extensions.Object;

namespace CoViD
{
	public class INI
	{
		/// <summary>
		/// 
		/// </summary>
		public decimal Radius;

		/// <summary>
		/// The number of people in the simulation;
		/// </summary>
		public int People;

		/// <summary>
		/// Specifies the kind of distribution
		/// </summary>
		public byte Steps;

		/// <summary>
		/// The max number of time unit. 
		/// </summary>
		public int Ticks;

		/// <summary>
		/// The percentage of people segregated at home.
		/// </summary>
		public Vi.Types.Percentage Segregation; //////

		/// <summary>
		/// Default CTor create an instance of an 'INI' having radius: 12000, people: 10000, steps: 1, ticks: 25000, segregation: 0
		/// </summary>
		public INI() : this(radius: 12000, people: 10000, steps: 1, ticks: 25000, segregation: 0) { }

		/// <summary>
		/// Create an instance of an 'INI' from the UpDown controls
		/// </summary>
		/// <param name="radius">The extention of the grid.</param>
		/// <param name="people"></param>
		/// <param name="steps"></param>
		/// <param name="ticks"></param>
		/// <param name="segregation"></param>
		public INI(CoViD.GUI.UC.UpDown radius, CoViD.GUI.UC.UpDown people, CoViD.GUI.UC.UpDown steps, CoViD.GUI.UC.UpDown ticks, CoViD.GUI.UC.UpDown segregation)
			:this(radius.Value, (int)people.Value, (byte)steps.Value, (int)ticks.Value, segregation.Value){}

		/// <summary>
		/// Main CTor Create an instance of INI set with the provided values		
		/// </summary>
		/// <param name="radius"></param>
		/// <param name="people"></param>
		/// <param name="steps"></param>
		/// <param name="ticks"></param>
		/// <param name="segregation"></param>
		public INI(decimal radius, int people, byte steps, int ticks, decimal segregation)
		{
			this.Radius = radius;
			this.People = people;
			this.Steps = steps;
			this.Ticks = ticks;
			this.Segregation = new Vi.Types.Percentage(segregation);
		}

		/// <summary>
		/// Compares two instance of the class INI checking if they are equal fied by field.
		/// </summary>
		/// <param name="iniL">One instance of the class INI</param>
		/// <param name="iniR">The other instance of the class INI</param>
		/// <returns></returns>
		public static bool operator ==(CoViD.INI iniL, CoViD.INI iniR)
		{
			return
			iniL.IsNotNull() &&
			iniR.IsNotNull() && (
				object.ReferenceEquals(iniL, iniR) ||
				(
					iniL.GetType() == iniR.GetType() &&
					iniL.Radius == iniR.Radius &&
					iniL.People == iniR.People &&
					iniL.Segregation == iniR.Segregation &&
					iniL.Steps == iniR.Steps &&
					iniL.Ticks == iniR.Ticks
				)
			);
		}

		/// <summary>
		/// Compares two instance of the class INI checking for disuguality 
		/// </summary>
		/// <param name="iniL">One instance of the class INI</param>
		/// <param name="iniR">The other instance of the class INI</param>
		/// <returns>True if both the parameters are not null and each filed in the left parameter is ugual to the same field in the right parameter. False otherwise.</returns>
		public static bool operator !=(CoViD.INI iniL, CoViD.INI iniR) => !(iniL == iniR);

		/// <summary>
		/// compare this instance with the provided instance of The INI class.
		/// </summary>
		/// <param name="ini">The other INI object to compare with this.</param>
		/// <returns>True if both the parameters are not null and each filed in the left parameter is ugual to the same field in the right parameter. False otherwise.</returns>
		public bool Equals(CoViD.INI ini)
		{
			return this == ini;
		}
	}
}
