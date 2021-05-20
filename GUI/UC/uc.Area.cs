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
	public partial class Grid : UserControl
	{
		public delegate void CoordinatesDelegate(float x, float y);
		public event CoordinatesDelegate Coordinates;
		private void OnCoordinates(float x, float y) { if (this.Coordinates != null) { this.Coordinates(x, y); } }

		public CoViD.GUI.UC.Cartesian Cartesian;

		public int _Radius;
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

		public string Label
		{
			set { this.lblLabel.Text = value; }
			get { return this.lblLabel.Text; }
		}

		public Grid()
		{
			InitializeComponent();

			this.BackColor = Color.FromArgb(32, 32, 32);
			this.pnlMain.BackColor =  this.BackColor;
			this.pctDrawingGrid.BackColor = Color.Black;

			pnlMain.Left = 0;
			pnlMain.Top = 0;
			pnlMain.Size = this.Size;
		}

		public void SetXY(int radius, string title)
		{
			this.Radius = radius;
			this.lblLabel.Text = title;
			this.Cartesian = new CoViD.GUI.UC.Cartesian(this.pctDrawingGrid, -radius, radius, -radius, radius);
			this.lblResolution.Text = this.Cartesian.ResolutionX.ToString("#,##0.00");
			this.Cartesian.Coordinates += Cartesian_Coordinates;
		}

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

		public CoViD.GUI.UC.Cartesian.Bitmap Image
		{
			set 
			{
				this.Cartesian.Graph = value;
				this.Cartesian.Flush();
			}
		}

		private void Grid_Resize(object sender, EventArgs e)
		{
			var deltaH = this.pnlMain.Width - this.pctDrawingGrid.Width;
			var deltaV = this.pnlMain.Height - this.pctDrawingGrid.Height;
			//var x = Math.Abs(
			var r = Math.Min(this.Width - deltaH, this.Height - deltaV);
			this.pnlMain.Width = r + deltaH;
			this.pnlMain.Height = r + deltaV;

			this.pnlMain.Left = (this.Width - (r + deltaH)) / 2;

		}
	}
}
