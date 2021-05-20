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
		public class Bitmap
		{
			public System.Drawing.Bitmap Image;
			private System.Drawing.Graphics Graphics;

			private Func<float, int> X2W;
			private Func<float, int> Y2H;
			public Bitmap(int width, int height, Func<float, int> x2w, Func<float, int> y2h)
			{
				this.Image = new System.Drawing.Bitmap(width, height);
				this.Graphics = System.Drawing.Graphics.FromImage(this.Image);

				this.X2W = x2w;
				this.Y2H = y2h;
			}

			public void Point(float x, float y, Color color)
			{
				int w = this.X2W(x);
				int h = this.Y2H(y);
				this.Graphics.FillRectangle(new SolidBrush(color), w, h, 1, 1);
			}
			public void Point(CoViD.CL.Point point, Color color) { this.Point(point.X, point.Y, color); }


			public void Save(string filename, System.Drawing.Imaging.ImageFormat format)
			{
				var directoryName = System.IO.Path.GetDirectoryName(filename);
				System.IO.Directory.CreateDirectory(directoryName);
				this.Image.Save(filename, format);
			}
			public void Save(string filename) { this.Save(filename, System.Drawing.Imaging.ImageFormat.Bmp); }
		}
	}
}
