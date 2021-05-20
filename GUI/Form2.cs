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
    public partial class Form2: Form
    {
        CoViD.GUI.UC.Cartesian DrawingGrid;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.DrawingGrid = new CoViD.GUI.UC.Cartesian(this.pictureBox1, -10, 10, -10, 10);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.DrawingGrid.Point(0, 0, Color.Red);
            this.DrawingGrid.Point(-10, 10, Color.Red);
            this.DrawingGrid.Point(10, 10, Color.Red);
            this.DrawingGrid.Point(10, -10, Color.Red);
            this.DrawingGrid.Point(-10, -10, Color.Red);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var graph = this.DrawingGrid.NewGraph();

            graph.Point(0, 0, Color.Red);
            graph.Point(-10, 10, Color.Red);
            graph.Point(10, 10, Color.Red);
            graph.Point(10, -10, Color.Red);
            graph.Point(-10, -10, Color.Red);

            this.DrawingGrid.Graph = graph;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DrawingGrid.Graph.Point(0, 0, Color.Red);
            this.DrawingGrid.Graph.Point(-10, 10, Color.Red);
            this.DrawingGrid.Graph.Point(10, 10, Color.Red);
            this.DrawingGrid.Graph.Point(10, -10, Color.Red);
            this.DrawingGrid.Graph.Point(-10, -10, Color.Red);

            this.DrawingGrid.Graph = this.DrawingGrid.Graph;
        }
    }
}
