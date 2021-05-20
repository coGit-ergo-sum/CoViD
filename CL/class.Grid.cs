using System;
using System.Collections.Generic;
using System.Text;

using Vi.Tools.Extensions.Random;
using Vi.Tools.Extensions.Object;

namespace CoViD.CL
{
	/// <summary>
	/// Is a square region made of points. (Simulates the place where the people lives and where the epidemic spreads.)
	/// 
	/// </summary>
	public class Grid
	{
		#region Events
		public delegate void RemoveDelegate(float x, float y);
		public event RemoveDelegate Remove;
		private void OnRemove(float x, float y)
		{
			if (this.Remove.IsNotNull()) { this.Remove(x, y); }
		}

		public delegate void AddDelegate(float x, float y);
		public event AddDelegate Add;
		private void OnAdd(float x, float y)
		{
			if (this.Add.IsNotNull()) { this.Add(x, y); }
		}
		#endregion


		#region elements
		/// <summary>
		/// Points over the surface contaminated by the viruses
		/// </summary>
		private float[,] Contamination;

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
		public CoViD.CL.Popolation Popolation;
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



		int IndexMax;
		public Grid(int radius, CoViD.CL.Popolation popolation, CoViD.CL.Hospitals hospitals)
		{

			this.IndexMax = (int)Math.Ceiling(((decimal)2 * (decimal)radius) / (decimal)100);
			int _radius = 50 * this.IndexMax;

			this.Contamination = new float[this.IndexMax, this.IndexMax];
			this.Contaminated = new List<CoViD.CL.Point>();

			this.M = (decimal)(this.IndexMax - 1) / ((decimal)2 * (decimal)_radius);
			this.Y0 = (decimal)_radius * this.M;


			this.Popolation = popolation;
			this.Hospitals = hospitals;

			this.Radius = radius;
		}

		public void Contaminate(float viruses, CoViD.CL.Point location)
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

		public void Tick()
		{
			for (int index = this.Contaminated.Count - 1; index >= 0; index--)
			{
				var point = this.Contaminated[index];

				var r = this.X2R(point.X);
				var c = this.Y2C(point.Y);

				var virusesRC = this.Contamination[r, c];
				virusesRC = virusesRC * 0.9F;

				if (virusesRC > 0.001F)
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

			this.Popolation.Tick();
			this.Ticks++;
		}

		public float GetViruses(CoViD.CL.Point point)
		{
			var r = this.X2R(point.X);
			var c = this.Y2C(point.Y);
			var isInternal = (r >= 0 && c >= 0 && r < this.IndexMax && c < this.IndexMax);
			return isInternal ? this.Contamination[r, c] : 0;
		}

		public void Reset()
		{
			this.Ticks = 0;
			this.Contaminated.Clear();
			this.Popolation.Reset();

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