using System;
using System.Collections.Generic;
using System.Text;

namespace CoViD.CL
{
	/// <summary>
	/// The place where a person goes when its ilness become severe. 
	/// </summary>
	public class Hospital
	{
		/// <summary>
		/// The posizion on the grid.
		/// </summary>
		public CoViD.CL.Point Location;

		/// <summary>
		/// The number of bed available in the hospital.
		/// </summary>
		public readonly int Beds;

		/// <summary>
		/// Main CTor (sets location and beds).
		/// </summary>
		/// <param name="location">The posizion on the grid.</param>
		/// <param name="beds">The number of bed available in the hospital.</param>
		public Hospital(CoViD.CL.Point location, int beds)
		{
			this.Location = location;
			this.Beds = beds;
		}

		/// <summary>
		/// A unity of time (not implemented.)
		/// </summary>
		public void Tick() { }

		/// <summary>
		/// Re sets the hospital at its inizial status (not implemented.)
		/// </summary>
		public void Reset() { }
	}
}
