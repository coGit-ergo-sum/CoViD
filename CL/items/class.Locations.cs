using System;
using System.Collections.Generic;
using System.Text;

using Vi.Tools.Extensions.Random;
using Vi.Tools.Extensions.Int;

namespace CoViD.CL
{
	/// <summary>
	/// The list of points on the grid, randomly generated, during a person's journey. 
	/// (The hope is to find some source of real movements)
	/// </summary>
	public class Locations : System.Collections.Generic.List<CoViD.CL.Point> 
	{

		// The random number generation starts from a seed value. If the same seed is used repeatedly, 
		// the same series of numbers is generated. 

		private static Random Rnd = new Random();

		/// <summary>
		/// Retrives the coordinates of a single location (point) 
		/// </summary>
		/// <param name="index">The index of the point.</param>
		/// <returns>The location at the given index.</returns>
		new public CoViD.CL.Point this[int index]
		{
			get
			{
				return (this.Count == 0) ? new CoViD.CL.Point() : base[index % this.Count];
			}
			set
			{
				base[index] = value;
			}
		}


		/// <summary>
		/// Creates a list with only one point at '0, 0'.
		/// </summary>
		/// <returns>A list with only one point at '0, 0'</returns>
		public Locations()
		{
			base.Add(new CoViD.CL.Point(0, 0));
		}

		/// <summary>
		/// Create a list of points on the grid to simulate a person's movements.
		/// The "grid is splitted in 4 different sub grids: cities. Each people moves
		/// in its own city. 
		/// Travellers can move across cities.
		/// If Traveller is 1 (100%) there is only one big city
		/// Points are taken randomly. 
		/// (This method calls the other method in overload with 'travellers = 1')
		/// </summary>
		/// <param name="radius">"Grid" is a square which side is twice 'radius'.</param>
		/// <param name="distribution">Change the distribution of the probability.</param>
		/// <returns>A List of points simulating someone moving.</returns>
		public Locations(int radius, byte distribution) : this(radius, distribution, traveller: 1) { }



		/// <summary>
		/// Create a list of points on the grid to simulate a person's movements.
		/// The "grid is splitted in 4 different sub grids: cities. Each people moves
		/// in its own city. 
		/// Travellers can move across cities.
		/// If Traveller is 1 (100%) there is only one big city
		/// Points are taken randomly. 
		/// (This method calls the other method in overload with 'travellers = 1')
		/// </summary>
		/// <param name="radius">"Grid" is a square which side is twice 'radius'.</param>
		/// <param name="distribution">Change the distribution from 1: Omogeneous, 2:triangular, 3: parabolic ... Gaussian (should be  'The Central limit theorem' if I'm right.)</param>
		/// <param name="traveller"></param>
		public Locations(int radius, byte distribution, Vi.Types.Percentage traveller)
		{
			var subRadius = radius / 20;

			var centerX = Locations.Rnd.Next(-radius, radius, distribution);
			var centerY = Locations.Rnd.Next(-radius, radius, distribution);

			int x = Locations.Rnd.Next(centerX - subRadius, centerX + subRadius, iterations: distribution);
			int y = Locations.Rnd.Next(centerY - subRadius, centerY + subRadius, iterations: distribution);

			// these are the places reached during the journey
			var targets = Locations.Rnd.Next(3, 10, 2);
			for (int i = 0; i < targets; i++)
			{
				int x1 = Locations.Rnd.Next(centerX - subRadius, centerX + subRadius, iterations: distribution);
				int y1 = Locations.Rnd.Next(centerY - subRadius, centerY + subRadius, iterations: distribution);

				float length = Locations.Rnd.Next(10, 30, 1);

				float y0x = x;
				float mx = ((float)x1 - (float)x) / length;

				float y0y = y;
				float my = ((float)y1 - (float)y) / length;

				// this is the segment between two 'targets'
				for (int j = 0; j < length; j++)
				{
					var point = new CoViD.CL.Point(
						(int)(y0x + mx * j),
						(int)(y0y + my * j)
					);
					this.Add(point);
				}

				x = x1;
				y = y1;
			}
		}
	}
}

	/*
	This method as no reference to it
		/// <summary>
		/// Creates a list of point on the Grid to simulate movement of a person.
		/// The "grid is splitted in 4 different sub grids: cities. Each people moves
		/// in its own city. Travellers can move across cities.
		/// If Traveller is 1 (100%) there is only one big city
		/// Points are taken randomly. 
		/// </summary>
		/// <param name="radius">"Grid" is a square of side twice 'radius'.</param>
		/// <param name="distribution">Change the distribution of the probability.</param>
		/// <param name="traveller">The ratio of person that travel from cities.Number between 0 and 1.</param>
		/// <returns>A List of points simulating someone moving.</returns>
		public Locations(int radius, byte distribution, Vi.Tools.Types.Percent traveller, int xxxx)
		{
			//traveller = 0.01F;
			// --------------------------------------------------------------------------------------- //
			// Returns the region where a 'person' can move: a region is a portion of the 'Grid'
			// The grid can be splittet in 4 regions. 
			// If 'Travellers' = 1 there is only a big region.
			Func<Point> getCity = () =>
			{
				/ *
				//float traveller100 = traveller * 100;
				//int alea = Locations.Rnd.Next(0, 100);
				return
					(alea < traveller100) ? new Point(-radius, radius) :
					((alea & 1) == 1) ? new Point(-radius, 0) : new Point(0, radius);
				* /

				var bet = Locations.Rnd.Bet(traveller);
				return
					bet ? new Point(-radius, radius) :
					((Locations.Rnd.Next(0, 100) & 1) == 1) ? new Point(-radius, 0) : new Point(0, radius);
			};
			// --------------------------------------------------------------------------------------- //


			var cityX = getCity();
			var cityY = getCity();

			int x = Locations.Rnd.Next(cityX.X, cityX.Y, iterations: distribution);
			int y = Locations.Rnd.Next(cityY.X, cityY.Y, iterations: distribution);
			//int x = Grid.Rnd.Next(-radius, radius, iterations: distribution);
			//int y = Grid.Rnd.Next(-radius, radius, iterations: distribution);

			// these are the places reached during the journey
			var targets = Locations.Rnd.Next(5, 20, 1);
			for (int i = 0; i < targets; i++)
			{


				int x1 = Locations.Rnd.Next(cityX.X, cityX.Y, iterations: distribution);
				int y1 = Locations.Rnd.Next(cityY.X, cityY.Y, iterations: distribution);

				float length = Locations.Rnd.Next(50, 500, 1);

				float y0x = x;
				float mx = ((float)x1 - (float)x) / length;

				float y0y = y;
				float my = ((float)y1 - (float)y) / length;

				// this is the segment between two 'targets'
				for (int j = 0; j < length; j++)
				{
					var point = new CoViD.CL.Point(
						(int)(y0x + mx * j),
						(int)(y0y + my * j)
					);

					this.Add(point);
				}

				x = x1;
				y = y1;
			}
		}
	*/
	