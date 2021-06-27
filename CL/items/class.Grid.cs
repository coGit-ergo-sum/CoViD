using System;
using System.Collections.Generic;
using Vi.Tools.Extensions.Object;

namespace CoViD.CL
{
	/// <summary>
	/// Is a square region made of points. (Simulates the place where the people lives and where the epidemic spreads.) 
	/// </summary>
	public class Grid
	{
		#region Events
		/// <summary>
		/// The delegate for the event Remove
		/// </summary>
		/// <param name="x">The x coordinate of the removing point.</param>
		/// <param name="y">The y coordinate of the removing point.</param>
		public delegate void RemoveDelegate(float x, float y);

		/// <summary>
		/// Event raised when a point is removed
		/// </summary>
		public event RemoveDelegate Remove;

		/// <summary>
		/// Infrastructural methods: prevents the null reference exception
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		private void OnRemove(float x, float y)
		{
			if (this.Remove.IsNotNull()) { this.Remove(x, y); }
		}

		/// <summary>
		/// The delegate for the event 'Add' 
		/// </summary>
		/// <param name="x">The x coordinate of the removing point.</param>
		/// <param name="y">The y coordinate of the removing point.</param>
		public delegate void AddDelegate(float x, float y);

		/// <summary>
		/// Event raised when a new contaminated point is added
		/// </summary>
		public event AddDelegate Add;

		/// <summary>
		/// Infrastructural methods: prevents the null reference exception
		/// </summary>
		/// <param name="x">The x coordinate of the removing point.</param>
		/// <param name="y">The y coordinate of the removing point.</param>
		private void OnAdd(float x, float y)
		{
			if (this.Add.IsNotNull()) { this.Add(x, y); }
		}
		#endregion


		#region elements
		/// <summary>
		/// Points over the surface contaminated by the viruses
		/// </summary>
		private decimal[,] Contamination;

		/// <summary>
		/// The list of the contaminated points (is a kind of indexing)
		/// </summary>
		public List<CoViD.CL.Point> Contaminated;


		/// <summary>
		/// Information about the Hospitals in the region.
		/// </summary>
		public CoViD.CL.Hospitals Hospitals;

		/// <summary>
		/// Who lives in the grid
		/// </summary>
		public CoViD.CL.Population Population;
		#endregion



		/// <summary>
		/// The extention of the grid. The 'Grid' is a square that spans between '-Radius' and 'Radius'.
		/// </summary>
		public readonly int Radius;

		/// <summary>
		/// The elapsed unity of time from the begining of the computation.
		/// </summary>
		public int Ticks { get; private set; }

		// ----------------------------------------------------------------------------------------------- //
		// Points over the 'Grid' must be mapped with elements in a bidimensional array (a matrix)
		// these are the parameter for the mapping function between points and coordinates
 
		/// <summary>
		/// The 'intercept'of the linear mapping.
		/// </summary>
		private decimal Y0;

		/// <summary>
		/// he 'slope'of the linear mapping.
		/// </summary>
		private decimal M;

		// ----------------------------------------------------------------------------------------------- //

		/// <summary>
		/// Converts the 'x' value of the point in the corresponding Row value in the bidimensionale array 'Contamination'.
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		public int X2R(float x) { return (int)Math.Floor(this.Y0 + (this.M * (decimal)x)); }

		/// <summary>
		/// Converts the 'y' value of the point in the corresponding Column value in the bidimensionale array 'Contamination'.
		/// </summary>
		/// <param name="y"></param>
		/// <returns></returns>
		private int Y2C(float y) { return (int)Math.Floor(this.Y0 + (this.M * (decimal)y)); }

		/// <summary>
		/// Converts the 'Row' value in the bidimensionale array 'Contamination' to  the 'x' value of the point.
		/// </summary>
		/// <param name="r">The 'row' value in the bidimensionale array 'Contamination'.</param>
		/// <returns>The corrisponding 'x' value.</returns>
		public float R2X(int r) { return (float)(((decimal)r - this.Y0) / (this.M)); }

		/// <summary>
		/// Converts the 'Column' value in the bidimensionale array 'Contamination' to  the 'y' value of the point.
		/// </summary>
		/// <param name="c">The 'column' value in the bidimensionale array 'Contamination'.</param>
		/// <returns>The corrisponding 'y' value.</returns>
		private float C2Y(int c) { return (float)(((decimal)c - this.Y0) / (this.M)); }
		// ----------------------------------------------------------------------------------------------- //


		/// <summary>
		/// 
		/// </summary>
		int IndexMax;

		/// <summary>
		/// Main Constructor: initializes the grid
		/// </summary>
		/// <param name="radius">The extention of the grid.</param>
		/// <param name="population">One instance of the Population object.</param>
		/// <param name="hospitals">The collection of Hospitals where people with 'severe' illnes are sent</param>
		public Grid(int radius, CoViD.CL.Population population, CoViD.CL.Hospitals hospitals)
		{

			this.IndexMax = (int)Math.Ceiling(((decimal)2 * (decimal)radius) / (decimal)100);
			int _radius = 50 * this.IndexMax;

			this.Contamination = new decimal[this.IndexMax, this.IndexMax];
			this.Contaminated = new List<CoViD.CL.Point>();

			this.M = (decimal)(this.IndexMax - 1) / ((decimal)2 * (decimal)_radius);
			this.Y0 = (decimal)_radius * this.M;


			this.Population = population;
			this.Hospitals = hospitals;

			this.Radius = radius;
		}

		/// <summary>
		///  Sets the contamination for a point 
		/// </summary>
		/// <param name="viruses">The number of viruses (unity of viruses) in the provided point.</param>
		/// <param name="location">The location where is the contamination</param>
		public void Contaminate(decimal viruses, CoViD.CL.Point location)
		{
			if (viruses > 0)
			{
				var r = this.X2R(location.X);
				var c = this.Y2C(location.Y);

				var isInternal = (r >= 0 && c >= 0 && r < this.IndexMax && c < this.IndexMax);
				if (isInternal)
				{
					var virusesRC = this.Contamination[r, c];
					if (virusesRC == 0)
					{
						this.Contaminated.Add(new CL.Point(location.X, location.Y));
						var _x = this.R2X(r);
						var _y = this.C2Y(c);
						this.OnAdd(_x, _y);
					}
					this.Contamination[r, c] = virusesRC + viruses;
				}
			}
		}

		/// <summary>
		/// Evolves the dynamic of one unit of time.
		/// </summary>
		public void Tick()
		{
			for (int index = this.Contaminated.Count - 1; index >= 0; index--)
			{
				var point = this.Contaminated[index];

				var r = this.X2R(point.X);
				var c = this.Y2C(point.Y);

				var virusesRC = this.Contamination[r, c];
				virusesRC = virusesRC * (decimal)0.9;

				if (virusesRC > (decimal)0.001)
				{
					this.Contamination[r, c] = virusesRC;
				}
				else
				{
					this.Contamination[r, c] = 0;
					this.Contaminated.RemoveAt(index);
					var _x = this.R2X(r);
					var _y = this.C2Y(c);
					this.OnRemove(_x, _y);
				}
			}

			this.Population.Tick();
			this.Ticks++;
		}

		/// <summary>
		/// Gets the viruses on the grid in the provided point.
		/// </summary>
		/// <param name="point">The point on the grid from where get the number of viruses.</param>
		/// <returns>Hov many unity of viruses there are in the provided point.</returns>
		public decimal GetViruses(CoViD.CL.Point point)
		{
			var r = this.X2R(point.X);
			var c = this.Y2C(point.Y);
			var isInternal = (r >= 0 && c >= 0 && r < this.IndexMax && c < this.IndexMax);
			return isInternal ? this.Contamination[r, c] : 0;
		}

		/// <summary>
		/// Resets all the grid: clears contaminated, set Ticks = 0, calls Population.Reset() and sets to 0 the matrix Contamination
		/// </summary>
		public void Reset()
		{
			this.Ticks = 0;
			this.Contaminated.Clear();
			this.Population.Reset();

			var xMax = this.Contamination.GetLength(0);
			var yMax = this.Contamination.GetLength(1);
			for (int x = 0; x < xMax; x++)
			{
				for (int y = 0; y < yMax; y++)
				{
					this.Contamination[x, y] = 0;
				}
			}
		}
	}
}