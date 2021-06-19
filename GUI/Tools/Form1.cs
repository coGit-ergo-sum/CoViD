using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoViD.GUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			this.grid1.SetXY(10, "Bho");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var image1 = this.grid1.Cartesian.NewGraph();
			image1.Point(0, 0, Color.Red);
			this.grid1.Image = image1;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.grid1.Cartesian.Point(1, 1, Color.Green);
		}
	}
}
