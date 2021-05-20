using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Vi.Tools.Extensions.Random;

namespace CoViD.GUI
{
	public partial class Plot : Form
	{

		private CoViD.CL.Region World;
		private CoViD.CL.Popolation Popolation;

		/// <summary>
		/// 
		static Pen rPen = new Pen(Color.Red);

		static Brush rBrush = (Brush)Brushes.Red;
		static Brush bBrush = (Brush)Brushes.Black;
		static Brush wBrush = (Brush)Brushes.White;
		static Brush gBrush = (Brush)Brushes.Gray;

		static Graphics g; // 
		/// </summary>

		public Plot()
		{
			InitializeComponent();
			Plot.g = pictureBox1.CreateGraphics();
		}


		private void btnInitialize_Click(object sender, EventArgs e)
		{
			this.Initialize();
		}


		private void btnTick_Click(object sender, EventArgs e)
		{
			var btn = (Button)sender;
			btn.Visible = false;

			this.Popolation.Tick();
			this.World.Tick();

			btn.Visible = true;
		}

		private void Initialize()
		{
			Random rnd = new Random();

			var xMin = 0;
			var xMax = this.pictureBox1.Width;

			var yMin = 0;
			var yMax = this.pictureBox1.Height;

			var count = 2000;


			Func<int, List<CoViD.CL.Point>> getLocations = (index) =>
			{
				int x = rnd.Next(xMin, xMax, iterations: 1);
				int y = rnd.Next(yMin, yMax, iterations: 1);

				var locations = new List<CoViD.CL.Point>() { new CoViD.CL.Point(x, y) };
				return locations;
			};

			this.Region = new CoViD.CL.Region(pictureBox1.Width/2);
			///////this.World = new CoViD.CL.World(pictureBox1.Width, pictureBox1.Height);
			this.Popolation = new CoViD.CL.Popolation();

			for (int i = 0; i < count; i++)
			{
				var locations = getLocations(i);
				var person = new CoViD.CL.Person(locations);
				person.Sneeze += this.Person_Sneeze;
				person.Inhale += this.Person_Inhale;

				this.Popolation.Add(person);
			}

			// ------------------------------------------------------------------------------------- //
			// Simulate the sneeze of the first infected person. This create a contaminated area
			var location = new CoViD.CL.Point(pictureBox1.Width / 2, pictureBox1.Height / 2);
			Person_Sneeze(1, location);
			// ------------------------------------------------------------------------------------- //

		}

		private float Person_Inhale(CoViD.CL.Point location)
		{
			return this.World.GetViruses(location);
		}

		private void Person_Sneeze(float viruses, CoViD.CL.Point location)
		{
			this.World.Contaminate(viruses, location);
		}

		private void btnPeople_Click(object sender, EventArgs e)
		{
			g.FillRectangle(bBrush, 0, 0, pictureBox1.Width, pictureBox1.Height);
			foreach (var persona in this.Popolation)
			{
				var location = persona.Location;
				g.FillRectangle(wBrush, location.X, location.Y, 1, 1);
			}
		}

		private void btnContamination_Click(object sender, EventArgs e)
		{
			g.FillRectangle(bBrush, 0, 0, pictureBox1.Width, pictureBox1.Height);
			this.Text = this.World.Contaminated.Count.ToString("#,##0") + " - " + this.Popolation.Count.ToString("#,##0");
			Application.DoEvents();

			foreach (var point in this.World.Contaminated)
			{
				var contaminationXY = this.World.GetViruses(point);
				byte value = (byte)Math.Min(200, contaminationXY);
				var color = Color.FromArgb(55 + value, 0, 0);

				var sBrush = new SolidBrush(color);
				g.FillRectangle(sBrush, point.X, point.Y, 1, 1);
			}

			btnInfected_Click(null, null);
		}

		private void btnInfected_Click(object sender, EventArgs e)
		{
			int counter = 0;

			this.Text = this.World.Contaminated.Count.ToString("#,##0");
			Application.DoEvents();

			foreach (var person in this.Popolation)
			{
				if (person.State == CoViD.CL.Person.States.Incubation)
				{
					counter++;
					var point = person.Location;
					g.FillRectangle(wBrush, point.X, point.Y, 1, 1);
				}
			}

			this.Text += " - " + counter.ToString("#,##0");

		}
	}

}

//////////private void btnLoop_Click(object sender, EventArgs e)
//////////{

//////////	g.FillRectangle(bBrush, 0, 0, pictureBox1.Width, pictureBox1.Height);


//////////	var radius = 20;
//////////	var viruses = 10;
//////////	sbyte iterations = 3;


//////////	Random rnd = new Random();
//////////	//int x = rnd.Next(radius, this.pictureBox1.Width - radius, iterations: 1);
//////////	//var y = rnd.Next(radius, this.pictureBox1.Height - radius, iterations: 1);
//////////	//int x = 100; // this.pictureBox1.Width / 2;
//////////	//var y = 100; // this.pictureBox1.Height / 2;
//////////	var location = new CoViD.CL.Point(100, 100);

//////////	Single[,] contamination = new Single[this.pictureBox1.Width, this.pictureBox1.Height];

//////////	int iMax = (radius * radius) / 20;

//////////	for (int index = 0; index <= iMax; index++)
//////////	{
//////////		var x = rnd.Next(0, radius, iterations);
//////////		var y = rnd.Next(0, radius, iterations);

//////////		var contaminationXY = 255; // contamination[x, y];
//////////		contamination[x, y] = contaminationXY + viruses;

//////////		byte value = (byte)Math.Min(255, contaminationXY);
//////////		var color = Color.FromArgb(value, value, value);

//////////		var sBrush = new SolidBrush(color);
//////////		g.FillRectangle(sBrush, location.X + x, location.Y + y, 1, 1);
//////////	}

//////////}
///////////*
//////////for (int _x = xMin; _x <= xMax; _x++)
//////////{
//////////	for (int _y = yMin; _y <= yMax; _y++)
//////////	{
//////////		var contaminationXY = 255; // contamination[_x, _y];
//////////		contamination[_x, _y] = contaminationXY + viruses;

//////////		byte value = (byte)Math.Min(255, contaminationXY);
//////////		var color = Color.FromArgb(value, value, value);

//////////		var sBrush = new SolidBrush(color);
//////////		g.FillRectangle(sBrush, _x, _y, 1, 1);

//////////	}
//////////}
//////////*/
		////////////private void btnLoop_Click(object sender, EventArgs e)
		////////////{
		////////////	var xMin = radius;
		////////////	var xMax = 1 + this.pictureBox1.Width - radius;

		////////////	var yMin = radius;
		////////////	var yMax = 1 + this.pictureBox1.Height - radius;

		////////////	this.People = new Person[this.pictureBox1.Width, this.pictureBox1.Height];
		////////////	this.Territory = new int[this.pictureBox1.Width, this.pictureBox1.Height];

		////////////	Func<int, int, Person> newPerson = (x, y) =>
		////////////	{
		////////////		var person = new Person(x, y);
		////////////		person.Sneeze += this.Person_Sneeze;
		////////////		this.People[x, y] = person;
		////////////		return person;
		////////////	};

		////////////	///////g.FillRectangle(bBrush, radius, radius, xMax, yMax);

		////////////	Func<int, int, int, int> next = (min, max, iterations) =>
		////////////	{

		////////////		int tot = 0;
		////////////		for (int i = 0; i < iterations; i++)
		////////////		{
		////////////			tot += Rnd.Next(min, max);
		////////////		}
		////////////		return tot / iterations;
		////////////	};

		////////////	for (int i = 0; i < this.Popolation.Count; i++)
		////////////	{

		////////////		int x = 0;
		////////////		int y = 0;

		////////////		do
		////////////		{
		////////////			x = next(xMin, xMax, 1);
		////////////			y = next(yMin, yMax, 1);

		////////////		} while (this.People[x, y] != null);

		////////////		newPerson(x, y);

		////////////	}
		////////////	{
		////////////		var x = xMax / 2;
		////////////		var y = yMax / 2;
		////////////		var persona = newPerson(xMax / 2, yMax / 2);
		////////////		persona.Receive(1);
		////////////		//this.Infected.Add(persona);

		////////////		/////g.FillRectangle(rBrush, x - 1, y - 1, 3, 3);
		////////////	}

		////////////}






		////////////////////public static void DrawCircle(this Graphics g, Pen pen, float centerX, float centerY, float radius)
		////////////////////{
		////////////////////	g.DrawEllipse(pen, centerX - radius, centerY - radius,  radius + radius, radius + radius);
		////////////////////}

		//////////////int Counter = 0;
		////////////private void button2_Click(object sender, EventArgs e)
		////////////{
		////////////	//////////for (int t = 0; t < 250; t++)
		////////////	//////////{
		////////////	//////////	this.Text = t.ToString();
		////////////	//////////	Application.DoEvents();
		////////////	//////////	var count = this.Infected.Count - 1;
		////////////	//////////	for (int i = 0; i <= count; i++)
		////////////	//////////	{
		////////////	//////////		this.Infected[count - i].Tick();
		////////////	//////////	}
		////////////	//////////	//System.Threading.Thread.Sleep(5);
		////////////	//////////}

		////////////}

		////////////private void button3_Click(object sender, EventArgs e)
		////////////{
		////////////	//////this.Stop = true;
		////////////}

		////////////private void timer1_Tick(object sender, EventArgs e)
		////////////{
		////////////	Plot_Load(null, null);

		////////////	timer1.Enabled = false;
		////////////}