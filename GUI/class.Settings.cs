using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

		public INI() : this(radius: 12000, people: 10000, steps: 1, ticks: 25000, segregation: 0) { }


		public INI(decimal radius, int people, byte steps, int ticks, decimal segregation)
		{
			this.Radius = radius;
			this.People = people;
			this.Steps = steps;
			this.Ticks = ticks;
			this.Segregation = new Vi.Types.Percentage(segregation);
		}

	}
}
