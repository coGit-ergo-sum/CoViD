using System;
using System.Collections.Generic;
using System.Text;

using Vi.Tools.Extensions.Random;

namespace CoViD.CL
{
	/// <summary>
	/// 
	/// </summary>
	public class Population : System.Collections.Generic.List<CoViD.CL.Person>
	{
		#region SIR

		/// <summary>
		/// The total number of persons
		/// </summary>
		public int N
		{
			get { return this.Count; }
			private set { }
		}

		/// <summary>
		///  The number of susceptible individuals. When a susceptible and an infectious individual come into "infectious contact", the susceptible individual contracts the disease and transitions to the infectious compartment. [Wiki]
		/// </summary>
		public int Susceptibles = 0;

		/// <summary>
		/// The number of infectious individuals. These are individuals who have been infected and are capable of infecting susceptible individuals. [Wiki]
		/// </summary>
		public int Infected = 0;

		/// <summary>
		/// for the number of removed (and immune) or deceased individuals. These are individuals who have been infected and have either recovered from the disease and entered the removed compartment, or died. It is assumed that the number of deaths is negligible with respect to the total population. This compartment may also be called "recovered" or "resistant". [Wiki]
		/// </summary>
		public int Recovered = 0;

		/// <summary>
		/// Delta Susceptibles. The increments of the 'Susceptibles'.
		/// </summary>
		public int DSusceptibles = 0;

		/// <summary>
		/// Delta Infected. The increments of the 'Infected'.
		/// </summary>
		public int DInfected = 0;

		/// <summary>
		/// Delta Recovered. The increments of the 'Recovered'.
		/// </summary>
		public int DRecovered = 0;
		#endregion

		/// <summary>
		/// The number of person in 'Latency': infected but still not contagious.
		/// </summary>
		public int Latency = 0;

		/// <summary>
		/// The number of person 'ill'
		/// </summary>
		public int Ill = 0;

		/// <summary>
		/// The number of person in need of Hospitalization
		/// </summary>
		public int Severe = 0;

		/// <summary>
		/// The number of person 
		/// </summary>
		public int Convalescent = 0;

		/// <summary>
		/// The number of people recovered alive from the illness.
		/// </summary>
		public int Immunes = 0;

		/// <summary>
		/// The number of people recovered dead from the illness.
		/// </summary>
		public int Deads = 0;

		/// <summary>
		/// In the theory of SIR equation γ the probability of an infectious individual recovering. 
		/// </summary>
		public double γ = 0;

		/// <summary>
		/// In the theory of SIR equation β is the average number of contacts per person per time and is a given value
		/// In this model is a calculated  value. 
		/// </summary>
		public double β = 0;

		/// <summary>
		/// Resets all the Person in this Population
		/// </summary>
		public void Reset() {
			this.ForEach(person => person.Reset()); 
		}



		/// <summary>
		/// Runs the single unit of time. (Resets all the counter calls 'Tick' on all the person and sets all the statistics):
		/// </summary>
		public void Tick()
		{
			int infected = 0;
			int recovered = 0;

			this.Latency = 0;
			this.Ill = 0;
			this.Severe = 0;
			this.Convalescent = 0;
			this.Immunes = 0;
			this.Deads = 0;

			this.ForEach((person) =>
			{
				person.Tick();

				infected += person.IsI ? 1 : 0;
				recovered += person.IsR ? 1 : 0;

				this.Latency += person.IsLatency ? 1 : 0;
				this.Ill += person.IsIll ? 1 : 0;
				this.Severe += person.IsSevere ? 1 : 0;
				this.Convalescent += person.IsConvalescent ? 1 : 0;
				this.Immunes += person.IsImmune ? 1 : 0;
				this.Deads += person.IsDead ? 1 : 0;
			});

			this.DInfected = infected - this.Infected;

			this.DRecovered = recovered -  this.Recovered;
			this.DSusceptibles =  - (this.DInfected + this.DRecovered);

			this.γ = (double)this.DRecovered / (double)this.Infected;

			double IS = (double)this.Infected * (double)this.Susceptibles;
			this.β = (this.N / IS) * (double)this.DSusceptibles;


			this.Susceptibles = this.Count - (infected + recovered);
			this.Infected = infected;
			this.Recovered = recovered;
		}

	}
}