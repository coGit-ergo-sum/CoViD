using System;
using Vi.Tools.Extensions.Int;

namespace CoViD.CL
{
	/// <summary>
	/// The coordinates (x, y)  of the location in space.
	/// </summary>
	[Serializable]
	public struct Point
	{
		/// <summary>
		/// The 'x' coordinate.
		/// </summary>
		public int X;

		/// <summary>
		/// The 'y' coordinate.
		/// </summary>
		public int Y;

		/// <summary>
		/// CTor. Sets the x, y values.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		public Point(int x, int y)
		{
			this.X = x;
			this.Y = y;
		}

		/// <summary>
		/// Makes each instance more readable during the Debug session.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return X.ToText() + "; " + Y.ToText();
		}
	}
}

