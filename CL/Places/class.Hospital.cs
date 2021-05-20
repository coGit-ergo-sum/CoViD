using System;
using System.Collections.Generic;
using System.Text;

namespace CoViD.CL
{
	public class Hospital
	{
		public CoViD.CL.Point Location;
		public readonly int Beds;

		public Hospital(CoViD.CL.Point location, int beds)
		{
			this.Location = location;
			this.Beds = beds;
		}

		public void Tick() { }
		public void Reset() { }
	}
}
