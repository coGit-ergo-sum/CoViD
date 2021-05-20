//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//using Vi.Tools.Extensions.String;
//using Vi.Tools.Extensions.Float;

//namespace CoViD.GUI.Tools.Extensions.Control
//{	
//	public static class Methods
//	{
//		public static void Add(this System.Windows.Forms.Control control, float value)
//		{
//			var v = control.Text.ToFloat(0);
//			v += value;
//			v = Math.Max(0, v);
//			control.Text = (v / 100).ToPercent2();
//		}

//		public static void Add(this System.Windows.Forms.Control control, int value)
//		{
//			var v = control.Text.ToInt(0);
//			v += value;
//			v = Math.Max(0, v);
//			control.Text = v.ToString("#,##0");
//		}
//	}
//}
