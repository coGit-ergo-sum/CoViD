using System;
using System.Collections.Generic;
using System.Text;

namespace CoViD.CL
{
	/// <summary>
	/// A list of all the hospitals
	/// </summary>
	public class Hospitals : System.Collections.Generic.List<CoViD.CL.Hospital>
	{
		/// <summary>
		/// Main CTor (empty)
		/// </summary>
		public Hospitals() { }

		/// <summary>
		/// Resets each hospital in the list.
		/// </summary>
		public void Reset() { this.ForEach(hospital => hospital.Reset()); }

		/// <summary>
		/// Ticks each hospital in the list.
		/// </summary>
		public void Tick() { this.ForEach(hospital => hospital.Tick()); }
	}
}
