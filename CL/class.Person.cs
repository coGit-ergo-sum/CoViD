
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

		/// <summary>
		/// The possible states in this simulation
		/// </summary>
		public enum States
		{
			/// <summary>
			/// Who can be affected by an illness (the same as the SIR Model)
			/// </summary>
			Susceptible = 0,

			/// <summary>
			/// The symptomless incubation period
			/// </summary>
			Latency,

			/// <summary>
			/// The infection become evident and contagious.
			/// </summary>
			Ill,

			/// <summary>
			/// The disease has crossed a threshold and the person needs hospitalization.
			/// </summary>
			Severe,

			/// <summary>
			/// The disease has passed its peak and the person is doing better (not the concept of recovery in SIR)
			/// </summary>
			Convalescent,

			/// <summary>
			/// The illness is gone and the person is protected from disease.
			/// </summary>
			Immune,

			/// <summary>
			/// The person is dead.
			/// </summary>
			Dead
		}

		/// <summary>
		/// The possible states in a SIR model
		/// </summary>
		public enum SIRStates
		{
			/// <summary>
			/// Who can be affected by an illness
			/// </summary>
			Susceptible = 0,

			/// <summary>
			/// Who is affected by an illness
			/// </summary>
			Infected = 1,

			/// <summary>
			/// The disease has passed its peak, regardless the person is dead or alive
			/// </summary>
			Recovered = 2
		}

		/// <summary>
		/// Partition in five age ranges
		/// </summary>
		public enum Ages
		{
			/// <summary>
			/// Who with the age under 5 years
			/// </summary>
			Under5s = 1,

			/// <summary>
			/// Who with the age under 15 years
			/// </summary>
			Under15 = 2,

			/// <summary>
			/// Who with the age under 25 years
			/// </summary>
			Under25 = 3,

			/// <summary>
			/// Who with the age under 65 years
			/// </summary>
			Under65 = 4,

			/// <summary>
			/// Who with the age over 65 years
			/// </summary>
			Plus65
		}
		#endregion

		#region events
		/// <summary>
		/// The delegate for the 'Sick' event.
		/// </summary>
		public delegate void SickDelegate();

		/// <summary>
		/// Event raised when a person become 'Ill' (contagious)
		/// </summary>
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
		/// <summary>
		/// The delegate for the 'Sneeze' event. (Sneezing is one way that lets the viruses spread)
		/// </summary>
		/// <param name="viruses">The number of (unity of) viruses emitted with the sneeze.</param>
		/// <param name="location">The 'Point' infected by the sneeze.</param>
		public delegate void SneezeDelegate(decimal viruses, CL.Point location);

		/// <summary>
		/// Event raised each time the person sneezes, spreading viruses.
		/// </summary>
		public event SneezeDelegate Sneeze;

		/// <summary>
		/// Infrastructural methods: prevents the null reference exception
		/// </summary>
		/// <param name="viruses">The number of viruses spreaded by the sneeze.</param>
		/// <param name="location">The current location of the person</param>
		[DebuggerStepThrough]
		private void OnSneeze(decimal viruses, CL.Point location)
		{
			if (this.Sneeze != null) { this.Sneeze(viruses, location); }
		}
		#endregion

		#region Touch
		/// <summary>
		/// The delegate for the 'Touch' event. (Touching is the oter way that lets the viruses spread)
		/// </summary>
		/// <param name="viruses">The number of viruses spreaded by the sneeze.</param>
		/// <param name="location">The current location of the person</param>
		/// <returns></returns>
		public delegate ulong TouchDelegate(ulong viruses, CL.Point location);

		/// <summary>
		/// Event raised each time the person touches something, spreading viruses.
		/// </summary>
		public event TouchDelegate Touch;

		/// <summary>
		/// Infrastructural methods: prevents the null reference exception
		/// </summary>
		/// <param name="viruses"></param>
		/// <returns></returns>
		[DebuggerStepThrough]
		private ulong OnTouch(ulong viruses)
		{
			return (this.Touch == null) ? 0 : this.Touch(viruses, this.Location);
		}
		#endregion

		#region Inhale
		/// <summary>
		/// The delegate for the 'Inhale' event. (Inhaling is a way that lets the viruses enter the body)
		/// </summary>
		public delegate decimal InhaleDelegate(CL.Point location);
		public event InhaleDelegate Inhale;

		/// <summary>
		/// Infrastructural methods: prevents the null reference exception
		/// </summary>
		/// <returns></returns>
		//[DebuggerStepThrough]
		private decimal OnInhale()
		{
			//return 
			//	((this.Inhale == null) || (this.Location == null)) ? 0 : this.Inhale(this.Location);
			return
				(this.Inhale == null) ? 0 : this.Inhale(this.Location);
		}
		#endregion

		#region Exhale
		/// <summary>
		/// The delegate for the 'Exhale' event. (Inhaling is a way that lets the viruses enter the body)
		/// </summary>
		/// <param name="viruses">The number of viruses a sneeze can emit.</param>
		/// <param name="x">The x location of the person.</param>
		/// <param name="y">The y location of the person.</param>
		public delegate void ExhaleDelegate(int viruses, int x, int y);

		/// <summary>
		/// Infrastructural methods: prevents the null reference exception
		/// </summary>
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

		/// <summary>
		/// Infrastructural methods: prevents the null reference exception
		/// </summary>
		/// <param name="viruses"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
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
		public decimal AntibodyGrowthRatio { get; private set; }

		/// <summary>
		/// 
		/// </summary>
		public Vi.Types.Percentage AntibodyGrowth { get; private set; }

		/// <summary>
		///  Antibodies's decay ratio
		/// </summary>
		public decimal AntibodyDecayRatio { get; private set; }
		public Vi.Types.Percentage AntibodyDecay { get; private set; }

		/// <summary>
		/// The 'theoric' growth ratio for the virus. (here plays the rule of the maximum growth ratio.)
		/// </summary>
		public decimal VirusGrowthRatio { get; private set; }

		/// <summary>
		/// The 'ongoing' growth ratio:  
		/// _VirusGrowthRatio = VirusGrowthRatio - ((VirusGrowthRatio - 1)/100) * VirusPercent
		/// (It is a linear interpolation between 1 and VirusGrowthRatio.)
		/// </summary>
		public decimal _VirusGrowthRatio{ get; private set; }

		/// <summary>
		/// The 'theoric' growth percentage for the virus. (here plays the rule of the maximum growth percentage.)
		/// </summary>
		public Vi.Types.Percentage VirusGrowth { get; private set; }

		/// <summary>
		/// The age of the person
		/// </summary>
		public float Age { get; private set; }

		/// <summary>
		/// Max number of ("unities") of viruses in a body.
		/// (Used to get a limit to the growth of the number of viruses.)
		/// </summary>
		public static float VirusLimit = 1000 * 1000 * 1000;

		/// <summary>
		/// 
		/// </summary>
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
		public void Tick(decimal newViruses)
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


			// the new viruses's population.
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

		/// <summary>
		/// 
		/// </summary>
		/// <param name="locations"></param>
		public Person(CoViD.CL.Locations locations)
		{
			this.Configure(locations);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="locations"></param>
		/// <param name="virusGrowth"></param>
		/// <param name="antibodyGrowth"></param>
		/// <param name="antibodyDecay"></param>
		/// <param name="deadThreshold"></param>
		/// <param name="mobility"></param>
		public Person(
			CoViD.CL.Locations locations,
			Vi.Types.Percentage virusGrowth,
			Vi.Types.Percentage antibodyGrowth,
			Vi.Types.Percentage antibodyDecay,
			Vi.Types.Percentage deadThreshold,
			byte mobility
		)
		{
			this.Configure(locations, virusGrowth, antibodyGrowth, antibodyDecay, mobility);
		}



		private void Configure(CoViD.CL.Locations locations)
		{
			// ATTENTION: do not create a new Rnd. Use  the static variable.
			var rnd = Person.Rnd;
			var antibodyGrowth = ((decimal)rnd.Next(10, 40)) / (decimal)1000;
			var antibodyDecay = ((decimal)rnd.Next(0, 12)) / (decimal)1000;
			var virusGrowth = ((decimal)rnd.Next(20, 40)) / (decimal)1000;
			var mobility = (byte)rnd.Next(0, 255);

			this.Configure(locations, virusGrowth, antibodyGrowth, antibodyDecay, mobility);

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="locations"></param>
		/// <param name="virusGrowth"></param>
		/// <param name="antibodyGrowth"></param>
		/// <param name="antibodyDecay"></param>
		/// <param name="mobility"></param>
		private void Configure(CoViD.CL.Locations locations, Vi.Types.Percentage virusGrowth, Vi.Types.Percentage antibodyGrowth, Vi.Types.Percentage antibodyDecay, byte mobility)
		{

			this.Locations = locations;
			this.SIR = SIRStates.Susceptible;
			this.State = States.Susceptible;

			this.AntibodyGrowth = antibodyGrowth;
			this.AntibodyDecay = antibodyDecay;
			this.VirusGrowth = virusGrowth;
			this.DeadThreshold = ((float)Person.Rnd.Next(72, 100, 3)) / (float)100;
			//this.DeadThreshold = (float)((float)Person.Rnd.Next(50000, 100000) / 100000F);
			this.Age = Person.Rnd.Next(0, 100, 4);

			this.AntibodyGrowthRatio = (decimal)1 + antibodyGrowth.Value;
			this.AntibodyDecayRatio = (decimal)1 - antibodyDecay;
			this.VirusGrowthRatio = (decimal)1 + virusGrowth.Value;

			this._VirusGrowthRatio = this.VirusGrowthRatio;

			this.Mobility = mobility;

		}

		#endregion

	}
}

