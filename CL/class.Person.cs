
using System;
using System.Collections.Generic;
using System.Diagnostics;

/////using CoViD.GUI.Tools.Extensions.Person;
using Vi.Tools.Extensions.Random;
using Vi.Tools.Extensions.String;
using Vi.Tools.Extensions.Object;
using Vi.Tools.Extensions.Int;

// Entity, Code, Year, Under-5s, Under age 15, Under age 25, 25-64 years, 65+ years, Total population
//  Italy,  ITA, 2015,  2553684,      8167971,     13865056,    32332306,  13306850,         59504212

namespace CoViD.CL
{
	public class Person
	{
		internal class Values
		{
			internal float Viruses;
			internal float Antibodies;
			internal Values(float viruses, float antibodies)
			{
				this.Viruses = viruses;
				this.Antibodies = antibodies;
			}
		}

		// The random number generation starts from a seed value. If the same seed is used repeatedly, 
		// the same series of numbers is generated. One way to produce different sequences is to make the 
		// seed value time-dependent, thereby producing a different series with each new instance of Random.
		// But if the machine generates 'persons' too quicly, the time dipendent seed value does not have the
		// time to change and the sequences created by two instance of 'this.Rnd' are ugual. 
		// Making the variable static ensures that only one object 'Rnd' exists: the same for all the 'Person' 
		private static Random Rnd = new Random();

		#region enums
		public enum States
		{
			Susceptible = 0,
			Latency,
			Ill,
			Severe,
			Convalescent,
			Immune,
			Dead
		}

		public enum SIRStates
		{
			Susceptible = 0,
			Infected = 1,
			Recovered = 2
		}

		public enum Ages
		{
			Under5s = 1,
			Under15 = 2,
			Under25 = 3,
			Under65 = 4,
			Plus65
		}
		#endregion

		#region events
		public delegate void SickDelegate();
		public event SickDelegate Sick;

		/*
		#region Latency
		public delegate void LatencyDelegate(CL.Point location);

		/// <summary>
		/// The person sneezes and spreads viruses
		/// </summary>
		/// <param name="viruses">The number of viruses a sneeze can emit.</param>
		/// <param name="x">The x location of the person.</param>
		/// <param name="y">The y location of the person.</param>
		public event LatencyDelegate Latency;

		/// <summary>
		/// Infrastructural methods: prevents the null reference exception
		/// </summary>
		/// <param name="viruses">Tghe number of viruses spreaded by the sneeze.</param>
		/// <param name="location">The current location of the person</param>
		private void OnLatency(CL.Point location)
		{
			if (this.Latency != null) { this.Latency(location); }
		}
		#endregion

		#region ILL
		public delegate void ILLDelegate(CL.Point location);

		/// <summary>
		/// The person sneezes and spreads viruses
		/// </summary>
		/// <param name="viruses">The number of viruses a sneeze can emit.</param>
		/// <param name="x">The x location of the person.</param>
		/// <param name="y">The y location of the person.</param>
		public event ILLDelegate Latency;

		/// <summary>
		/// Infrastructural methods: prevents the null reference exception
		/// </summary>
		/// <param name="viruses">Tghe number of viruses spreaded by the sneeze.</param>
		/// <param name="location">The current location of the person</param>
		private void OnILL(CL.Point location)
		{
			if (this.ILL != null) { this.ILL(location); }
		}
		#endregion

		#region Severe
		public delegate void SevereDelegate(CL.Point location);

		/// <summary>
		/// The person sneezes and spreads viruses
		/// </summary>
		/// <param name="viruses">The number of viruses a sneeze can emit.</param>
		/// <param name="x">The x location of the person.</param>
		/// <param name="y">The y location of the person.</param>
		public event SevereDelegate Severe;

		/// <summary>
		/// Infrastructural methods: prevents the null reference exception
		/// </summary>
		/// <param name="viruses">Tghe number of viruses spreaded by the sneeze.</param>
		/// <param name="location">The current location of the person</param>
		private void OnSevere(CL.Point location)
		{
			if (this.Severe != null) { this.Severe(location); }
		}
		#endregion

		#region Dead
		public delegate void DeadDelegate(CL.Point location);

		/// <summary>
		/// The person sneezes and spreads viruses
		/// </summary>
		/// <param name="viruses">The number of viruses a sneeze can emit.</param>
		/// <param name="x">The x location of the person.</param>
		/// <param name="y">The y location of the person.</param>
		public event DeadDelegate Dead;

		/// <summary>
		/// Infrastructural methods: prevents the null reference exception
		/// </summary>
		/// <param name="viruses">Tghe number of viruses spreaded by the sneeze.</param>
		/// <param name="location">The current location of the person</param>
		private void OnDead(CL.Point location)
		{
			if (this.Dead != null) { this.Dead(location); }
		}
		#endregion

		#region Recovered
		public delegate void RecoveredDelegate(CL.Point location);

		/// <summary>
		/// The person sneezes and spreads viruses
		/// </summary>
		/// <param name="viruses">The number of viruses a sneeze can emit.</param>
		/// <param name="x">The x location of the person.</param>
		/// <param name="y">The y location of the person.</param>
		public event RecoveredDelegate Recovered;

		/// <summary>
		/// Infrastructural methods: prevents the null reference exception
		/// </summary>
		/// <param name="viruses">Tghe number of viruses spreaded by the sneeze.</param>
		/// <param name="location">The current location of the person</param>
		private void OnRecovered(CL.Point location)
		{
			if (this.Recovered != null) { this.Recovered(location); }
		}
		#endregion
		*/
		
		#region Sneeze
		public delegate void SneezeDelegate(float viruses, CL.Point location);

		/// <summary>
		/// The person sneezes and spreads viruses
		/// </summary>
		/// <param name="viruses">The number of viruses a sneeze can emit.</param>
		/// <param name="x">The x location of the person.</param>
		/// <param name="y">The y location of the person.</param>
		public event SneezeDelegate Sneeze;

		/// <summary>
		/// Infrastructural methods: prevents the null reference exception
		/// </summary>
		/// <param name="viruses">Tghe number of viruses spreaded by the sneeze.</param>
		/// <param name="location">The current location of the person</param>
		[DebuggerStepThrough]
		private void OnSneeze(float viruses, CL.Point location)
		{
			if (this.Sneeze != null) { this.Sneeze(viruses, location); }
		}
		#endregion

		#region Touch
		public delegate ulong TouchDelegate(ulong viruses, CL.Point location);
		public event TouchDelegate Touch;
		[DebuggerStepThrough]
		private ulong OnTouch(ulong viruses)
		{
			return (this.Touch == null) ? 0 : this.Touch(viruses, this.Location);
		}
		#endregion

		#region Inhale
		public delegate float InhaleDelegate(CL.Point location);
		public event InhaleDelegate Inhale;
		//[DebuggerStepThrough]
		private float OnInhale()
		{
			//return 
			//	((this.Inhale == null) || (this.Location == null)) ? 0 : this.Inhale(this.Location);
			return
				(this.Inhale == null) ? 0 : this.Inhale(this.Location);
		}
		#endregion

		#region Exhale
		public delegate void ExhaleDelegate(int viruses, int x, int y);
		public event ExhaleDelegate Exhale;
		[DebuggerStepThrough]
		private void OnExhale(int viruses, int x, int y)
		{
			if (this.Exhale != null) { this.Exhale(viruses, x, y); }
		}
		#endregion

		#region Cough
		public delegate void CoughDelegate(int viruses, int x, int y);
		public event CoughDelegate Cough;
		[DebuggerStepThrough]
		private void OnCough(int viruses, int x, int y)
		{
			if (this.Cough != null) { this.Cough(viruses, x, y); }
		}
		#endregion
		#endregion

		#region Properties
		/// <summary>
		///  Antibodies's growth ratio
		/// </summary>
		public float AntibodyGrowthRatio { get; private set; }
		public float AntibodyGrowthPercent { get; private set; }

		/// <summary>
		///  Antibodies's decay ratio
		/// </summary>
		public float AntibodyDecayRatio { get; private set; }
		public float AntibodyDecayPercent { get; private set; }

		/// <summary>
		/// The 'theoric' growth ratio for the virus. (here plays the rule of the maximum growth ratio.)
		/// </summary>
		public float VirusGrowthRatio { get; private set; }

		/// <summary>
		/// The 'ongoing' growth ratio:  
		/// _VirusGrowthRatio = VirusGrowthRatio - ((VirusGrowthRatio - 1)/100) * VirusPercent
		/// (It is a linear interpolation between 1 and VirusGrowthRatio.)
		/// </summary>
		public float _VirusGrowthRatio{ get; private set; }

		/// <summary>
		/// The 'theoric' growth percentage for the virus. (here plays the rule of the maximum growth percentage.)
		/// </summary>
		public float VirusGrowthPercent { get; private set; }


		public float Age { get; private set; }

		/// <summary>
		/// Max number of ("unities") of viruses in a body.
		/// (Used to get a limit to the growth of the number of viruses.)
		/// </summary>
		public static float VirusLimit = 1000 * 1000 * 1000;

		public float DeadThreshold{ get; private set; }


		public float VirusMaxPercent { get; private set; }
		public float VirusPercent { get; private set; }
		public float VirusMax { get; private set; }
		#endregion

		#region Locations
		private int Ticks = 0;


		/// <summary>
		/// Gets the current location of the person.
		/// </summary>
		public CL.Point Location
		{
			get
			{
				var stayAtHome = this.IsSegregated || this.IsSevere;
				return stayAtHome ? this.Home : this.Locations[this.Ticks];
			}
			set { }
		}
				//////return this.Locations[this.Ticks]; } private set { } }
		//////////public CL.Point Location { get; private set; }

		public CL.Point Home { get { return this.Locations[0]; } private set { } }

		/// <summary>
		/// List of the location of the person during the simulation.
		/// </summary>
		public CoViD.CL.Locations Locations;
		#endregion

		/// <summary>
		/// The current state of health
		/// </summary>
		public Person.States State;

		/// <summary>
		/// The current SIR's state
		/// </summary>
		public Person.SIRStates SIR;


		public bool IsSusceptible { get { return this.State == States.Susceptible; } }
		public bool IsLatency { get { return this.State == States.Latency; } }
		public bool IsIll { get { return this.State == States.Ill; } }
		public bool IsSevere { get { return this.State == States.Severe; } }
		public bool IsConvalescent { get { return this.State == States.Convalescent; } }
		public bool IsImmune { get { return this.State == States.Immune; } }
		public bool IsDead { get { return this.State == States.Dead; } }

		public bool IsS { get { return this.SIR == SIRStates.Susceptible; } }
		public bool IsI { get { return this.SIR == SIRStates.Infected; } }
		public bool IsR { get { return this.SIR == SIRStates.Recovered; } }

		/// <summary>
		/// True if the mobility of this person is lower than 'SegregationThreshold'.
		/// (The person must stay at home (Locations[0]) when it is segregated.)
		/// </summary>
		public bool IsSegregated { get { return this.Mobility < CoViD.CL.Person.SegregationThreshold; } }

		#region Mobility
		/// <summary>
		/// A value imposed from the outside (a government) to decide who can move during a segregation period
		/// and who is forced to stay at home. (0 everyone is free to move; 255 eveyone is confinated at home.)
		/// </summary>
		public static byte SegregationThreshold = 0;

		/// <summary>
		/// Is the 'right' to move, a person has when 'segregation' is started: who has mobility < SegregationLevel 
		/// is forced to stay at home.
		/// </summary>
		public byte Mobility { get; private set; }
		#endregion

		public void Reset()
		{
			//this.Locations.Reset();
			this.counter = 0;
			this.Ticks = 0;
			this._Viruses = 0;
			this.Antibodies = 0;
			this.VirusMax = 0;
			this.VirusPercent = 0;
			this.VirusMaxPercent = 0;
			this._VirusGrowthRatio = this.VirusGrowthRatio;

			this.State = States.Susceptible;
			this.SIR = SIRStates.Susceptible;

		}

		/// <summary>
		/// the number of viruses. Should be regarded as the number of "unities" of viruses
		/// </summary>
		private float _Viruses;
		public float Viruses
		{
			private set
			{
				bool isWorsening = this._Viruses < value;
				bool isSteady = this._Viruses == value;
				bool isRecovering = (this._Viruses > value);///// && (this._Viruses > 0);

				this._Viruses = value;
				this.VirusMax = Math.Max(this.VirusMax, value);
				this.VirusPercent = (value / Person.VirusLimit);
				this.VirusMaxPercent = Math.Max(this.VirusMaxPercent, this.VirusPercent);

				//////////if (this.VirusPercent > this.DeadThreshold) { 
				//////////	this.State = States.Dead; }
				//////////else if (this.VirusPercent > 0.666) { this.State = States.Severe; }
				//////////else if (this.VirusPercent > 0.333 && isWorsening) { this.State = States.Ill; }
				//////////else if (this.VirusPercent > 0.001 && isWorsening) { this.State = States.Latency; }
				//////////else if (this.VirusPercent < 0.001 && this.VirusMax > value) { this.State = States.Immune; }
				//////////else if (this.VirusPercent < 0.666 && isRecovering) { this.State = States.Convalescent; }
				//////////else { this.State = States.Susceptible; }

				//////////if (this.IsSusceptible) { this.SIR = SIRStates.Susceptible; }
				//////////else if (this.IsLatency || this.IsIll || this.IsSevere || this.IsConvalescent) { this.SIR = SIRStates.Infected; }
				//////////else if (this.IsImmune || this.IsDead)  { this.SIR = SIRStates.Recovered; }
				//////////else { throw new System.Exception("Unexpected condition."); }
				///////////isWorsening = true;
				////////this.State =
				////////	(this.VirusPercent > this.DeadThreshold) ? States.Dead :
				////////	(this.VirusPercent > 0.666) ? States.Severe :
				////////	(this.VirusPercent > 0.333 && isWorsening) ? States.Ill :
				////////	(this.VirusPercent > 0.001 && isWorsening) ? States.Latency :
				////////	(this.VirusPercent < 0.001 && this.VirusMax > value) ? States.Immune :
				////////	(this.VirusPercent < 0.666 && isRecovering) ? States.Convalescent :
				////////	States.Susceptible;
				///

				this.State =
					(this.VirusPercent > this.DeadThreshold) ? States.Dead :
					isSteady ? this.State :
					(this.VirusPercent > 0.666) ? States.Severe :
					(this.VirusPercent > 0.333 && isWorsening) ? States.Ill :
					(this.VirusPercent > 0.333 && isRecovering) ? States.Convalescent :
					isWorsening ? States.Latency :
					isRecovering ? States.Immune :			
					States.Susceptible;///

				this.SIR =
					(this.IsSusceptible) ? SIRStates.Susceptible :
					(this.IsLatency || this.IsIll || this.IsSevere || this.IsConvalescent) ? SIRStates.Infected :
					(this.IsImmune || this.IsDead) ? SIRStates.Recovered :
					throw new System.Exception("Unexpected condition.");

				if (this.IsIll || this.IsSevere) {
					var location = this.Location;
					this.OnSneeze(1000, location);
				}
			}

			get { return (ulong)this._Viruses; }
		}

		public float Antibodies
		{
			get;
			private set;
		}

		#region Tick

		public void Tick()
		{
			if (!this.IsDead)
			{
				var newViruses = this.OnInhale();
				this.Tick(newViruses);
			}
		}
		static int counterMin = 500;
		static int counterMax = counterMin + 100;
		int counter = 0;
		public void Tick(float newViruses)
		{
			
			this.Antibodies = 0;
			if (((newViruses > 0) || (counter > 0))  && (counter < counterMax))
			{
				if (counter > counterMin)
				{
					this.Viruses = 600 * 1000 * 1000;
					//this.Viruses = Math.Min(600, counter) * 1000 * 1000;
				}
				else
				{
					this.Viruses = 0;
				}
				counter++;
			}
			else 
			{
				this.Viruses = 0;
			}
			this.Ticks++;
			
			
			//ToDo Analize the Erlang distribution: https://en.wikipedia.org/wiki/Erlang_distribution
			/*
			float viruses = this._Viruses;
			float antibodies = (float)this.Antibodies;

			// slope of the segment between 1 and 'Y'
			float m = ((this.VirusGrowthRatio - (float)1) / (float)100);

			// Percent of virus's spread
			float p = (float)100 * (viruses / Person.VirusLimit);

			// Interpolation of the growth rate between 1 (no growth) and 'Y' (max growth rate)
			this._VirusGrowthRatio = Math.Min(this._VirusGrowthRatio, this.VirusGrowthRatio - (m * p));
			//rv = Y - (m * p);


			// the new viruses's popolation.
			viruses = newViruses + (viruses * this._VirusGrowthRatio);
			antibodies = (antibodies + (viruses * AntibodyGrowthPercent * VirusGrowthPercent)) * (AntibodyDecayRatio * 1F);

			viruses = Math.Max((float)0, viruses - (antibodies * (float)0.25));

			this.Antibodies = antibodies;
			this.Viruses = viruses;
			this.Ticks++;
			*/
		}
		#endregion

		#region CTors


		public Person(CoViD.CL.Locations locations)
		{
			this.Configure(locations);
		}

		public Person(
			CoViD.CL.Locations locations,
			CoViD.Types.Percent virusGrowth, 
			CoViD.Types.Percent antibodyGrowth,
			CoViD.Types.Percent antibodyDecay,
			CoViD.Types.Percent deadThreshold,
			byte mobility
		)
		{
			this.Configure(locations, virusGrowth, antibodyGrowth, antibodyDecay, mobility);
		}



		private void Configure(CoViD.CL.Locations locations)
		{
			// ATTENTION: do not create a new Rnd. Use  the static variable.
			var rnd = Person.Rnd;
			var antibodyGrowthPercent = ((float)rnd.Next(10, 40)) / (float)1000;
			var antibodyDecayPercent = ((float)rnd.Next(0, 12)) / (float)1000;
			var virusGrowthPercent = ((float)rnd.Next(20, 40)) / (float)1000;
			var mobility = (byte)rnd.Next(0, 255);

			this.Configure(locations, virusGrowthPercent, antibodyGrowthPercent, antibodyDecayPercent, mobility);

		}



		private void Configure(CoViD.CL.Locations locations, float virusGrowthPercent, float antibodyGrowthPercent, float antibodyDecayPercent, byte mobility)
		{
			///this.Reset();

			this.Locations = locations;
			this.SIR = SIRStates.Susceptible;
			this.State = States.Susceptible;

			this.AntibodyGrowthPercent = antibodyGrowthPercent;
			this.AntibodyDecayPercent = antibodyDecayPercent;
			this.VirusGrowthPercent = virusGrowthPercent;
			this.DeadThreshold = ((float)Person.Rnd.Next(72, 100, 3)) / (float)100;
			//this.DeadThreshold = (float)((float)Person.Rnd.Next(50000, 100000) / 100000F);
			this.Age = Person.Rnd.Next(0, 100, 4);

			this.AntibodyGrowthRatio = (float)1 + antibodyGrowthPercent;
			this.AntibodyDecayRatio = (float)1 - antibodyDecayPercent;
			this.VirusGrowthRatio = (float)1 + virusGrowthPercent;

			this._VirusGrowthRatio = this.VirusGrowthRatio;

			this.Mobility = mobility;

		}

		#endregion

	}
}

