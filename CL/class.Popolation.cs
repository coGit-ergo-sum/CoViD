using System;
using System.Collections.Generic;
using System.Text;

using Vi.Tools.Extensions.Random;

namespace CoViD.CL
{
	public class Popolation : System.Collections.Generic.List<CoViD.CL.Person>
	{
		#region SIR
		public int Susceptibles = 0;
		public int Infected = 0;
		public int Recovered = 0;

		public int DSusceptibles = 0;
		public int DInfected = 0;
		//////////////public float DInfected10 = 0;
		////////////public List<int> _DInfected10 = new List<int>();
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
		public int Immunes = 0;
		public int Deads = 0;

		public void Reset() {
			//////////base.Reset();
			this.ForEach(person => person.Reset()); 
		}
		new public void Tick()
		{
			//int susceptibles = 0; ;
			int infected = 0;
			int recovered = 0;

			//this.DSusceptibles = 0;
			//this.DInfected = 0;
			//this.DRecovered = 0;

			this.Latency = 0;
			this.Ill = 0;
			this.Severe = 0;
			this.Convalescent = 0;
			this.Immunes = 0;
			this.Deads = 0;

			this.ForEach((person) =>
			{
				//this.Susceptibles = this.Count;
				person.Tick();

				/////susceptibles += person.IsSusceptible ? 1 : 0;
				infected += person.IsI ? 1 : 0;
				recovered += person.IsR ? 1 : 0;

				this.Latency += person.IsLatency ? 1 : 0;
				this.Ill += person.IsIll ? 1 : 0;
				this.Severe += person.IsSevere ? 1 : 0;
				this.Convalescent += person.IsConvalescent ? 1 : 0;
				this.Immunes += person.IsImmune ? 1 : 0;
				this.Deads += person.IsDead ? 1 : 0;
			});

			/////int susceptibles = this.Count - (infected + recovered); ;

			////////this.DSusceptibles = this.Susceptibles - (infected + recovered);
			this.DInfected = infected - this.Infected;
			////////////this._DInfected10.Add(this.DInfected);
			////////////if (this._DInfected10.Count > 20) { this._DInfected10.RemoveAt(0); }
			////////////if (this._DInfected10.Count > 20) { this._DInfected10.RemoveAt(0); }
			////////////if (this._DInfected10.Count == 20) { 
			////////////	this.DInfected10 = 
			////////////		(float)(
			////////////		this._DInfected10[0] + this._DInfected10[1] + this._DInfected10[2] + this._DInfected10[3] + this._DInfected10[4] + this._DInfected10[5] + this._DInfected10[6] + this._DInfected10[7] + this._DInfected10[8] + this._DInfected10[9] +
			////////////		this._DInfected10[10] + this._DInfected10[11] + this._DInfected10[12] + this._DInfected10[13] + this._DInfected10[14] + this._DInfected10[15] + this._DInfected10[16] + this._DInfected10[17] + this._DInfected10[18] + this._DInfected10[19]) / 20F; 
			
			////////////}

			this.DRecovered = recovered -  this.Recovered;
			this.DSusceptibles =  - (this.DInfected + this.DRecovered);

			this.Susceptibles = this.Count - (infected + recovered);
			this.Infected = infected;
			this.Recovered = recovered;
		}

		//new void Add(Person person);
	}
}