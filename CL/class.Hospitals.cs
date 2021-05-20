using System;
using System.Collections.Generic;
using System.Text;

namespace CoViD.CL
{
	public class Hospitals : System.Collections.Generic.List<CoViD.CL.Hospital>
	{
		public Hospitals() { }
		public void Reset() { this.ForEach(hospital => hospital.Reset()); }
		public void Tick() { this.ForEach(hospital => hospital.Tick()); }
	}
}
