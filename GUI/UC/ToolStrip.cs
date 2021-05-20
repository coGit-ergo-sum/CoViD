using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoViD.GUI.UC
{
	public partial class ToolStrip : UserControl
	{
		public delegate void ClickDelegate();
		public event ClickDelegate Resume;
		public event ClickDelegate Pause;

		public ToolStrip()
		{
			InitializeComponent();
		}

		#region Run stop resume
		private void tsbPause_Click(object sender, EventArgs e)
		{
			tsbPause.Visible = false;
			tsbPlay.Visible = true;
			tsbPlay.Enabled = true;
		}

		private void tsbPlay_Click(object sender, EventArgs e)
		{
			tsbPlay.Visible = false;
			tsbPause.Visible = true;
		}

		private void tsbReplay_Click(object sender, EventArgs e)
		{
			tsbPlay.Visible = false;
			tsbPause.Visible = true;
			tsbPause.Enabled = true;
		}

		private void tsbNew_Click(object sender, EventArgs e)
		{
			tsbPlay.Visible = false;
			tsbPause.Visible = true;
			tsbPause.Enabled = true;
		}
		#endregion

		private void tsbSettings_Click(object sender, EventArgs e)
		{
		}

		private void tsbPeople_Click(object sender, EventArgs e)
		{

		}

	}
}
