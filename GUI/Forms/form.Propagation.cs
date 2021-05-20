using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoViD.GUI.Forms
{
	public partial class Propagation : Form
	{
		public Propagation()
		{
			InitializeComponent();
			
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void Propagation_Load(object sender, EventArgs e)
		{
			Propagation_Resize(null, null);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.area1.Cartesian.Point(-500, -500, Color.Red);
			this.area1.Cartesian.Point(-500, 500, Color.Red);
			this.area1.Cartesian.Point(500, 500, Color.Red);
			this.area1.Cartesian.Point(500, -500, Color.Red);

			this.area1.Cartesian.Point(-998, -998, Color.White);
			//this.area1.Point(-999, 999, Color.White);
			this.area1.Cartesian.Point(998, 998, Color.White);
			//this.area1.Point(999, -999, Color.White);

			this.area1.Cartesian.Point(0, 0, Color.Green);

			for (int i = -990; i < 991; i++)
			{
				//this.area1.Point(i, i, Color.Red);
			}
		}

		private void Propagation_Resize(object sender, EventArgs e)
		{
			int radius = 1000;
			this.area1.SetXY(radius, "Propagation");
		}
	}
}
