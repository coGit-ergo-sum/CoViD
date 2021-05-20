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
using Vi.Tools.Extensions.Float;

namespace CoViD.GUI
{
	public partial class XY : UserControl
	{
		public delegate void CoordinatesDelegate(float x, float y);
		public event CoordinatesDelegate Coordinates;
		private void OnCoordinates(float x, float y)		{ if (this.Coordinates != null) { this.Coordinates(x, y); }	}

		public CoViD.GUI.UC.Cartesian Cartesian;

		/// <summary>
		/// The Graphics for the usercontrol.
		/// </summary>
		private Graphics UCGraphics;

		private Color ColorAxis = Color.FromArgb(74, 74, 74);

		public XY()
		{
			InitializeComponent();
		}

		private void XY_Load(object sender, EventArgs e)
		{

		}

		public void SetXY(
			float xMin, float xMax, string textXMin, string textXMax, string labelX,
			float yMin, float yMax, string textYMin, string textYMax, string labelY
		)
		{
			this.Cartesian = new CoViD.GUI.UC.Cartesian(this.pctDrawingGrid, xMin, xMax, yMin, yMax);
			this.Cartesian.Coordinates += Cartesian_Coordinates;

			this.lblXMin.Text = textXMin;
			this.lblXMax.Text = textXMax;
			this.lblLabelX.Text = labelX;
			
			this.lblYMin.Text = textYMin;
			this.lblYMax.Text = textYMax;

			this.LabelY = labelY;

			this.UCGraphics.FillRectangle(new SolidBrush(ColorAxis), this.pctDrawingGrid.Left - 1, this.pctDrawingGrid.Top + this.pctDrawingGrid.Height, this.pctDrawingGrid.Width, 1);
			this.UCGraphics.FillRectangle(new SolidBrush(ColorAxis), this.pctDrawingGrid.Left - 1, this.pctDrawingGrid.Top, 1, this.pctDrawingGrid.Height);
		}

		private void Cartesian_Coordinates(float x, float y)
		{
			lblX.Text = x.ToText(2);
			lblY.Text = y.ToText(2);
			this.OnCoordinates(x, y);
		}


		private string _LabelY;
		public string LabelY
		{
			get { return this._LabelY; }
			private set
			{
				//  http://csharphelper.com/blog/2017/01/easily-draw-rotated-text-on-a-form-in-c/

				var text = this.lblLabelX.Text;
				this.lblLabelX.Text = value;
				var width = lblLabelX.Width;
				var height = lblLabelX.Height;

				lblLabelX.Text = text;

				var delta = this.lblLabelX.Top - (this.pctDrawingGrid.Top + this.pctDrawingGrid.Height);
				var w = this.pctDrawingGrid.Left - (delta + height);
				var h = this.pctDrawingGrid.Top + ((this.pctDrawingGrid.Height - width) / 2);
				var pointF = new System.Drawing.PointF(w, h);

				StringFormat stringFormat = new StringFormat();
				SolidBrush solidBrush = new SolidBrush(Color.FromArgb(255, 200, 200, 200));

				stringFormat.FormatFlags = StringFormatFlags.DirectionVertical;

				this.CreateGraphics().DrawString(value, lblLabelX.Font, solidBrush, pointF, stringFormat);

			}
		}

		private void XY_Resize(object sender, EventArgs e)
		{
			this.UCGraphics = this.CreateGraphics();
			lblLabelX.Left = pctDrawingGrid.Left + ((pctDrawingGrid.Width - lblLabelX.Width) / 2);
		}
	}
}