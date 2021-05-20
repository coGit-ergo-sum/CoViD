using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CoViD.GUI.Tools.Extensions.Person;
using Vi.Tools.Extensions.Random;
using Vi.Tools.Extensions.Object;

namespace CoViD.GUI
{
	public partial class Form3 : Form
	{
		public Random Rnd;
		private string FullFilename;

		public Form3()
		{
			InitializeComponent();
			this.Rnd = new Random();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
			////var fileNamme = String.Format("{0:yyyy-MM-dd}.{1:hh-mm-ss}.People.{2}.bmp",
			var fileNamme = String.Format("Locations.{0}.exa", 1);
			this.FullFilename = System.IO.Path.Combine(baseDirectory, "Bytes", fileNamme);
			//FullFilename.ser


			var locations = this.Locations(1000, 2);
			var bytes = CoViD.GUI.Methods.ToBytes(locations);
			System.IO.File.WriteAllBytes(this.FullFilename, bytes);

		}


		private void button2_Click(object sender, EventArgs e)
		{
			var bytes = System.IO.File.ReadAllBytes(this.FullFilename);
			var locations = CoViD.GUI.Methods.Deserialize<List<CoViD.CL.Point>>(bytes);
		}


		public List<CoViD.CL.Point> Locations(int radius, byte steps)
		{


			var locations = new List<CoViD.CL.Point>();

			//var radius = (int)udRadius.Value;

			//byte steps = (byte)udSteps.Value;

			int x = this.Rnd.Next(-radius, radius, iterations: steps);
			int y = this.Rnd.Next(-radius, radius, iterations: steps);

			var targets = this.Rnd.Next(5, 20, 1);
			for (int i = 0; i < targets; i++)
			{
				int x1 = this.Rnd.Next(-radius, radius, iterations: steps);
				int y1 = this.Rnd.Next(-radius, radius, iterations: steps);

				float length = this.Rnd.Next(50, 500, 1);

				float y0x = x;
				float mx = ((float)x1 - (float)x) / length;

				float y0y = y;
				float my = ((float)y1 - (float)y) / length;

				for (int j = 0; j < length; j++)
				{
					var point = new CoViD.CL.Point(
						(int)(y0x + mx * j),
						(int)(y0y + my * j)
					);

					locations.Add(point);
				}

				x = x1;
				y = y1;
			}

			return locations;

		}

	}

	public static class Methods
    {


        public static byte[] ToBytes(this object value)
        {
			byte[] result = null;
			if (value != null)
			{
				var bf = new BinaryFormatter();
				using (var ms = new System.IO.MemoryStream())
				{
					bf.Serialize(ms, value);
					result = ms.ToArray();
				}
			}
			return result;
        }

        public static T Deserialize<T>(this byte[] bytes) where T : class
        {
			T result = null;
			if (bytes != null)
			{
				using (var ms = new System.IO.MemoryStream())
				{
					var bf = new BinaryFormatter();
					ms.Write(bytes, 0, bytes.Length);
					ms.Seek(0, SeekOrigin.Begin);
					var obj = (T)bf.Deserialize(ms);
					return obj;
				}
			}
			return result;
        }
    }
}
