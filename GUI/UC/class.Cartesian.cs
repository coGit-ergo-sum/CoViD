using System;
using System.Windows.Forms;

namespace CoViD.GUI.UC
{
	/// <summary>
	/// This class implements the drawing area of a cartesian plane
	/// </summary>
	public class Cartesian
	{
		#region events
		/// <summary>
		/// The delegate for the event 'Coordinates'
		/// </summary>
		/// <param name="x">The 'x' value.</param>
		/// <param name="y">The 'y' value.</param>
		public delegate void CoordinatesDelegate(float x, float y);

		/// <summary>
		/// Exposes the coordinate of the moving mouse.
		/// </summary>
		public event CoordinatesDelegate Coordinates;

		/// <summary>
		/// Method to 'safely' call the event 'Coordinates'.
		/// </summary>
		/// <param name="x">The 'x' value.</param>
		/// <param name="y">The 'y' value.</param>
		private void OnCoordinates(float x, float y) { if (this.Coordinates != null) { this.Coordinates(x, y); } }

		/// <summary>
		/// To persist the diagram on screen, points are 'written' on a 'Drawing.Bitmap'. 
		/// This Field (a 'Cartesian.Bitmap') manages the interaction with it.
		/// </summary>
		public Cartesian.Bitmap Graph;
		#endregion
		
		#region Max Min
		/// <summary>
		/// The maximum Y value the diagram can represents.
		/// </summary>
		public float YMax { get; private set; }

		/// <summary>
		/// The Minimum Y value the diagram can represents.
		/// </summary>
		public float YMin { get; private set; }

		/// <summary>
		/// The maximum X value the diagram can represents.
		/// </summary>
		public float XMax { get; private set; }

		/// <summary>
		/// The Minimum X value the diagram can represents.
		/// </summary>
		public float XMin { get; private set; }
		#endregion
		
		// Parameters for the equation of a line to map values from X axes to the width of the control.
		private float KX;
		private float MX;

		// Parameters for the equation of a line to map values from Y axes to the height of the control.
		private float KY;
		private float MY;

		/// <summary>
		/// The number of X unities a pixel represents.
		/// </summary>
		public float ResolutionX { get; private set; }

		/// <summary>
		/// The number of Y unities a pixel represents.
		/// </summary>
		public float ResolutionY { get; private set; }

		private System.Windows.Forms.PictureBox Pct;

		/// <summary>
		/// Specialize a 'Drawing.Graphics' to interact with a fixed rectangle grid and a given range of x-y values. 
		/// </summary>
		public class Bitmap
		{
			/// <summary>
			/// 
			/// </summary>
			public System.Drawing.Bitmap Image;

			/// <summary>
			/// 
			/// </summary>
			private System.Drawing.Graphics Graphics;

			/// <summary>
			/// Maps a X value (within the given range) to the w (width) value in the drawing grid.
			/// </summary>
			private Func<float, int> X2W;

			/// <summary>
			/// Maps a Y value (within the given range) to the h (height) value in the drawing grid.
			/// </summary>
			private Func<float, int> Y2H;

			/// <summary>
			/// Initialize a Drawing.Bitmap(width, height), a 'Drawing.Graphics' and stores the 
			/// mapping 'functions'.
			/// </summary>
			/// <param name="width"></param>
			/// <param name="height"></param>
			/// <param name="x2w"></param>
			/// <param name="y2h"></param>
			public Bitmap(
				int width, int height,
				Func<float, int> x2w, 
				Func<float, int> y2h
			)
			{
				try
				{
					this.Image = new System.Drawing.Bitmap(width, height);

					this.Graphics = System.Drawing.Graphics.FromImage(this.Image);

					this.X2W = x2w;
					this.Y2H = y2h;
				}
				catch (System.Exception se)
				{
					Console.Write(se);
				}
			}

			/// <summary>
			/// Clears the entire drawing surface and fills it with the specified background color.
			/// </summary>
			/// <param name="color">System.Drawing.Color structure that represents the background color of the drawing surface.</param>
			public void Clear(System.Drawing.Color color)
			{
				this.Graphics.Clear(color);
			}

			/// <summary>
			/// Draws a point (a 1x1 rectangle) in the drawing surface.
			/// </summary>
			/// <param name="point">The coordinates of the point.</param>
			/// <param name="color">The color of the point.</param>
			public void Point(CoViD.CL.Point point, System.Drawing.Color color) { this.Point(point.X, point.Y, new System.Drawing.SolidBrush(color)); }

			/// <summary>
			/// Draws a point (a 1x1 rectangle) in the drawing surface.
			/// </summary>
			/// <param name="x">The x coordinates of the point.</param>
			/// <param name="y">The y coordinates of the point.</param>
			/// <param name="color">The color of the point.</param>
			public void Point(float x, float y, System.Drawing.Color color) { this.Point(x, y, new System.Drawing.SolidBrush(color)); }


			/// <summary>
			/// Draws a point (a 1x1 rectangle) in the drawing surface. (this is the method that performs the job
			/// </summary>
			/// <param name="x">The x coordinates of the point.</param>
			/// <param name="y">The y coordinates of the point.</param>
			/// <param name="color">The color of the point.</param>
			public void Point(float x, float y, System.Drawing.Brush color)
			{

				int w = this.X2W(x) & 536870911;
				int h = this.Y2H(y) & 536870911;
				this.Graphics.FillRectangle(color, w, h, 1, 1);
			}

			/*
			public void Point(float x, float y, float radius, System.Drawing.Color color) { this.Point(x, y, radius, new System.Drawing.SolidBrush(color)); }
			public void Point(float x, float y, float radius, System.Drawing.Brush color)
			{
				int w = this.X2W(x);
				int h = this.Y2H(y);
				int r = 3;// Math.Abs(this.X2W(0) - this.X2W(radius));
				this.Graphics.FillEllipse(color, w, h, r, r);
			}
			*/

			/// <summary>
			/// Saves the graph to a file in the 'bmp' format, Creates the containing directory if does not exists.
			/// </summary>
			/// <param name="filename">The full file name</param>
			public void Save(string filename) { this.Save(filename, System.Drawing.Imaging.ImageFormat.Bmp); }

			/// <summary>
			/// Saves the graph to a file in the 'bmp' format, Creates the containing directory if does not exists.
			/// </summary>
			/// <param name="filename">The full file name</param>
			/// <param name="format">The format for the file.</param>
			public void Save(string filename, System.Drawing.Imaging.ImageFormat format)
			{
				var directoryName = System.IO.Path.GetDirectoryName(filename);
				System.IO.Directory.CreateDirectory(directoryName);
				this.Image.Save(filename, format);
			}
		}

		/// <summary>
		/// Stores the provided parameter and assigns a 'this.NewGraph' to the field 'this.Grap'
		/// </summary>
		/// <param name="pct">The container of the graph of the diagram (only the graph, without axes, label, ... </param>
		/// <param name="xMin">The minimum value for the x coordinate.</param>
		/// <param name="xMax">The maximum value for the x coordinate.</param>
		/// <param name="yMin">The minimum value for the y coordinate.</param>
		/// <param name="yMax">The maximum value for the y coordinate.</param>
		public Cartesian(System.Windows.Forms.PictureBox pct, float xMin, float xMax, float yMin, float yMax)
		{
			this.XMin = xMin;
			this.XMax = xMax;

			this.YMin = yMin;
			this.YMax = yMax;

			this.Pct = pct;
			this.Pct.Resize += Pct_Resize;
			this.Pct.MouseMove += Pct_MouseMove;
			this.Pct.MouseLeave += Pct_MouseLeave;

			this.Graph = this.NewGraph();
		}

		#region Point
		public void Point(CoViD.CL.Point point, System.Drawing.Color color) { this.Point(point.X, point.Y, new System.Drawing.SolidBrush(color)); }
		public void Point(float x, float y, System.Drawing.Color color) { this.Point(x, y, new System.Drawing.SolidBrush(color)); }

		/// <summary>
		/// Draws a point over the drawing grid at position x, y.
		/// (to write a set of points draw all the points with 'this.Graph.Point' and then  'this.Flush'.; 
		/// </summary>
		/// <param name="x">The 'x' position of the new point.</param>
		/// <param name="y">The 'y' position of the new point.</param>
		/// <param name="color">The color of the new point.</param>
		public void Point(float x, float y, System.Drawing.Brush color)
		{
			this.Graph.Point(x, y, color);
			this.Flush();
		}

		public void Flush()
		{
			this.Pct.Image = this.Graph.Image;
		}
		#endregion

		public Cartesian.Bitmap NewGraph()
		{
			///////////return new Cartesian.Bitmap(this.pctDrawingGrid.Width, this.pctDrawingGrid.Height, this.X2W, this.Y2H);
			int height = this.Pct.ClientSize.Height;
			int width = this.Pct.ClientSize.Width;

			// Like 'array' the position of a pixel (in a control) is 'zero based' and this is the max index a pixel can have. 
			int hMax = height - 1;
			int wMax = width - 1;

			// Parameters for the equation of a line to map values from X axes to the width of the control.
			this.MX = (float)wMax / (this.XMax - this.XMin);
			this.KX = -this.MX * this.XMin;

			// Parameters for the equation of a line to map values from Y axes to the height of the control.
			this.MY = (float)hMax / (this.YMax - this.YMin);
			this.KY = this.MY * this.YMax;

			this.ResolutionX = Math.Abs((this.XMax - this.XMin) / (float)width);
			this.ResolutionY = Math.Abs((this.YMax - this.YMin) / (float)height);

			// Equation of a line to map a point from the x/y domain to the width/height.
			Func<float, int> x2w = x => (int)(this.KX + (float)(this.MX * x));
			Func<float, int> y2h = y => (int)(this.KY - (float)(this.MY * y));

			return new Cartesian.Bitmap(width, height, x2w, y2h);

		}

		/// <summary>
		/// Clears the drawing grid.
		/// </summary>
		public void Clear()
		{
			this.Graph.Clear(this.Pct.BackColor);
		}

		private void Pct_Resize(object sender, EventArgs e)
		{
			this.Graph = this.NewGraph();
			////////////int height = this.Pct.ClientSize.Height;
			////////////int width = this.Pct.ClientSize.Width;
			////////////this.ResolutionX = Math.Abs((this.XMax - this.XMin) / (float)width);
			////////////this.ResolutionY = Math.Abs((this.YMax - this.YMin) / (float)height);
		}

		/// <summary>
		/// Raises the event 'Coordinates' providing to the outside the actual position of the cursor. 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Pct_MouseMove(object sender, MouseEventArgs e)
		{
			float x = ((float)e.X - this.KX) / this.MX;
			float y = (this.KY - (float)e.Y) / this.MY;
			this.OnCoordinates(x, y);
		}

		private void Pct_MouseLeave(object sender, EventArgs e)
		{
			this.OnCoordinates(0, 0);
		}

	}
}