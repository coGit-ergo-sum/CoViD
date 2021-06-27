using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vi.Tools.Extensions.Int;

namespace CoViD.GUI.UC
{
	/// <summary>
	/// Plotting area specialized to display a square region having the point 0, 0 in the center of the space.
	/// </summary>
	public partial class Region : UserControl
	{
		/// <summary>
		/// The delegate for the event 'Coordinates'
		/// </summary>
		/// <param name="x">The current mouse's x position.</param>
		/// <param name="y">The current mouse's y position.</param>
		public delegate void CoordinatesDelegate(float x, float y);

		/// <summary>
		/// Specializes the event 'mouseMove' to provide the position of the mouse on the diagram.
		/// </summary>
		public event CoordinatesDelegate Coordinates;

		/// <summary>
		/// Method to 'safely' call the event 'Coordinates'.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		private void OnCoordinates(float x, float y) { if (this.Coordinates != null) { this.Coordinates(x, y); } }

		/// <summary>
		/// The Cartesian Plane where points are plotted.
		/// </summary>
		public CoViD.GUI.UC.Cartesian Cartesian;

		/// <summary>
		/// The semi extention where the CoViD spreads
		/// </summary>
		public int _Radius;

		/// <summary>
		/// The semi extention where the CoViD spreads
		/// </summary>
		public int Radius
		{
			get { return this._Radius; }
			private set { 
				this._Radius = value; 
				this.lblRadius.Text = value.ToText();
				this.lblLabelResol.Left = lblRadius.Left + lblRadius.Width + 20;
				this.lblResolution.Left = lblLabelResol.Left + lblLabelResol.Width + 5;
			}
		}

		/// <summary>
		/// The title shown below the plotting area, in the middle of the available space.
		/// </summary>
		public string Title
		{
			set { this.lblTitle.Text = value; }
			get { return this.lblTitle.Text; }
		}

		/// <summary>
		/// Main CTor. Inizialize components; sets background color and positions.
		/// </summary>
		public Region()
		{
			InitializeComponent();

			this.BackColor = Color.FromArgb(32, 32, 32);
			this.pnlMain.BackColor =  this.BackColor;
			this.pctDrawingGrid.BackColor = Color.Black;

			pnlMain.Left = 0;
			pnlMain.Top = 0;
			pnlMain.Size = this.Size;
		}

		/// <summary>
		/// Sets the text around plotting area.
		/// </summary>
		/// <param name="radius"></param>
		/// <param name="title"></param>
		public void SetXY(int radius, string title)
		{
			this.Radius = radius;
			this.lblTitle.Text = title;
			this.Cartesian = new CoViD.GUI.UC.Cartesian(this.pctDrawingGrid, -radius, radius, -radius, radius);
			this.lblResolution.Text = this.Cartesian.ResolutionX.ToString("#,##0.00");
			this.Cartesian.Coordinates += Cartesian_Coordinates;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		private void Cartesian_Coordinates(float x, float y)
		{
			lblX.Text = x.ToString("#,##0.00");
			lblY.Text = y.ToString("#,##0.00");
			this.OnCoordinates(x, y);
		}

		/// <summary>
		/// Draws a point over the drawing grid at position x, y
		/// </summary>
		/// <param name="point">The 'location' of the point.</param>
		/// <param name="color">The color of the new point.</param>
		public void Point(CoViD.CL.Point point, Color color) { 
			this.Cartesian.Point(point.X, point.Y, color); 
		}

		/// <summary>
		/// Sets thimage for the cartesian area.
		/// </summary>
		public CoViD.GUI.UC.Cartesian.Bitmap Image
		{
			set 
			{
				this.Cartesian.Graph = value;
				this.Cartesian.Flush();
			}
		}

		/// <summary>
		/// Resizes the Grid avoiding overflows
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Grid_Resize(object sender, EventArgs e)
		{
			var deltaH = this.pnlMain.Width - this.pctDrawingGrid.Width;
			var deltaV = this.pnlMain.Height - this.pctDrawingGrid.Height;

			var r = Math.Min(this.Width - deltaH, this.Height - deltaV);
			this.pnlMain.Width = r + deltaH;
			this.pnlMain.Height = r + deltaV;

			this.pnlMain.Left = (this.Width - (r + deltaH)) / 2;

		}
	}
}
